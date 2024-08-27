namespace StreamWriterClass
{
    public class LowerStreamWriter : StreamWriter
    {
        private string CoreNewLineStr = Environment.NewLine;
        public LowerStreamWriter(Stream stream) : base(stream)
        {
        }

        public override void WriteLine(string? value)
        {
            if (value != null)
            {
                Write(value.ToLower());
            }
            Write(CoreNewLineStr);
        }
    }
}
