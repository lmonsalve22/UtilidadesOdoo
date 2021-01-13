using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionBlanco.Models
{
    public class BaseGEE
    {
        public List<VistasGEE> vistas;

        public BaseGEE()
        {
            this.vistas = new List<VistasGEE>();
            vistas.Add(new VistasGEE(id: 9901, geeURL: "https://anin.users.earthengine.app/view/muestra3", comentario: "Test", nombre: "Atlantida",urlImagen: "ImpactosDelHuracanETAenHonduras.jpg"));
            vistas.Add(new VistasGEE(id: 9911, geeURL: "https://anin.users.earthengine.app/view/muestra3", comentario: "Test", nombre: "Comayagua", urlImagen: "ImpactosDelHuracanETAenHonduras.jpg"));
            vistas.Add(new VistasGEE(id: 9921, geeURL: "https://anin.users.earthengine.app/view/muestra3", comentario: "Test", nombre: "Gracias a Dios", urlImagen: "ImpactosDelHuracanETAenHonduras.jpg"));
            vistas.Add(new VistasGEE(id: 9931, geeURL: "https://anin.users.earthengine.app/view/muestra3", comentario: "Test", nombre: "Valle", urlImagen: "ImpactosDelHuracanETAenHonduras.jpg"));
            vistas.Add(new VistasGEE(id: 9941, geeURL: "https://anin.users.earthengine.app/view/muestra3", comentario: "Test", nombre: "La Paz", urlImagen: "ImpactosDelHuracanETAenHonduras.jpg"));
            vistas.Add(new VistasGEE(id: 9951, geeURL: "https://anin.users.earthengine.app/view/muestra3", comentario: "Test", nombre: "Olancho", urlImagen: "ImpactosDelHuracanETAenHonduras.jpg"));
            vistas.Add(new VistasGEE(id: 9961, geeURL: "https://anin.users.earthengine.app/view/muestra3", comentario: "Test", nombre: "Colón", urlImagen: "ImpactosDelHuracanETAenHonduras.jpg"));

            vistas.Add(new VistasGEE(id: 9902, geeURL: "https://anin.users.earthengine.app/view/muestra4", comentario: "Test", nombre: "Test muestra 4 regiones", urlImagen: "ImpactosDelHuracanETAenHonduras.jpg"));
        
        }
    }
}