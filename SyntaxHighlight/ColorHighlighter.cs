using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxHighlight
{
    public class ColorHighlighter : Highlighter
    {
        public string Color  { get; set; }
        public string Keyword { get; set; }


        private Highlighter _highlighter;
        public ColorHighlighter(Highlighter highlighter, string color, string keyword)
        {
            _highlighter = highlighter;
            Color = color;
            Keyword = keyword;
        }

        public override string Process()
        {
            return this._highlighter.ToProcess.Replace(Keyword, $"[{Color}]{Keyword}[{Color}]");
        }
    }
}
