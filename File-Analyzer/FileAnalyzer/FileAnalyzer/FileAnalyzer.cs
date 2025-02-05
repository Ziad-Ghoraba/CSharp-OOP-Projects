using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer
{
    internal class FileAnalyzer
    {
        private AnalysisResults results;

        public AnalysisResults GetResults()
        {
            return results;
        }

        public void SetResults(AnalysisResults results)
        {
            //Checking or validation
            this.results = results;
        }

    }
}
