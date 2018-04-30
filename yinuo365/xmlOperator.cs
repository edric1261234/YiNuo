using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace yinuo365
{
    class xmlOperator
    {
        XmlDocument xmlDoc;

        public void UpdateNode(string jine, string shuie)
        {
            string root = System.AppDomain.CurrentDomain.BaseDirectory;

            string path = root + "export.xml";

            xmlDoc = new XmlDocument();
            xmlDoc.Load(path); //加载xml文件

            //获取bookshop节点的所有子节点 
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("DZSBB").ChildNodes;
            XmlNode xn = nodeList[0];
            XmlElement xe = (XmlElement)xn; //将子节点类型转换为XmlElement类型 


            XmlNodeList nodeList1 = xe.SelectSingleNode("SB_FWSKKP_FPXX").ChildNodes;
            XmlNode xn1 = nodeList1[0];
            XmlElement xe1 = (XmlElement)xn1; //将子节点类型转换为XmlElement类型 


            string s = xe1.GetAttribute("SB_FWSKKP_MXXX_JE");


            foreach (XmlNode xn2 in xe1.ChildNodes)//遍历 
            {
                XmlElement xe2 = (XmlElement)xn2; //转换类型
                if (xe2.Name == "SB_FWSKKP_MXXX_JE")//如果找到 
                {
                    xe2.InnerText = jine;//则修改  
                }
                if (xe2.Name == "SB_FWSKKP_MXXX_SE")//如果找到 
                {
                    xe2.InnerText = shuie;//则修改  
                }
            }
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\export.xml";
            xmlDoc.Save(dir);//保存。 
            MessageBox.Show("导出成功!");
        }

    }
}
