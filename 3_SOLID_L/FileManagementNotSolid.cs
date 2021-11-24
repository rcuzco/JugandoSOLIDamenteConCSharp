using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SOLID_L
{
    public class SqlFile
    {
        public string FilePath { get; }
        public SqlFile(string filePath)
        {
            FilePath = filePath.Trim();
        }        

        public string LoadText()
        {
            Console.WriteLine($"Excellent code to load the text from file {FilePath}");
            return $"the text from the file in path {FilePath} - {DateTime.Now.Ticks.ToString()} - {Guid.NewGuid()}";
        }

        public void SaveText()
        {
            Console.WriteLine($"Excellent code to save text to the file {FilePath}");
        }
    }

    public class ReadOnlySqlFile : SqlFile
    {
        public ReadOnlySqlFile(string filePath) : base(filePath)
        {
        }

        public new void SaveText()
        {
            throw new IOException("Can't save to a readonly file");
        }
    }

    public class SqlFileManagerNotSolid
    {
        public List<SqlFile> Files { get; set; } = new List<SqlFile>();
        public string GetTextFromFiles()
        {
            Console.WriteLine($"Excellent code to get text from all files");

            StringBuilder textFromFiles = new StringBuilder();
            foreach (var file in Files)
            {
                textFromFiles.AppendLine(file.LoadText());
            }
            return textFromFiles.ToString();
        }

        public void SaveTextToFiles()
        {
            //hemos tenido que modificar la clase, concretamente este método para determinar si el fichero es de tipo
            //solo lectura. O sea que no podemos usar a ReadOnlySqlFile como substituto de SqlFile sin que tengamos que alterar la 
            //clase SqlFileManager
            Console.WriteLine($"Excellent code to save text to all files");

            foreach (var file in Files)
            {
                if (file is not ReadOnlySqlFile)
                {
                    file.SaveText();
                }
                
            }
        }
    }
}
