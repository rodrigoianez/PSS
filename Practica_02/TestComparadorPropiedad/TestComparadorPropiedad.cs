namespace PSS.rih419.Practica_02
{
    [TestClass]
    public class TestComparadorPropiedad
    {
        UsuarioView usuario1 = new UsuarioView(0, "Rodrigo", "Comer", "Comida", true);
        UsuarioView usuario2 = new UsuarioView(1, "Gelado", "Cenar", "Cena", false);
        UsuarioView usuario3 = null;

        UsuarioView usuario4 = new UsuarioView(0, "Rodrigo", "Comer", "Comida", true);

        [TestMethod]
        public void CompareId_UsuarioNull()
        {
            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(1,propiedad.Compare(usuario1, usuario3));

        }

        [TestMethod]
        public void CompareId_NullUsuario()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(-1, propiedad.Compare(usuario3, usuario1));

        }

        [TestMethod]
        public void CompareId_NullNull()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(0, propiedad.Compare(usuario3, usuario3));

        }

        [TestMethod]
        public void CompareId_UsuarioUsuario_Menor()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(-1, propiedad.Compare(usuario1, usuario2));

        }

        [TestMethod]
        public void CompareId_UsuarioUsuario_Igual()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(0, propiedad.Compare(usuario1, usuario4));

        }

        [TestMethod]
        public void CompareId_UsuarioUsuario_Mayor()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(1, propiedad.Compare(usuario2, usuario1));

        }

        [TestMethod]
        public void CompareEsValido_UsuarioNull()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("EsValido");

            Assert.AreEqual(1, propiedad.Compare(usuario1, usuario3));

        }

        [TestMethod]
        public void CompareEsValido_NullUsuario()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("EsValido");

            Assert.AreEqual(-1, propiedad.Compare(usuario3, usuario1));

        }

        [TestMethod]
        public void CompareEsValido_NullNull()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("EsValido");

            Assert.AreEqual(0, propiedad.Compare(usuario3, usuario3));

        }

        [TestMethod]
        public void CompareEsValido_UsuarioUsuario_Distintos()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("EsValido");

            Assert.IsTrue(0 != propiedad.Compare(usuario1, usuario2));

        }

        [TestMethod]
        public void CompareEsValido_UsuarioUsuario_Igual()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("EsValido");

            Assert.AreEqual(0, propiedad.Compare(usuario1, usuario4));

        }

        [TestMethod]
        public void CompareNombre_UsuarioNull()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Nombre");

            Assert.AreEqual(1, propiedad.Compare(usuario1, usuario3));

        }

        [TestMethod]
        public void CompareNombre_NullUsuario()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Nombre");

            Assert.AreEqual(-1, propiedad.Compare(usuario3, usuario1));

        }

        [TestMethod]
        public void CompareNombre_NullNull()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Nombre");

            Assert.AreEqual(0, propiedad.Compare(usuario3, usuario3));

        }

        [TestMethod]
        public void CompareNombre_UsuarioUsuario_Igual()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Nombre");

            Assert.AreEqual(0, propiedad.Compare(usuario1, usuario4));

        }

        [TestMethod]
        public void CompareNombre_UsuarioUsuario_Distinto()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Nombre");

            Assert.IsTrue(0 != propiedad.Compare(usuario1, usuario2));

        }

        [TestMethod]
        public void ComparePalabraPaso_UsuarioNull()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("PalabraPaso");

            Assert.AreEqual(1, propiedad.Compare(usuario1, usuario3));

        }

        [TestMethod]
        public void ComparePalabraPaso_NullUsuario()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("PalabraPaso");

            Assert.AreEqual(-1, propiedad.Compare(usuario3, usuario1));

        }

        [TestMethod]
        public void ComparePalabraPaso_NullNull()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("PalabraPaso");

            Assert.AreEqual(0, propiedad.Compare(usuario3, usuario3));

        }

        [TestMethod]
        public void ComparePalabraPaso_UsuarioUsuario_Igual()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("PalabraPaso");

            Assert.AreEqual(0, propiedad.Compare(usuario1, usuario4));

        }

        [TestMethod]
        public void ComparePalabraPaso_UsuarioUsuario_Distinto()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("PalabraPaso");

            Assert.IsTrue(0 != propiedad.Compare(usuario1, usuario2));

        }

        [TestMethod]
        public void CompareCategoria_UsuarioNull()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Categoria");

            Assert.AreEqual(1, propiedad.Compare(usuario1, usuario3));

        }

        [TestMethod]
        public void CompareCategoria_NullUsuario()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Categoria");

            Assert.AreEqual(-1, propiedad.Compare(usuario3, usuario1));

        }

        [TestMethod]
        public void CompareCategoria_NullNull()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Categoria");

            Assert.AreEqual(0, propiedad.Compare(usuario3, usuario3));

        }

        [TestMethod]
        public void CompareCategoria_UsuarioUsuario_Igual()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Categoria");

            Assert.AreEqual(0, propiedad.Compare(usuario1, usuario4));

        }

        [TestMethod]
        public void CompareCataegoria_UsuarioUsuario_Distinto()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Categoria");

            Assert.IsTrue(0 != propiedad.Compare(usuario1, usuario2));

        }



    }
}