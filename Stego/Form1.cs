using System.Security.Cryptography;
using System.Text;

namespace Stego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string hash { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";

        void SetEnabled()
        {
            GizleBTN.Enabled = true;
            CozBTN.Enabled = true;
            SifreCBOX.Enabled = true;
            MetinSecBTN.Enabled = true;
        }

        void SetDisabled()
        {
            ResimKaydetBTN.Enabled = false;
            GizleBTN.Enabled = false;
            CozBTN.Enabled = false;
            SifreleBTN.Enabled = false;
            SifreCBOX.Enabled = false;
            MetinKaydetBTN.Enabled = false;
            MetinSecBTN.Enabled = false;
        }

        void Clear()
        {
            MetinTBOX.Text = string.Empty;
            ResimPBOX.Image = null;
            SifreCBOX.SelectedIndex = 0;
        }

        void TextSize()
        {
            if (ResimPBOX.Image != null)
            {
                Bitmap bmp = new Bitmap(ResimPBOX.Image);
                int height = bmp.Height;
                int width = bmp.Width;
                if (SifreCBOX.SelectedIndex == 0)
                {
                    MetinTBOX.MaxLength = (height * width / 3) - 36;
                    int yazilabilir = MetinTBOX.MaxLength - MetinTBOX.Text.Length;
                    TextSizeLBL.Text = "Yazýlabilir Karakter: " + yazilabilir;
                }
                else
                {
                    MetinTBOX.MaxLength = (height * width / 3) / 2;
                    int yazilabilir = MetinTBOX.MaxLength - MetinTBOX.Text.Length;
                    TextSizeLBL.Text = "Yazýlabilir Karakter: " + yazilabilir;
                }
            }
        }

        public static string StringToBinary(string metin)
        {
            string metinBinary = string.Empty;
            foreach (char ch in metin)
            {
                string temp = Convert.ToString(ch, 2);
                for (int i = 0; i < 9 - temp.Length; i++)
                {
                    metinBinary += '0';
                }
                metinBinary += temp;
            }
            return metinBinary;
        }

        public static string BinaryToString(string metin)
        {
            return Convert.ToChar(Convert.ToInt32(metin, 2)).ToString();
        }

        public static string MD5Decrypt(string text)
        {
            byte[] data = Convert.FromBase64String(text); 
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    text = UTF8Encoding.UTF8.GetString(results);
                }
            }
            return text;
        }

        public static string MD5Encrypt(string text)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return text;
        }

        public string Sifrele(string text)
        {
            if (SifreCBOX.SelectedIndex == 1)
            {
                text = MD5Encrypt(text);
                text += "|";
            }
            else text += "_";
            return text;
        }
        public string Coz(string text, string key)
        {
            if (key == "001111100")
            {
                text = text.Remove(text.Length - 1, 1);
                text = MD5Decrypt(text);
            }
            return text;
        }

        private void GizleBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MetinTBOX.Text) == false)
            {
                string metin = MetinTBOX.Text;
                metin = StringToBinary(metin);
                metin = "000000000" + metin + "000000000";

                Bitmap bmp = new Bitmap(ResimPBOX.Image);
                int height = bmp.Height;
                int width = bmp.Width;
                int count = 0;
                bool kosul = true;

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Color c = bmp.GetPixel(i, j);
                        int r = c.R;
                        int g = c.G;
                        int b = c.B;
                        r = (r >> 1 << 1) + metin[count] - '0';
                        count += 1;
                        g = (g >> 1 << 1) + metin[count] - '0';
                        count += 1;
                        b = (b >> 1 << 1) + metin[count] - '0';
                        count += 1;
                        bmp.SetPixel(i, j, Color.FromArgb(r, g, b));

                        if (count == metin.Length) { kosul = false; break; }
                    }
                    if (kosul == false) break;
                }
                MessageBox.Show("Gizleme Baþarýlý.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResimPBOX.Image = bmp;
                ResimKaydetBTN.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Bir Metin Giriniz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CozBTN_Click(object sender, EventArgs e)
        {
            string metin = string.Empty;
            string temp = string.Empty;
            string key = string.Empty;

            bool kontrol = true;
            bool kosul = true;

            Bitmap bmp = new Bitmap(ResimPBOX.Image);
            int height = bmp.Height;
            int width = bmp.Width;
           
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color c = bmp.GetPixel(i, j);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    temp = temp + (r & 1).ToString() + (g & 1).ToString() + (b & 1).ToString();
                    if (temp.Length == 9)
                    {
                        if (temp == "000000000" && kontrol == false) 
                        {
                            kosul = false; 
                            break; 
                        }
                        else if (temp != "000000000" && kontrol == true)
                        {
                            kosul = false;
                            break;
                        }
                        else 
                        {
                            key = temp; 
                            kontrol = false;
                            metin += BinaryToString(temp);
                            temp = string.Empty; 
                        }
                    }
                }
                if (kosul == false) break;
            }
            try
            {
                metin = Coz(metin.Remove(0, 1), key);
                MessageBox.Show("Çözme Baþarýlý.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MetinTBOX.Text = metin;
                MetinKaydetBTN.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Gizli Metin Bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void SifreCBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SifreCBOX.SelectedIndex != 0)
            {
                SifreleBTN.Enabled = true;
                GizleBTN.Enabled = false;
            }
            else
            {
                SifreleBTN.Enabled = false;
            }
            TextSize();
        }

        private void SifreleBTN_Click(object sender, EventArgs e)
        {
            string metin = MetinTBOX.Text;
            metin = Sifrele(metin);
            MetinTBOX.Text = metin;
            GizleBTN.Enabled = true;
            MessageBox.Show("Þifreleme Baþarýlý.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResimSecBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Resim Seç";
            ofd.ShowDialog();
            string FilePath = ofd.FileName;
            ResimPBOX.ImageLocation = FilePath;
            SetEnabled();
        }

        private void ResimKaydetBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png;";
            sfd.Title = "Resim Kaydet";
            sfd.FileName = "Gizli_" + SifreCBOX.SelectedItem;
            DialogResult sonuc = sfd.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ResimPBOX.Image.Save(sfd.FileName);
                SetDisabled();
                Clear();
                MessageBox.Show("Resim Kaydetme Baþarýlý.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MetinSecBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Metin Dosyalarý|*.txt";
            ofd.Title = "Metin Seç";
            DialogResult sonuc = ofd.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                string FilePath = ofd.FileName;
                MetinTBOX.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                SetEnabled();
            }
        }

        private void MetinKaydetBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Metin Dosyalarý|*.txt";
            sfd.Title = "Metin Kaydet";
            sfd.FileName = "Gizli";
            DialogResult sonuc = sfd.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.OpenFile());
                sw.Write(MetinTBOX.Text);
                sw.Dispose();
                sw.Close();
                SetDisabled();
                Clear();
                MessageBox.Show("Metin Kaydetme Baþarýlý.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SifreCBOX.SelectedIndex = 0;
        }

        private void MetinTBOX_TextChanged(object sender, EventArgs e)
        {
            TextSize();
        }
    }
}