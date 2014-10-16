using System;
using Antlr4.Runtime;
using AntlrTreeVis;

namespace JSON2XML
{
	static class Program
	{
		static void Main(string[] args)
		{
			const string input = @"{
	""description"" : ""An imaginary server config file"",
	""logs"" : {""level"":""verbose"", ""dir"":""/var/log""},
	""host"" : ""antlr.org"",
	""admin"": [""parrt"", ""tombu""],
	""aliases"": []
}
";
			Console.WriteLine(input);

			var stream = new AntlrInputStream(input);
			var lexer = new JSONLexer(stream);
			var tokens = new CommonTokenStream(lexer);
			var parser = new JSONParser(tokens);
			var tree = parser.json();

			var visualised = new ParseTreeVisualiser().Visualise(tree);
			Console.WriteLine(visualised);

			var visitor = new XMLEmitterVisitor();
			var xml = tree.Accept(visitor);
			Console.WriteLine(xml);
			Console.ReadKey();

		}
	}

}
