using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestJeuDroide
{
    [TestClass]
    public class JediUnitTest
    {
        [TestMethod]
        public void TesterAttaquerToutEstOk()
        {

            ExempleJediTestUnitaire.Jedi jedi = new ExempleJediTestUnitaire.Jedi();
            ExempleJediTestUnitaire.Droide droide = new ExempleJediTestUnitaire.Droide()
            {
                PointDeVie = 100
            };

            jedi.Attaquer(droide);

            Assert.IsTrue(droide.PointDeVie == 50);

        }
    }
}
