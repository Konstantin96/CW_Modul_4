using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Modul_4.MODUL
{
    public enum Request_Type
    {
        none, SALES, SALESIMS, STORED, MOVING, GOODS_RECEIPT
    }
    public class REQUEST
    {
        public Request_Type Request_Type { get; set; }
        public string Request { get; set; }
        /// <summary>
        /// Код поставщика из системы SAP ERP (или BIN).
        ///Если идет передача SALESIMS, то код KUNNR не заполняется.
        /// </summary>
        public string KUNNR { get; set; }
        /// <summary>
        /// Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен
        /// </summary>
        public string BUKRS { get; set; }
        /// <summary>
        /// Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP
        /// </summary>
        public string WERKS { get; set; }
        /// <summary>
        /// Дата с начало периода
        /// </summary>
        public DateTime DATA1 { get; set; }
        /// <summary>
        /// Дата конец периода
        /// </summary>
        public DateTime DATA2 { get; set; }
    }
}
