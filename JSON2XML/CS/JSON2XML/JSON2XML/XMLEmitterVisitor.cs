using System.Text;

namespace JSON2XML
{
	public class XMLEmitterVisitor : JSONBaseVisitor<string>
	{
		public override string VisitJson(JSONParser.JsonContext context)
		{
			return context.GetChild(0).Accept(this);
		}

		public override string VisitAnObject(JSONParser.AnObjectContext context)
		{
			var buf = new StringBuilder();
			buf.Append("\n");
			foreach (JSONParser.PairContext pctx in context.pair())
			{
				buf.Append(pctx.Accept(this));
			}
			return buf.ToString();
		}

		public override string VisitEmptyObject(JSONParser.EmptyObjectContext context)
		{
			return "";
		}

		public override string VisitArrayOfValues(JSONParser.ArrayOfValuesContext context)
		{
			var buf = new StringBuilder();
			buf.Append("\n");
			foreach (JSONParser.ValueContext vctx in context.value())
			{
				buf.Append("<element>").Append(vctx.Accept(this)).Append("</element>").Append("\n");
			}
			return buf.ToString();
		}

		public override string VisitEmptyArray(JSONParser.EmptyArrayContext context)
		{
			return "";
		}

		public override string VisitPair(JSONParser.PairContext context)
		{
			var tag = StripQuotes(context.STRING().GetText());
			JSONParser.ValueContext vctx = context.value();
			var ret = string.Format("<{0}>{1}</{0}>\n", tag, vctx.Accept(this));
			return ret;
		}

		public override string VisitObjectValue(JSONParser.ObjectValueContext context)
		{
			return context.@object().Accept(this);
		}

		public override string VisitArrayValue(JSONParser.ArrayValueContext context)
		{
			return context.array().Accept(this);
		}

		public override string VisitAtom(JSONParser.AtomContext context)
		{
			return context.GetText();
		}

		public override string VisitString(JSONParser.StringContext context)
		{
			return StripQuotes(context.GetText());
		}


		private string StripQuotes(string s)
		{
			return s.Replace("\"", "");
		}
	}
}
