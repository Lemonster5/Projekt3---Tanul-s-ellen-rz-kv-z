using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanulas_ellenorzo_kvíz
{
    class Kerdes
    {
        string tantargy { get; set; }
        string temakor { get; set; }
        string kerdes { get; set; }
        string helyesValasz { get; set; }
        string elsoRosszValasz { get; set; }
        string masodikRosszValasz { get; set; }
        string harmadikRosszValasz { get; set; }
        public Kerdes( string sor)
        {
            string[] sorElemei = sor.Split(';');
            tantargy = sorElemei[0];
            temakor = sorElemei[1];
            kerdes = sorElemei[2];
            helyesValasz = sorElemei[3];
            elsoRosszValasz = sorElemei[4];
            masodikRosszValasz = sorElemei[5];
            harmadikRosszValasz = sorElemei[6];
        }
    }
    
}

