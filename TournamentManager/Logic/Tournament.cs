using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Logic
{
    public abstract class Tournament
    {
        public string Name { get; set; }
        public string Descripsion { get; set; }
        public string Location { get; set; }
        public DateTime DateEndRegistration { get; set; }
        public DateTime DateStartTournament { get; set; }
        public string TournamentLevel { get; set; }
        public uint CountParticipants { get; set; }

        public enum Level
        {
            Begginer,
            Middle,
            Advanced
        }

        public void CreateVisualisation() 
        {
          
        }

        public void AddParticipant()
        {

        }

        public void RemoveParticipant()
        {

        }

        public void ReplaceParticipant()
        {

        }

        public void SwapParticipants()
        {

        }

        public void SetScore()
        {

        }

    }
}
