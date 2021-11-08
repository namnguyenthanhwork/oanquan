using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /*
     * This class use to connect with file with specific file path, read and write datas from that file 
     */
    public class FileDAL
    {
        private string filePath; //file path want to interact

        public List<List<string>> datas { get; set; }//data list is read from or wrote to specific file path  

        private static char SEPERATOR = '.'; //seperator each field of each data line 

        //constructor
        public FileDAL(string filePath)
        {
            this.filePath = filePath;
            datas = new List<List<string>>();
        }
        /*
         * This method is used for checking the file path is correct or not
         */
        private bool isValidPath() => System.IO.File.Exists(filePath);

        /*
         * This method is used for reading all of datas from the specific file path.
         * After read each data line in file, it will be stored in a list with each field is a string object. 
         * When read all of datas from file, this method will return list of line data
         * if can't read file , return null value
         */
        public List<List<string>> readDataFromFile()
        {
            if (!isValidPath())
                return null;
            datas.Clear();
            System.IO.StreamReader streamReader = new System.IO.StreamReader(filePath, Encoding.UTF8);
            string line;
            while ((line = streamReader.ReadLine()) != null)
                datas.Add(line.Split(SEPERATOR).ToList());
            streamReader.Close();
            return datas;
        }

        /*
         * This method is used for writing all of datas to the specific file path.
         * each field of each line was seperate by the specific seperated charactor
         * if path of the file is not exits. return false
         */
        public bool writeDataToFile()
        {
            if (!isValidPath())
                return false;
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filePath, false, Encoding.UTF8);
            datas.ForEach(e =>
            {
                string line = String.Empty;
                e.ForEach(e1 => line += e1 + SEPERATOR);
                line = line.Substring(0, line.Length - 1);
                streamWriter.WriteLine(line);
            });
            streamWriter.Flush();
            streamWriter.Close();
            return true;
        }
        /*
         * This method is used to read specific line which contains input string in its field from file.
         * if found , return that line. 
         * otherwise return null value
         */
        public List<string> readLineData(string conditionString) =>
            readDataFromFile()?.Find(e => e.Contains(conditionString));


        /*
         * This method is used to append specific dat aline which each field of it was seperated by 
         * seperated character to file.
         * if append fail or input data line is empty, return false
         */
        public bool writeLineData(List<string> line)
        {
            if (line == null || line.Count == 0 || !isValidPath())
                return false;
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filePath, true, Encoding.UTF8);
            string reLine = String.Empty;
            line.ForEach(e => reLine += e + SEPERATOR);
            reLine = reLine.Substring(0, reLine.Length - 1);
            streamWriter.WriteLine(reLine);
            streamWriter.Flush();
            streamWriter.Close();
            return true;
        }

        public static string encodeString(string str) =>
            Convert.ToBase64String(Encoding.UTF8.GetBytes(str.Trim().ToString()));

        public static string decodeString(string str) =>
            Encoding.UTF8.GetString(Convert.FromBase64String(str));
    }

}
