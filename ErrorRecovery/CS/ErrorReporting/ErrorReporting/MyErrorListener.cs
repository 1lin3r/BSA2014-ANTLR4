using System;
using Antlr4.Runtime;

namespace ErrorReporting
{
	public class MyErrorListener : BaseErrorListener
	{
		public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
		{
			 Console.WriteLine("Error at position ["+line+":"+charPositionInLine+"] : "+msg);
			 UnderlineError(recognizer,(IToken)offendingSymbol, line, charPositionInLine);
		}

		private void UnderlineError(IRecognizer recognizer, IToken offendingToken, int line, int charPositionInLine)
		{
			var tokens = (CommonTokenStream) recognizer.InputStream;
			var input = tokens.TokenSource.InputStream.ToString();
			var lines = input.Split('\n');
			var errorLine = lines[line - 1];

			Console.Write(errorLine.Substring(0, charPositionInLine));
			var prevColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(errorLine.Substring(charPositionInLine, offendingToken.StopIndex - offendingToken.StartIndex + 1));
			Console.ForegroundColor = prevColor;
			Console.WriteLine(errorLine.Substring(charPositionInLine+offendingToken.StopIndex - offendingToken.StartIndex + 1));
			Console.WriteLine();
		}
	}
}

