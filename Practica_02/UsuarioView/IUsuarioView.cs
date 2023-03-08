using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.rih419.Practica_02
{
    public interface IUsuarioView
    {
        string Id {get;set;} //representa el identificador único del objeto
        string Nombre {get;set;}
        string PalabraPaso {get;set;}
        string Categoria {get;set;}
        bool EsValido {get;set;}
    

}
}
