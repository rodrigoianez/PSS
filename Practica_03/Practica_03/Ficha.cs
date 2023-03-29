namespace PSS.rih419.Practica_03
{
    public class Ficha
    {

        public ColorFicha _color;

        public ColorFicha Color { get { return _color; } }

        public Ficha()
        {
        }

        public Ficha(ColorFicha color)
        {
            _color = color;
        }
    }

    public enum ColorFicha
    {
        Rojo, Negro, SinColor

    }
}