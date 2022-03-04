using System.Text;
using System.Security.Cryptography;

namespace VpnReconnector
{
    internal class CryptData
    {
        public static string EncryptString(string input, string entropyStr)
        {
            byte[] entropy = Encoding.Unicode.GetBytes(entropyStr);
            byte[] encryptedData = ProtectedData.Protect(Encoding.Unicode.GetBytes(input), entropy, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        public static string DecryptString(string encryptedData, string entropyStr)
        {
            byte[] entropy = Encoding.Unicode.GetBytes(entropyStr);
            try
            {
                byte[] decryptedData = ProtectedData.Unprotect(Convert.FromBase64String(encryptedData), entropy, DataProtectionScope.CurrentUser);
                return Encoding.Unicode.GetString(decryptedData);
            }
            catch
            {
                return "";
            }
        }
    }
}
