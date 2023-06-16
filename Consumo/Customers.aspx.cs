using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consumo.ServiceReference1;
namespace Consumo
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            Service1Client client = new Service1Client();
            GridView1.DataSource = client.Get().CustomersTable;
            GridView1.DataBind();
        }

        protected void OnRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void Insert(object sender, EventArgs e)
        {

        }
    }
}