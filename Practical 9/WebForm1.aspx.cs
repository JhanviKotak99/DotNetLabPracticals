using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDecreaseFont_Click(object sender, EventArgs e)
        {
            //==== Get the current font size of the lable and remove pt concated with font size.
            int currentSize = Convert.ToInt32(lblOutput.Font.Size.ToString().Replace("pt", ""));

            //==== Decrease font size by 1pt.
            lblOutput.Font.Size = currentSize - 1;
        }
        protected void btnIncreaseFont_Click(object sender, EventArgs e)
        {
            //==== Get the current font size of the lable and remove pt concated with font size.
            int currentSize = Convert.ToInt32(lblOutput.Font.Size.ToString().Replace("pt", ""));

            //==== Increase font size by 1pt.
            lblOutput.Font.Size = currentSize + 1;
        }

    }
}