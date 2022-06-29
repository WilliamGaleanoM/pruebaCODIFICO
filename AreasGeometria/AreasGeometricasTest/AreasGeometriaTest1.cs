using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;


namespace AreasGeometricasTest
{
    [TestClass]
    public class AreasGeometriaTest1
    {

        [TestMethod]
        public void AreasGeometriaTestCirculo1()
        {
            string Expected = "El �rea del c�rculo es 50,26544";
            using (var sw = new StringWriter())
            {
               
                
                Console.SetOut(sw);
                AreasGeometria.Program.Main(new string[] {"1", "4"});
               
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void AreasGeometriaTestRectangulo1()
        {
            string Expected = "El �rea del rect�ngulo es 20";
            using (var sw = new StringWriter())
            {


                Console.SetOut(sw);
                AreasGeometria.Program.Main(new string[] { "2", "4", "5" });

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

    }
}
