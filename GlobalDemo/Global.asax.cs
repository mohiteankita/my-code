using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace GlobalDemo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Console.WriteLine("Application Started");
            Application["appcounter"] = 500;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Console.WriteLine("Session Started");
            Session["sesscounter"] = 600;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Console.WriteLine("Session Ended");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Console.WriteLine("Application Ended");
        }
    }
}