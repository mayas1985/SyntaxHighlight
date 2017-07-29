using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SyntaxHighlight;

namespace Test
{
    [TestClass]
    public class SyntaxHighlighTest
    {
        [TestMethod]
        public void Should_Add_Color_Highlight()
        {
            const string searchstring = "as if twice";
            var highlighter = new Highlighter(searchstring);
            var colorHighlighter = new ColorHighlighter(highlighter, "blue", "as");
            var caseHighLighter = new CaseHighlighter(colorHighlighter, CaseHighlighter.StringCase.Upper, "if");
            var fontHighlighter = new FontHighlighter(caseHighLighter, FontHighlighter.FontStyle.Bold, "as");
            var t = fontHighlighter.Process();
            Assert.AreEqual(t, "[blue][bold]as[bold][blue] IF twice");

        }
    }
}
