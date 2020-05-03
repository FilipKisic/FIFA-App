using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class FormSetup
    {
        private const string DIR = @"D:\ALGEBRA\4.semestar - Objektno orijentirano programiranje u .NET okolini\FIFA App\MainForm\config";
        private const string FILE = @"\config.txt";
        private const string CONFIG_PATH = DIR + FILE;
        private const char DELIMITER = '|';

        public static void Setup()
        {
            if (!File.Exists(CONFIG_PATH))
            {
                Debug.WriteLine(CONFIG_PATH);
                Directory.CreateDirectory(DIR);
                File.Create(CONFIG_PATH).Close();
                Debug.WriteLine("File created!");
            }
            Debug.WriteLine("File exists...");
        }

        public static void Save(string localization, string championship)
        {
            string config = $"{localization}{DELIMITER}{championship}";
            File.WriteAllText(CONFIG_PATH, config);
        }

        public static void Save(string localization, string championship, string representation)
        {
            string config = $"{localization}{DELIMITER}{championship}{DELIMITER}{representation}";
            File.WriteAllText(CONFIG_PATH, config);
        }

        public static string[] Load()
        {
            string details = File.ReadAllText(CONFIG_PATH);
            return details.Split(DELIMITER);
        }
    }
}
