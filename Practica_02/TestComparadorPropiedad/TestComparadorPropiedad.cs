namespace PSS.rih419.Practica_02
{
    [TestClass]
    public class TestComparadorPropiedad
    {
        public static  UsuarioView usuario1 = new UsuarioView(0, "Rodrigo", "Comer", "Comida", true);
        public static  UsuarioView usuario2 = new UsuarioView(1, "Gelado", "Cenar", "Cena", false);

        public static  UsuarioView usuario3 = null;
        
        public static UsuarioView usuario4 = new UsuarioView(0, "Rodrigo", "Comer", "Comida", true);
        public static UsuarioView usuario5 = new UsuarioView();
        public static UsuarioView usuario6 = new UsuarioView(2, "Miguel Angel", "Correr", "Zapatillas", false);

        List<UsuarioView> Lista1 = new List<UsuarioView>() { usuario1, usuario2, usuario6};
        List<UsuarioView> Lista2 = new List<UsuarioView>() { usuario6, usuario1, usuario2};


        List<UsuarioView> Lista3 = new List<UsuarioView>() { usuario2, usuario6, usuario1 };
        List<UsuarioView> Lista4 = new List<UsuarioView>() { usuario6, usuario2, usuario1 };


        List<UsuarioView> Lista5 = new List<UsuarioView>() { usuario2, usuario1, usuario6 };
        List<UsuarioView> Lista6 = new List<UsuarioView>() { usuario6, usuario2, usuario1 };



        List<UsuarioView> Lista7 = new List<UsuarioView>() { usuario2, usuario1, usuario6 };
        List<UsuarioView> Lista8 = new List<UsuarioView>() { usuario6, usuario1, usuario2 };


        List<UsuarioView> Lista9 = new List<UsuarioView>() { usuario2, usuario6, usuario1 };
        List<UsuarioView> Lista10 = new List<UsuarioView>() { usuario2, usuario1, usuario6 };


        [TestMethod]
        public void CompareId_Lista()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");
            Lista2.Sort(propiedad);
            CollectionAssert.AreEqual(Lista1, Lista2);

        }
        [TestMethod]
        public void CompareNombre_Lista()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Nombre");
            Lista4.Sort(propiedad);
            CollectionAssert.AreEqual(Lista3, Lista4);

        }

        [TestMethod]
        public void ComparePalabraPaso_Lista()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("PalabraPaso");
            Lista6.Sort(propiedad);
            CollectionAssert.AreEqual(Lista5, Lista6);

        }

        [TestMethod]
        public void CompareCategoria_Lista()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Categoria");
            Lista8.Sort(propiedad);
            CollectionAssert.AreEqual(Lista7, Lista8);

        }

        [TestMethod]
        public void CompareEsValido_Lista()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("EsValido");
            Lista10.Sort(propiedad);
            CollectionAssert.AreEqual(Lista9, Lista10);

        }


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

    }
}