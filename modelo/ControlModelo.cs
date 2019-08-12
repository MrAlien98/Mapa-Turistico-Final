using System;
using System.Collections;
using System.Collections.Generic;

namespace modelo
{
    public class ControlModelo
    {
        private ArrayList puntos;

        public ControlModelo()
        {
            Puntos = new ArrayList();
        }

        public ArrayList Puntos { get => puntos; set => puntos = value; }

        public ArrayList getPuntos()
        {
            return puntos;
        }

        public ArrayList depts()
        {
            ArrayList dps = new ArrayList();
            ArrayList dpsF= new ArrayList();
            ArrayList dpsFF = new ArrayList();
            for (int i = 0; i < puntos.Count; i++)
            {
                PuntoTuristico a = (PuntoTuristico) puntos[i];
                dps.Add(a.Depto);
            }
            int c = 0;
            for (int i=0;i<dps.Count;i++)
            {
                PuntoTuristico a = (PuntoTuristico) puntos[i];
                for (int j=0;j<dps.Count;j++)
                {
                    if (a.Depto.Equals( (String) dps[j]) )
                    {
                        c++;
                    }
                }
                dpsF.Add(new KeyValuePair<String, int>(a.Depto, c));
                c = 0;              
            }
            dpsF.Sort();
            return dps;
        }
    }
}
