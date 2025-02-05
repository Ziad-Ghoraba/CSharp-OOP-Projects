namespace FileAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To File Analyzer");
            Console.WriteLine("Pleas enter Folder Path To Analyze :)");
            string inputFolder = Console.ReadLine();

            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);
            if (!directoryInfo.Exists )
            {
                Console.WriteLine("Folder Doesn't Exist");
                return;
            }

            FileInfo[] fileNames = directoryInfo.GetFiles();
            IFileAnalysis fileAnalysis = null;
            foreach ( FileInfo file in fileNames )
            {
                if(file.IsTxtFile())
                {
                    fileAnalysis = new TxtFileAnalyzer();
                    fileAnalysis.AnalysisFile(file);
                    var results = ((FileAnalyzer)fileAnalysis).GetResults();
                    Console.WriteLine("////////////////////////////////////////////////");
                    Console.WriteLine($"File name : {file.Name}");
                    Console.WriteLine($"Word Count : {results.WordCount}");
                    Console.WriteLine($"Character Count : {results.CharacterCount}");
                    Console.WriteLine($"Line Count : {results.LineCount}");
                }
                else if(file.IsCSVFile())
                {
                    fileAnalysis = new CSVFileAnalyzer();
                    fileAnalysis.AnalysisFile(file);
                    var results = ((FileAnalyzer)fileAnalysis).GetResults();
                    Console.WriteLine("////////////////////////////////////////////////");
                    Console.WriteLine($"File name : {file.Name}");
                    Console.WriteLine($"Field Count : {results.FieldCount}");

                }
            }
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Thanks For Your Trust!");
        }
    }
}
