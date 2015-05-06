using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

                await UpdateList(CitiesComboBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Something went wrong :(");
            }

            SubmitButtom.Enabled = true;
        }

        private async void CitiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdateList(CitiesComboBox.SelectedItem.ToString());
        }

        private void TopPlayersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var playerList = _topPlayers.ToList();
            var selectedPlayer = playerList[TopPlayersBox.SelectedIndex];

            PlayerIdTextBox.Text = selectedPlayer.PlayerId.ToString();
            ScoreTextBox.Text = selectedPlayer.Score.ToString();
        }

        private async Task UpdateList(string city)
        {
            TopPlayersBox.Items.Clear();

            _city = CitiesComboBox.SelectedItem.ToString();

            _topPlayers = await _scoreFixer.GetTopPlayers(_city);

            var rank = 1;

            foreach (var player in _topPlayers)
            {
                TopPlayersBox.Items.Add(String.Format("{0}. {1} ({2} points)", rank, player.Name, player.Score));
                rank++;
            }
        }

        private int _playerId;
        private int _score;
        private string _city;
        private ScoreFixer _scoreFixer;
        private IEnumerable<Player> _topPlayers;




    }
}