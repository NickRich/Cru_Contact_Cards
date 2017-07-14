using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cru_Contact_Cards
{
    public partial class CruContactCard : Form
    {
        //TODO: Set actions to get these values
        private string religion;
        private string race;
        private string cruInfo;
        private string convo;

        public CruContactCard()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact(tboName.Text, cboGrade.SelectedItem.ToString(), cboGender.SelectedItem.ToString(),
                cboResidence.SelectedItem.ToString(), tboRoom.ToString(), religion, race, trkRelationship.Value, cruInfo, convo);
        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {
            tboOther.Enabled = !tboOther.Enabled;
        }

        private void chkRaceOther_CheckedChanged(object sender, EventArgs e)
        {
            tboRaceOther.Enabled = !tboRaceOther.Enabled;
        }
    }
}
