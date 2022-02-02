using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace donationrequest
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session.Add("eRaiderDBConnStr", "user id=ESI_ADS_CENTRALIZEDDB;password=Ir9jUxUgAyEnAmE;database=eraider;server=eraiderdb.net.ttu.edu");

            Session.Add("eRaiderDispatchURL", "https://appdev.itts.ttu.edu/staging/CentralizedDegreeDb/Login.aspx");
            Session.Add("eRaiderFailureURL", "https://eraider.ttu.edu/");
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

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}