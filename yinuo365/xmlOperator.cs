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
            xmlDoc.Load(path); //����xml�ļ�

            //��ȡbookshop�ڵ�������ӽڵ� 
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("DZSBB").ChildNodes;
            XmlNode xn = nodeList[0];
            XmlElement xe = (XmlElement)xn; //���ӽڵ�����ת��ΪXmlElement���� 


            XmlNodeList nodeList1 = xe.SelectSingleNode("SB_FWSKKP_FPXX").ChildNodes;
            XmlNode xn1 = nodeList1[0];
            XmlElement xe1 = (XmlElement)xn1; //���ӽڵ�����ת��ΪXmlElement���� 


            string s = xe1.GetAttribute("SB_FWSKKP_MXXX_JE");


            foreach (XmlNode xn2 in xe1.ChildNodes)//���� 
            {
                XmlElement xe2 = (XmlElement)xn2; //ת������
                if (xe2.Name == "SB_FWSKKP_MXXX_JE")//����ҵ� 
                {
                    xe2.InnerText = jine;//���޸�  
                }
                if (xe2.Name == "SB_FWSKKP_MXXX_SE")//����ҵ� 
                {
                    xe2.InnerText = shuie;//���޸�  
                }
            }
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\export.xml";
            xmlDoc.Save(dir);//���档 
            MessageBox.Show("�����ɹ�!");
        }

    }
}
