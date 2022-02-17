using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCDalEx1.Models
{
    public class DepartmentDal
    {
            SqlConnection connection;
            SqlDataAdapter adapter;
            SqlCommand cmd;
            SqlCommandBuilder builder;
            DataSet dataset;
            DataTable table;

            public DepartmentDal()
            {
                connection = new SqlConnection("server=LAPTOP-81HIQF3R\\SQLEXPRESS;database=MYDATABASE;trusted_connection=true");
                cmd = new SqlCommand("Get_Department_List", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                builder = new SqlCommandBuilder(adapter);
                dataset = new DataSet();

                adapter.Fill(dataset, "department");
                table = dataset.Tables[0];

            }
            public List<Department> GetDeptList()
            {
                List<Department> dept_list = new List<Department>();
                foreach (DataRow row in table.Rows)
                {
                    dept_list.Add(new Department { deptid = Convert.ToInt32(row["deptid"].ToString()), deptname = row["deptname"].ToString(), location = row["location"].ToString(), country = row["country"].ToString() });
                }
                return dept_list;
            }

            public Department GetDepartment(int deptid)
            {
                DataRow[] rows = table.Select("deptid=" + deptid);
                Department dept = new Department();
                if (rows.Length > 0)
                {
                    DataRow deptrow = rows[0];
                    dept.deptid = Convert.ToInt32(deptrow["deptid"]);
                    dept.deptname = deptrow["deptname"].ToString();
                    dept.location = deptrow["location"].ToString();
                    dept.country = deptrow["Country"].ToString();
                }

                return dept;

            }

            public bool InsertDepartment(Department dept)
            {
                try
                {
                    DataRow newrow = table.NewRow();
                    newrow["deptid"] = dept.deptid;
                    newrow["deptname"] = dept.deptname;
                    newrow["location"] = dept.location;
                    newrow["country"] = dept.country;
                    table.Rows.Add(newrow);
                    adapter.Update(dataset, "department");
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }

            public bool UpdateDepartment(Department dept)
            {
                try
                {
                    DataRow[] rows = table.Select("deptid=" + dept.deptid);
                    if (rows.Length > 0)
                    {
                        DataRow deptrow = rows[0];
                        deptrow["deptid"] = dept.deptid;
                        deptrow["deptname"] = dept.deptname;
                        deptrow["location"] = dept.location;
                        deptrow["country"] = dept.country;
                        adapter.Update(dataset, "department");
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            public bool DeleteDepartment(Department dept)
            {
                try
                {
                    DataRow[] rows = table.Select("deptid=" + dept.deptid);
                    if (rows.Length > 0)
                    {
                        DataRow deptrow = rows[0];
                        deptrow.Delete();
                        adapter.Update(dataset, "department");
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
    }
}