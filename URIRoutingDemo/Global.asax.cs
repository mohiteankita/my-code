using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace URIRoutingDemo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            ResgisterRoutes(RouteTable.Routes);
        }

        public static void ResgisterRoutes(RouteCollection rcollection)
        {
            rcollection.MapPageRoute("RouteForArticle", "Article/{id}/{Title}", "~/DetailsPage.aspx");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //code that run when a new session is started
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //code that run when an unhandled error occurs
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //code that runs when a session ends
        }

        protected void Application_End(object sender, EventArgs e)
        {
            //code that run on application shutdown

            //Note: The Session_End event is raised only when the sessionstate mode
            //is set to InProc in the Web.config file. If session mode is set to StateServer
            //or SQLServer, the event is not raised.
        }
    }
}