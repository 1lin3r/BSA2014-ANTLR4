//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Kutuzow\Documents\BinaryStudio\ANTLR4\Code\Lesson_03\CS\ErrorReporting\ErrorReporting\Simple.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace ErrorReporting {

using System;

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class SimpleParser : Parser {
	public const int
		T__7=1, T__6=2, T__5=3, T__4=4, T__3=5, T__2=6, T__1=7, T__0=8, INT=9, 
		ID=10, WS=11;
	public static readonly string[] tokenNames = {
		"<INVALID>", "'{'", "')'", "'('", "'int'", "'='", "'class'", "'}'", "';'", 
		"INT", "ID", "WS"
	};
	public const int
		RULE_prog = 0, RULE_classDef = 1, RULE_member = 2, RULE_stat = 3, RULE_expr = 4;
	public static readonly string[] ruleNames = {
		"prog", "classDef", "member", "stat", "expr"
	};

	public override string GrammarFileName { get { return "Simple.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public SimpleParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgContext : ParserRuleContext {
		public ClassDefContext classDef(int i) {
			return GetRuleContext<ClassDefContext>(i);
		}
		public IReadOnlyList<ClassDefContext> classDef() {
			return GetRuleContexts<ClassDefContext>();
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISimpleListener typedListener = listener as ISimpleListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISimpleListener typedListener = listener as ISimpleListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISimpleVisitor<TResult> typedVisitor = visitor as ISimpleVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProg(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 11;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 10; classDef();
				}
				}
				State = 13;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( _la==T__2 );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ClassDefContext : ParserRuleContext {
		public IToken _ID;
		public IReadOnlyList<MemberContext> member() {
			return GetRuleContexts<MemberContext>();
		}
		public ITerminalNode ID() { return GetToken(SimpleParser.ID, 0); }
		public MemberContext member(int i) {
			return GetRuleContext<MemberContext>(i);
		}
		public ClassDefContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classDef; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISimpleListener typedListener = listener as ISimpleListener;
			if (typedListener != null) typedListener.EnterClassDef(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISimpleListener typedListener = listener as ISimpleListener;
			if (typedListener != null) typedListener.ExitClassDef(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISimpleVisitor<TResult> typedVisitor = visitor as ISimpleVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitClassDef(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ClassDefContext classDef() {
		ClassDefContext _localctx = new ClassDefContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_classDef);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 15; Match(T__2);
			State = 16; _localctx._ID = Match(ID);
			State = 17; Match(T__7);
			State = 19;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 18; member();
				}
				}
				State = 21;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( _la==T__4 );
			State = 23; Match(T__1);
			Console.WriteLine("class "+(_localctx._ID!=null?_localctx._ID.Text:null));
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MemberContext : ParserRuleContext {
		public IToken _ID;
		public IToken f;
		public IReadOnlyList<ITerminalNode> ID() { return GetTokens(SimpleParser.ID); }
		public StatContext stat() {
			return GetRuleContext<StatContext>(0);
		}
		public ITerminalNode ID(int i) {
			return GetToken(SimpleParser.ID, i);
		}
		public MemberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_member; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISimpleListener typedListener = listener as ISimpleListener;
			if (typedListener != null) typedListener.EnterMember(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISimpleListener typedListener = listener as ISimpleListener;
			if (typedListener != null) typedListener.ExitMember(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISimpleVisitor<TResult> typedVisitor = visitor as ISimpleVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMember(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MemberContext member() {
		MemberContext _localctx = new MemberContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_member);
		try {
			State = 40;
			switch ( Interpreter.AdaptivePredict(_input,2,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 26; Match(T__4);
				State = 27; _localctx._ID = Match(ID);
				State = 28; Match(T__0);
				Console.WriteLine("var "+(_localctx._ID!=null?_localctx._ID.Text:null));
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 30; Match(T__4);
				State = 31; _localctx.f = Match(ID);
				State = 32; Match(T__5);
				State = 33; Match(ID);
				State = 34; Match(T__6);
				State = 35; Match(T__7);
				State = 36; stat();
				State = 37; Match(T__1);
				Console.WriteLine("method: "+(_localctx.f!=null?_localctx.f.Text:null));
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatContext : ParserRuleContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode ID() { return GetToken(SimpleParser.ID, 0); }
		public StatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stat; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISimpleListener typedListener = listener as ISimpleListener;
			if (typedListener != null) typedListener.EnterStat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISimpleListener typedListener = listener as ISimpleListener;
			if (typedListener != null) typedListener.ExitStat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISimpleVisitor<TResult> typedVisitor = visitor as ISimpleVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatContext stat() {
		StatContext _localctx = new StatContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_stat);
		try {
			State = 52;
			switch ( Interpreter.AdaptivePredict(_input,3,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 42; expr();
				State = 43; Match(T__0);
				Console.WriteLine("found expr: "+_localctx.GetText());
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 46; Match(ID);
				State = 47; Match(T__3);
				State = 48; expr();
				State = 49; Match(T__0);
				Console.WriteLine("found assign: "+_localctx.GetText());
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ITerminalNode INT() { return GetToken(SimpleParser.INT, 0); }
		public ITerminalNode ID() { return GetToken(SimpleParser.ID, 0); }
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISimpleListener typedListener = listener as ISimpleListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISimpleListener typedListener = listener as ISimpleListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISimpleVisitor<TResult> typedVisitor = visitor as ISimpleVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_expr);
		try {
			State = 59;
			switch (_input.La(1)) {
			case INT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 54; Match(INT);
				}
				break;
			case ID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 55; Match(ID);
				State = 56; Match(T__5);
				State = 57; Match(INT);
				State = 58; Match(T__6);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\r@\x4\x2\t\x2\x4"+
		"\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x3\x2\x6\x2\xE\n\x2\r\x2\xE"+
		"\x2\xF\x3\x3\x3\x3\x3\x3\x3\x3\x6\x3\x16\n\x3\r\x3\xE\x3\x17\x3\x3\x3"+
		"\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4+\n\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x37\n\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\x6\x5\x6>\n\x6\x3\x6\x2\x2\x2\a\x2\x2\x4\x2\x6\x2\b\x2\n\x2\x2\x2?\x2"+
		"\r\x3\x2\x2\x2\x4\x11\x3\x2\x2\x2\x6*\x3\x2\x2\x2\b\x36\x3\x2\x2\x2\n"+
		"=\x3\x2\x2\x2\f\xE\x5\x4\x3\x2\r\f\x3\x2\x2\x2\xE\xF\x3\x2\x2\x2\xF\r"+
		"\x3\x2\x2\x2\xF\x10\x3\x2\x2\x2\x10\x3\x3\x2\x2\x2\x11\x12\a\b\x2\x2\x12"+
		"\x13\a\f\x2\x2\x13\x15\a\x3\x2\x2\x14\x16\x5\x6\x4\x2\x15\x14\x3\x2\x2"+
		"\x2\x16\x17\x3\x2\x2\x2\x17\x15\x3\x2\x2\x2\x17\x18\x3\x2\x2\x2\x18\x19"+
		"\x3\x2\x2\x2\x19\x1A\a\t\x2\x2\x1A\x1B\b\x3\x1\x2\x1B\x5\x3\x2\x2\x2\x1C"+
		"\x1D\a\x6\x2\x2\x1D\x1E\a\f\x2\x2\x1E\x1F\a\n\x2\x2\x1F+\b\x4\x1\x2 !"+
		"\a\x6\x2\x2!\"\a\f\x2\x2\"#\a\x5\x2\x2#$\a\f\x2\x2$%\a\x4\x2\x2%&\a\x3"+
		"\x2\x2&\'\x5\b\x5\x2\'(\a\t\x2\x2()\b\x4\x1\x2)+\x3\x2\x2\x2*\x1C\x3\x2"+
		"\x2\x2* \x3\x2\x2\x2+\a\x3\x2\x2\x2,-\x5\n\x6\x2-.\a\n\x2\x2./\b\x5\x1"+
		"\x2/\x37\x3\x2\x2\x2\x30\x31\a\f\x2\x2\x31\x32\a\a\x2\x2\x32\x33\x5\n"+
		"\x6\x2\x33\x34\a\n\x2\x2\x34\x35\b\x5\x1\x2\x35\x37\x3\x2\x2\x2\x36,\x3"+
		"\x2\x2\x2\x36\x30\x3\x2\x2\x2\x37\t\x3\x2\x2\x2\x38>\a\v\x2\x2\x39:\a"+
		"\f\x2\x2:;\a\x5\x2\x2;<\a\v\x2\x2<>\a\x4\x2\x2=\x38\x3\x2\x2\x2=\x39\x3"+
		"\x2\x2\x2>\v\x3\x2\x2\x2\a\xF\x17*\x36=";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ErrorReporting
