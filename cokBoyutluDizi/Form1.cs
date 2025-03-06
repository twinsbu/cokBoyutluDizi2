namespace cokBoyutluDizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //�ok Boyutlu Dizi Tan�m� ve Kullan�m�: C# dilinde �ok boyutlu diziler [,] ile tan�mlan�r.
        //Bu diziler, i� i�e diziler olarak d���n�lebilir.
        //�rne�in, bir 2D dizi sat�r ve s�tunlardan olu�ur.


        // 2 boyutlu dizi tan�mlan�yor: 3 sat�r, 4 s�tun.
        int[,] ogrenciNotlari = new int[3, 4];

        private void button1_Click(object sender, EventArgs e)
        {
            // Diziye de�er atama i�lemi:
            ogrenciNotlari[0, 0] = 85;  // 1. ��rencinin 1. s�nav notu
            ogrenciNotlari[0, 1] = 90;  // 1. ��rencinin 2. s�nav notu
            ogrenciNotlari[0, 2] = 88;  // 1. ��rencinin 3. s�nav notu
            ogrenciNotlari[0, 3] = 92;  // 1. ��rencinin 4. s�nav notu

            ogrenciNotlari[1, 0] = 78;  // 2. ��rencinin 1. s�nav notu
            ogrenciNotlari[1, 1] = 82;  // 2. ��rencinin 2. s�nav notu
            ogrenciNotlari[1, 2] = 80;  // 2. ��rencinin 3. s�nav notu
            ogrenciNotlari[1, 3] = 85;  // 2. ��rencinin 4. s�nav notu

            ogrenciNotlari[2, 0] = 90;  // 3. ��rencinin 1. s�nav notu
            ogrenciNotlari[2, 1] = 95;  // 3. ��rencinin 2. s�nav notu
            ogrenciNotlari[2, 2] = 92;  // 3. ��rencinin 3. s�nav notu
            ogrenciNotlari[2, 3] = 89;  // 3. ��rencinin 4. s�nav notu

            // Dizinin i�eri�ini bir metin olarak haz�rlay�p Label'a yazd�r�yoruz.
            string output = "";

            // Dizinin t�m elemanlar�n� gezip ekrana yazd�r�yoruz
            for (int i = 0; i < ogrenciNotlari.GetLength(0); i++)  // Sat�r say�s� (��renciler)
            {
                for (int j = 0; j < ogrenciNotlari.GetLength(1); j++)  // S�tun say�s� (s�navlar)
                {
                    output += "��renci " + (i + 1) + " - S�nav " + (j + 1) + ": " + ogrenciNotlari[i, j] + "\n";
                }
                output += "\n"; // Her ��rencinin notlar� aras�na bo�luk koyuyoruz
            }

            // Sonu�lar� Label'da g�steriyoruz
            label1.Text = output;
        }
    }
}
