using System;
using System.Collections.Generic;
using Uddeholm.Core;
using Uddeholm.Core.Entites;
using Excel;

namespace Uddeholm.Core.Repositories
{
    public class ToolTypeRepository : ExcelReader
    {
        private List<ToolType> ToolTypes = new List<ToolType>();

        public ToolTypeRepository()
        {
            ReadToolTypes();
        }

        public List<ToolType> GetAllToolTypes()
        {
            return ToolTypes;
        }

        public void ReadToolTypes()
        {
            string startupPath = Environment.CurrentDirectory;
            IExcelDataReader excelReader = ReadExcel(startupPath + @"\vaerktoejstyper.xlsx");

            excelReader.Read();

            while (excelReader.Read())
            {
                ToolType TP  = new ToolType();
                TP.Name      = excelReader.GetString(0);
                TP.AddFactor = excelReader.GetDouble(1);

                ToolTypes.Add(TP);
            }

            excelReader.Close();
        }

        public ToolType GetToolType(string name)
        {
            return GetAllToolTypes().Find(x => x.Name == name);
        }
    }
}
