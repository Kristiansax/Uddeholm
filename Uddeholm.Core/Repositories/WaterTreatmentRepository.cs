using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uddeholm.Core.Entites;
using Excel;

namespace Uddeholm.Core.Repositories
{
    public class WaterTreatmentRepository : ExcelReader
    {
        public List<WaterTreatment> WaterTreatments = new List<WaterTreatment>();

        public WaterTreatmentRepository()
        {
            ReadWaterTreatments();
        }

        public void ReadWaterTreatments()
        {
            string startupPath = Environment.CurrentDirectory;
            IExcelDataReader excelReader = ReadExcel(startupPath + @"\vaadstraaling.xlsx");

            excelReader.Read();

            while (excelReader.Read())
            {
                WaterTreatment DT = new WaterTreatment();
                DT.ToVolume = excelReader.GetDouble(0);
                DT.QuantityLow = excelReader.GetDouble(1);
                DT.QuantityMid = excelReader.GetDouble(2);
                DT.QuantityHigh = excelReader.GetDouble(3);

                WaterTreatments.Add(DT);
            }

            excelReader.Close();
        }

        public List<WaterTreatment> GetAllWaterTreatments()
        {
            return WaterTreatments;
        }

        public WaterTreatment GetWaterTreatment(Steel steel)
        {
            foreach (WaterTreatment DT in WaterTreatments)
            {
                if (steel.GetVolume() > DT.ToVolume)
                    continue;
                return DT;
            }

            return null;
        }
    }
}
