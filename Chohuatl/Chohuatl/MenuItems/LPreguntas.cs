using System;
using System.Collections.Generic;
using System.Text;

namespace Chohuatl.MenuItems
{
    public class LPreguntas
    {
        List<int> lista;
        CPregunta[] list;
        Random rd = new Random();

        public LPreguntas()
        {
            lista = new List<int>();
            list = new CPregunta[] 
            {
                new CPregunta(0,"Pegunta0"),
                new CPregunta(1,"Pegunta1"),
                new CPregunta(2,"Pegunta2"),
                new CPregunta(3,"Pegunta3"),
                new CPregunta(4,"Pegunta4"),
                new CPregunta(5,"Pegunta5"),
                new CPregunta(6,"Pegunta6")
            };
        }

        public int obtener_clave()
        {
            //restriccion limite
            int cv = numero_random();
            //   string pregunta = "";
            int cve = 0;

            for (int i = 0; i < list.Length; i++)
            {
                cve = list[i].clave;
                //     pregunta = list[i].pregunta;

                if (cve == cv)
                {
                    break;
                }
            }
            return cve;
        }
        public string obtener_pregunta(int cv)
        {
            //restriccion limite
            //  int cv = numero_random();
            string pregunta = "";
            int cve;

            for (int i = 0; i < list.Length; i++)
            {
                cve = list[i].clave;
                pregunta = list[i].pregunta;

                if (cve == cv)
                {
                    break;
                }
            }
            return pregunta;
        }



        public string leer_lista()
        {
            string datos = "";
            for (int i = 0; i < lista.Count; i++)
            {
                datos += i + "   " + lista[i].ToString() + "\n";//ultima modificacion
            }
            return datos;
        }

        public int numero_random()//calcula el numero random
        {
            if (lista.Count == 0)//si tiene 0 elementos
            {
                int xx = rd.Next(0, list.Length - 1);
                lista.Add(xx);
                return xx;
            }
            else //si tiene elementos
            {
                int xx = rd.Next(0, list.Length - 1);
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[j] == xx)
                    {
                        xx = numero_random();
                        break;
                    }
                }
                lista.Add(xx);
                return xx;
            }
        }

    }
}
