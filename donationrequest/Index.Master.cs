using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using donationrequest.Functions;

namespace donationrequest
{
    public partial class Index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Athl_TicketRequestEntities context = new Athl_TicketRequestEntities();
            //Nullable<short> loginId = RaiderStaff.getLoginUserId(Session);
            //if (loginId == null)
            //    Response.Redirect("~/DummyLogin.aspx");
            //Page.Title= Common.getUserFullNameById(loginId, context);

            //// Menu bar
            //user usr = Common.getUserFromUserId(loginId, context);
            //string userLevel = RaiderStaff.getUserLevel(usr.supervisor, usr.senior, usr.admin, usr.ticket, usr.parking);
            //switch (userLevel)
            //{
            //    case RaiderStaff.LV_USER:
            //        liMakeRequest.Visible = true;
            //        liOverview.Visible = false;
            //        liAdmin.Visible = false;
                    
            //        liTableau.Visible = false;
            //        break;
            //    case RaiderStaff.LV_ADMIN:
            //        liMakeRequest.Visible = true;
            //        liOverview.Visible = true;
            //        liAdmin.Visible = true;
                    
            //        liTableau.Visible = true;
            //        break;
            //    case RaiderStaff.LV_SUPERVISOR:
            //        liMakeRequest.Visible = true;
            //        liOverview.Visible = true;
            //        liAdmin.Visible = true;
                    
            //        liTableau.Visible = true;
            //        break;
            //    case RaiderStaff.LV_SENIOR:
            //        liMakeRequest.Visible = true;
            //        liOverview.Visible = true;
            //        liAdmin.Visible = true;
                    
            //        liTableau.Visible = true;
            //        break;
            //    case RaiderStaff.LV_TICKET:
            //        liMakeRequest.Visible = true;
            //        liOverview.Visible = true;
            //        liAdmin.Visible = false;
                    
            //        liTableau.Visible = false;
            //        break;
            //}
        }
    }
}