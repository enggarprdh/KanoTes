using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using DataAccess.Model;
using DataAccess.Model.Map;

namespace DataAccess
{
    public class ReadCSVPerRow
    {
        protected string CmgUnmaskedID;

        public ReadCSVPerRow(string id)
        {
            CmgUnmaskedID = id;
        }

        public Company Read()
        {
            try
            {
                string fileName = "companies.csv";
                string oldPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Source\\" + fileName);
                string path = GenerateFile(oldPath, fileName);
                using (var reader = new StreamReader(path, Encoding.Default))
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CreateSpecificCulture("en")))
                {
                    csv.Configuration.RegisterClassMap<CompanyMap>();
                    var records = csv.GetRecords<Company>().Where(x => x.CMGUnmaskedID == CmgUnmaskedID).FirstOrDefault();

                    
                    return records;
                }
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
        }

        private string GenerateFile(string oldPath, string fileName)
        {
            string pathDir = @"C:\KANO";


            //check dir

            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }

            if (!File.Exists(pathDir + "\\" + fileName))
            {
                File.Copy(oldPath, pathDir + "\\" + fileName);
            }

            return pathDir + "\\" + fileName;
        }
    }
}
