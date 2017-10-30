using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void carWizard_FinishButtonClick(object sender,
      WizardNavigationEventArgs e)
    {
        // Get each value.
        string order =
            $"{txtCarPetName.Text}, your {ListBoxColors.SelectedValue} {txtCarModel.Text} will arrive on {carCalendar.SelectedDate.ToShortDateString()}.";

        // Assign to label
        lblOrder.Text = order;
    }
}
