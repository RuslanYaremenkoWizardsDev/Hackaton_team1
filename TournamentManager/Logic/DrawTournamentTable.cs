using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;



namespace TournamentManager
{
    public class DrawTournTable
    {
        int _height = 30;
        int _width = 180;
        Pen _pen;
        List<List<string>> _teams;
        List<string> _teamNames;
        Font font = new Font("Calibri", 14);
        Brush greenBrush = new SolidBrush(Color.Green);
        Brush redBrush = new SolidBrush(Color.Red);
        Brush blackBrush = new SolidBrush(Color.Black);
        StringFormat stringFormat = new StringFormat();
        Point startPoint = new Point();
        public void Initialize()
        {
            _teams = new List<List<string>>();
            _teams.Add(new List<string>());
            for (int i = 0; i < 8; i++)
            {
                _teams[0].Add("Team " + (i + 1).ToString());
            }
            _teams.Add(new List<string>());
            for (int i = 0; i < 4; i++)
            {
                _teams[1].Add("Team " + (2 * i + 1).ToString());
            }
            _teams.Add(new List<string>());
            for (int i = 0; i < 2; i++)
            {
                _teams[2].Add("Team " + (4 * i + 1).ToString());

            }
            _teams.Add(new List<string>());
            _teams[3].Add("Team 1");
        }
        public void Draw(Graphics graphics, Pen pen)
        {


            for (int i = 0; i < _teams.Count; i++)
            {
                for (int j = 0; j < _teams[i].Count; j++)
                {
                    startPoint.X = i * _width;
                    startPoint.Y = j * _height;
                    if (j % 2 == 0)
                    {
                        graphics.FillRectangle(greenBrush, startPoint.X, startPoint.Y, _width, _height);
                        graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, _width, _height);
                    }
                    else
                    {
                        graphics.FillRectangle(redBrush, startPoint.X, startPoint.Y, _width, _height);
                        graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, _width, _height);
                    }

                    graphics.DrawString(_teams[i][j], font, blackBrush, startPoint.X + 4, startPoint.Y + 4, stringFormat);

                }
            }
        }
    }

}

