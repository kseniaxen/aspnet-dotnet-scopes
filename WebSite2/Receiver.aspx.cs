using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Receiver : System.Web.UI.Page
{
    public string data;
    protected void Page_Load(object sender, EventArgs e)
    {
        data = this.Request.QueryString["sender"] + ": " + Request.QueryString["count"];
    }
}