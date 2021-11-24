using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SOLID_L.Good
{
    public interface IReadableSqlFile
    {
        string LoadText();
    }

    public interface IWritableSqlFile
    {
        string SaveText();
    }

    public class SqlFile : IReadableSqlFile, IWritableSqlFile
    {
        public string FilePath { get; }
        public SqlFile(string filePath)
        {
            FilePath = filePath.Trim();
        }

        public string SaveText()
        {
            Console.WriteLine($"Excellent code to save text to the file {FilePath}");
            return $"the text from the file in path {FilePath} - {DateTime.Now.Ticks.ToString()} - {Guid.NewGuid()}";
        }

        public string LoadText()
        {
            Console.WriteLine($"Excellent code to load the text from file {FilePath}");
            return $"the text from the file in path {FilePath} - {DateTime.Now.Ticks.ToString()} - {Guid.NewGuid()}";
        }
    }

    public class ReadOnlySqlFile : IReadableSqlFile
    {
        public string FilePath { get; }
        public ReadOnlySqlFile(string filePath)
        {
            FilePath = filePath.Trim();
        }

        public string LoadText()
        {
            Console.WriteLine($"Excellent code to load the text from file {FilePath}");
            return $"the text from the file in path {FilePath} - {DateTime.Now.Ticks.ToString()} - {Guid.NewGuid()}";
        }
    }

    public class SqlFileManager
    {
        public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFiles)
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in aLstReadableFiles)
            {
                objStrBuilder.AppendLine(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles(List<IWritableSqlFile> aLstWritableFiles)
        {
            foreach (var objFile in aLstWritableFiles)
            {
                objFile.SaveText();
            }
        }
    }

}
