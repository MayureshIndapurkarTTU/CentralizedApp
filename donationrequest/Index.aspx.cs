using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace donationrequest
{
    public partial class Index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (ADS_CentralizedDegreePlans_StagingEntities context = new ADS_CentralizedDegreePlans_StagingEntities())
                {
                    var progs = (from u in context.Programs where !u.Name.Contains("Online")  orderby u.Name select new { u.Name, u.Code });
                    DropDownList1.DataSource = progs.ToList();
                    DropDownList1.DataTextField = "Name";
                    DropDownList1.DataValueField = "Code";
                    DropDownList1.DataBind();
                    render(context);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ADS_CentralizedDegreePlans_StagingEntities context = new ADS_CentralizedDegreePlans_StagingEntities())
            {
                render(context);
            }
        }

        protected void render(ADS_CentralizedDegreePlans_StagingEntities context)
        {
            populate(context, GridView1, "Sophomore", "Fall");
            populate(context, GridView2, "Sophomore", "Spring");
            populate(context, GridView3, "Junior", "Fall");
            populate(context, GridView4, "Junior", "Spring");

            populate(context, GridView5, "Senior", "Fall");
            populate(context, GridView6, "Senior", "Spring");
            populate(context, GridView7, "Freshman", "Fall");
            populate(context, GridView8, "Freshman", "Spring");
        }

        protected void populate(ADS_CentralizedDegreePlans_StagingEntities context, GridView gv, string year, string semester)
        {

            gv.DataSource = context.FetchPlan(DropDownList1.SelectedValue, year, semester, "abc").ToList();
            gv.DataBind();
            
        }

    }
}