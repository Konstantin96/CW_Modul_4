using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Modul_4.MODUL
{
    public class SALESIMS
    {/// <summary>
     /// BUKRS	ID дистрибьютора
     /// WERKS Филиал
     ///MTART Код продукта дистрибьютора
     /// MTART_TXT Наименование продукта
     ///MTART_PROIZVOD_COUNTRY  Производитель и страна производителя
     ///BSTART Количество
     ///SUMM Сумма отгрузки/сумма возврата минусом
     /// </summary>
        public string BUKRS { get; set; }
        public string WERKS { get; set; }
        public int MTART { get; set; }
        public string MTART_TXT { get; set; }
        public string MTART_PROIZVOD_COUNTRY { get; set; }
        public double BSTART { get; set; } = 0;
        private double SUMM_;
        public double SUMM
        {
            get
            {
                return SUMM_;
            }
            set
            {
                if (BSTART < 0)
                    value = value * -1;
                SUMM_ = value;
            }
        }
    }
}
