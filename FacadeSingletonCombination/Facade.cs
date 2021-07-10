using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSingletonCombination
{
    class Facade
    {
        private Banka _banka;
        private MerkezBankasi _merkezBankasi;
        private Kredi _kredi;

        private static Facade _instance; //Facade'ı singleton olarak kullanacağız.

        private Facade()
        {
            _banka = new Banka();
            _merkezBankasi = new MerkezBankasi();
            _kredi = new Kredi();
        }

        public static Facade GetSingleton()//Singleton kısmı
        {
            if (_instance == null)
                _instance = new Facade();

            return _instance;
        }

        public void KrediKullan(Musteri m, decimal talep)
        {///BAGIS UYGUNLUK
            if (! _merkezBankasi.KaraListeKontrol(m.TcNo)
                &&_kredi.KrediyiKullanmaDurumu(m))
            {
                _banka.KrediyiKullan(m, talep);
                Console.WriteLine("Kredi Kullanıldı");
            }
        }
    }
}
