using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanulas_ellenorzo_kvíz
{
    class Kerdes
    {
        string tantargy;
        string temakor;
        string kerdes;
        string helyesValasz;
        string[] valaszok;

        public Kerdes(string sor)
        {
            var sorE = sor.Split(';');
            tantargy = sorE[0];
            temakor = sorE[1];
            kerdes = sorE[2];
            helyesValasz = sorE[3];
            valaszok = new string[4];
        }

        public string Tantargy { get => tantargy; set => tantargy = value; }

        public string Temakor { get => temakor; set => temakor = value; }

        public string TemaKerdes { get => kerdes; set => kerdes = value; }

        public string HelyesValasz { get => helyesValasz; set => helyesValasz = value; }

        public string[] MaradekValasz { get => valaszok; private set => valaszok = value; }
     
    }
}
