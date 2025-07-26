using System.Security.Cryptography;
using System.Text;

namespace VitalTrackAI.Api.Helpers;

public class CryptoHelper
{
    public static string Encrypt(string text, string key)
    {
        if (text == null) return null;

        using var aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.GenerateIV();
        
        var encryptor = aes.CreateEncryptor();
        var plainBytes = Encoding.UTF8.GetBytes(text);
        var cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        
        var result = new byte[aes.IV.Length + cipherBytes.Length];
        Buffer.BlockCopy(aes.IV, 0, result, 0, aes.IV.Length);
        Buffer.BlockCopy(cipherBytes, 0, result, aes.IV.Length, cipherBytes.Length);
        
        return Convert.ToBase64String(result);
    }

    public static string Decrypt(string text, string key)
    {
        if(string.IsNullOrEmpty(text)) return null;
        
        var fullCipher = Convert.FromBase64String(text);
        
        using var aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);

        var iv = new byte[16];
        var cipher = new byte[fullCipher.Length - 16];
        
        Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
        Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, cipher.Length);
        
        aes.IV = iv;
        
        var decryptor = aes.CreateDecryptor();
        var decryptedBytes = decryptor.TransformFinalBlock(cipher, 0, cipher.Length);
        
        return Encoding.UTF8.GetString(decryptedBytes);
    }
}