using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Korkma, sönmez bu şafaklarda yüzen al sancak;";
            int karakterSayisi = metin.Length;
            Console.WriteLine("Metnin karakter sayısı:{0}", karakterSayisi);
            string kopyaMetin = string.Copy(metin);
            Console.WriteLine("Kopya metin:{0}", kopyaMetin);
            bool kelimeVarMi = metin.Contains("korkma");
            Console.WriteLine("Korkma kelimesi var mı?:{0}", kelimeVarMi);
            bool nvileBitrMi = metin.EndsWith(";");
            Console.WriteLine("; ile biter mi?:{0}", nvileBitrMi);
            bool esitMi = metin.Equals("İstiklal Marşı");
            Console.WriteLine("İstiklal marşına eşit mi?:{0}", esitMi);
            int sIndexi = metin.IndexOf("s");
            Console.WriteLine("S'nin indexi:{0}", sIndexi);
            string buyukHarfliMetin = metin.ToUpper();
            Console.WriteLine("BÜyük harfli metin:{0}", buyukHarfliMetin);
            string kucukHarfliMetin = metin.ToLower();
            Console.WriteLine("Küçük harfli metin:{0}", kucukHarfliMetin);
            metin = metin.Insert(metin.Length - 1, "Sönmeden yurdumun üstünde tüten en son ocak.");
            Console.WriteLine("Ekleme yapıldıktan sonra metin -1:{0}", metin);
            metin += "O benim milletimin yıldızıdır parlayacak;;;";
            Console.WriteLine("Ekleme yapıldıktan sonra metin -2:{0}", metin);
            metin = metin.Remove(metin.Length - 2);
            Console.WriteLine("Silme yapıldıktan sonra metin :{0}", metin);
            metin = metin.Replace(" ", "_");
            Console.WriteLine("Replace işleminden sonra metin :{0}", metin);
            string[] kelimeler = metin.Split('_');
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }

            char[] ilkKelimeninKarakterleri = kelimeler[0].ToCharArray();
            foreach (var item in ilkKelimeninKarakterleri)
            {
                Console.WriteLine(item);
            }
            metin.Trim();
            string parcalananMetin = metin.Substring(20, 10);
            Console.WriteLine("Metinden alınan parça:{0}", parcalananMetin);
            Console.ReadKey();
        }
    }
}
