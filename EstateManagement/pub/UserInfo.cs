using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EstateManagement.pub
{
    public static class UserInfo
    {
        public static string UserName;
        public static string Permissions;
        public static string NickName;
        public static string RoleName;
        public static int ID;
        public static bool checkIfExist(string UserName, string Password)
        {
            using (DataBase db = new DataBase())
            {
                db.AddParameter("USER_NAME", UserName);
                db.AddParameter("PASSWORD", Password);
                DataTable dt = db.ExecuteDataTable("SELECT A.[ID],[USERNAME],[NICKNAME],[ROLE_NAME]," +
                    "[PERMISSIONS] FROM CJ_ADMIN A,CJ_ROLE B WHERE A.ROLE_ID=B.ID AND " +
                    "USERNAME=@USER_NAME AND PASSWORD=@PASSWORD");
                if (dt.Rows.Count == 1)
                {
                    UserInfo.UserName = UserName;
                    UserInfo.NickName = dt.Rows[0][2].ToString();
                    UserInfo.RoleName = dt.Rows[0][3].ToString();
                    UserInfo.ID = int.Parse(dt.Rows[0][0].ToString());
                    UserInfo.Permissions = dt.Rows[0][4].ToString();

                    return true;
                }
                else
                {
                    db.Dispose();
                    return false;
                }
            }
        }
        public static bool hasPermission(string permission)
        {
            if (Permissions.IndexOf(permission) >= 0 || RoleName == "Administrator")
                return true;
            return false;
        }
    }
}
