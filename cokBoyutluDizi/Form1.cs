namespace cokBoyutluDizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Çok Boyutlu Dizi Tanýmý ve Kullanýmý: C# dilinde çok boyutlu diziler [,] ile tanýmlanýr.
        //Bu diziler, iç içe diziler olarak düþünülebilir.
        //Örneðin, bir 2D dizi satýr ve sütunlardan oluþur.


        // 2 boyutlu dizi tanýmlanýyor: 3 satýr, 4 sütun.
        int[,] ogrenciNotlari = new int[3, 4];

        private void button1_Click(object sender, EventArgs e)
        {
            // Diziye deðer atama iþlemi:
            ogrenciNotlari[0, 0] = 85;  // 1. öðrencinin 1. sýnav notu
            ogrenciNotlari[0, 1] = 90;  // 1. öðrencinin 2. sýnav notu
            ogrenciNotlari[0, 2] = 88;  // 1. öðrencinin 3. sýnav notu
            ogrenciNotlari[0, 3] = 92;  // 1. öðrencinin 4. sýnav notu

            ogrenciNotlari[1, 0] = 78;  // 2. öðrencinin 1. sýnav notu
            ogrenciNotlari[1, 1] = 82;  // 2. öðrencinin 2. sýnav notu
            ogrenciNotlari[1, 2] = 80;  // 2. öðrencinin 3. sýnav notu
            ogrenciNotlari[1, 3] = 85;  // 2. öðrencinin 4. sýnav notu

            ogrenciNotlari[2, 0] = 90;  // 3. öðrencinin 1. sýnav notu
            ogrenciNotlari[2, 1] = 95;  // 3. öðrencinin 2. sýnav notu
            ogrenciNotlari[2, 2] = 92;  // 3. öðrencinin 3. sýnav notu
            ogrenciNotlari[2, 3] = 89;  // 3. öðrencinin 4. sýnav notu

            // Dizinin içeriðini bir metin olarak hazýrlayýp Label'a yazdýrýyoruz.
            string output = "";

            // Dizinin tüm elemanlarýný gezip ekrana yazdýrýyoruz
            for (int i = 0; i < ogrenciNotlari.GetLength(0); i++)  // Satýr sayýsý (öðrenciler)
            {
                for (int j = 0; j < ogrenciNotlari.GetLength(1); j++)  // Sütun sayýsý (sýnavlar)
                {
                    output += "Öðrenci " + (i + 1) + " - Sýnav " + (j + 1) + ": " + ogrenciNotlari[i, j] + "\n";
                }
                output += "\n"; // Her öðrencinin notlarý arasýna boþluk koyuyoruz
            }

            // Sonuçlarý Label'da gösteriyoruz
            label1.Text = output;
        }
    }
}
