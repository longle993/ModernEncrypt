using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CAST_128
{
    internal class TrippleDES
    {
        public static byte[] Encrypt(string plainText, byte[] key, byte[] iv)
        {
            using (TripleDESCryptoServiceProvider algorithm = new TripleDESCryptoServiceProvider())
            {
                algorithm.Mode = CipherMode.CBC;
                algorithm.Padding = PaddingMode.PKCS7;

                // Chuyển đổi key và IV thành 64-bit (8 bytes)
                byte[] adjustedKey = new byte[24];
                byte[] adjustedIV = new byte[8];
                Array.Copy(key, 0, adjustedKey, 0, Math.Min(key.Length, 24));
                Array.Copy(iv, 0, adjustedIV, 0, Math.Min(iv.Length, 8));

                algorithm.Key = adjustedKey;
                algorithm.IV = adjustedIV;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, algorithm.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] plaintextBytes = Encoding.UTF8.GetBytes(plainText);
                        cs.Write(plaintextBytes, 0, plaintextBytes.Length);
                        cs.FlushFinalBlock();
                    }
                    return ms.ToArray();
                }
            }
        }

        // Giải mã dữ liệu
        public static string Decrypt(byte[] cipherText, byte[] key, byte[] iv)
        {
            using (TripleDESCryptoServiceProvider algorithm = new TripleDESCryptoServiceProvider())
            {
                algorithm.Mode = CipherMode.CBC;
                algorithm.Padding = PaddingMode.PKCS7;

                // Chuyển đổi key và IV thành 64-bit (8 bytes)
                byte[] adjustedKey = new byte[24];
                byte[] adjustedIV = new byte[8];
                Array.Copy(key, 0, adjustedKey, 0, Math.Min(key.Length, 24));
                Array.Copy(iv, 0, adjustedIV, 0, Math.Min(iv.Length, 8));

                algorithm.Key = adjustedKey;
                algorithm.IV = adjustedIV;

                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, algorithm.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
