using System.Drawing;

namespace PSS.rih419.Practica_03
{
    public class Ficha
    {

        public ColorFicha color;

        public ColorFicha Color { get { return color; } }

        public Ficha()
        {

        }

        public Ficha(ColorFicha color1)
        {
            color = color1;
        }
        public string ToString()
        {

            string colorString;
            if (Juego.idioma == 1)
            {
                if (this.Color == ColorFicha.Morado)
                {
                    colorString = "Morado";
                }
                else
                {
                    colorString = "Verde";
                }
            }
            else
            {
                if (this.Color == ColorFicha.Morado)
                {
                    colorString = "Purple";
                }
                else
                {
                    colorString = "Green";
                }
            }
            

            return colorString;
        }
    }

    public enum ColorFicha
    {
        Morado, Verde

    }
}