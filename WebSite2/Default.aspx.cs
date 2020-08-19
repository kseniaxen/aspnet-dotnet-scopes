using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string data = "Hello ASP!";
    public string output;
    // public bool isPost = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        string fileName = this.Server.MapPath(@"App_Data\LoginTemplate.txt");
        output = File.ReadAllText(fileName);
        User user = new User("user1", "test@test.test");
        output = output.Replace("<% Login %>", user.mLogin);
        output = output.Replace("<% Email %>", user.mEmail);
        this.Response.Write(output);
    }

    protected void registerButton_Click(object sender, EventArgs e)
    {
        // isPost = true;
        /* this.Response.Write(
            this.Request.Params["loginTextBox"] + " " + this.Request.Params["passwordTextBox"]
        ); */
                
    }
}