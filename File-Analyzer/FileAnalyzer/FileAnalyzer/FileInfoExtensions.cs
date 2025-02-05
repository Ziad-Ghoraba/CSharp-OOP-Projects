using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer
{
    public static class FileInfoExtensions
    {
        public static bool IsTxtFile(this FileInfo fileInfo)
        {
            return (fileInfo.Extension == ".txt") ;
        }

        public static bool IsCSVFile(this FileInfo fileInfo)
        {
            return (fileInfo.Extension == ".csv");
        }
    }
}
