using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Logic
{
    class Participant
    {
        public static void AddParticipantToDatabase(string participantName)
        {

        }
        public static void AddScoreForParticipant(string participantName, int score)
        {

        }
        public static void DeleteScoreForParticipant(string participantName, int stage)
        {

        }
        public static void ChangeScoreForParticipant(string participantName, int stage, int score)
        {

        }
        public static void ClearScoreForParticipant(string participantName)
        {

        }
        public static void DeleteParticipant(string participantName)
        {

        }
        public static int GetScoreForParticipant(string participantName, int stage)
        {
            return 0;
        }
        public static int[] GetScoreForParticipant(string participantName)
        {
            return new int[] { 0 };
        }
        public static void SetOpponentForParticipant(string participantName, string opponentName)
        {

        }
        public static string GetOpponentNameOfParticipant(string participantName)
        {
            return "";
        }
        public static int GetOpponentScoreOfParticipant(string participantName, int stage)
        {
            return 0;
        }
        public static int[] GetOpponentScoreOfParticipant(string participantName)
        {
            return new int[] { 0 };
        }
    }
}
