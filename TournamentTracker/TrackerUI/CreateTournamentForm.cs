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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeams_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();

            WiredUpLists();
        }

        private void WiredUpLists()
        {
            selectTeamDropDown.DataSource = null;

            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;

            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WiredUpLists();
            }
            else
            {
                string message = "Please Select a Team Member";
                string title = "Selection Error";
                MessageBox.Show(message, title);
            }
        }

        private void deleteSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WiredUpLists();
            }
            else
            {
                string message = "Please Select a Team";
                string title = "Selection Error";
                MessageBox.Show(message, title);
            }
        }

        private void deleteSelectedPrizesButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WiredUpLists();
            }
            else
            {
                string message = "Please Select a Prize";
                string title = "Selection Error";
                MessageBox.Show(message, title);
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call createPrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

        }

        //Get Back from the form a prize model
        public void PrizeComplite(PrizeModel model)
        {
            //Get prize model and put it in our list Of selected prizes
            selectedPrizes.Add(model);
            WiredUpLists();

        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WiredUpLists();
        }

        private void createNewTeamLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

    }
}
