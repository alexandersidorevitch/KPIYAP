using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace Laba_8_Rpiyzp
{
    class Program
    {
        public static void GreateHtmlDoc(string TextInBody)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html >");
            sb.Append("<head >");
            string meta = @"<meta charset=""UTF-8"">";
            sb.Append(meta);
            sb.Append("<title >");
            sb.Append("</title >");
            sb.Append("</head >");
            sb.Append("<body >");
            sb.Append(TextInBody);
            sb.Append("</body >");
            sb.Append("</html >");
            using (StreamWriter sw = new StreamWriter("MyHtml.html"))
            {
                sw.Write(sb.ToString());
                sw.Close();
                Console.WriteLine("Файл создан успешно!");
                System.Diagnostics.Process.Start("MyHtml.html");
            }
        }
        public static void first_task()
        {
            StreamReader reader = new StreamReader("first_task.txt");
            Regex regex = new Regex(@"(\w+)\s\w\.\w\.\s-\s\$(\d+)");
            foreach (Match item in regex.Matches(reader.ReadToEnd()))
            {
                if (double.Parse(item.Groups[2].Value) > 9000.0)
                {
                    Console.WriteLine($"Человек с фамилией {item.Groups[1].Value} получает {item.Groups[2].Value}");
                }
            }
        }
        public static void second_task()
        {
            StreamReader reader = new StreamReader("second_task.txt");
            Dictionary<string, string> Fonts = new Dictionary<string, string>();
            Fonts.Add("A", "Arial");
            Fonts.Add("T", "Times New Roman");
            Fonts.Add("C", "Calibri");
            Fonts.Add("M", "Mistral");

            Regex first_reg = new Regex($@"Ff([{String.Join("", Fonts.Keys)}])(.+)");
            Regex second_reg = new Regex(@"su(.+)");

            StringBuilder result = new StringBuilder();
            foreach (string line in reader.ReadToEnd().Split('\n'))
            {
                if (first_reg.IsMatch(line))
                {
                    result.Append( $"<font face= {Fonts[first_reg.Match(line).Groups[1].Value]}> {first_reg.Match(line).Groups[2].Value} </font>");
                }
                else if (second_reg.IsMatch(line))
                {
                    result.Append($"<sub>{second_reg.Match(line).Groups[1].Value} </sub>");
                }
            }
            GreateHtmlDoc(result.ToString());
        }
        static void Main(string[] args)
        {
            second_task();
        }
    }
}
