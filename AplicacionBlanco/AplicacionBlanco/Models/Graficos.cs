using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionBlanco.Models
{
    public class Graficos
    {

        public List<Grafico> GRAFICOS { get; set; }

        public Graficos()
        {
            GRAFICOS = new List<Grafico>();
            //int iD, string nOMBRE, string tITULO, string sUBTITULO, string dESCRIPCION, string fECHA_PUBLICACION, string rEGION, string pERIODO_ESTUDIO, string gRUPO_EDAD, string tAGS, string mACROTEMA, string uRL, string Español
            GRAFICOS.Add(new Grafico(iD:1, 
                                    nOMBRE:"Grafico_Test_1", 
                                    tITULO:"Gráfico Test 1", 
                                    sUBTITULO:"", 
                                    dESCRIPCION:"Este gráfico es de ejemplo para usos varios.",
                                    fECHA_PUBLICACION:"3 de Marzo", 
                                    rEGION:"Sin región", 
                                    pERIODO_ESTUDIO:"Sin Período", 
                                    gRUPO_EDAD:"Sin grupo de edad", 
                                    tAGS:"test prueba", 
                                    mACROTEMA:"Prueba", 
                                    uRL:"test.csv",
                                    Español:"Espanol"));
            GRAFICOS.Add(new Grafico(2, "Grafico_Test_2", "Gráfico Test 2", "", "Este gráfico es de ejemplo para usos varios.", 
                                     "3 de Marzo", "Sin región", "Sin Período", "Sin grupo de edad", "test prueba", "Prueba", "test2.csv","español"));
            GRAFICOS.Add(new Grafico(3, "Grafico_Test_3", "Gráfico Test 3", "", "Este gráfico es de ejemplo para usos varios.",
                                     "3 de Marzo", "Sin región", "Sin Período", "Sin grupo de edad", "test prueba", "Prueba", "test3.csv", "español"));
            GRAFICOS.Add(new Grafico(4, "Grafico_Test_2", "Gráfico Test 2", "", "Este gráfico es de ejemplo para usos varios.",
                                     "3 de Marzo", "Sin región", "Sin Período", "Sin grupo de edad", "test prueba", "Prueba", "test4.csv", "español"));
            GRAFICOS.Add(new Grafico(5, "Grafico_Test_2", "Gráfico Test 2", "", "Este gráfico es de ejemplo para usos varios.",
                                     "3 de Marzo", "Sin región", "Sin Período", "Sin grupo de edad", "test prueba", "Prueba", "test5.csv", "español"));
            GRAFICOS.Add(new Grafico(6, "Gráfico de geografía", "Mapa geográfico", "", "Este gráfico es de ejemplo para usos varios.",
                                     "3 de Marzo", "Sin región", "Sin Período", "Sin grupo de edad", "test prueba", "Prueba", "mapadechile_engeochart_2021.csv", "español"));


        }

        public Grafico BuscarGrafico(int id)
        {
            return GRAFICOS.Where(x => x.ID == id).First();
        }
    }
}