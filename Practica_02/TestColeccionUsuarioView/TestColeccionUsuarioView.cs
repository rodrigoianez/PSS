namespace PSS.rih419.Practica_02
{
    [TestClass]
    public class TestColeccionUsuarioView {

        public static UsuarioView usuario1 = new UsuarioView(1, "Rodrigo", "", "", false);
        public static UsuarioView usuario2 = new UsuarioView(2, "Miguel Angel", "", "", false);
        public static UsuarioView usuario3 = new UsuarioView(3, "", "", "", false);
        List<UsuarioView> ListaObjetos = new List<UsuarioView>() {usuario1, usuario2, usuario3 };

        public static UsuarioView usuario5 = new UsuarioView(5, "Rodrigo", "", "", false);



        [TestMethod]
        public void ContainsListaAdd()
        {
            
             ListaObjetos.Add(usuario5);
             Assert.IsTrue(ListaObjetos.Contains(usuario5));

        }

        [TestMethod]
        public void ConstainsLista ()
        {
            
            Assert.IsTrue(ListaObjetos.Contains(usuario1));

        }

        [TestMethod]
        public void IndexOf()
        {

            Assert.IsNull(ListaObjetos.IndexOf(usuario1));

        }


    }
}