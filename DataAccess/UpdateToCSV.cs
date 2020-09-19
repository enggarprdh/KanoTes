using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using DataAccess.Model;
using DataAccess.Model.Map;

namespace DataAccess
{
    public class UpdateToCSV
    {
        protected Company company;

        public UpdateToCSV(Company _company)
        {
            company = _company;
        }

        public UpdateResult Update()
        {
            UpdateResult result = new UpdateResult();
            string message = "Failed";
            bool res = false;

            try
            {
                if (company != null && company.CMGUnmaskedID != "")
                {
                    //var serviceRead = new ReadCSVPerRow(company.CMGUnmaskedID);
                    var readOption = new ReadOptions();
                    readOption.PageSize = -1;
                    readOption.Start = 0;
                    var serviceRead = new ReadCSVToDataTable(readOption);

                    List<Company> temp = new List<Company>();

                    var companyInfo = serviceRead.Read().Data;

                    if (companyInfo != null && companyInfo.Count > 0)
                    {

                        var dataUpdate = companyInfo.Where(x => x.CMGUnmaskedID == company.CMGUnmaskedID).FirstOrDefault();
                        
                        if(dataUpdate != null)
                        {
                            var newData = new Company();
                            newData = dataUpdate;
                            newData.ROE_FY14 = company.ROE_FY14;
                            newData.REVENUE_FY14 = company.REVENUE_FY14;
                            newData.RWAFY14 = company.RWAFY14;
                            newData.TotalLimits_EOP_FY14 = company.TotalLimits_EOP_FY14;
                            newData.Company_Avg_Activity_FY14 = company.Company_Avg_Activity_FY14;
                            newData.ROE_FY15 = company.ROE_FY15;
                            newData.REVENUE_FY15 = company.REVENUE_FY15;
                            newData.RWAFY15 = company.RWAFY15;
                            newData.TotalLimits_EOP_FY15 = company.TotalLimits_EOP_FY15;
                            newData.Company_Avg_Activity_FY15 = company.Company_Avg_Activity_FY15;

                            companyInfo.Remove(dataUpdate);

                            temp.Add(newData);
                        }

       
                        
                        temp.AddRange(companyInfo);



                        string fileName = "companies.csv";
                        string oldPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Source\\" + fileName);
                        string path = GenerateFile(oldPath, fileName);

                        CsvConfiguration config = new CsvConfiguration(CultureInfo.CurrentCulture)
                        {
                            HasHeaderRecord = !File.Exists(path)
                        };


                        using (var writer = new StreamWriter(path))
                        using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.CreateSpecificCulture("en")))
                        {

                            csv.Configuration.RegisterClassMap<CompanyMap>();
                            csv.WriteHeader<Company>();
                            csv.NextRecord();
                            csv.WriteRecords(temp);

                            writer.Flush();
                            writer.Dispose();
                        }

                        message = "Success";
                        res = true;
                    }
                }

                result.Message = message;
                result.Result = res;

                return result;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Result = false;
                return result;
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

    public class UpdateResult
    {
        public string Message { get; set; }
        public bool Result { get; set; }
    }
}
