using Cruxlab_lib.Model;

namespace Cruxlab_lib.Validator
{
    public class PasswordValidator
    {
        public bool IsValidPassword(PasswordRequirementsModel password)
        {
            var charCount = _countByString(password.Password, password.RequiredString);

            if(charCount >= password.MinCountOfRequiredString && charCount <= password.MaxCountOfRequiredString)
                return true;
            return false;
        }

       private int _countByString(string word, string str)
       {
            var count = 0;  

            for (int i = 0; i < word.Length; i++)
            {
                if(i + str.Length <= word.Length)
                {
                    var wordToEqual = word[i..(i + str.Length)];
                    if (wordToEqual.Equals(str))
                    {
                        count++;
                        i += str.Length - 1; // for not to count words that has been counted earlier
                    }
                        
                }
            }

            return count;
       }  
    }
}
