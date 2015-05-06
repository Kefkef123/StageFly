using System;
using System.Windows.Forms;

namespace StageFly
{
    public partial class StageFlyForm : Form
    {
        public StageFlyForm()
        {
            _scoreFixer = new ScoreFixer();

            InitializeComponent();
        }

        private async void SubmitButtom_Click(object sender, EventArgs e)
        {
            SubmitButtom.Enabled = false;
            _playerId = Int32.Parse(PlayerIdTextBox.Text);
            _score = Int32.Parse(ScoreTextBox.Text);
            _city = CitiesComboBox.SelectedItem.ToString();

            var updatedPlayer = await _scoreFixer.SetScore(_score, _playerId, _city);

            if (updatedPlayer != null)
            {
                MessageBox.Show(String.Format("You are now at place {0}", updatedPlayer.Rank));
            }
            else
            {
                MessageBox.Show("Something went wrong :(");
            }

            SubmitButtom.Enabled = true;
        }

        private int _playerId;
        private int _score;
        private string _city;
        private ScoreFixer _scoreFixer;
    }
}