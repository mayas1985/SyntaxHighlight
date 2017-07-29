using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxHighlight
{
    public class CaseHighlighter : Highlighter
    {
        public StringCase Case { get; set; }
        public string Keyword { get; set; }

        private Highlighter _highlighter;

        public enum StringCase
        {
            Lower,
            Upper,
            Default
        }

        public CaseHighlighter(Highlighter highlighter, StringCase stringCase, string keyword)
        {
            _highlighter = highlighter;
            Case = stringCase;
            Keyword = keyword;
        }

        public override string Process()
        {
            return this._highlighter.Process().Replace(Keyword, Case == StringCase.Upper? Keyword.ToUpper():Keyword.ToLower());
        }
    }
}
