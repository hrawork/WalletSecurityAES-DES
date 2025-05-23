using static WalletSecurityAES.KeyForm;
using System.Security.Cryptography;
using System.Text;
using System;

public static class AESHelper
{
    public static string Encrypt(string plainText)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(GlobalKey.AesKey);

        if (keyBytes.Length != 16)
            throw new ArgumentException("AES key must be exactly 16 characters (128 bits).");

        using (Aes aes = Aes.Create())
        {
            aes.Key = keyBytes;
            aes.Mode = CipherMode.ECB;          // Use ECB for textbook comparison (not recommended for production)
            aes.Padding = PaddingMode.PKCS7;    // Use PKCS7 for text input that is not always 16 bytes

            var encryptor = aes.CreateEncryptor();
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encrypted = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            return Convert.ToBase64String(encrypted);
        }
    }

    public static string Decrypt(string cipherText)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(GlobalKey.AesKey);

        if (keyBytes.Length != 16)
            throw new ArgumentException("AES key must be exactly 16 characters (128 bits).");

        using (Aes aes = Aes.Create())
        {
            aes.Key = keyBytes;
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;

            var decryptor = aes.CreateDecryptor();
            byte[] inputBytes = Convert.FromBase64String(cipherText);
            byte[] decrypted = decryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
