using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        int guess = 0;
        double timer = 3.1;

        Random randGen = new Random();

        SoundPlayer green = new SoundPlayer(Properties.Resources.green);
        SoundPlayer red = new SoundPlayer(Properties.Resources.red);
        SoundPlayer yellow = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer blue = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer mistake = new SoundPlayer(Properties.Resources.mistake);

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0, 0, 220, 220);
            Region buttonRegion = new Region(circlePath);
            greenButton.Region = buttonRegion;

            Matrix transformMatrix = new Matrix();
            transformMatrix.RotateAt(90, new PointF(55, 55));
            buttonRegion.Transform(transformMatrix);
            redButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55));
            buttonRegion.Transform(transformMatrix);
            yellowButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55));
            buttonRegion.Transform(transformMatrix);
            blueButton.Region = buttonRegion;

            Form1.randOrder.Clear();

            greenRupeeBox.Refresh();
            redRupeeBox.Refresh();
            yellowRupeeBox.Refresh();
            blueRupeeBox.Refresh();
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            timer = 3.1;
            int nextColor = randGen.Next(0, 4);
            Form1.randOrder.Add(nextColor);
            ButtonRefresh(1000);

            for (int i = 0; i < Form1.randOrder.Count; i++)
            {
                switch(Form1.randOrder[i])
                {
                    case 0:
                        GreenButton();
                        break;
                    case 1:
                        RedButton();
                        break;
                    case 2:
                        YellowButton();
                        break;
                    case 3:
                        BlueButton();
                        break;
                }
            }
            guess = 0;
            limitTimer.Enabled = true;
        }

        public void GameOver()
        {
            limitTimer.Enabled = false;
            mistake.Play();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen gos = new GameOverScreen();
            f.Controls.Add(gos);
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.randOrder[guess] == 0)
            {
                GreenButton();
                guess++;
                timer = 3.1;
            }
            else
            {
                GameOver();
            }
            PlayerEnd();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.randOrder[guess] == 1)
            {
                RedButton();
                guess++;
                timer = 3.1;
            }
            else
            {
                GameOver();
            }
            PlayerEnd();
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.randOrder[guess] == 2)
            {
                YellowButton();
                guess++;
                timer = 3.1;
            }
            else
            {
                GameOver();
            }
            PlayerEnd();

        }
        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.randOrder[guess] == 3)
            {
                BlueButton();
                guess++;
                timer = 3.1;
            }
            else
            {
                GameOver();
            }
            PlayerEnd();
        }

        private void ButtonRefresh(int time)
        {
            greenButton.Refresh();
            redButton.Refresh();
            yellowButton.Refresh();
            blueButton.Refresh();
            Thread.Sleep(time);
        }

        private void GreenButton()
        {
            green.Play();
            greenButton.BackColor = Color.LawnGreen;
            ButtonRefresh(900);
            greenButton.BackColor = Color.ForestGreen;
            ButtonRefresh(400);

        }
        private void RedButton()
        {
            red.Play();
            redButton.BackColor = Color.Red;
            ButtonRefresh(900);
            redButton.BackColor = Color.DarkRed;
            ButtonRefresh(400);

        }

        private void YellowButton()
        {
            yellow.Play();
            yellowButton.BackColor = Color.Yellow;
            ButtonRefresh(900);
            yellowButton.BackColor = Color.Goldenrod;
            ButtonRefresh(400);

        }

        private void BlueButton()
        {
            blue.Play();
            blueButton.BackColor = Color.Blue;
            ButtonRefresh(900);
            blueButton.BackColor = Color.DarkBlue;
            ButtonRefresh(400);

        }

        private void PlayerEnd()
        {
            if (guess == Form1.randOrder.Count)
            {
                Form1.score++;
                limitTimer.Enabled = false;
                ComputerTurn();
            }
        }

        private void limitTimer_Tick(object sender, EventArgs e)
        {
            timer -= 0.1;
            outputLabel.Text = $"{timer}";

            if (timer <= 0)
            {
                limitTimer.Enabled = false;
                GameOver();
            }
        }
    }
}
