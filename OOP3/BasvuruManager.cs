using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuran Bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            loggerService.Log();
        } 

        //birden fazla kredinin hesabını yapmak için list kullanıyoruz türüde IKrediManager olsun diyoruz
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }


    }
}
