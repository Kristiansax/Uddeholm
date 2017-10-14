using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uddeholm.Core.Entites;
using ExcelDataReader;

namespace Uddeholm.Core.Repositories
{
    public class DryTreatmentRepository : ExcelReader
    {
        public List<DryTreatment> DryTreatments = new List<DryTreatment>();

        public DryTreatmentRepository()
        {
            ReadDryTreatments();
        }

        public void ReadDryTreatments()
        {
            string startupPath = Environment.CurrentDirectory;
            IExcelDataReader excelReader = ReadExcel(startupPath + @"\toerstraaling.xlsx");

            excelReader.Read();

            while (excelReader.Read())
            {
                DryTreatment DT = new DryTreatment();
                DT.ToVolume     = excelReader.GetDouble(0);
                DT.QuantityLow  = excelReader.GetDouble(1);
                DT.QuantityMid  = excelReader.GetDouble(2);
                DT.QuantityHigh = excelReader.GetDouble(3);

                DryTreatments.Add(DT);
            }

            excelReader.Close();
        }

        public List<DryTreatment> GetAllDryTreatments()
        {
            return DryTreatments;
        }

        public DryTreatment GetDryTreatment(Steel steel)
        {
            foreach (DryTreatment DT in DryTreatments)
            {
                if (steel.GetVolume() > DT.ToVolume)
                    continue;
                return DT;
            }

            return null;
        }
    }
}
