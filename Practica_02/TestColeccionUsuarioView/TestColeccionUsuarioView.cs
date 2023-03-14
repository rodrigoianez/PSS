namespace PSS.rih419.Practica_02
{
    [TestClass]
    public class TestColeccionUsuarioView {

        public static UsuarioView usuario1 = new UsuarioView(1, "Rodrigo", "", "", false);
        public static UsuarioView usuario2 = new UsuarioView(2, "Miguel Angel", "", "", false);
        public static UsuarioView usuario3 = new UsuarioView(3, "", "", "", false);
        public static UsuarioView usuario4 = new UsuarioView(4, "Rodrigo", "", "", false);
        public static UsuarioView usuario5 = new UsuarioView(1, "Gelado", "", "", true);


        List<UsuarioView> ListaObjetos = new List<UsuarioView>() { usuario1, usuario2, usuario3 };


        [TestMethod]
        public void ContainsListaAdd()
        {
            
             ListaObjetos.Add(usuario4);
             Assert.IsTrue(ListaObjetos.Contains(usuario4));

        }

        [TestMethod]
        public void ConstainsLista ()
        {
            
            Assert.IsTrue(ListaObjetos.Contains(usuario1));

        }

        [TestMethod]
        public void IndexOf()
        {

            Assert.AreEqual(0,ListaObjetos.IndexOf(usuario1));
            
        }

        [TestMethod]
        public void LastIndexOf()
        {

            Assert.AreEqual(4, ListaObjetos.IndexOf(usuario1));

        }
        [TestMethod]
        public void Remove()
        {

            ListaObjetos.Remove(usuario4);
            Assert.IsFalse(ListaObjetos.Contains(usuario4));

        }




    }
}