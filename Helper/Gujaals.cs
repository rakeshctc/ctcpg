using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CTC_Latest_4._0.Helper
{
    public class Gujaals
    {
        public string BatMan(string input)
        {
            string str = Encryptdata(input);
            return str;
        }

        public string Hitman(string Output)
        {
            string str = Decryptdata(Output);
            return str;
        }

        private string Encryptdata(string input)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[input.Length];
            encode = Encoding.UTF8.GetBytes(input);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }

        private string Decryptdata(string output)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(output);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;
        }
    }
}