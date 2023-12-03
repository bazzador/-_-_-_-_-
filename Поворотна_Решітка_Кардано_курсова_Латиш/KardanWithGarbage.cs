using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Поворотна_Решітка_Кардано_курсова_Латиш
{
    public partial class Form1
    {

        private void FillMatrixByRandomLetters()
        {
            List<char> randomLetters = new List<char>();
            if (Regex.IsMatch(text, pattern1))
            {
                randomLetters = new List<char>
                {
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
                };
                
            }
            else 
            {
                randomLetters = new List<char>
                {
                    'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                    'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ',
                    'ь', 'ю', 'я'
                };
            }
            FillMatrix(randomLetters);
        }
    }
}
