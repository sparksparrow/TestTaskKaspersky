using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace FileProcessorTestTaskKaspersky.FileProcessors
{
    public class FileProcessor
    {
        //Словарь альтернативных расширений
        private static Dictionary<string, string> alternativeExtensions = new Dictionary<string, string>
        {
            { "Html", "Htm" }
        };

        //Строит имя нужного класса на основе расширения файла
        private string BuildClassName(string extension)
        {
            extension = new string($"{char.ToUpper(extension[0])}{extension[1..].ToLower()}");

            foreach (var altName in alternativeExtensions)
            {
                if (extension.Contains(altName.Value))
                {
                    extension = new string(extension.Replace(altName.Value, altName.Key));
                    break;
                }
            }

            return new string($"{Assembly.GetEntryAssembly().GetName().Name}.FileProcessors.{extension}Processor");
        }
                
        //Создает объект необходимого класса через выбранный конструктор на основе рефлексии и вызывает метод обработки файла
        public void ProcessFile(string fileName)
        {
            if (!File.Exists(fileName)) return;
           

            string extension = Path.GetExtension(fileName);

            if (extension == string.Empty) return;
            
            extension = new string(
                BuildClassName
                    (
                        extension.Replace(".", string.Empty)
                    ));  

            Type type = Type.GetType(extension, false, true);

            if (type == null) return;

            ConstructorInfo[] constructorInfos = type.GetConstructors();
            ProcessorBase fileProcessor = constructorInfos[0].Invoke(null) as ProcessorBase;
                        
            fileProcessor.ProcessFile(fileName);
        }
    }
}
