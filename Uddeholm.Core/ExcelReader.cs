using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using System.IO;

namespace Uddeholm.Core
{
    public abstract class ExcelReader
    {
        public IExcelDataReader ReadExcel(string path)
        {
            FileStream filestream = File.Open(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(filestream);

            return reader;
        }
    }
}