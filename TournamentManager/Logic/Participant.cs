using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Logic
{
    class Participant
    {
        public static void AddParticipantToDatabase(string tournamentName, string participantName)
        {

        }
        public static void AddScoreForParticipant(string tournamentName, string participantName, int score)
        {

        }
        public static void DeleteScoreForParticipant(string tournamentName, string participantName, int stage)
        {

        }
        public static void ChangeScoreForParticipant(string tournamentName, string participantName, int stage, int score)
        {

        }
        public static void ClearScoreForParticipant(string tournamentName, string participantName)
        {

        }
        public static void DeleteParticipant(string tournamentName, string participantName)
        {

        }
        public static int GetScoreForParticipant(string tournamentName, string participantName, int stage)
        {
            return 0;
        }
        public static int[] GetScoreForParticipant(string tournamentName, string participantName)
        {
            return new int[] { 0 };
        }
        public static void SetOpponentForParticipant(string tournamentName, string participantName, string opponentName)
        {

        }
        public static string GetOpponentNameOfParticipant(string tournamentName, string participantName)
        {
            return "";
        }
        public static int GetOpponentScoreOfParticipant(string tournamentName, string participantName, int stage)
        {
            return 0;
        }
        public static int[] GetOpponentScoreOfParticipant(string tournamentName, string participantName)
        {
            return new int[] { 0 };
        }
    }
}
