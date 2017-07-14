﻿using System;
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
        RadioButton currentReligion;
        RadioButton currentRace;
        RadioButton currentCru;
        RadioButton currentConvo;
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
        }

        #region ---Religion Interactables---

        private void rdoChristian_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Christian";
            currentReligion = rdoChristian;
        }

        private void rdoMuslim_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Muslim";
            currentReligion = rdoMuslim;
        }

        private void rdoJewish_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Jewish";
            currentReligion = rdoJewish;
        }

        private void rdoBuddhist_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Buddhist";
            currentReligion = rdoBuddhist;
        }

        private void rdoHindu_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Hindu";
            currentReligion = rdoHindu;
        }

        private void rdoTaoist_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Taoist";
            currentReligion = rdoTaoist;
        }

        private void rdoAtheist_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Atheist";
            currentReligion = rdoAtheist;
        }

        private void rdoAgnostic_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Agnostic";
            currentReligion = rdoAgnostic;
        }

        private void rdoUndecided_CheckedChanged(object sender, EventArgs e)
        {
            religion = "Undecided";
            currentReligion = rdoUndecided;
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
            tboOther.Enabled = rdoOther.Checked;
        }

        private void tboOther_TextChanged(object sender, EventArgs e)
        {
            this.religion = tboOther.Text;
        }


        #endregion

        #region ---Race Interactables---

        private void rdoWhite_CheckedChanged(object sender, EventArgs e)
        {
            race = "White / Caucasian";
            currentRace = rdoWhite;
        }

        private void rdoBlack_CheckedChanged(object sender, EventArgs e)
        {
            race = "Black / African American";
            currentRace = rdoBlack;
        }

        private void rdoHispanic_CheckedChanged(object sender, EventArgs e)
        {
            race = "Black / African American";
            currentRace = rdoHispanic;
        }

        private void rdoNative_CheckedChanged(object sender, EventArgs e)
        {
            race = "Native American / American Indian";
            currentRace = rdoNative;
        }

        private void rdoAsian_CheckedChanged(object sender, EventArgs e)
        {
            race = "Asian / Pacific Islander";
            currentRace = rdoAsian;
        }

        private void rdoRaceOther_CheckedChanged(object sender, EventArgs e)
        {
            tboRaceOther.Enabled = rdoRaceOther.Checked;
            currentRace = rdoOther;
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
            currentCru = rdoCruYes;
        }

        private void rdoCruMaybe_CheckedChanged(object sender, EventArgs e)
        {
            this.cruInfo = "Maybe";
            currentCru = rdoCruMaybe;
        }

        private void rdoCruNo_CheckedChanged(object sender, EventArgs e)
        {
            this.cruInfo = "No";
            currentCru = rdoCruNo;
        }

        #endregion

        #region ---Spiritual Conversation Interactables---

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            this.convo = "Yes";
            currentConvo = rdoYes;
        }

        private void rdoMaybe_CheckedChanged(object sender, EventArgs e)
        {
            this.convo = "Maybe";
            currentConvo = rdoMaybe;
        }

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            this.convo = "No";
            currentConvo = rdoNo;
        }

        #endregion
    }
}
