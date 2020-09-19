using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CsvHelper.TypeConversion;

namespace DataAccess.Model
{
    public class Company
    {
        private string _revenue_fy14;
        private string _revenue_fy15;
        private string _deposits_eop_fy14;
        private string _deposits_eop_fy15x;
        private string _TotalLimits_EOP_FY14;
        private string _TotalLimits_EOP_FY15;
        private string _TotalLimits_EOP_FY15x;
        private string _RWAFY15;
        private string _RWAFY14;
        private string _REV_RWA_FY14;
        private string _REV_RWA_FY15;
        private string _Company_Avg_Activity_FY14;
        private string _Company_Avg_Activity_FY15;
        private string _ROE_FY14;
        private string _ROE_FY15;
        private string _NPAT_AllocEq_FY14;
        private string _NPAT_AllocEq_FY15X;

        public string CMGUnmaskedID { get; set; }
        public string CMGUnmaskedName { get; set; }
        public string ClientTier { get; set; }
        public string GCPStream { get; set; }
        public string GCPBusiness { get; set; }
        public string CMGGlobalBU { get; set; }
        public string CMGSegmentName { get; set; }
        public string GlobalControlPoint { get; set; }
        public string GCPGeography { get; set; }
        public string GlobalRelationshipManagerName { get; set; }
        public string REVENUE_FY14
        {
            get
            {
                if (_revenue_fy14 == null)
                {
                    _revenue_fy14 = "0";
                }
                return _revenue_fy14.Replace(",", "");
            }
            set
            {
                _revenue_fy14 = value.ToString();
            }
        }
        public string REVENUE_FY15
        {
            get
            {
                if (_revenue_fy15 == null)
                {
                    _revenue_fy15 = "0";
                }
                return _revenue_fy15.Replace(",", "");
            }
            set
            {
                _revenue_fy15 = value.ToString();
            }
        }
        public string Deposits_EOP_FY14
        {
            get
            {
                if (_deposits_eop_fy14 == null)
                {
                    _deposits_eop_fy14 = "0";
                }
                return _deposits_eop_fy14.Replace(",", "");
            }
            set
            {
                _deposits_eop_fy14 = value.ToString();
            }
        }
        public string Deposits_EOP_FY15x
        {
            get
            {
                if (_deposits_eop_fy15x == null)
                {
                    _deposits_eop_fy15x = "0";
                }
                return _deposits_eop_fy15x.Replace(",", "");
            }
            set
            {
                _deposits_eop_fy15x = value.ToString();
            }
        }
        public string TotalLimits_EOP_FY14
        {
            get
            {
                if (_TotalLimits_EOP_FY14 == null)
                {
                    _TotalLimits_EOP_FY14 = "0";
                }
                return _TotalLimits_EOP_FY14.Replace(",", "");
            }
            set
            {
                _TotalLimits_EOP_FY14 = value.ToString();
            }
        }
        public string TotalLimits_EOP_FY15
        {
            get
            {
                if (_TotalLimits_EOP_FY15 == null)
                {
                    _TotalLimits_EOP_FY15 = "0";
                }
                return _TotalLimits_EOP_FY15.Replace(",", "");
            }
            set
            {
                _TotalLimits_EOP_FY15 = value.ToString();
            }
        }
        public string TotalLimits_EOP_FY15x
        {
            get
            {
                if (_TotalLimits_EOP_FY15x == null)
                {
                    _TotalLimits_EOP_FY15x = "0";
                }
                return _TotalLimits_EOP_FY15x.Replace(",", "");
            }
            set
            {
                _TotalLimits_EOP_FY15x = value.ToString();
            }
        }
        public string RWAFY15
        {
            get
            {
                if (_RWAFY15 == null)
                {
                    _RWAFY15 = "0";
                }
                return _RWAFY15.Replace(",", "");
            }
            set
            {
                _RWAFY15 = value.ToString();
            }
        }
        public string RWAFY14
        {
            get
            {
                if (_RWAFY14 == null)
                {
                    _RWAFY14 = "0";
                }
                return _RWAFY14.Replace(",", "");
            }
            set
            {
                _RWAFY14 = value.ToString();
            }
        }

        //REV/RWA FY14
        public string REV_RWA_FY14
        {
            get
            {
                if (_REV_RWA_FY14 == null)
                {
                    _REV_RWA_FY14 = "0";
                }
                return _REV_RWA_FY14.Replace("%", "");
            }
            set
            {
                _REV_RWA_FY14 = value.ToString();
            }
        }
        //REV/RWA FY15
        public string REV_RWA_FY15
        {
            get
            {
                if (_REV_RWA_FY15 == null)
                {
                    _REV_RWA_FY15 = "0";
                }
                return _REV_RWA_FY15.Replace("%", "");
            }
            set
            {
                _REV_RWA_FY15 = value.ToString();
            }
        }
        public string NPAT_AllocEq_FY14
        {
            get
            {
                if (_NPAT_AllocEq_FY14 == null)
                {
                    _NPAT_AllocEq_FY14 = "0";
                }
                return _NPAT_AllocEq_FY14.Replace(",", "");
            }
            set
            {
                _NPAT_AllocEq_FY14 = value.ToString();
            }
        }
        public string NPAT_AllocEq_FY15X
        {
            get
            {
                if (_NPAT_AllocEq_FY15X == null)
                {
                    _NPAT_AllocEq_FY15X = "0";
                }
                return _NPAT_AllocEq_FY15X.Replace(",", "");
            }
            set
            {
                _NPAT_AllocEq_FY15X = value.ToString();
            }
        }
        public string Company_Avg_Activity_FY14
        {
            get
            {
                if (_Company_Avg_Activity_FY14 == null)
                {
                    _Company_Avg_Activity_FY14 = "0";
                }
                return _Company_Avg_Activity_FY14.Replace(",", "");
            }
            set
            {
                _Company_Avg_Activity_FY14 = value.ToString();
            }
        }
        public string Company_Avg_Activity_FY15
        {
            get
            {
                if (_Company_Avg_Activity_FY15 == null)
                {
                    _Company_Avg_Activity_FY15 = "0";
                }
                return _Company_Avg_Activity_FY15.Replace(",", "");
            }
            set
            {
                _Company_Avg_Activity_FY15 = value.ToString();
            }
        }
        public string ROE_FY14
        {
            get
            {
                if (_ROE_FY14 == null)
                {
                    _ROE_FY14 = "0";
                }

                return _ROE_FY14.Replace("%", "");
            }
            set
            {
                _ROE_FY14 = value.ToString();
            }
        }
        public string ROE_FY15
        {
            get
            {
                if (_ROE_FY15 == null)
                {
                    _ROE_FY15 = "0";
                }

                return _ROE_FY15.Replace("%", "");
            }
            set
            {
                _ROE_FY15 = value.ToString();
            }
        }
    }
}
