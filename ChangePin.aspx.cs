using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using INBAdodotnetDR;

namespace NiharikaBank
{
	/// <summary>
	/// Summary description for ChangePin.
	/// </summary>
	public class ChangePin : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.Label result;
		protected System.Web.UI.WebControls.TextBox OldPin;
		protected System.Web.UI.WebControls.TextBox NewPin;
		protected System.Web.UI.WebControls.TextBox rePin;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.CompareValidator CompareValidator1;
		protected System.Web.UI.WebControls.Button Button1;
		Customer custObj;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			custObj = new Customer();
			custObj.DatabaseName = "Banking";
			custObj.ServerName = "localhost";
			custObj.UserName = "sa";
			custObj.Password = "sa";
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			custObj.ChangeTpin(10012, OldPin.Text, NewPin.Text);
		}
	}
}
