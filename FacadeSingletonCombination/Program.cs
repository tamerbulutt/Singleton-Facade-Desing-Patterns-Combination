using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSingletonCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade fcd = Facade.GetSingleton();
            string adim="Tamer";//its work
            fcd.KrediKullan(new Musteri { Ad = "Tamer", TcNo = "123455", MusteriNo = 123 }, 2500);
            
        }
    }
}
