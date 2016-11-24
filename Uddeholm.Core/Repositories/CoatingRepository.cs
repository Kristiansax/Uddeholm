using System;
using System.Collections.Generic;
using Uddeholm.Core;
using Uddeholm.Core.Entites;
using Excel;

namespace Uddeholm.Core.Repositories
{
    public class CoatingRepository : ExcelReader
    {
        public List<Coating> Coatings = new List<Coating>();

        public CoatingRepository()
        {
            ReadCoatings();
        }

        public void ReadCoatings()
        {
            IExcelDataReader excelReader = ReadExcel(@"C:\Users\Fumi\Source\Repos\Uddeholm4\Uddeholm.Test\bin\Debug\factors.xlsx");
            excelReader.IsFirstRowAsColumnNames = true;
            excelReader.Read();
            while (excelReader.Read())
            {
                Coating coating = new Coating();
                coating.name = excelReader.GetString(0);
                coating.factor = excelReader.GetDouble(1);

                Coatings.Add(coating);
            }

            excelReader.Close();
        }

        public Coating GetCoating(string name)
        {
            foreach (Coating c in Coatings)
            {
                if (name == c.name)
                    return c;
            }
            return null;
        }

        public List<Coating> GetAllCoatings()
        {
            return Coatings;
        }
    }
}