namespace SyntaxHighlight
{
    public class Highlighter
    {
        public string ToProcess { get; set; }

        public Highlighter()
        {

        }

        public Highlighter(string toProcess)
        {
            ToProcess = toProcess;
        }

        public virtual string Process()
        {
            return ToProcess;
        }
    }
}