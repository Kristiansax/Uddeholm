using System;
using System.Collections.Generic;
using Uddeholm.Core;
using Uddeholm.Core.Entites;
using Excel;

namespace Uddeholm.Core.Repositories
{
    public class PriceRepository : ExcelReader
    {
        public List<Price> Prices = new List<Price>();

        public PriceRepository()
        {
            ReadPrices();
        }

        public void ReadPrices()
        {
            IExcelDataReader excelReader = ReadExcel(@"C:\Users\Fumi\Source\Repos\Uddeholm4\Uddeholm.Test\bin\Debug\PVD.xlsx");
            excelReader.IsFirstRowAsColumnNames = true;
            excelReader.Read();
            while (excelReader.Read())
            {
                Price price = new Price();
                price.ToVolume = excelReader.GetDouble(0);
                price.PriceCM3 = excelReader.GetDouble(1);

                Prices.Add(price);
            }

            excelReader.Close();
        }

        public Price GetPrice(double volume)
        {
            foreach (Price p in Prices)
            {
                if (volume > p.ToVolume)
                    continue;
                return p;
            }
            return null;
        }

        public List<Price> GetAllPrices()
        {
            return Prices;
        }
    }
}