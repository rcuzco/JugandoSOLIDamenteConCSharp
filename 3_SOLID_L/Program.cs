// See https://aka.ms/new-console-template for more information
using _3_SOLID_L;

Console.WriteLine("Hello, World!");

SqlFile file1 = new SqlFile("ruta-1");
SqlFile file2 = new SqlFile("ruta-2");
SqlFile file3 = new SqlFile("ruta-3");
ReadOnlySqlFile file4 = new ReadOnlySqlFile("ruta-4");
List<SqlFile> files = new List<SqlFile>() { file1, file2, file3, file4 };

SqlFileManagerNotSolid sqlFileManagerNotSolid = new SqlFileManagerNotSolid() { Files = files };
Console.WriteLine(sqlFileManagerNotSolid.GetTextFromFiles());
sqlFileManagerNotSolid.SaveTextToFiles();

//hasta ahora todo bien, pero nos comunican que vana aparecer tb ficheros de solo lectura...
//qué hacemos??!?! no se puede grabar nada en un fichero de solo lectura... entonces vamos a crear un tipo de fichero de solo lectura
//que herede de SqlFile, pero eso además nos obliga a modificar nuestra clase SqlFileManager.. MAL!!

Console.WriteLine("Ahora vamos a hacerlo bien");


_3_SOLID_L.Good.ReadOnlySqlFile readOnlySqlFile1 = new _3_SOLID_L.Good.ReadOnlySqlFile("ruta-1");
_3_SOLID_L.Good.ReadOnlySqlFile readOnlySqlFile2 = new _3_SOLID_L.Good.ReadOnlySqlFile("ruta-2");
List<_3_SOLID_L.Good.IReadableSqlFile> readableSqlFiles = new List<_3_SOLID_L.Good.IReadableSqlFile>() { readOnlySqlFile1, readOnlySqlFile2 };

_3_SOLID_L.Good.SqlFile sqlFile1 = new _3_SOLID_L.Good.SqlFile("ruta-3");
_3_SOLID_L.Good.SqlFile sqlFile2 = new _3_SOLID_L.Good.SqlFile("ruta-4");
List<_3_SOLID_L.Good.IWritableSqlFile> writableSqlFiles = new List<_3_SOLID_L.Good.IWritableSqlFile>() { sqlFile1, sqlFile2 };

_3_SOLID_L.Good.SqlFileManager sqlFileManager = new _3_SOLID_L.Good.SqlFileManager();
Console.WriteLine(sqlFileManager.GetTextFromFiles(readableSqlFiles));
sqlFileManager.SaveTextIntoFiles(writableSqlFiles);



