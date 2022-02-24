using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{     //İnterface kuralları ıcerır ve kendine ımplemente eden classlar o kuralları kendıne gore doldurmak zorundadır 
      //Operasyonlar altarnetif sistemler ıcın bır sablon ve buna ek olarak refrans tutucu gorevı goruyor.
      //İnterfaceleri birbirinin altarnetifi olan ama kod içerikleri farklı olan durumlar ıcın kulanırız.
      //REFERANS TUTUCUDUR!!!!!!!!!!

    interface IKrediManager
    {
        void Hesapla();

        void BiseyYap();
    }
}
