using System.Security.Cryptography;
using System.Text;

namespace CAST_128
{
    public partial class Form1 : Form
    {
        byte[] key;
        byte[] block;
        byte[] encrypted;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            key = Encoding.UTF8.GetBytes("0123456789abcdef01234567");
            block = Encoding.UTF8.GetBytes("12345678");

            for (int i = 0; i < key.Length; i++)
            {
                txtKey.Text += key[i] + " ";
            }


        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            encrypted = TrippleDES.Encrypt(txtInput.Text, key, block);
            for (int i = 0; i < encrypted.Length; i++)
            {
                txtCipherTextBit.Text += encrypted[i] + " ";
            }
            txtCipherText.Text = Convert.ToBase64String(encrypted);
            txtInput.Text = "";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtInput.Text = TrippleDES.Decrypt(encrypted, key, block);
            txtCipherText.Text = "";
            txtCipherTextBit.Text = "";
        }
    }
}
