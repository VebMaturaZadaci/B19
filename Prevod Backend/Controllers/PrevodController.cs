using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Prevod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrevodController : ControllerBase
    {
        private static readonly Dictionary<char, string> LatUCir = new Dictionary<char, string>
        {
            {'a', "а" },{'b', "б" },{'v', "в" },{'g', "г" },{'d', "д" },{'đ', "ђ" },
            {'e', "е" },{'ž', "ж" },{'z', "з" },{'i', "и" },{'j', "ј" },{'k', "к" },
            {'l', "л" },{'m', "м" },{'n', "н" },{'w', "њ" },{'o', "о" },{'p', "п" },
            {'r', "р" },{'s', "с" },{'t', "т" },{'ć', "ћ" },{'u', "у" },{'f', "ф" },
            {'h', "х" },{'c', "ц" },{'č', "ч" },{'x', "џ" },{'š', "ш" },{' ', " " },
            {'A', "А" },{'B', "Б" },{'V', "В" },{'G', "Г" },{'D', "Д" },{'Đ', "Ђ" },
            {'E', "Е" },{'Ž', "Ж" },{'Z', "З" },{'I', "И" },{'J', "Ј" },{'K', "К" },
            {'L', "Л" },{'M', "М" },{'N', "Н" },{'W', "Њ" },{'O', "О" },{'P', "П" },
            {'R', "Р" },{'S', "С" },{'T', "Т" },{'Ć', "Ћ" },{'U', "У" },{'F', "Ф" },
            {'H', "Х" },{'C', "Ц" },{'Č', "Ч" },{'X', "Џ" },{'Š', "Ш" }
        };
        private static readonly Dictionary<char, string> CirULat = new Dictionary<char, string>
        {
            {'а', "a" },{'б', "b" },{'в', "v" },{'г', "g" },{'д', "d" },{'ђ', "đ" },
            {'е', "e" },{'ж', "ž" },{'з', "z" },{'и', "i" },{'ј', "j" },{'к', "k" },
            {'л', "l" },{'м', "m" },{'н', "n" },{'њ', "w" },{'о', "o" },{'п', "p" },
            {'р', "r" },{'с', "s" },{'т', "t" },{'ћ', "ć" },{'у', "u" },{'ф', "f" },
            {'х', "h" },{'ц', "c" },{'ч', "č" },{'џ', "x" },{'ш', "š" },{' ', " " },
            {'А', "A" },{'Б', "B" },{'В', "V" },{'Г', "G" },{'Д', "D" },{'Ђ', "Đ" },
            {'Е', "E" },{'Ж', "Ž" },{'З', "Z" },{'И', "I" },{'Ј', "J" },{'К', "K" },
            {'Л', "L" },{'М', "M" },{'Н', "N" },{'Њ', "W" },{'О', "O" },{'П', "P" },
            {'Р', "R" },{'С', "S" },{'Т', "T" },{'Ћ', "Ć" },{'У', "U" },{'Ф', "F" },
            {'Х', "H" },{'Ц', "C" },{'Ч', "Č" },{'Џ', "X" },{'Ш', "Š" }
        };

        [HttpGet("CirilicaULatinicu/{text}")]
        public string CirilicaULatinicu(string text)
        {
            var prevod = new StringBuilder();
            foreach (var letter in text)
            {
                prevod.Append(CirULat[letter]);
            }
            return prevod.ToString();
        }
        [HttpGet("LatinicaUCirilicu/{text}")]
        public string LatinicaUCirilicu(string text)
        {
            var prevod = new StringBuilder();
            foreach (var letter in text)
            {
                prevod.Append(LatUCir[letter]);
            }
            return prevod.ToString();
        }
    }
}
