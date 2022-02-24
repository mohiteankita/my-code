using MVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkToObject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DeptBal bal = new DeptBal();
            List<Department> dlist = bal.GetDeptList();
            //var res = from data in dlist
            //          where data.deptid < 113
            //          select new { data.deptid, data.deptname };

            //var res = from data in dlist
            //          where data.deptid < 113
            //          select data;

            var res = from data in dlist
                      where data.deptname.Length > 6
                      select data;

            GridView1.DataSource = res;
            GridView1.DataBind();
        }
    }
}