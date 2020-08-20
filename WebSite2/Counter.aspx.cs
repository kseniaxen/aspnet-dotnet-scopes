﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Counter : System.Web.UI.Page
{
    // Request Scope
    public int count = 0;
    public int dataCount;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Request Scope
        dataCount = Convert.ToInt32(Request.QueryString["count"]);
        if (dataCount != null) {
            count = dataCount;
        }
    }

    protected void increment_Click(object sender, EventArgs e)
    {
        // count++;
        // ViewState Scope
        /* Object obj = this.ViewState["count"];
        if (obj != null)
        {
            count = (int)obj;
        }
        count += 1;
        this.ViewState["count"] = count; */

        // Request Scope
        count++;
        Response.Redirect($"Counter.aspx?sender={this.GetType().Name}&count={count}");
    }

    protected void send_Click(object sender, EventArgs e)
    {
        Response.Redirect($"Receiver.aspx?sender={this.GetType().Name}&count={count}");
    }
}