using System.IO;

namespace FileProcessorTestTaskKaspersky.FileProcessors
{
    public class JsonProcessor : ProcessorBase
    {
        public override void ProcessFile(string fileName)
        {
            string temp;
            using(StreamReader streamReader = new StreamReader(fileName))
            {
                temp = streamReader.ReadToEnd();
            }
            temp = new string(temp.Replace("\"","\'"));
            
            File.WriteAllText(fileName, temp);            
        }
    }
}
