namespace PSS.rih419.Practica_02
{
    [TestClass]
    public class RecorridoSecuenciaTest
    {

        UsuarioView usuario1 = new UsuarioView(0, "Rodrigo", "Comer", "Comida", true);
        UsuarioView usuario2 = new UsuarioView(1, "Cristian", "Correr", "Zapatillas", true);
        UsuarioView usuario3 = new UsuarioView(2, "Miguel Angel", "Saltar", "Rapido", true);
       public static  UsuarioView usuario4 = new UsuarioView(4, "Gelado", "Comprar", "ChocoBoom", true);

        [TestMethod]
        public void RecorridoAdelante()
        {

            Secuencia<UsuarioView> secuencia1 = new Secuencia<UsuarioView>{

                usuario1, usuario2, usuario3, usuario4
           
            };

            Secuencia<UsuarioView> secuencia2 = new Secuencia<UsuarioView>{

                usuario1, usuario2, usuario3, usuario4

            };

            Secuencia<UsuarioView> secuencia3 = new Secuencia<UsuarioView>();

            foreach(UsuarioView usuario in secuencia1.RecorridoAdelante())
            {

                secuencia3.Añadir(usuario);

            }

           CollectionAssert.AreEqual(secuencia3,secuencia2);




        }
    }
}