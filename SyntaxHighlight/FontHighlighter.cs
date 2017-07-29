using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxHighlight
{
    public class FontHighlighter : Highlighter
    {
        
        public FontStyle Style { get; set; }
        public string Keyword { get; set; }

        private Highlighter _highlighter;

        public enum FontStyle
        {
            Bold,
            Normal
        }

        public FontHighlighter(Highlighter highlighter, FontStyle fontStyle, string keyword)
        {
            _highlighter = highlighter;
            Style = fontStyle;
            Keyword = keyword;
        }

        public override string Process()
        {
            return this._highlighter.Process().Replace(Keyword, Style == FontStyle.Bold? $"[bold]{Keyword}[bold]":Keyword);
        }
    }
}
