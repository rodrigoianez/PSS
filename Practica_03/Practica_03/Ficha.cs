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


        public string tostring()
        {

            string colorString;

            if (this.Color == ColorFicha.Rojo)
            {
                colorString = "rojo";
            }
            else
            {
                colorString = "negro";
            }

            return colorString;
        }
    }
   
    public enum ColorFicha
    {
        Rojo, Negro

    }
}