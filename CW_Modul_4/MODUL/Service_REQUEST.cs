using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Modul_4.MODUL
{
    public class Service_REQUEST
    {
        public Respose Get_REQUEST_data()
        {
            REQUEST req1 = new REQUEST();
            Console.Write("Введите тип запроса: ");
            int tr = 0;
            Int32.TryParse(Console.ReadLine(), out tr);
            if (tr <= Enum.GetNames(typeof(Request_Type)).Length)
            {
                req1.Request_Type = (Request_Type)tr;
            }
            Console.WriteLine("Введите код поставщика: ");
            req1.KUNNR = Console.ReadLine();
            Console.WriteLine("Введите код Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен: ");
            req1.BUKRS = Console.ReadLine();
            Console.WriteLine("Введите Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP:");
            req1.WERKS = Console.ReadLine();

            Console.WriteLine("Введите Дата с начало периода: ");
            DateTime data1;
            if (DateTime.TryParse(Console.ReadLine(), out data1))
            {
                req1.DATA1 = data1;
            }
            else
            {
                req1.DATA1 = DateTime.MinValue;
            }
            Console.WriteLine("Введите Дата конец периода: ");

            if (DateTime.TryParse(Console.ReadLine(), out data1))
            {
                req1.DATA2 = data1;
            }
            else
            {
                req1.DATA2 = DateTime.MinValue;
            }
            return REQUEST_Input(req1);

        }
        public Respose REQUEST_Input(REQUEST req1)
        {
            Respose response=null;
            switch (req1.Request_Type)
            {
                case Request_Type.none:
                    break;
                case Request_Type.SALES:
                    {
                        List<Sales> s = null;
                        response= GetSalesReport(req1, out s);
                    }
                    break;
                case Request_Type.SALESIMS:
                    break;
                case Request_Type.STORED:
                    break;
                case Request_Type.MOVING:
                    break;
                case Request_Type.GOODS_RECEIPT:
                    break;
                default:
                    break;
            }
            return response;
        }
        public Respose GetSalesReport(REQUEST req1, out List<Sales> salesReport)
        {
            Respose resp = new Respose();
            salesReport = new List<Sales>();
            salesReport = GetSalesData(req1);
            if (salesReport.Count <= 0)
            {
                resp.status = status.error;
                resp.Error = "ОШИБКА!";
            }
            else
                resp.status = status.good;

            return resp;
        }
        private List<Sales> GetSalesData(REQUEST req1)
        {
            List<Sales> saleses = new List<Sales>();
            for (int i = 0; i < (req1.DATA2 - req1.DATA1).TotalDays; i++)
            {
                Sales sales = new Sales();
                sales.BSTART = rnd.Next(1000);
                sales.BUKRS = "JKD" + rnd.Next(20);
                sales.VALUTA = (Currecy)rnd.Next(4);
                sales.ID_OUT_DELIVERY_DATA = string.Format("{0:dd-mm-yy}", DateTime.Now.AddDays(rnd.Next(1, 30000)));
                sales.KUNNR = "JKD" + rnd.Next(20);
                sales.KUNNR_ADR_UR = "JKD" + rnd.Next(20);
                sales.KUNNR_ADR_DOST = "JKD" + rnd.Next(20);
                sales.KUNNR_BIN = rnd.Next(11111111, 99999999);
                sales.KUNNR_TXT = "JKD" + rnd.Next(20);
                sales.LGORT = "JKD" + rnd.Next(20);
                sales.SALES_CHANEL_TXT = (SALES_CHANEL_TXT)rnd.Next(4);
                sales.SUMM = rnd.Next();
                saleses.Add(sales);
            }
            return saleses;
        }
        private Random rnd = new Random();
    }
}
