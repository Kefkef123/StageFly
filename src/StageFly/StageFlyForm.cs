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
            _score = Int64.Parse(ScoreTextBox.Text);
            _city = CitiesComboBox.SelectedItem.ToString();

            var updatedPlayer = await _scoreFixer.SetScore(_score, _playerId, _city);

            if (updatedPlayer != null)
            {
                MessageBox.Show($"You are now at place {updatedPlayer.Rank}");

                await UpdateList();
            }
            else
            {
                MessageBox.Show("Something went wrong :(");
            }

            SubmitButtom.Enabled = true;
        }

        private async void StageFlyForm_Load(object sender, EventArgs e)
        {
            var cities = await _scoreFixer.GetCities();

            foreach (var city in cities)
            {
                CitiesComboBox.Items.Add(city.City);
            }
        }

        private async void CitiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdateList();
        }

        private void TopPlayersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var playerList = _topPlayers.ToList();
            var selectedPlayer = playerList[TopPlayersBox.SelectedIndex];

            PlayerIdTextBox.Text = selectedPlayer.PlayerId.ToString();
            ScoreTextBox.Text = selectedPlayer.Score.ToString();
        }

        private async Task UpdateList()
        {
            TopPlayersBox.Items.Clear();

            _city = CitiesComboBox.SelectedItem.ToString();

            _topPlayers = await _scoreFixer.GetTopPlayers(_city);

            var rank = 1;

            foreach (var player in _topPlayers)
            {
                TopPlayersBox.Items.Add($"{rank}. {player.Name} ({player.Score} points)");
                rank++;
            }
        }

        private int _playerId;
        private long _score;
        private string _city;
        private readonly ScoreFixer _scoreFixer;
        private IEnumerable<Player> _topPlayers;
    }
}