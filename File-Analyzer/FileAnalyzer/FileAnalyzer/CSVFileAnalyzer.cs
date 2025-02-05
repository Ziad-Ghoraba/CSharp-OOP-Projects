using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer
{
    internal class CSVFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalysisFile(FileInfo fileInfo)
        {
            string[] fileString = File.ReadAllLines(fileInfo.FullName);
            AnalysisResults results = new AnalysisResults();
            results.FieldCount = fileString[0].Split(new char[] { ','}).Length;
            SetResults(results);
        }
    }
}
