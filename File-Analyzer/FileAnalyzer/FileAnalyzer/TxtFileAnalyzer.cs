using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer
{
    internal class TxtFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalysisFile(FileInfo fileInfo)
        {
            string fileString = File.ReadAllText(fileInfo.FullName);

            AnalysisResults results = new AnalysisResults();
            string[] words = fileString.Split(new char[] { ' ', '\n', '\r' });
            results.WordCount = words.Length;
            results.CharacterCount = fileString.Length;
            results.LineCount = fileString.Split(new char[] {'\n'}).Length;
            SetResults(results);


        }
    }
}
