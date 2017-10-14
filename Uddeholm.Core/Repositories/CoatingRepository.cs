using System;
using System.Collections.Generic;
using Uddeholm.Core;
using Uddeholm.Core.Entites;
using ExcelDataReader;

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
            string startupPath = Environment.CurrentDirectory;
            IExcelDataReader excelReader = ReadExcel(startupPath+ @"\BelaegningsTyper.xlsx");
            //excelReader.IsFirstRowAsColumnNames = true;
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