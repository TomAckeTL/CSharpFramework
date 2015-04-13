using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;

namespace WebdriverSeleniumProject.HelperClasses
{
    class Data
    {

        private List<String> UserNames = new List<String>();
        private  List<String> UserPasswords = new List<String>();
        private  List<String> Elements = new List<String>();
        private  List<String> ElementValues = new List<String>();
        private int j = 0;


        public Data()
        {
            ReadCredentials(@"DataFiles\LoginData.txt");  //Laad de credentials in in 2 Lists(UserNames, UserPasswords)
            ReadElements(@"DataFiles\ElementData.txt"); //Laad Elementen en hun ID in in 2 Lists(Elements, ElementValues)
        }

        public string gen(string element)
        {
            string output = ElementValues[Elements.IndexOf(element)];
            return output;
        }

        public void ReadCredentials(string dir)
        {
            StreamReader reader = new StreamReader(dir);
            string line = reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                UserNames.Add(parts[0]);
                UserPasswords.Add(parts[1].Trim(' '));
                j++;

            }
            reader.Close();
        }

        public void ReadElements(string dir)
        {
            StreamReader reader = new StreamReader(dir);
            string line = reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                Elements.Add(parts[0].Trim(' '));
                ElementValues.Add(parts[1].Trim(' '));

            }
            reader.Close();
        }

        public List<String> Users
        {
            get { return UserNames; }
            
        }

        public List<String> Passwords
        {
            get { return UserPasswords; }

        }

        public int counter
        {

            get { return j; }
            set { j = value; }
        }

    }
}
