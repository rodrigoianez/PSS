using System.Security.Cryptography.X509Certificates;

namespace PSS.rih419.Practica_02
{
    [TestClass]
    public class UnitTest1
    {

        public static UsuarioView usuario1 = new UsuarioView(0, "", "", "", true);
        public static UsuarioView usuario2 = new UsuarioView(1, "", "", "", true);
        public static UsuarioView usuario3 = new UsuarioView(2, "", "", "", true);
        public static UsuarioView usuario4 = new UsuarioView();
        public static UsuarioView usuario5 = null;

        public static UsuarioView usuario6 = new UsuarioView(0, "", "", "", true);
        public static UsuarioView usuario7 = null;
        public static UsuarioView usuario8 = new UsuarioView();




        [TestMethod]
        public void IsNull()
        {

            Assert.IsNull(usuario5);

        }

        [TestMethod]
        public void IsNotNull()
        {

            Assert.IsNotNull(usuario1);

        }

        [TestMethod]
        public void AreEqual()
        {

            Assert.AreEqual(usuario1, usuario6);

        }

        [TestMethod]
        public void AreEqualsGetHashCode()
        {

            Assert.AreEqual(usuario1.GetHashCode(), usuario1.GetHashCode());

        }

        [TestMethod]
        public void AreNotEqualsGetHashCode()
        {

            Assert.AreNotEqual(usuario1.GetHashCode(), usuario2.GetHashCode());

        }

        [TestMethod]
        public void AreNotEqualGetHashCode()
        {

            Assert.AreNotEqual(usuario1.GetHashCode(), usuario2.GetHashCode());

        }

        [TestMethod]
        public void Distinto()
        {

            Assert.IsTrue(usuario2 != usuario5);

        }

        [TestMethod]
        public void Igual()
        {

            Assert.IsTrue(usuario1 == usuario6);

        }

        [TestMethod]
        public void CompareTo_AA_Iguales()
        {

            UsuarioView A = new UsuarioView(0, "", "", "", true);
            int expected = 0;
            int actual = A.CompareTo(A);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void CompareTo_AB_Iguales()
        {

            UsuarioView A = new UsuarioView(0, "", "", "", true);
            UsuarioView B = new UsuarioView(0, "", "", "", true);

            Assert.AreEqual(0, A.CompareTo(B));
            Assert.AreEqual(0, B.CompareTo(A));

        }

        public void CompareTo_ABC_Iguales()
        {

            UsuarioView A = new UsuarioView(0, "", "", "", true);
            UsuarioView B = new UsuarioView(0, "", "", "", true);
            UsuarioView C = new UsuarioView(0, "", "", "", true);

            Assert.AreEqual(0, A.CompareTo(B));
            Assert.AreEqual(0, B.CompareTo(C));
            Assert.AreEqual(0, A.CompareTo(C));

        }

        public void CompareTo_AB_Distintos()
        {

            UsuarioView A = new UsuarioView(0, "", "", "", true);
            UsuarioView B = new UsuarioView(1, "", "", "", true);


            int validacion1 = A.CompareTo(B);

            int validacion2 = B.CompareTo(A);

            Assert.AreEqual(validacion1, -validacion2);
        }

        [TestMethod]
        public void CompareTo_ABC_Distintos()
        {

            UsuarioView A = new UsuarioView(3, "", "", "", true);
            UsuarioView B = new UsuarioView(2, "", "", "", true);
            UsuarioView C = new UsuarioView(1, "", "", "", true);

            int validacion1 = A.CompareTo(B);

            int validacion2 = B.CompareTo(C);

            int validacion3 = A.CompareTo(C);

            Assert.AreEqual(validacion1, validacion2);
            Assert.AreEqual(validacion1, validacion3);

        }

       

    }
} 