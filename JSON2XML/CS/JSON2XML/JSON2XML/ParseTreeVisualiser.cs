using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Tree;
using Microsoft.Win32.SafeHandles;

namespace AntlrTreeVis
{
	public class ParseTreeVisualiser:IParseTreeVisitor<string>
	{
		private int CurLevel { get; set; }
		public string Visit(IParseTree tree)
		{
			var sb = new StringBuilder();
			for (var i = 0; i < CurLevel; i++)
			{
				sb.Append("  ");
			}
			if (tree is TerminalNodeImpl)
			{
				sb.Append("[").Append((tree as TerminalNodeImpl).GetText()).Append("]\n");
			}
			else if (tree is IRuleNode)
			{
				sb.Append(tree.GetType().Name.Replace("Context", "")).Append("\n");
				CurLevel++;
				var ruleNode = tree as IRuleNode;
				for (var i = 0; i < ruleNode.ChildCount; i++)
				{
					sb.Append(Visit(ruleNode.GetChild(i)));
				}
				CurLevel--;
			}
			return sb.ToString();
		}

		public string VisitChildren(IRuleNode node)
		{
			throw new NotImplementedException();
		}

		public string VisitTerminal(ITerminalNode node)
		{
			throw new NotImplementedException();
		}

		public string VisitErrorNode(IErrorNode node)
		{
			throw new NotImplementedException();
		}

		public string Visualise(IParseTree tree)
		{
			return Visit(tree);
		}
	}
}
