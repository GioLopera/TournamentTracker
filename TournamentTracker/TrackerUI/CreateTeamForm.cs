using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form, IMemberRequester
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            //CreateSampleData();
            callingForm = caller;
            WiredUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel {FirstName = "Gio", LastName = "Lopera" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sarah", LastName = "Arnio" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jon", LastName = "Doe" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Dunkan" });
        }

        public void WiredUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMemberListBox.DataSource = null;

            teamMemberListBox.DataSource = selectedTeamMembers;
            teamMemberListBox.DisplayMember = "FullName";

        }

        private void createNewMemberLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Call AddNewMemberForm
            AddNewMemberForm ad = new AddNewMemberForm(this);
            ad.Show();
        }

        public void MemberComplite(PersonModel model)
        {
            selectedTeamMembers.Add(model);
            WiredUpLists();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WiredUpLists(); 
            }
            else
            {
                string message = "Please Select a Team Member";
                string title = "Selection Error";
                MessageBox.Show(message, title);
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WiredUpLists(); 
            }
            else
            {
                string message = "Please Select a Team Member";
                string title = "Selection Error";
                MessageBox.Show(message, title);
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }

    }
}
