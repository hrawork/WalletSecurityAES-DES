using System.Security.Cryptography;
using System.Text;
using System;

namespace WalletSecurityAES
{
    public static class DESHelper
    {
        public static string Encrypt(string plainText)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(DESKeyForm.GlobalDESKey.DesKey);

            using (DES des = DES.Create())
            {
                des.Key = keyBytes;
                des.Mode = CipherMode.ECB;
                des.Padding = PaddingMode.PKCS7;

                var encryptor = des.CreateEncryptor();
                byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] encrypted = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

                return Convert.ToBase64String(encrypted);
            }
        }

        public static string Decrypt(string cipherText)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(DESKeyForm.GlobalDESKey.DesKey);

            using (DES des = DES.Create())
            {
                des.Key = keyBytes;
                des.Mode = CipherMode.ECB;
                des.Padding = PaddingMode.PKCS7;

                var decryptor = des.CreateDecryptor();
                byte[] inputBytes = Convert.FromBase64String(cipherText);
                byte[] decrypted = decryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

                return Encoding.UTF8.GetString(decrypted);
            }
        }
    }
}