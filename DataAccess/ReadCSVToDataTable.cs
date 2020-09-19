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
    public class ReadCSVToDataTable
    {
        protected int Start;
        protected int PageSize;
        public ReadCSVToDataTable(ReadOptions options)
        {
            Start = options.Start;
            PageSize = options.PageSize;
        }

        public ReadDataTable Read()
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
                    List<Company> records = new List<Company>();
                    if(PageSize < 0)
                    {
                        records = csv.GetRecords<Company>().ToList();
                    } else
                    {
                        records = csv.GetRecords<Company>().Skip(Start).Take(PageSize).ToList();
                    }

                    var total = csv.GetRecords<Company>().Count();
                    ReadDataTable response = new ReadDataTable();
                    response.Data = records;
                    response.TotalRecord = total;
                    response.TotalDisplayRecord = total;
                    return response;
                }
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
        }

        private string GenerateFile(string oldPath,string fileName)
        {
            string pathDir = @"C:\KANO";
            

            //check dir

            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }

            if(!File.Exists(pathDir + "\\" + fileName))
            {
                File.Copy(oldPath, pathDir + "\\" + fileName);
            }

            return pathDir + "\\" + fileName;
        }
    }

    public class ReadOptions
    {
        public int Start { get; set; }
        public int PageSize { get; set; }
    }

    public class ReadDataTable
    {
        public List<Company> Data { get; set; }
        public int TotalRecord { get; set; }
        public int TotalDisplayRecord { get; set; }
    }
}
