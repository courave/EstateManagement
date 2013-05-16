using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstateManagement.notification
{
    public partial class FormNotification : Form
    {
        public FormNotification()
        {
            InitializeComponent();
        }

        private void FormNotification_Load(object sender, EventArgs e)
        {
            webBrowser_notification.DocumentText = GetAlertInfo();
        }

        private void webBrowser_notification_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
            string nav = e.Url.OriginalString;
            string scheme = e.Url.Scheme;
            if (scheme != "estate") return;
            e.Cancel = true;
            string csname = e.Url.Host.ToLower();
            String param = "";
            switch (csname)
            {
                case "formaddcustomer.cs":
                    param = e.Url.AbsolutePath;
                    if (param.Contains('/') && param.Length > 1)
                    {
                        param = param.Remove(0, 1);
                        customers.FormAddCustomer frmAddCustomer = new customers.FormAddCustomer(false, param);
                        frmAddCustomer.Show();
                    }
                    break;
            }
        }
        private String GetAlertInfo()
        {
            String htmlAlert = "<html><head><title>提醒</title></head><body>";
            
            using(pub.DataBase db=new pub.DataBase())
            {
                //合同过期跟快过期的客户
                String sql="SELECT ID,COMP_NAME,END_DATE,CONTACT,TELEPHONE,MOBILE FROM CONTRACT_INFO "+
                    "WHERE ((YEAR(END_DATE)=YEAR(GETDATE()) AND MONTH(END_DATE)-MONTH(GETDATE())<=1) "+
                    "OR END_DATE<GETDATE()) AND TERMINATE<>1";
                DataTable dt=db.ExecuteDataTable(sql);
                if(dt.Rows.Count>0)
                {
                    htmlAlert += "<span style='font-family: 宋体; font-size: large; font-weight: bolder'>合同已过期或将在一个月内过期的公司</span>"+
                        "<br/><br/><table style= ' border-width:1px; border-spacing:2px; border-style:solid; border-color:black; border-collapse: collapse;'>"+
                        "<tr><th style='border-width: 1px;padding: 1px;border-style: solid;border-color: black;'>公司</th>"+
                        "<th style='border-width: 1px;padding: 1px;border-style: solid;border-color: black;'>合同终止时间</th>"+
                        "<th style='border-width: 1px;padding: 1px;border-style: solid;border-color: black;'>联系人</th>"+
                        "<th style='border-width: 1px;padding: 1px;border-style: solid;border-color: black;'>办公室电话及传真</th>"+
                        "<th style='border-width: 1px;padding: 1px;border-style: solid;border-color: black;'>手机</th></tr>";
                    foreach(DataRow dr in dt.Rows)
                    {
                        htmlAlert += "<tr><td style='border-width: 1px;padding: 1px;border-style: solid;border-color: black;'>"+
                            "<a href='estate://FormAddCustomer.cs/" + dr[0].ToString() + "'>" + dr[1].ToString() + "</a></td>" +
                            "<td style='border-width: 1px;padding: 1px;border-style: solid;border-color: black;'>" + dr[2].ToString() +
                            "</td><td style='border-width: 1px;padding: 1px;border-style: solid;border-color: black;'>" + dr[3].ToString() +
                            "</td><td style='border-width: 1px;padding: 1px;border-style: solid;border-color: black;'>" + dr[4].ToString() +
                            "</td><td style='border-width: 1px;padding: 1px;border-style: solid;border-color: black;'>" + dr[5].ToString()+"</td></tr>";
                    }
                    htmlAlert+="</table>";
                }
                
            }



            htmlAlert += "</body></html>";
            return htmlAlert;
        }
    }
}
