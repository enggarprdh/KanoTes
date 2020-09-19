using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model.Map
{
    public sealed class CompanyMap : ClassMap<Company>
    {
        public CompanyMap()
        {
            Map(z => z.CMGUnmaskedID).Name("CMGUnmaskedID");
            Map(z => z.CMGUnmaskedName).Name("CMGUnmaskedName");
            Map(z => z.ClientTier).Name("ClientTier");
            Map(z => z.GCPStream).Name("GCPStream");
            Map(z => z.GCPBusiness).Name("GCPBusiness");
            Map(z => z.CMGGlobalBU).Name("CMGGlobalBU");
            Map(z => z.CMGSegmentName).Name("CMGSegmentName");
            Map(z => z.GlobalControlPoint).Name("GlobalControlPoint");
            Map(z => z.GCPGeography).Name("GCPGeography");
            Map(z => z.GlobalRelationshipManagerName).Name("GlobalRelationshipManagerName");
            Map(z => z.REVENUE_FY14).Name("REVENUE_FY14");
            Map(z => z.REVENUE_FY15).Name("REVENUE_FY15");
            Map(z => z.Deposits_EOP_FY14).Name(" Deposits_EOP_FY14");
            Map(z => z.Deposits_EOP_FY15x).Name(" Deposits_EOP_FY15x");
            Map(z => z.TotalLimits_EOP_FY14).Name(" TotalLimits_EOP_FY14");
            Map(z => z.TotalLimits_EOP_FY15).Name(" TotalLimits_EOP_FY15");
            Map(z => z.TotalLimits_EOP_FY15x).Name(" TotalLimits_EOP_FY15x");
            Map(z => z.RWAFY15).Name(" RWAFY15");
            Map(z => z.RWAFY14).Name(" RWAFY14");
            Map(z => z.REV_RWA_FY14).Name("REV/RWA FY14");
            Map(z => z.REV_RWA_FY15).Name("REV/RWA FY15");
            Map(z => z.NPAT_AllocEq_FY14).Name(" NPAT_AllocEq_FY14");
            Map(z => z.NPAT_AllocEq_FY15X).Name(" NPAT_AllocEq_FY15X");
            Map(z => z.Company_Avg_Activity_FY14).Name("Company_Avg_Activity_FY14");
            Map(z => z.Company_Avg_Activity_FY15).Name("Company_Avg_Activity_FY15");
            Map(z => z.ROE_FY14).Name("ROE_FY14");
            Map(z => z.ROE_FY15).Name("ROE_FY15");
        }
    }
}
