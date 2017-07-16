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
        //TODO: Figure out how to process lists
        //TODO: Figure out why it automatically presses rdoChristian

        #region ---Global Variables---
        RadioButton currentReligion = null;
        RadioButton currentRace = null;
        RadioButton currentCru = null;
        RadioButton currentConvo = null;
        private bool firstTime = true;
        private string religion = "";
        private string race = "";
        private string cruInfo = "";
        private string convo = "";
        bool needToProcess;
        private List<Contact> Cary;
        private List<Contact> Earhart;
        private List<Contact> FirstStreet;
        private List<Contact> Harrison;
        private List<Contact> Hawkins;
        private List<Contact> Hillenbrand;
        private List<Contact> Hilltop;
        private List<Contact> Honors;
        private List<Contact> McCutcheon;
        private List<Contact> Meredith;
        private List<Contact> Owen;
        private List<Contact> Pville;
        private List<Contact> Shreve;
        private List<Contact> Tarkington;
        private List<Contact> ThirdStreet;
        private List<Contact> Wiley;
        private List<Contact> Windsor;
#endregion

        public CruContactCard()
        {
            InitializeComponent();
            Cary = new List<Contact>();
            Earhart = new List<Contact>();
            FirstStreet = new List<Contact>();
            Harrison = new List<Contact>();
            Hawkins = new List<Contact>();
            Hillenbrand = new List<Contact>();
            Hilltop = new List<Contact>();
            Honors = new List<Contact>();
            McCutcheon = new List<Contact>();
            Meredith = new List<Contact>();
            Owen = new List<Contact>();
            Pville = new List<Contact>();
            Shreve = new List<Contact>();
            Tarkington = new List<Contact>();
            ThirdStreet = new List<Contact>();
            Wiley = new List<Contact>();
            Windsor = new List<Contact>();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact(tboName.Text, cboGrade.SelectedItem.ToString(), cboGender.SelectedItem.ToString(),
                cboResidence.SelectedItem.ToString(), tboRoom.ToString(), religion, race, trkRelationship.Value, cruInfo, convo);

            #region ---Add to Lists---
            string hall = newContact.getHall();
            if (hall.Contains("Cary"))
            {
                Cary.Add(newContact);
            }
            else if (hall.Contains("Earhart"))
            {
                Earhart.Add(newContact);
            }
            else if (hall.Contains("First Street"))
            {
                FirstStreet.Add(newContact);
            }
            else if (hall.Contains("Harrison"))
            {
                Harrison.Add(newContact);
            }
            else if (hall.Contains("Hawkins"))
            {
                Hawkins.Add(newContact);
            }
            else if (hall.Contains("Hillenbrand"))
            {
                Hillenbrand.Add(newContact);
            }
            else if (hall.Contains("Hilltop"))
            {
                Hilltop.Add(newContact);
            }
            else if (hall.Contains("Honors"))
            {
                Honors.Add(newContact);
            }
            else if (hall.Contains("McCutcheon"))
            {
                McCutcheon.Add(newContact);
            }
            else if (hall.Contains("Meredith"))
            {
                Meredith.Add(newContact);
            }
            else if (hall.Contains("Owen"))
            {
                Owen.Add(newContact);
            }
            else if (hall.Contains("Village"))
            {
                Pville.Add(newContact);
            }
            else if (hall.Contains("Shreve"))
            {
                Shreve.Add(newContact);
            }
            else if (hall.Contains("Tarkington"))
            {
                Tarkington.Add(newContact);
            }
            else if (hall.Contains("Third Street"))
            {
                ThirdStreet.Add(newContact);
            }
            else if (hall.Contains("Wiley"))
            {
                Wiley.Add(newContact);
            }
            else if (hall.Contains("Windsor"))
            {
                Windsor.Add(newContact);
            }
            #endregion
            
            //Reset Card
            tboName.Text = "";
            cboGender.Text = "";
            cboGrade.Text = "";
            cboResidence.Text = "";
            tboRoom.Text = "";
            tboOther.Text = "";
            tboRaceOther.Text = "";
            trkRelationship.Value = 0;
            currentReligion.Checked = false;
            currentRace.Checked = false;
            currentCru.Checked = false;
            currentConvo.Checked = false;
            needToProcess = true;
            menuExit.Enabled = false;
            currentConvo = null;
            currentCru = null;
            currentRace = null;
            currentReligion = null;
            btnDone.Enabled = false;
        }

        #region ---Personal Info Interactables---

        private void tboName_TextChanged(object sender, EventArgs e)
        {
            btnDone.Enabled = checkIfComplete();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDone.Enabled = checkIfComplete();
        }

        private void cboResidence_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDone.Enabled = checkIfComplete();
        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDone.Enabled = checkIfComplete();
        }

        private void tboRoom_TextChanged(object sender, EventArgs e)
        {
            btnDone.Enabled = checkIfComplete();
        }

        #endregion

        #region ---Religion Interactables---

        private void rdoChristian_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Christian";
            currentReligion = rdoChristian;
            //Visual Studio Automatically checked this upon startup, removes said problem until more elegant solution found
            if (firstTime)
            {
                rdoChristian.Checked = false;
                religion = "";
                currentReligion = null;
                firstTime = false;
                return;
            }
            btnDone.Enabled = checkIfComplete();

        }

        private void rdoMuslim_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Muslim";
            currentReligion = rdoMuslim;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoJewish_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Jewish";
            currentReligion = rdoJewish;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoBuddhist_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Buddhist";
            currentReligion = rdoBuddhist;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoHindu_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Hindu";
            currentReligion = rdoHindu;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoTaoist_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Taoist";
            currentReligion = rdoTaoist;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoAtheist_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Atheist";
            currentReligion = rdoAtheist;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoAgnostic_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Agnostic";
            currentReligion = rdoAgnostic;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoUndecided_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Undecided";
            currentReligion = rdoUndecided;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
            tboOther.Enabled = rdoOther.Checked;
        }

        private void tboOther_TextChanged(object sender, EventArgs e)
        {
            this.religion = tboOther.Text;
            btnDone.Enabled = checkIfComplete();
        }


        #endregion

        #region ---Race Interactables---

        private void rdoWhite_CheckedChanged(object sender, EventArgs e)
        {
            race = "White / Caucasian";
            currentRace = rdoWhite;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoBlack_CheckedChanged(object sender, EventArgs e)
        {
            race = "Black / African American";
            currentRace = rdoBlack;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoHispanic_CheckedChanged(object sender, EventArgs e)
        {
            race = "Black / African American";
            currentRace = rdoHispanic;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoNative_CheckedChanged(object sender, EventArgs e)
        {
            race = "Native American / American Indian";
            currentRace = rdoNative;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoAsian_CheckedChanged(object sender, EventArgs e)
        {
            race = "Asian / Pacific Islander";
            currentRace = rdoAsian;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoRaceOther_CheckedChanged(object sender, EventArgs e)
        {
            tboRaceOther.Enabled = rdoRaceOther.Checked;
            currentRace = rdoOther;
        }

        private void tboRaceOther_TextChanged(object sender, EventArgs e)
        {
            this.race = tboRaceOther.Text;
            btnDone.Enabled = checkIfComplete();
        }


        #endregion

        #region ---Cru Info Interactables---

        private void rdoCruYes_CheckedChanged(object sender, EventArgs e)
        {
            this.cruInfo = "Yes";
            currentCru = rdoCruYes;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoCruMaybe_CheckedChanged(object sender, EventArgs e)
        {
            this.cruInfo = "Maybe";
            currentCru = rdoCruMaybe;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoCruNo_CheckedChanged(object sender, EventArgs e)
        {
            this.cruInfo = "No";
            currentCru = rdoCruNo;
            btnDone.Enabled = checkIfComplete();
        }

        #endregion

        #region ---Spiritual Conversation Interactables---

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            this.convo = "Yes";
            currentConvo = rdoYes;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoMaybe_CheckedChanged(object sender, EventArgs e)
        {
            this.convo = "Maybe";
            currentConvo = rdoMaybe;
            btnDone.Enabled = checkIfComplete();
        }

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            this.convo = "No";
            currentConvo = rdoNo;
            btnDone.Enabled = checkIfComplete();
        }

        #endregion

        public bool checkIfComplete()
        {
            if (cboGrade.SelectedItem == null || cboGender.SelectedItem == null || cboResidence.SelectedItem == null
                || tboName.Text == "" || cboGrade.SelectedItem.ToString() == "" || cboGender.SelectedItem.ToString() == ""
                || cboResidence.SelectedItem.ToString() == "" || tboRoom.Text == "")
            {
                return false;
            }

            if (currentConvo == null || currentCru == null || currentRace == null || currentReligion == null)
            {
                return false;
            }
            return true;
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
