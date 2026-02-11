using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DalXml
{
    class Config
    {
        const string filePath = @"../xml/dataConfig.xml";
        static XElement dataConfig= XElement.Load(filePath);

        public static int ProductCode
        {
            get
            {
                //XElement dataConfig = XElement.Load(filePath);
                int code;
                if (!int.TryParse(dataConfig.Element("NextProductId").Value, out code))
                    code = 1000;
                dataConfig.Element("NextProductId").SetValue(code + 10);
                dataConfig.Save(filePath);
                return code;

            }
        }

        public static int SaleCode
        {
            get
            {
                XElement dataConfig = XElement.Load(filePath);
                int code;
                if (!int.TryParse(dataConfig.Element("NextSaleId").Value, out code))
                    code = 1000;
                dataConfig.Element("NextSaleId").SetValue(code + 10);
                dataConfig.Save(filePath);
                return code;

            }
        }
    }
}
