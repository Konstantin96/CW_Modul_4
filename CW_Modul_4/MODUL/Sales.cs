using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Modul_4.MODUL
{
    public enum Currecy
    {
        KZT = 398, RUB = 256, USD = 323
    }
    public enum SALES_CHANEL_TXT
    {
        opt=8, roz=7, net=12
    }
    public class Sales
    {
        public string BUKRS { get; set; }
        public string WERKS { get; set; }
        public string LGORT { get; set; }
        public int SALES_CHANEL { get; private set; }
        /// <summary>
        /// Наименование Канал сбыта
        /// </summary>
        private SALES_CHANEL_TXT SALES_CHANEL_TXT_;
        public SALES_CHANEL_TXT SALES_CHANEL_TXT
        {
            get
            {
                return SALES_CHANEL_TXT_;
            }
            set
            {
                SALES_CHANEL_TXT_ = value;
                SALES_CHANEL = (int)value;
                //switch (value)
                //{
                //    case SALES_CHANEL_TXT.opt:
                //        SALES_CHANEL = 8;
                //        break;
                //    case SALES_CHANEL_TXT.roz:
                //        SALES_CHANEL = 7;
                //        break;
                //    case SALES_CHANEL_TXT.net:
                //        SALES_CHANEL = 12;
                //        break;
                //    default:
                //        break;
                //}
            }

        }
        public string KUNNR { get; set; }
        public string KUNNR_TXT { get; set; }
        public int KUNNR_BIN { get; set; }
        public string KUNNR_ADR_UR { get; set; }
        public string KUNNR_ADR_DOST { get; set; }
        public string ID_OUT_DELIVERY { get; set; }
        public string ID_OUT_DELIVERY_DATA { get; set; }
        public int BSTART { get; set; }
        public double SUMM { get; set; }
        public string SUMMWithCur
        {
            get
            {
                return SUMM + " " + VALUTA.ToString();
            }
        }
        public Currecy VALUTA { get; set; } = Currecy.KZT;
    }
}
