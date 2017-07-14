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
        //TODO: Figure out what I want btnDone to do
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

        #region ---Relation Interactables---

        private void chkChristian_CheckedChanged(object sender, EventArgs e)
        {
            this.religion = "Christian";
        }

        private void chkMuslim_CheckedChanged(object sender, EventArgs e)
        {
            this.religion = "Muslim";
        }

        private void chkJewish_CheckedChanged(object sender, EventArgs e)
        {
            this.religion = "Jewish";
        }

        private void chkBuddhist_CheckedChanged(object sender, EventArgs e)
        {
            this.religion = "Buddhist";
        }

        private void chkHindu_CheckedChanged(object sender, EventArgs e)
        {
            this.religion = "Hindu";
        }

        private void chkTaoist_CheckedChanged(object sender, EventArgs e)
        {
            this.religion = "Taoist";
        }

        private void chkAtheist_CheckedChanged(object sender, EventArgs e)
        {
            this.religion = "Atheist";
        }

        private void chkAgnostic_CheckedChanged(object sender, EventArgs e)
        {
            this.religion = "Agnostic";
        }

        private void chkUndecided_CheckedChanged(object sender, EventArgs e)
        {
            this.religion = "Undecided";
        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {
            tboOther.Enabled = !tboOther.Enabled;
        }

        private void tboOther_TextChanged(object sender, EventArgs e)
        {
            this.religion = tboOther.Text;
        }


        #endregion

        #region ---Race Interactables---

        private void chkWhite_CheckedChanged(object sender, EventArgs e)
        {
            this.race = "White";
        }

        private void chkBlack_CheckedChanged(object sender, EventArgs e)
        {
            this.race = "Black";
        }

        private void chkHispanic_CheckedChanged(object sender, EventArgs e)
        {
            this.race = "Hispanic";
        }

        private void chkNative_CheckedChanged(object sender, EventArgs e)
        {
            this.race = "Native American";
        }

        private void chkAsian_CheckedChanged(object sender, EventArgs e)
        {
            this.race = "Asian";
        }

        private void chkRaceOther_CheckedChanged(object sender, EventArgs e)
        {
            tboRaceOther.Enabled = !tboRaceOther.Enabled;
        }

        private void tboRaceOther_TextChanged(object sender, EventArgs e)
        {
            this.race = tboRaceOther.Text;
        }


        #endregion

        #region ---Cru Info Interactables---

        private void rdoCruYes_CheckedChanged(object sender, EventArgs e)
        {
            this.cruInfo = "Yes";
        }

        private void rdoCruMaybe_CheckedChanged(object sender, EventArgs e)
        {
            this.cruInfo = "Maybe";
        }

        private void rdoCruNo_CheckedChanged(object sender, EventArgs e)
        {
            this.cruInfo = "No";
        }

        #endregion

        #region ---Spiritual Conversation Interactables---

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            this.convo = "Yes";
        }

        private void rdoMaybe_CheckedChanged(object sender, EventArgs e)
        {
            this.convo = "Maybe";
        }

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            this.convo = "No";
        }

        #endregion
    }
}
