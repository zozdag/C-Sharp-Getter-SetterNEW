using System;

namespace ConsoleApp1
{

    public class Ogrenci
    {
        private string Name { get; set; }
        private string SurName;
        private int Point;


        // sadece point class tanımladık (yeni c# getter setter yapısı)
        public int point
        {
            get
            {
                return Point;
            }
            set
            {
                Point = value;
            }
        }


        /* Eski Java Yapısında Getter Setter Kullanımı -Başlangıç Kısmı- */
        public Ogrenci(string Name,string SurName,int Point)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Point = Point;
        }

        public string GetterName()
        {
            return Name;
        }
        public string GetterSurName()
        {
            return SurName;
        }
        public int GetterPoint()
        {
            return Point;
        }

        public void SetPoint(int point)
        {
            this.Point = point;
        }
        /* Eski Java Yapısında Getter Setter Kullanımı -Bitiş Kısmı- */



    }

    class Program
    {
        static void Main(string[] args)
        {

            // Geleneksel olarak javadan gelen getter setter yapısı ile methodlar üzerinden get ettik..
            Ogrenci ogr = new Ogrenci("Cemal","Kaya",45);
            Console.WriteLine("Öğrenci Adı : " + ogr.GetterName() + "\n" +
                "Öğrenci Soyadı : " + ogr.GetterSurName() + "\n" + 
                "Öğrencinin Puanı : "+ ogr.GetterPoint().ToString());

            // java gibi method içerisinden class özelliğini set ettik
            ogr.SetPoint(35);

            // java yapısında get methodu ile ekrana yazdık
            Console.WriteLine("Öğrencinin Yeni Puanı : " +ogr.GetterPoint().ToString());

            // C# Yapısında ogr.point ' için içine direk değer atayabildik ve set etmiş olduk
            ogr.point = 5;
            // Eski yapıda ekrana yazdık
            Console.WriteLine(ogr.GetterPoint().ToString());

            // C# Yeni Yapıda ekrana yazdık..
            Console.WriteLine(ogr.point);

        }
    }
}
