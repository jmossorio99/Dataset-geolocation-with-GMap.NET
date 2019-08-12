using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShareAVehicle
{

    class DataManager
    {

        private readonly String filePath = @".. \.. \dataset1000lines.csv";

        public DataManager() { }

        public List<Double> readFromFile() {

            List<Double> output = new List<Double>();
            List<String> list = File.ReadAllLines(filePath).ToList();
            foreach (var line in list)
            {
                String[] latAndLong = line.Split(',');
                output.Add(Convert.ToDouble(latAndLong[1]));
                output.Add(Convert.ToDouble(latAndLong[2]));
            }
            return output;

        }

        public void writeFile(string list) {

            File.AppendAllText(filePath,list);

        }

    }
}
