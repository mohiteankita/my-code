using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCDalExample.Models
{
    public class DepartmentDAL
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        SqlCommandBuilder builder;
        DataSet dataset;
        DataTable table;

        public DepartmentDAL()
        {
            try
            {
                connection = new SqlConnection("server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=HRMSDB; trusted_connection=true");
                cmd = new SqlCommand("GetDepartmentData", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                builder = new SqlCommandBuilder(adapter);
                dataset = new DataSet();
                adapter.Fill(dataset, "departments");
                table = dataset.Tables[0];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Department> GetDeptList()
        {
            List<Department> deptlist = new List<Department>();
            foreach (DataRow row in table.Rows)
            {
                Department d = new Department();
                d.department_id = Double.Parse(row["department_id"].ToString());
                d.department_name = row["department_name"].ToString();
                d.location_id = Double.Parse(row["location_id"].ToString() == "" ? "0" : row["location_id"].ToString());
                d.manager_id = Double.Parse(row["manager_id"].ToString() == "" ? "0" : row["manager_id"].ToString());
                deptlist.Add(d);
            }
            return deptlist;
        }

        public Department GetDepartment(int deptid)
        {
            DataRow[] rows = table.Select("department_id=" + deptid);
            Department d = new Department();
            if (rows.Length > 0)
            {
                DataRow deptrow = rows[0];
                d.department_id = Double.Parse(deptrow["department_id"].ToString());
                d.department_name = deptrow["department_name"].ToString();
                d.manager_id = Double.Parse(deptrow["location_id"].ToString() == "" ? "0" : deptrow["location_id"].ToString());
                d.location_id = Double.Parse(deptrow["manager_id"].ToString() == "" ? "0" : deptrow["manager_id"].ToString());
            }
            return d;
        }

        public bool InsertDepartment(Department d)
        {
            try
            {
                DataRow newrow = table.NewRow();
                newrow["department_id"] = d.department_id;
                newrow["department_name"] = d.department_name;
                newrow["manager_id"] = d.manager_id;
                newrow["location_id"] = d.location_id;

                table.Rows.Add(newrow);
                adapter.Update(dataset, "departments");
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
           
        }

        public bool UpdateDepartment(Department d)
        {
            try
            {
                DataRow[] rows = table.Select("department_id=" + d.department_id);
               
                if (rows.Length > 0)
                {
                    DataRow deptrow = rows[0];
                    deptrow["department_id"] = d.department_id;
                    deptrow["department_name"] = d.department_name;
                    deptrow["manager_id"] = d.manager_id;
                    deptrow["location_id"] = d.location_id;

                    adapter.Update(table);
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        internal object DeleteDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDepartment(Department d)
        {
            try
            {
                DataRow[] rows = table.Select("department_id=" + d.department_id);
                if(rows.Length > 0)
                {
                    DataRow deptrow = rows[0];
                    deptrow.Delete();
                    adapter.Update(dataset, "departments");
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        
    }
}