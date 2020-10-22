using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace KPIYAP_LABA_7
{
    static class StringFunc
    {
        private static string text = "У лукоморья дуб зелёный;\n" +
 "Златая цепь на дубе том:\n" +
 "И днём и ночью кот учёный\n" +
 "Всё ходит по цепи кругом;\n" +
 "Идёт направо — песнь заводит,\n" +
 "Налево — сказку говорит.\n" +
 "Там чудеса: там леший бродит,\n" +
 "Русалка на ветвях сидит;\n" +
 "Там на неведомых дорожках\n" +
 "Следы невиданных зверей;\n" +
 "Избушка там на курьих ножках\n" +
 "Стоит без окон, без дверей;\n" +
 "Там лес и дол видений полны;\n" +
 "Там о заре прихлынут волны\n" +
 "На брег песчаный и пустой,\n" +
 "И тридцать витязей прекрасных\n" +
 "Чредой из вод выходят ясных,\n" +
 "И с ними дядька их морской;\n" +
 "Там королевич мимоходом\n" +
 "Пленяет грозного царя;\n" +
 "Там в облаках перед народом\n" +
 "Через леса, через моря\n" +
 "Колдун несёт богатыря;\n" +
 "В темнице там царевна тужит,\n" +
 "А бурый волк ей верно служит;\n" +
 "Там ступа с Бабою Ягой\n" +
 "Идёт, бредёт сама собой,\n" +
 "Там царь Кащей над златом чахнет;\n" +
 "Там русский дух… там Русью пахнет!\n" +
 "И там я был, и мёд я пил;\n" +
 "У моря видел дуб зелёный;\n" +
 "Под ним сидел, и кот учёный\n" +
 "Свои мне сказки говорил.";

        private static char[] vowelsLetters = { 'а', 'я', 'о', 'е', 'у', 'ю', 'ы', 'и', 'э', 'ё' };
        private static char[] chars = { ',', ' ', '.', ';', ':', '!', '?', '—', '\n' };
        private static string[] words = text.Split(chars).Where(word => word != "").ToArray();
        private delegate string Timer();
        private static Random rand = new Random();
        private static int maxLength = 1000000;


        private static bool startWithСonsonant(string s) { return !vowelsLetters.Contains(s[0]); }
        private static bool endWithVowel(string s) { return vowelsLetters.Contains(s[s.Length - 1]); }
        public static void thirdTask()
        {
            Console.WriteLine("Слова котрые начинаются с согласной и заканчиваются гласной");
            foreach (var word in words)
            {
                if (startWithСonsonant(word) && endWithVowel(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
        private static void timer(Timer t)
        {
            Stopwatch Watch = new Stopwatch();
            " ".Replace()
            Watch.Start();
            string s = t();
            Watch.Stop();
            Console.WriteLine(s);
            Console.WriteLine($"Секунд затраченно: {Watch.Elapsed.TotalSeconds}");
        }
        private static string randElem(string[] words)
        {
            return words[rand.Next(words.Length)];
        }
        private static string SlowTimer()
        {
            string s = "";
            while (s.Length < maxLength)
            {
                s += randElem(words) + " ";
            }
            return s;
        }
        public static void Slow()
        {
            timer(new Timer(SlowTimer));
        }
        private static string FastTimer()
        {
            StringBuilder s = new StringBuilder(maxLength + 100);
            while (s.Length < maxLength)
            {
                s.Append(randElem(words) + " "); 
            }
            return s.ToString();
        }
        public static void Fast()
        {
            timer(new Timer(FastTimer));
        }

    }
}
