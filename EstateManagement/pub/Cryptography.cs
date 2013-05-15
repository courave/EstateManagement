using System;
using System.Security.Cryptography;

namespace EstateManagement.pub
{
    public static class Cryptography
    {
        public static string Encrypt(string msg)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            String retData = "";
            byte[] fromData = System.Text.Encoding.Unicode.GetBytes(msg);
            byte[] midData1 = md5.ComputeHash(fromData);
            foreach (byte b in midData1)
            {
                retData += b.ToString("x");
            }
            foreach (byte b in fromData)
            {
                retData += b.ToString("x");
            }

            byte[] midData2 = System.Text.Encoding.Unicode.GetBytes(retData);
            byte[] targetData = sha1.ComputeHash(midData2);
            retData = "";
            foreach (byte b in targetData)
            {
                retData += b.ToString("x");
            }
            return retData;
        }
    }
}
