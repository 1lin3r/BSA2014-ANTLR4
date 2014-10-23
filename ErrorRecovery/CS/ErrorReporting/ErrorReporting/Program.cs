using System;
using Antlr4.Runtime;

namespace ErrorReporting
{
	static class Program
	{
		static void Main(string[] args)
		{
			const string fileName = "inputFiles\\ex_05_1.txt";
			
			var stream = new AntlrFileStream(fileName);
			var lexer = new SimpleLexer(stream);
			var tokens = new CommonTokenStream(lexer);
			var parser = new SimpleParser(tokens);

			parser.RemoveErrorListeners();
			parser.AddErrorListener(new MyErrorListener());

			var tree = parser.prog();
			
			Console.ReadKey();
		}
	}
}
