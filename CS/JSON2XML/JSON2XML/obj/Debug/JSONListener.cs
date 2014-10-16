//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Practice\JSON2XML\CS\JSON2XML\JSON2XML\JSON.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace JSON2XML {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="JSONParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface IJSONListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>ObjectValue</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectValue([NotNull] JSONParser.ObjectValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ObjectValue</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectValue([NotNull] JSONParser.ObjectValueContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayValue</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayValue([NotNull] JSONParser.ArrayValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayValue</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayValue([NotNull] JSONParser.ArrayValueContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AnObject</c>
	/// labeled alternative in <see cref="JSONParser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnObject([NotNull] JSONParser.AnObjectContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AnObject</c>
	/// labeled alternative in <see cref="JSONParser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnObject([NotNull] JSONParser.AnObjectContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayOfValues</c>
	/// labeled alternative in <see cref="JSONParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayOfValues([NotNull] JSONParser.ArrayOfValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayOfValues</c>
	/// labeled alternative in <see cref="JSONParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayOfValues([NotNull] JSONParser.ArrayOfValuesContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Atom</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] JSONParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Atom</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] JSONParser.AtomContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPair([NotNull] JSONParser.PairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPair([NotNull] JSONParser.PairContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJson([NotNull] JSONParser.JsonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJson([NotNull] JSONParser.JsonContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] JSONParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] JSONParser.StringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>EmptyArray</c>
	/// labeled alternative in <see cref="JSONParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmptyArray([NotNull] JSONParser.EmptyArrayContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>EmptyArray</c>
	/// labeled alternative in <see cref="JSONParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmptyArray([NotNull] JSONParser.EmptyArrayContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>EmptyObject</c>
	/// labeled alternative in <see cref="JSONParser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmptyObject([NotNull] JSONParser.EmptyObjectContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>EmptyObject</c>
	/// labeled alternative in <see cref="JSONParser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmptyObject([NotNull] JSONParser.EmptyObjectContext context);
}
} // namespace JSON2XML