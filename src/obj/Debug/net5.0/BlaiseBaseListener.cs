//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/srimithra/Documents/GitHub/blaise2-SrimithraBingi/src/Blaise.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Blaise2 {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IBlaiseListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class BlaiseBaseListener : IBlaiseListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.file"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFile([NotNull] BlaiseParser.FileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.file"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFile([NotNull] BlaiseParser.FileContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] BlaiseParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] BlaiseParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.programDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgramDecl([NotNull] BlaiseParser.ProgramDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.programDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgramDecl([NotNull] BlaiseParser.ProgramDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.varBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarBlock([NotNull] BlaiseParser.VarBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.varBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarBlock([NotNull] BlaiseParser.VarBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.varDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarDecl([NotNull] BlaiseParser.VarDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.varDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarDecl([NotNull] BlaiseParser.VarDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.typeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeExpr([NotNull] BlaiseParser.TypeExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.typeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeExpr([NotNull] BlaiseParser.TypeExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.simpleTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleTypeExpr([NotNull] BlaiseParser.SimpleTypeExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.simpleTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleTypeExpr([NotNull] BlaiseParser.SimpleTypeExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.arrayTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayTypeExpr([NotNull] BlaiseParser.ArrayTypeExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.arrayTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayTypeExpr([NotNull] BlaiseParser.ArrayTypeExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.setTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetTypeExpr([NotNull] BlaiseParser.SetTypeExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.setTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetTypeExpr([NotNull] BlaiseParser.SetTypeExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStat([NotNull] BlaiseParser.StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStat([NotNull] BlaiseParser.StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] BlaiseParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] BlaiseParser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.write"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWrite([NotNull] BlaiseParser.WriteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.write"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWrite([NotNull] BlaiseParser.WriteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.writeln"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWriteln([NotNull] BlaiseParser.WritelnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.writeln"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWriteln([NotNull] BlaiseParser.WritelnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] BlaiseParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] BlaiseParser.AssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.routines"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoutines([NotNull] BlaiseParser.RoutinesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.routines"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoutines([NotNull] BlaiseParser.RoutinesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedure([NotNull] BlaiseParser.ProcedureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedure([NotNull] BlaiseParser.ProcedureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction([NotNull] BlaiseParser.FunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction([NotNull] BlaiseParser.FunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.argsList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgsList([NotNull] BlaiseParser.ArgsListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.argsList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgsList([NotNull] BlaiseParser.ArgsListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] BlaiseParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] BlaiseParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.numericAtom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericAtom([NotNull] BlaiseParser.NumericAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.numericAtom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericAtom([NotNull] BlaiseParser.NumericAtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtom([NotNull] BlaiseParser.AtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtom([NotNull] BlaiseParser.AtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BlaiseParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] BlaiseParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BlaiseParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] BlaiseParser.FunctionCallContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Blaise2
