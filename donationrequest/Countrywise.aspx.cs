using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace donationrequest
{
    public partial class Countrywise : System.Web.UI.Page
    {
        string cnt;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //string refererPage = Request.UrlReferrer.ToString();
            //string url = refererPage.Split('?').Last();
            //string country = url.Split('=').Last();
            if (!IsPostBack)
            {
                cnt = Request.QueryString["country"];
                lblcountry.Text = cnt;
                using (ADS_CentralizedDegreePlans_StagingEntities context = new ADS_CentralizedDegreePlans_StagingEntities())
                {
                    //var progs = (from u in context.Programs orderby u.Name select new { u.Name, u.Code });
                    //DropDownList1.DataSource = progs.ToList();
                    //DropDownList1.DataTextField = "Name";
                    //DropDownList1.DataValueField = "Code";
                    //DropDownList1.DataBind();
                    render(context);
                }
            }
        }

        protected void render(ADS_CentralizedDegreePlans_StagingEntities context)
        {
            populate(context, GridView1, cnt);
        }

        protected void populate(ADS_CentralizedDegreePlans_StagingEntities context, GridView gv, string country)
        {
            gv.DataSource = context.Countrywise(country).ToList();
            gv.DataBind();
        }
    }
}