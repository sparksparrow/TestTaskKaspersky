using NUnit.Framework;
using FileProcessorTestTaskKaspersky.FileProcessors;
using System.IO;
using System.Reflection;

namespace FileProcessorTests
{
    public class FileProcessorTests
    {

        static string tempFile;

        [TearDown]
        public void AfterTest()
        {
            File.Delete(tempFile);
            tempFile = null;
        }


        [Test]
        public void FileProcessor_ProcessFile_TxtFile_SuccessedProcessedFile()
        {
            FileProcessor fileProcessor = new FileProcessor();
            string testFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\FileProcessor_ProcessFile_File_ProcessedFile\TxtProcessor_ProcessFile_TxtFile_SuccessedProcessedFile.txt"
                );
            tempFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
               @"TestFiles\FileProcessor_ProcessFile_File_ProcessedFile\Expected_TxtProcessor_ProcessFile_TxtFile_SuccessedProcessedFile_Temp.txt"
                );
            string expectedFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile\Expected_FileProcessor_ProcessFile_File_FailedProcessedFile.txt"
                );

            File.Copy(testFile, tempFile, true);
            fileProcessor.ProcessFile(tempFile);

            var tempFileBytes = File.ReadAllBytes(tempFile);
            var expectedFileBytes = File.ReadAllBytes(testFile);
            Assert.AreEqual(expectedFileBytes, tempFileBytes);
        }

        [Test]
        public void FileProcessor_ProcessFile_ExeFile_FailedProcessedFile()
        {
            FileProcessor fileProcessor = new FileProcessor();
            string testFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\FileProcessor_ProcessFile_File_ProcessedFile\FileProcessor_ProcessFile_File_FailedProcessedFile.exe"
                );
            tempFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
               @"TestFiles\FileProcessor_ProcessFile_File_ProcessedFile\Expected_FileProcessor_ProcessFile_File_ProcessedFile_Temp.exe"
                );            

            File.Copy(testFile, tempFile, true);
            fileProcessor.ProcessFile(tempFile);

            var tempFileBytes = File.ReadAllBytes(tempFile);
            var expectedFileBytes = File.ReadAllBytes(testFile);
            Assert.AreEqual(expectedFileBytes, tempFileBytes);
        }

        [Test]
        public void FileProcessor_ProcessFile_EmptyFile_FailedProcessedFile()
        {
            FileProcessor fileProcessor = new FileProcessor();
            string testFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\FileProcessor_ProcessFile_File_ProcessedFile\FileProcessor_ProcessFile_File_FailedProcessedFile"
                );
            tempFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
               @"TestFiles\FileProcessor_ProcessFile_File_ProcessedFile\Expected_FileProcessor_ProcessFile_File_FailedProcessedFile_Temp"
                );

            File.Copy(testFile, tempFile, true);
            fileProcessor.ProcessFile(tempFile);

            var tempFileBytes = File.ReadAllBytes(tempFile);
            var expectedFileBytes = File.ReadAllBytes(testFile);
            Assert.AreEqual(expectedFileBytes, tempFileBytes);
        }

        [Test]
        public void HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile()
        {
            HtmlProcessor htmlProcessor = new HtmlProcessor();
            string testFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile\HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile.html"
                );
            tempFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile\Expected_HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile_Temp.html"
                );
            string expectedFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile\Expected_HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile.html"
                );

            File.Copy(testFile, tempFile, true);
            htmlProcessor.ProcessFile(tempFile);

            var tempFileBytes = File.ReadAllBytes(tempFile);
            var expectedFileBytes = File.ReadAllBytes(expectedFile);
            Assert.AreEqual(expectedFileBytes, tempFileBytes);
        }

        [Test]
        public void HtmlProcessor_ProcessFile_HtmFile_SuccessedProcessedFile()
        {
            HtmlProcessor htmlProcessor = new HtmlProcessor();
            string testFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile\HtmlProcessor_ProcessFile_HtmFile_SuccessedProcessedFile.htm"
                );
            tempFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                 @"TestFiles\HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile\Expected_HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile_Temp.htm"
                );
            string expectedFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                 @"TestFiles\HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile\Expected_HtmlProcessor_ProcessFile_HtmlFile_SuccessedProcessedFile.html"
                );

            File.Copy(testFile, tempFile, true);
            htmlProcessor.ProcessFile(tempFile);

            var tempFileBytes = File.ReadAllBytes(tempFile);
            var expectedFileBytes = File.ReadAllBytes(expectedFile);
            Assert.AreEqual(expectedFileBytes, tempFileBytes);
        }


        [Test]
        public void JsonProcessor_ProcessFile_JsonFile_SuccessedProcessedFile()
        {
            JsonProcessor jsonProcessor = new JsonProcessor();
            string testFile = Path.Combine
                (
                Directory.GetCurrentDirectory(), 
                @"TestFiles\JsonProcessor_ProcessFile_File_ProcessedFile\JsonProcessor_ProcessFile_JsonFile_SuccessedProcessedFile.json"
                );
            tempFile = Path.Combine
                (
                Directory.GetCurrentDirectory(), 
                @"TestFiles\JsonProcessor_ProcessFile_File_ProcessedFile\Expected_JsonProcessor_ProcessFile_JsonFile_SuccessedProcessedFile_Temp.json"
                );
            string expectedFile = Path.Combine
                (
                Directory.GetCurrentDirectory(), 
                @"TestFiles\JsonProcessor_ProcessFile_File_ProcessedFile\Expected_JsonProcessor_ProcessFile_JsonFile_SuccessedProcessedFile.json"
                );

            File.Copy(testFile, tempFile, true);
            jsonProcessor.ProcessFile(tempFile);

            var tempFileBytes = File.ReadAllBytes(tempFile);
            var expectedFileBytes = File.ReadAllBytes(expectedFile);
            Assert.AreEqual(expectedFileBytes, tempFileBytes);
        }

        [Test]
        public void TxtProcessor_ProcessFile_TxtFile_SuccessedProcessedFile()
        {
            TxtProcessor txtProcessor = new TxtProcessor();
            string testFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\TxtProcessor_ProcessFile_TxtFile_SuccessedProcessedFile\TxtProcessor_ProcessFile_TxtFile_SuccessedProcessedFile.txt"
                );
            tempFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\TxtProcessor_ProcessFile_TxtFile_SuccessedProcessedFile\Expected_TxtProcessor_ProcessFile_TxtFile_SuccessedProcessedFile_Temp.txt"
                );
            string expectedFile = Path.Combine
                (
                Directory.GetCurrentDirectory(),
                @"TestFiles\TxtProcessor_ProcessFile_TxtFile_SuccessedProcessedFile\Expected_TxtProcessor_ProcessFile_TxtFile_SuccessedProcessedFile.txt"
                );

            File.Copy(testFile, tempFile, true);
            txtProcessor.ProcessFile(tempFile);

            var tempFileBytes = File.ReadAllBytes(tempFile);
            var expectedFileBytes = File.ReadAllBytes(expectedFile);
            Assert.AreEqual(expectedFileBytes, tempFileBytes);
        }
    }
}
