using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;

namespace EstateManagement.print
{
    public partial class FormFeePrintPreview : Form
    {
        public string mMonth;
        private bool isPaid;
        private int compid;
        public FormFeePrintPreview():this("<全部>",false){}
        public FormFeePrintPreview(string _mMonth,bool _isPaid):this(_mMonth,_isPaid,-1){}
        public FormFeePrintPreview(string _mMonth,bool _isPaid,int _compid)
        {
            InitializeComponent();
            mMonth = _mMonth;
            isPaid = _isPaid;
            compid = _compid;
        }

        private void FormFeePrintPreview_Load(object sender, EventArgs e)
        {
            CrystalReport_feelist feereport = new CrystalReport_feelist();
            List<ClassFeeReport> printList = new List<ClassFeeReport>();
            DataTable dtReport;
            using (DataBase db = new DataBase())
            {
                String sql = "SELECT * FROM View_FEE_REPORT WHERE ISPAID=@ISPAID ";
                db.AddParameter("ISPAID", isPaid);
                if (mMonth != "<全部>")
                {
                    sql += " AND GEN_MONTH=@GEN_MONTH ";
                    db.AddParameter("GEN_MONTH", mMonth);
                }
                if (compid != -1)
                {
                    sql += " AND ID=@ID ";
                    db.AddParameter("ID", compid);
                }
                dtReport = db.ExecuteDataTable(sql);
            }
            if (dtReport.Rows.Count == 0)
            {
                MessageBox.Show("没有需要打印的记录");
                Dispose();
                return;
            }
            foreach (DataRow dr in dtReport.Rows)
            {
                double subTotal = 0;
                ClassFeeReport bill = new ClassFeeReport();
                bill.customer = dr["COMP_NAME"].ToString();
                bill.roomno = GetRoomNo(dr["ID"].ToString());
                bill.noticeDate = ((DateTime)dr["FZ_LE"]).ToString("yyyy.M.d");
                if (dr["FZ_FEE"].ToString() != "")
                {
                    bill.feeType1 = "房租";
                    bill.feeDate1 = ((DateTime)dr["FZ_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["FZ_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount1 = dr["FZ_FEE"].ToString();
                    bill.comment1 = dr["FZ_COMMENT"].ToString();
                    subTotal += (double)dr["FZ_FEE"];
                }
                if (dr["FWF_FEE"].ToString() != "")
                {
                    bill.feeType1 = "综合技术服务费";
                    bill.feeDate1 = ((DateTime)dr["FWF_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["FWF_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount1 = dr["FWF_FEE"].ToString();
                    bill.comment1 = dr["FWF_COMMENT"].ToString();
                    subTotal += (double)dr["FWF_FEE"];
                }
                if (dr["WY_FEE"].ToString() != "")
                {
                    bill.feeType1 = "物业费";
                    bill.feeDate1 = ((DateTime)dr["WY_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["WY_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount1 = dr["WY_FEE"].ToString();
                    bill.comment1 = dr["WY_COMMENT"].ToString();
                    subTotal += (double)dr["WY_FEE"];
                }
                if (dr["WL_FEE"].ToString() != "")
                {
                    bill.feeType1 = "网络费";
                    bill.feeDate1 = ((DateTime)dr["WL_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["WL_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount1 = dr["WL_FEE"].ToString();
                    bill.comment1 = dr["WL_COMMENT"].ToString();
                    subTotal += (double)dr["WL_FEE"];
                }
                if (dr["CW_FEE"].ToString() != "")
                {
                    bill.feeType1 = "车位费";
                    bill.feeDate1 = ((DateTime)dr["CW_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["CW_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount1 = dr["CW_FEE"].ToString();
                    bill.comment1 = dr["CW_COMMENT"].ToString();
                    subTotal += (double)dr["CW_FEE"];
                }
                if (dr["QITA_FEE"].ToString() != "")
                {
                    bill.feeType1 = "其他费用";
                    bill.feeDate1 = ((DateTime)dr["QITA_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["QITA_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount1 = dr["QITA_FEE"].ToString();
                    bill.comment1 = dr["QITA_COMMENT"].ToString();
                    subTotal += (double)dr["QITA_FEE"];
                }
                bill.subtotal = subTotal.ToString();
                if (dr["SF_FEE"].ToString() != "")
                {
                    bill.feeType1 = "水费";
                    bill.feeDate1 = ((DateTime)dr["SF_LE"]).ToString("yy.M.d") + "抄表";
                    bill.feeAmount1 = dr["SF_FEE"].ToString();
                    bill.comment1 = dr["SF_COMMENT"].ToString();
                    subTotal += (double)dr["SF_FEE"];
                }
                if (dr["DF_FEE"].ToString() != "")
                {
                    bill.feeType1 = "电费";
                    bill.feeDate1 = ((DateTime)dr["DF_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["DF_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount1 = dr["DF_FEE"].ToString();
                    bill.comment1 = dr["DF_COMMENT"].ToString();
                    subTotal += (double)dr["DF_FEE"];
                }
                if (dr["MQF_FEE"].ToString() != "")
                {
                    bill.feeType1 = "煤气费";
                    bill.feeDate1 = ((DateTime)dr["MQF_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["MQF_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount1 = dr["MQF_FEE"].ToString();
                    bill.comment1 = dr["MQF_COMMENT"].ToString();
                    subTotal += (double)dr["MQF_FEE"];
                }
            }
        }
        private string GetRoomNo(string _compid)
        {
            //todo
            return "";
        }
    }
}
