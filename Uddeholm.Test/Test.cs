using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uddeholm.Core.Entites;
using Uddeholm.Core.Repositories;
using System.Collections.Generic;

namespace Uddeholm.Test
{
    [TestClass]
    public class Test
    {
        CoatingRepository        CoatingRepository        = new CoatingRepository();
        PriceRepository          PriceRepository          = new PriceRepository();
        SteelRepository          SteelRepository          = new SteelRepository();
        DryTreatmentRepository   DryTreatmentRepository   = new DryTreatmentRepository();
        WaterTreatmentRepository WaterTreatmentRepository = new WaterTreatmentRepository();
        ToolTypeRepository       ToolTypeRepository       = new ToolTypeRepository();

        // Empty values
        List<Coating>  coatings  = new List<Coating>();
        List<ToolType> tooltypes = new List<ToolType>();
        DryTreatment drytreatment = new DryTreatment();
        WaterTreatment watertreatment = new WaterTreatment();

        /* ========================== Testing files ========================== */

        [TestMethod]
        public void FilesExist()
        {
            string startupPath = Environment.CurrentDirectory;
            Assert.IsTrue(File.Exists(startupPath + @"\factors.xlsx"));
            Assert.IsTrue(File.Exists(startupPath + @"\PVD.xlsx"));
            Assert.IsTrue(File.Exists(startupPath + @"\toerstraaling.xlsx"));
            Assert.IsTrue(File.Exists(startupPath + @"\vaerktoejstyper.xlsx"));
        }

        /* ========================= Testing coatings ======================== */

        [TestMethod]
        public void CanPutCoatingsIntoList()
        {
            Assert.IsTrue(CoatingRepository.GetAllCoatings().Count > 0);
        }

        [TestMethod]
        public void CanGetCoatingFactorFromName()
        {
            Assert.AreEqual(1.4, CoatingRepository.GetCoating("SISTRAL").factor);
        }

        /* ========================== Testing Steel ========================= */

        [TestMethod]
        public void CalculateVolumeOfRoundSteel()
        {
            Steel steel = new Steel()
            {
                IsRound = true,
                Width = 20,
                Length = 20,
                Quantity = 1
            };

            Assert.AreEqual(6.28, Math.Round(steel.GetVolume(), 2));
        }

        [TestMethod]
        public void CalculateVolumeOfSquareSteel()
        {
            Steel steel = new Steel()
            {
                IsRound = false,
                Height = 20,
                Width = 20,
                Length = 20,
                Quantity = 1
            };

            Assert.AreEqual(8, steel.GetVolume());
        }

        /* ========================== Testing Prices ========================= */

        [TestMethod]
        public void CanPutPricesIntoList()
        {
            Assert.IsTrue(PriceRepository.GetAllPrices().Count > 0);
        }

        [TestMethod]
        public void GetGetCorrectPriceFromVolume()
        {
            Assert.AreEqual(3.71, PriceRepository.GetPrice(81).PriceCM3);
        }

        /* ================================ Tørstråling ================================ */

        [TestMethod]
        public void CanReadFromExcel()
        {
            Assert.AreEqual(27, DryTreatmentRepository.GetAllDryTreatments().Count);
        }

        [TestMethod]
        public void CanGetDifferentQuantities()
        {
            Steel steel = new Steel()
            {
                IsRound = false, Width = 50, Height = 50, Length = 50, Quantity = 4
            };

            Assert.AreEqual(57.49, Math.Round( DryTreatmentRepository.GetDryTreatment(steel).QuantityMid, 2));
        }

        [TestMethod]
        public void CanGetDryTreatmentFromRoundSteel()
        {
            Steel steel2 = new Steel()
            {
                IsRound = true, Width = 180, Length = 173, Quantity = 20
            };

            Assert.AreEqual(142.07, Math.Round(DryTreatmentRepository.GetDryTreatment(steel2).QuantityHigh, 2));
        }

        /* ================================ Vådstrling ================================ */

        [TestMethod]
        public void CanReadFromExcelWet()
        {
            Assert.AreEqual(27, WaterTreatmentRepository.GetAllWaterTreatments().Count);
        }

        [TestMethod]
        public void CanGetDifferentQuantitiesFromWet()
        {
            Steel steel = new Steel()
            {
                IsRound = false,
                Width = 83,
                Height = 83,
                Length = 83,
                Quantity = 4
            };

            Assert.AreEqual(106.48, Math.Round(WaterTreatmentRepository.GetWaterTreatment(steel).QuantityMid, 2));
        }

        [TestMethod]
        public void CanGetWaterTreatmentFromRoundSteel()
        {
            Steel steel2 = new Steel()
            {
                IsRound = true,
                Width = 180,
                Length = 173,
                Quantity = 20
            };

            Assert.AreEqual(186.75, Math.Round(WaterTreatmentRepository.GetWaterTreatment(steel2).QuantityHigh, 2));
        }

        /* ================================== Tools ==================================== */

        [TestMethod]
        public void CanAddToolTypesToRepository()
        {
            Assert.IsTrue(ToolTypeRepository.GetAllToolTypes().Count > 0);
        }

        [TestMethod]
        public void CanGetCorrectToolType()
        {
            Assert.AreEqual(0.3, ToolTypeRepository.GetToolType("Ekstremt fine værktøj og sensible værktøj").AddFactor);
        }

        /* ================================== Final price ==================================== */
        [TestMethod]
        public void CanCalculateFinalPriceWithOnlyCoatings()
        {
            Steel steel = new Steel(PriceRepository)
            {
                Width = 33,   Length = 20,   Height = 55,   IsRound = false,   Quantity = 1
            };

            coatings.Add(CoatingRepository.GetCoating("CROSAL"));
            coatings.Add(CoatingRepository.GetCoating("SISTRAL"));

            //Assert.AreEqual(601.13, steel.GetFinalPrice(coatings, watertreatment, drytreatment, tooltypes));
        }

        [TestMethod]
        public void CanCalculateFinalPriceWithMoreStuff()
        {
            Steel steel = new Steel(PriceRepository)
            {
                Width = 33,   Length = 20,   IsRound = true,   Quantity = 6
            };

            coatings.Add(CoatingRepository.GetCoating("SISTRAL"));
            coatings.Add(CoatingRepository.GetCoating("CROSAL"));

            tooltypes.Add(ToolTypeRepository.GetToolType("Plastværktøj, medicokomponenter"));

            watertreatment = WaterTreatmentRepository.GetWaterTreatment(steel);

            //Assert.AreEqual(2655.71, steel.GetFinalPrice(coatings, watertreatment, drytreatment, tooltypes));
        }

        [TestMethod]
        public void CanCalculateFinalPriceWithEvenMoreStuff()
        {
            Steel steel = new Steel(PriceRepository)
            {
                Width = 29,   Length = 61,   Height = 38,   IsRound = false,   Quantity = 23
            };

            coatings.Add(CoatingRepository.GetCoating("DUMATIC"));
            coatings.Add(CoatingRepository.GetCoating("MoST"));

            watertreatment = WaterTreatmentRepository.GetWaterTreatment(steel);

            tooltypes.Add(ToolTypeRepository.GetToolType("Ekstremt fine værktøj og sensible værktøj"));

            //Assert.AreEqual(19564.67, steel.GetFinalPrice(coatings, watertreatment, drytreatment, tooltypes));
        }
    }
}