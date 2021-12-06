using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class PageLiftCycle : System.Web.UI.Page
{
    public int i = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        i++;
        Response.Write("<br/>" + "PreInit" + i.ToString());
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        i++;
        Response.Write("<br/>" + "Init" + i.ToString());
    }

    //protected void Page_InitComplete(object sender, EventArgs e)
    //{
    //    i++;
    //    Response.Write("<br/>" + "InitComplete" + i.ToString());
    //}

    protected override void OnPreLoad(EventArgs e)
    {
        i++;
        Response.Write("<br/>" + "PreLoad" + i.ToString());
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        i++;
        Response.Write("<br/>" + "Load" + i.ToString());
    }

    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        i++;
        Response.Write("<br/>" + "LoadComplete" + i.ToString());
    }

    protected override void OnPreRender(EventArgs e)
    {
        i++;
        Response.Write("<br/>" + "PreRender" + i.ToString());
    }

    protected override void OnSaveStateComplete(EventArgs e)
    {
        i++;
        Response.Write("<br/>" + "SaveStateComplete" + i.ToString());
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        i++;
        //Runtime Error : Response is not available in this context.
        //Response.Write("<br/>" + "UnLoad" + i.ToString()); //Error
    }
}
