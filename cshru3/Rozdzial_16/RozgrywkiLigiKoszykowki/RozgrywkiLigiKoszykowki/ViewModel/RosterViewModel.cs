using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozgrywkiLigiKoszykowki.ViewModel
{
    using Model;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    class RosterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<PlayerViewModel> Starters { get; private set; }
        public ObservableCollection<PlayerViewModel> Bench { get; private set; }

        private Roster _roster;


        private string _teamName;
        public string TeamName
        {
            get { return _teamName; }
            set
            {
                _teamName = value;
                OnPropertyChanged("TeamName");
            }
        }

        public RosterViewModel(Roster roster)
        {
            _roster = roster;

            Starters = new ObservableCollection<PlayerViewModel>();
            Bench = new ObservableCollection<PlayerViewModel>();

            TeamName = _roster.TeamName;

            UpdateRosters();
        }

        private void UpdateRosters()
        {
            var startingPlayers =
                from player in _roster.Players
                where player.Starter
                select player;
            Starters.Clear();
            foreach (Player player in startingPlayers)
                Starters.Add(new PlayerViewModel(player.Name, player.Number));

            var benchPlayers =
                from player in _roster.Players
                where player.Starter == false
                select player;
            Bench.Clear();
            foreach (Player player in benchPlayers)
                Bench.Add(new PlayerViewModel(player.Name, player.Number));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged != null)
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
