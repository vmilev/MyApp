using System.IO;
using System.Text.RegularExpressions;

namespace XamlPreprocessor
{
    public class XamlPreprocessor
    {
        const string regex = @"""using:(?<namespace>[\w\.\-_]*)""";

        public static void Main(string[] args)
        {
            string unprocessedXaml = File.ReadAllText(args[0]);

            //Create destination directory if it doesn't exist
            (new FileInfo(args[1])).Directory.Create();
            
            var preprocessor = new XamlPreprocessor();
            var processedXaml = preprocessor.Process(unprocessedXaml);

            File.WriteAllText(args[1], processedXaml);
        }

        public string Process(string text)
        {
            return Regex.Replace(text, regex, RegExMatchEvaluator);
        }

        private string RegExMatchEvaluator(Match match)
        {
            return match.Result("\"clr-namespace:" + match.Groups["namespace"] + "\"");
        }
    }
}
