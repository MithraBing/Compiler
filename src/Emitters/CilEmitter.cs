using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Blaise2.Ast;
using System;

namespace Blaise2.Emitters
{
    [SuppressMessage("Performance", "CA1822", Justification = "all methods must be instance methods to participate in dynamic dispatch")]
    public class InvalidOperation : Exception
    {
        public InvalidOperation() : base($"Invalid Operation") { }
    }

    public partial class CilEmitter
    {
        private string Cil = string.Empty;
        private string ProgramName;

        public string Visit(ProgramNode node)
        {
            ProgramName = node.ProgramName;

            Cil += Preamble();

            Cil += $@"
.class public auto ansi beforefieldinit {node.ProgramName}
    extends [System.Private.CoreLib]System.Object
{{";
            foreach (var varDecl in node.VarDecls.OfType<VarDeclNode>())
            {
                Cil += $@"
    .field public {varDecl.BlaiseType.ToCilType()} {varDecl.Identifier}";
            }

            // TODO: emit routines as methods

            Cil += $@"
  // Methods
  .method public hidebysig static void main() cil managed
  {{
    .entrypoint
    .locals init (
      [0] class {ProgramName}
    )

    newobj instance void {ProgramName}::.ctor()
    stloc.0

";

            Cil += Visit((dynamic)node.Stat);

            Cil += @"
    ret
  } // end of main
";
            Cil += Postamble();

            return Cil;
        }

        public string Visit(BlockNode node)
        {
            var output = "";

            foreach (var stat in node.Stats)
            {
                output += Visit((dynamic)stat);
            }

            return output;
        }

        public string Visit(WriteNode node)
        {
            var output = "";
            output += Visit((dynamic)node.Expression);
            var method = node.WriteNewline ? "WriteLine" : "Write";
            output += $"\n    call void [System.Console]System.Console::{method}(int32)";
            return output;
        }

        public string Visit(AssignmentNode node)
        {
            var output = "    ldloc.0";
            output += Visit((dynamic)node.Expression);

            var info = FindVariable(node, node.Identifier);
            switch (info.VarType)
            {
                case VarType.Global:
                    output += $"\n    stfld {info.VarDecl.BlaiseType.ToCilType()} {ProgramName}::{ info.VarDecl.Identifier}";
                    break;
            }

            return output;
        }

        public string Visit(IntegerNode node)
        {
            return $"\n    ldc.i4.s {node.IntValue}";
        }

        public string Visit(FunctionCallNode node)
        {
            var output = $@"
            // call function {node.Identifier}
            ldloc.0";

            foreach (var arg in node.ArgumentExpressions)
            {
                output = +Visit((dynamic)arg);
            }

            var paramTypes = string.Join(", ", node.ArgumentExpressions.OfType<VarDeclNode>().Select(a => a.BlaiseType));

            output += $@"
            callvirt instance TYPE-TODO {ProgramName}::{node.Identifier}({paramTypes})";

            return output;
        }

        public string Visit(VarRefNode node)
        {
            var output = "";

            var info = FindVariable(node, node.Identifier);

            if (info is not null)
            {
                switch (info.VarType)
                {
                    case VarType.Global:
                        output += $@"
    ldloc.0
    ldfld {info.VarDecl.BlaiseType.ToCilType()} {ProgramName}::{info.VarDecl.Identifier}";
                        break;
                }
            }

            return output;
        }

        public string Visit(BinaryOpNode node)
        {
            var output = Visit((dynamic)node.Lhs);
            output += Visit((dynamic)node.Rhs);
            var op = node.Op switch
            {
                "+" => "add",
                "-" => "sub",
                "*" => "mul",
                "/" => "div",
                _ => throw new InvalidOperation(),
            };
            output += $@"
    {op}";
            return output;
        }
    }
}