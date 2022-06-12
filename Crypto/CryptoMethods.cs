using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    public class CryptoMethods
    {
        const String AlphabetRus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        const String AlphabetEng = "abcdefghijklmnopqrstuvwxyz";

        public String CaesarCipher(String sourceStr, int key, String lang, bool deciphering = false)
        {
            if (deciphering) key = -key;
            String fullAlphabet = "";
            if (lang == "eng")
                fullAlphabet = AlphabetEng;
            if (lang == "rus")
                fullAlphabet = AlphabetRus;

            int lettersCount = fullAlphabet.Length;
            String result = "";

            // Caesor algorithm
            for (int i = 0; i < sourceStr.Length; i++)
            {
                char sym = sourceStr[i];
                bool isUpperCase = Char.IsUpper(sym);
                int index = (isUpperCase ? fullAlphabet.IndexOf(Char.ToLower(sym)) : fullAlphabet.IndexOf(sym));

                // if symbol is not letter
                if (index < 0)
                {
                    result += sym.ToString();
                }
                else
                {
                    int newIndex = (lettersCount + index + key) % lettersCount; // index of ciphered sym
                    // check in what case letter(upper/lower)
                    result += (isUpperCase? Char.ToUpper(fullAlphabet[newIndex]) : fullAlphabet[newIndex]); 
                }
            }
            return result;

        }

        public String VigenereCipher(String sourceStr, String key, String lang, bool deciphering = false)
        {
            String fullAlphabet = "";
            if (lang == "eng")
                fullAlphabet = AlphabetEng;
            if (lang == "rus")
                fullAlphabet = AlphabetRus;

            sourceStr = new String(sourceStr.Where(Char.IsLetter).ToArray());

            int lettersCount = fullAlphabet.Length;
            String result = "";

            String fullKey = key;
            while (fullKey.Length < sourceStr.Length)
            {
                fullKey += fullKey;
            }
            fullKey = fullKey.Substring(0, sourceStr.Length);
            for (int i = 0; i < sourceStr.Length; i++)
            {
                bool isUpperCase = Char.IsUpper(sourceStr[i]);
                // column index in Vigenere square
                int firstIndex = fullAlphabet.IndexOf((isUpperCase ? Char.ToLower(sourceStr[i]) : sourceStr[i]));
                // row index in Vigenere square
                int secondIndex = fullAlphabet.IndexOf(isUpperCase ? Char.ToLower(fullKey[i]) : fullKey[i]);  
                
 

                // if symbol with index 'i' is not a letter
                if (firstIndex < 0)
                {
                    result += sourceStr[i];
                }
                else
                {
                    // siphering a letter
                    char cipheredSym = 
                        fullAlphabet[(fullAlphabet.Length + firstIndex + ((deciphering ? -1 : 1) * secondIndex)) % fullAlphabet.Length];
                    result += (isUpperCase ? Char.ToUpper(cipheredSym) : cipheredSym);  // check if letter in upper case
                        
                }
            }
            return result;
        }
    }
}
