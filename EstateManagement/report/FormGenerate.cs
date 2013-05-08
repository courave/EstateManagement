﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;
using System.Threading;

namespace EstateManagement.report
{
    public partial class FormGenerate : Form
    {
        private DateTime mMonthBegin;
        private DateTime mMonthEnd;
        private String mMonth = "";

        private int mTotalCount = -1;
        private int mCurrentCount = 0;
        private bool mCompleted = false;
        private bool mSucceed = false;
        private String mMessage = "";

        public FormGenerate()
        {
            InitializeComponent();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            //
            mMonthBegin = dateTimePicker_selmonth.Value;
            mMonthEnd = dateTimePicker_selmonth.Value.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
            mMonth = dateTimePicker_selmonth.Value.ToString("yyyyMM");

            mTotalCount = -1;
            mCurrentCount = 0;
            mCompleted = false;
            mSucceed = false;
            mMessage = "";

            lblMsg.Visible = true;
            button_generate.Enabled = false;
            dateTimePicker_selmonth.Enabled = false;

            Thread t = new Thread(new ThreadStart(generate));
            t.Start();

            timer_fee.Enabled = true;

        }
        private bool CheckIfExist()
        {
            using (DataBase db = new DataBase())
            {

                //DataTable dt = db.ExecuteDataTable("SELECT TOP 1 * FROM [CJ_MAIN_FEE] WHERE [LAST_END] >= '" + mMonthBegin.ToString() + "' AND [LAST_END] <= '" + mMonthEnd.ToString() + "'");
                DataTable dt = db.ExecuteDataTable("SELECT TOP 1 * FROM [FEE_INFO] WHERE [GEN_MONTH] = '" + mMonth + "'");
                if (dt.Rows.Count > 0)
                    return true;
            }
            return false;
        }

        private void FormGenerate_Load(object sender, EventArgs e)
        {
            dateTimePicker_selmonth.Value = dateTimePicker_selmonth.Value.AddDays(1 - dateTimePicker_selmonth.Value.Day).Date;

        }

        private void FormGenerate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!button_generate.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void generate()
        {
            if (CheckIfExist())
            {
                DialogResult dr=MessageBox.Show("所选月份已生成过报表,确定要继续吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    mMessage = "所选月份已经生成过报表。";
                    mCompleted = true;
                    return;
                }
            }
            //get all un-terminated companys
            DataTable dtCustomers=new DataTable();
            int interval = 3;
            using (DataBase db = new DataBase())
            {
                dtCustomers = db.ExecuteDataTable("SELECT * FROM CONTRACT_INFO WHERE TERMINATE<>1");
            }
            //search all the customers
            mTotalCount = dtCustomers.Rows.Count;
            for (mCurrentCount = 0; mCurrentCount < mTotalCount; mCurrentCount++)
            {
                DataRow drCustomer = dtCustomers.Rows[mCurrentCount];
                if ((DateTime)drCustomer["END_DATE"] < mMonthBegin)
                    continue;//合同到期的不处理
                String COMPANY_ID = drCustomer["ID"].ToString();
                int iCompanyID = -1;
                int.TryParse(COMPANY_ID, out iCompanyID);
                
                DateTime? lastNextStartTime = getLastNextStartTime(COMPANY_ID);
                DateTime lastEnd;
                DateTime nextStart;
                //
                DataTable dtPredCharge = new DataTable();
                using (DataBase db = new DataBase())
                {
                    dtPredCharge = db.ExecuteDataTable("SELECT * FROM View_PRED_CHARGE WHERE COMP_ID=" + COMPANY_ID);
                    if (dtPredCharge.Rows.Count > 0)
                        int.TryParse(dtPredCharge.Rows[0]["INTERVAL"].ToString(), out interval);
                    else
                    {
                        continue;
                    }
                }
                if (lastNextStartTime == null)
                {
                    // 新客户
                    DateTime dtContractStart = (DateTime)drCustomer["START_DATE"];
                    dtContractStart = dtContractStart.AddMonths(interval);
                    if (dtContractStart > mMonthEnd)
                    {
                        continue;
                    }

                    lastEnd = dtContractStart;
                }
                else
                {
                    if (lastNextStartTime.Value > mMonthEnd)
                    {
                        continue;
                    }

                    lastEnd = lastNextStartTime.Value;
                }
                nextStart = lastEnd.AddMonths(interval);
                //
                DataRow drPredCharge;
                if (dtPredCharge.Rows.Count > 0)
                    drPredCharge=dtPredCharge.Rows[0];
                else
                {
                    continue;
                }
                double fangzu = 0;
                double wuye = 0;
                double fuwu = 0;
                double wangluo = 0;
                double.TryParse(drPredCharge["FANGZU"].ToString(), out fangzu);
                double.TryParse(drPredCharge["WUYE"].ToString(), out wuye);
                double.TryParse(drPredCharge["FUWU"].ToString(), out fuwu);
                double.TryParse(drPredCharge["WANGLUO"].ToString(), out wangluo);
                if (fangzu != 0)
                {
                    addMainFee("房租", fangzu * interval, lastEnd, nextStart, "", iCompanyID);
                }
                if (wuye != 0)
                {
                    addMainFee("物业费", wuye * interval, lastEnd, nextStart, "", iCompanyID);
                }
                if (fuwu != 0)
                {
                    addMainFee("服务费", fuwu * interval, lastEnd, nextStart, "", iCompanyID);
                }
                if (wangluo != 0)
                {
                    addMainFee("网络费", wangluo * interval, lastEnd, nextStart, "", iCompanyID);
                }
                //车位费
                using (DataBase db = new DataBase())
                {
                    DataTable dtParking = db.ExecuteDataTable("SELECT CAR_PLATE,PRICE_MONTH FROM PARKING_INFO WHERE COMP_ID="+iCompanyID+" AND TERMINATE<>1");
                    if (dtParking.Rows.Count > 0)
                    {
                        //
                        string comment = "总共" + dtParking.Rows.Count + "个车位";
                        double ParkingFee = 0;
                        double tmp = 0;
                        foreach (DataRow dr in dtParking.Rows)
                        {
                            if (double.TryParse(dr[1].ToString(), out tmp))
                            {
                                ParkingFee += tmp;
                            }
                        }
                        addMainFee("车位费", ParkingFee * interval, lastEnd, nextStart, comment, iCompanyID);
                    }
                }
                //水电煤
                //水费
                using (DataBase db = new DataBase())
                {
                    db.AddParameter("COMPANY_ID", COMPANY_ID);
                    DataTable dtMiscFee = db.ExecuteDataTable("SELECT TOP 1 * FROM SDM_INFO WHERE SDM_TYPE='水费' AND COMP_ID=@COMPANY_ID AND ISPAID<>1 ORDER BY SDM_TIME DESC");
                    if (dtMiscFee.Rows.Count > 0)
                    {
                        DateTime dtCBTime;
                        DateTime.TryParse(dtMiscFee.Rows[0]["SDM_TIME"].ToString(), out dtCBTime);

                        double dFee = 0;
                        double.TryParse(dtMiscFee.Rows[0]["SDM_CHARGE"].ToString(), out dFee);

                        if (dFee != 0)
                            addMainFee("水费", dFee, dtCBTime, null,"抄表数:"+ dtMiscFee.Rows[0]["SDM_SUM"].ToString(), iCompanyID);
                    }
                }
                //电费
                using (DataBase db = new DataBase())
                {
                    db.AddParameter("COMPANY_ID", COMPANY_ID);
                    DataTable dtMiscFee = db.ExecuteDataTable("SELECT TOP 1 * FROM SDM_INFO WHERE SDM_TYPE='电费' AND COMP_ID=@COMPANY_ID AND ISPAID<>1 ORDER BY SDM_TIME DESC");
                    if (dtMiscFee.Rows.Count > 0)
                    {
                        DateTime dtCBTime;
                        DateTime.TryParse(dtMiscFee.Rows[0]["SDM_TIME"].ToString(), out dtCBTime);

                        double dFee = 0;
                        double.TryParse(dtMiscFee.Rows[0]["SDM_CHARGE"].ToString(), out dFee);

                        if (dFee != 0)
                            addMainFee("电费", dFee, dtCBTime, null, "抄表数:" + dtMiscFee.Rows[0]["SDM_SUM"].ToString(), iCompanyID);
                    }
                }
                //煤气费
                using (DataBase db = new DataBase())
                {
                    db.AddParameter("COMPANY_ID", COMPANY_ID);
                    DataTable dtMiscFee = db.ExecuteDataTable("SELECT TOP 1 * FROM SDM_INFO WHERE SDM_TYPE='煤气费' AND COMP_ID=@COMPANY_ID AND ISPAID<>1 ORDER BY SDM_TIME DESC");
                    if (dtMiscFee.Rows.Count > 0)
                    {
                        DateTime dtCBTime;
                        DateTime.TryParse(dtMiscFee.Rows[0]["SDM_TIME"].ToString(), out dtCBTime);

                        double dFee = 0;
                        double.TryParse(dtMiscFee.Rows[0]["SDM_CHARGE"].ToString(), out dFee);

                        if (dFee != 0)
                            addMainFee("煤气费", dFee, dtCBTime, null, "抄表数:" + dtMiscFee.Rows[0]["SDM_SUM"].ToString(), iCompanyID);
                    }
                }


            }
            mSucceed = true;
            mMessage = "报表生成成功";
            mCompleted = true;

        }

        private void timer_fee_Tick(object sender, EventArgs e)
        {
            if (mCompleted)
            {
                timer_fee.Enabled = false;
                lblMsg.Visible = false;
                button_generate.Enabled = true;
                dateTimePicker_selmonth.Enabled = true;


                if (mSucceed)
                {
                    MessageBox.Show(mMessage, "生成费用报表", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                {
                    MessageBox.Show(mMessage, "生成费用报表", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                try
                {
                    if (mTotalCount > 0)
                    {
                        if (progressBar_report.Style != ProgressBarStyle.Blocks)
                            progressBar_report.Style = ProgressBarStyle.Blocks;
                        if (progressBar_report.Maximum != mTotalCount)
                            progressBar_report.Maximum = mTotalCount;
                        progressBar_report.Value = mCurrentCount;
                    }
                    else
                    {
                        if (progressBar_report.Style != ProgressBarStyle.Marquee)
                            progressBar_report.Style = ProgressBarStyle.Marquee;
                    }
                }
                catch(Exception ex)
                {
                    lblMsg.Text = ex.Message;
                }
            }

        }
        private DateTime? getLastNextStartTime(String company_id)
        {
            using (DataBase db = new DataBase())
            {
                db.AddParameter("COMP_ID", company_id);
                // 得到最大的NextTime。  
                // 
                DataTable dt = db.ExecuteDataTable("SELECT MAX([NEXT_START]) FROM [FEE_INFO] WHERE [COMP_ID]=@COMP_ID AND [FEE_TYPE]='房租'");
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString() == "")
                        return null;
                    return (DateTime?)dt.Rows[0][0];
                }
            }
            return null;
        }
        private int addMainFee(String FEE_TYPE, double FEE, DateTime LAST_END, DateTime? NEXT_START, String COMMENT, int COMPANY_ID)
        {
            String sql = "INSERT INTO [FEE_INFO]([FEE_TYPE],[FEE_CHARGE],[LAST_END],[NEXT_START] "+
                ",[COMP_ID],[COMMENT],[GEN_MONTH],[ISPAID]) VALUES (@FEE_TYPE,@FEE_CHARGE " +
                ",@LAST_END,@NEXT_START,@COMP_ID,@COMMENT,@GEN_MONTH,@ISPAID)";

            using (DataBase db = new DataBase())
            {
                db.AddParameter("FEE_TYPE", FEE_TYPE);
                db.AddParameter("FEE_CHARGE", FEE);
                db.AddParameter("LAST_END", LAST_END);
                if (NEXT_START == null)
                    db.AddParameter("NEXT_START", DBNull.Value);
                else
                    db.AddParameter("NEXT_START", NEXT_START);
                db.AddParameter("COMMENT", COMMENT);
                db.AddParameter("COMP_ID", COMPANY_ID);
                db.AddParameter("GEN_MONTH", mMonth);
                db.AddParameter("ISPAID", false);

                return db.ExecuteNonQuery(sql);
            }


        }

    }
}
