namespace PSS.rih419.Practica_02
{
    public class TestUsuarioView
    {
        
            UsuarioView usuario1 = new UsuarioView(0, "Rodrigo", "cocinar", "avanzado", false);
            UsuarioView usuario2 = new UsuarioView(1, "Jesus", "comer", "experto", true);
            UsuarioView usuario3 = new UsuarioView();
            UsuarioView? usuario4;
            UsuarioView usuario5 = new UsuarioView(0, "Rodrigo", "cocinar", "experto", true);
        
        [Test]
        public void UsuariosDiferentes()
        {

            Assert.That(Equals(usuario1,usuario2), Is.EqualTo(false));
            Assert.That(Equals(usuario1, usuario5), Is.EqualTo(false));
            Assert.That(Equals(usuario2, usuario5), Is.EqualTo(false));

        }

        [Test]
        public void UsuariosIguales()
        {

            Assert.That(Equals(usuario1, usuario1), Is.EqualTo(true));
            Assert.That(Equals(usuario5, usuario5), Is.EqualTo(true));

        }

        [Test]
        public void Vacio_Usuario()
        {

            Assert.That(Equals(usuario1, usuario3), Is.EqualTo(false));
            Assert.That(Equals(usuario2, usuario3), Is.EqualTo(false));
            Assert.That(Equals(usuario5, usuario3), Is.EqualTo(false));

        }

        [Test]
        public void  Null_Vacio()
        {

            Assert.That(Equals(usuario4, usuario3), Is.EqualTo(false));

        }



    }
}