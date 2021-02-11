using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;

namespace OperazioniTests
{
    [TestClass]
    public class GestioneTests
    {
        [TestMethod]
        public void TestCalcoloMisterioso1()
        {
            int n = 5;
            int valore_aspettato = 240;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso2()
        {
            int n = 7;
            int valore_aspettato = 10080;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso3()
        {
            long n = 6;
            long valore_aspettato = 1440;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso4()
        {
            int n = 8;
            int valore_aspettato = 80640;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestMisurazioneMisteriosa()
        {
            double[] valori = new double[4]{ 4, 6, 7, -9.1 };
            double min = Gestione.MisurazioneMisteriosa(valori);
            double valore_aspettato = 3;
            Assert.AreEqual(valore_aspettato, min);
        }
        [TestMethod]
        public void TestMisurazioneMisteriosa2()
        {
            double[] valori = new double[4] { -2, 3, 5, 4.5 };
            double min = Gestione.MisurazioneMisteriosa(valori);
            double valore_aspettato = 0;
            Assert.AreEqual(valore_aspettato, min);
        }
        [TestMethod]
        public void TestMisurazioneMisteriosa3()
        {
            double[] valori = new double[4] { -3, 4, 0, 1.2 };
            double min = Gestione.MisurazioneMisteriosa(valori);
            double valore_aspettato = 0;
            Assert.AreEqual(valore_aspettato, min);
        }
        [TestMethod]
        public void TestMisurazioneMisteriosa4()
        {
            double[] valori = new double[4] { 4, 6, 7, -9.1 };
            double min = Gestione.MisurazioneMisteriosa(valori);
            double valore_aspettato = 3;
            Assert.AreEqual(valore_aspettato, min);
        }
    }
}
