
using StreamWriterClass;

TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput());

textWriter.WriteLine("Hello, World!");

textWriter.Flush();

textWriter.Close();

TextWriter lowerTextWriter = new LowerStreamWriter(Console.OpenStandardOutput());

lowerTextWriter.WriteLine("Hello, World!");
lowerTextWriter.Flush();

lowerTextWriter.Close();