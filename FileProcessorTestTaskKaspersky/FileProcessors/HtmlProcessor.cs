using System.IO;
using System.Text;

namespace FileProcessorTestTaskKaspersky.FileProcessors
{
    public class HtmlProcessor : ProcessorBase
    {
        public override void ProcessFile(string fileName)
        {
            string temp;
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                temp = streamReader.ReadToEnd();
            }
            temp = new string(temp.Replace("<p>", "<h2>").Replace("</p>","</h2>"));

            File.WriteAllText(fileName, temp);
        }
    }
}
