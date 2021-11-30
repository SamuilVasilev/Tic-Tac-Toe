using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Морски_Шахъ
{
    public partial class Form1 : Form
    {
        bool XTurn = true;
        int[] firstLine = new int[] { 0, 0, 0 };
        int[] secondLine = new int[] { 0, 0, 0 };
        int[] thirdLine = new int[] { 0, 0, 0 };
        byte DrawsCount = 0;
        byte XWins = 0;
        byte OWins = 0;
        bool XWinner = true;
        bool draw = false;
        bool AIOn = false;
        bool easyMode = true;
        bool mediumMode = false;
        bool hardMode = false;
        bool endBoolean = false;
        int gamesCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (XTurn)
            {
                X1Click();
            }
            else
            {
                O1Click();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (XTurn)
            {
                X2Click();
            }
            else
            {
                O2Click();
            }
        }

        private void X2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (XTurn)
            {
                X3Click();
            }
            else
            {
                O3Click();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (XTurn)
            {
                X4Click();
            }
            else
            {
                O4Click();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (XTurn)
            {
                X5Click();
            }
            else
            {
                O5Click();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (XTurn)
            {
                X6Click();
            }
            else
            {
                O6Click();
            }
        }

        private void X7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (XTurn)
            {
                X7Click();
            }
            else
            {
                O7Click();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (XTurn)
            {
                X8Click();
            }
            else
            {
                O8Click();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (XTurn)
            {
                X9Click();
            }
            else
            {
                O9Click();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {//MODES
            endBoolean = false;
            //if (easyMode)
            //{
            //    MediumModeChecker.Checked = false;
            //    EasyModeChecker.Checked = true;
            //    easyMode = true;
            //    mediumMode = false;
            //}
            //if (mediumMode)
            //{
            //    MediumModeChecker.Checked = true;
            //    EasyModeChecker.Checked = false;
            //    easyMode = false;
            //    mediumMode = true;
            //}
            if (easyMode && AIOn)
            {
                label1.Text = "easyMode";
            }
            else if (mediumMode && hardMode == false && AIOn)
            {
                label1.Text = "mediumMode";
            }
            else if (hardMode && AIOn)
            {
                label1.Text = "hardMode";
            }
            else
            {
                label1.Text = String.Empty;
            }
            label2.Text = String.Join(" ", firstLine);
            label3.Text = String.Join(" ", secondLine);
            label4.Text = String.Join(" ", thirdLine);
            if (firstLine[0] == firstLine[1] && firstLine[1] == firstLine[2] && firstLine[0] != 0)
            {
                DisableButtons();
                if (firstLine[0] == 1)
                {
                    XWinner = true;
                    end(XWinner, false);
                }
                else
                {
                    XWinner = false;
                    end(XWinner, false);
                }
            }
            else if (secondLine[0] == secondLine[1] && secondLine[1] == secondLine[2] && secondLine[0] != 0)
            {
                DisableButtons();
                if (secondLine[0] == 1)
                {
                    XWinner = true;
                    end(XWinner, false);
                }
                else
                {
                    XWinner = false;
                    end(XWinner, false);
                }
            }
            else if (thirdLine[0] == thirdLine[1] && thirdLine[1] == thirdLine[2] && thirdLine[0] != 0)
            {
                DisableButtons();
                if (thirdLine[0] == 1)
                {
                    XWinner = true;
                    end(XWinner, false);
                }
                else
                {
                    XWinner = false;
                    end(XWinner, false);
                }
            }
            else if (firstLine[0] == secondLine[0] && secondLine[0] == thirdLine[0] && firstLine[0] != 0)
            {
                DisableButtons();
                if (thirdLine[0] == 1)
                {
                    XWinner = true;
                    end(XWinner, false);
                }
                else
                {
                    XWinner = false;
                    end(XWinner, false);
                }
            }
            else if (firstLine[1] == secondLine[1] && secondLine[1] == thirdLine[1] && firstLine[1] != 0)
            {
                DisableButtons();
                if (thirdLine[1] == 1)
                {
                    XWinner = true;
                    end(XWinner, false);
                }
                else
                {
                    XWinner = false;
                    end(XWinner, false);
                }
            }
            else if (firstLine[2] == secondLine[2] && secondLine[2] == thirdLine[2] && firstLine[2] != 0)
            {
                DisableButtons();
                if (thirdLine[2] == 1)
                {
                    XWinner = true;
                    end(XWinner, false);
                }
                else
                {
                    XWinner = false;
                    end(XWinner, false);
                }
            }
            else if (firstLine[0] == secondLine[1] && secondLine[1] == thirdLine[2] && firstLine[0] != 0)
            {
                DisableButtons();
                if (firstLine[0] == 1)
                {
                    XWinner = true;
                    end(XWinner, false);
                }
                else
                {
                    XWinner = false;
                    end(XWinner, false);
                }
            }
            else if (firstLine[2] == secondLine[1] && secondLine[1] == thirdLine[0] && firstLine[2] != 0)
            {
                DisableButtons();
                if (firstLine[2] == 1)
                {
                    XWinner = true;
                    end(XWinner, false);
                }
                else
                {
                    XWinner = false;
                    end(XWinner, false);
                }
            }
            else if (!(String.Join("", firstLine) + String.Join("", secondLine) + String.Join("", thirdLine)).Contains("0"))
            {
                DisableButtons();
                draw = true;
                end(false, draw);
            }
            if (AIOn && XTurn == false && endBoolean == false)
            {
                AITurn();
                XTurn = true;
            }
        }
        public void end(bool XWinner, bool draw)
        {
            endBoolean = true;
            if (draw)
            {
                DrawsCount++;
                label1.Text = "Draw";
                DrawsCountLabel.Text = $"Draws Count: {DrawsCount}";
                draw = false;
            }
            else if (XWinner)
            {
                XWins++;
                label1.Text = "X is the winner";
                XPoints.Text = $"X Points {XWins}";
            }
            else
            {
                OWins++;
                label1.Text = "O is the winner";
                OPoints.Text = $"O Points: {OWins}";
            }
            var t = Task.Delay(1000);
            t.Wait();
            gamesCount++;
            if (gamesCount % 2 == 0)
            {
                XTurn = true;
            }
            else
            {
                XTurn = false;
            }
            firstLine = new int[] { 0, 0, 0 };
            secondLine = new int[] { 0, 0, 0 };
            thirdLine = new int[] { 0, 0, 0 };
            buttonsStatsReset();





        }

        private void XPoints_Click(object sender, EventArgs e)
        {

        }

        private void OPoints_Click(object sender, EventArgs e)
        {

        }

        private void X9_Click(object sender, EventArgs e)
        {

        }
        public void DisableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void buttonsStatsReset()
        {
            O1.Visible = false;
            O2.Visible = false;
            O3.Visible = false;
            O4.Visible = false;
            O5.Visible = false;
            O6.Visible = false;
            O7.Visible = false;
            O8.Visible = false;
            O9.Visible = false;
            X1.Visible = false;
            X2.Visible = false;
            X3.Visible = false;
            X4.Visible = false;
            X5.Visible = false;
            X6.Visible = false;
            X7.Visible = false;
            X8.Visible = false;
            X9.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            label1.Text = String.Empty;
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            XTurn = true;
            firstLine = new int[] { 0, 0, 0 };
            secondLine = new int[] { 0, 0, 0 };
            thirdLine = new int[] { 0, 0, 0 };
            XWinner = true;
            draw = false;
            DrawsCount = 0;
            XWins = 0;
            OWins = 0;
            OPoints.Text = "O Points: 0";
            XPoints.Text = "X Points: 0";
            DrawsCountLabel.Text = "Draws Count: 0";
            buttonsStatsReset();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (AIOn == false)
            {
                AIOn = true;
                AILabel.Text = "AI turned on";
            }
            else
            {
                AIOn = false;
                AILabel.Text = "AI turned off";
            }
        }
        public void AITurn()
        {
            //if (hardMode && thirdLine[0] == 1 && firstLine[2] == 0)
            //{
            //    O3Click();
            //}
            //else if (hardMode && thirdLine[2] == 1 && firstLine[0] == 0)
            //{
            //    O1Click();
            //}
            //else if (hardMode && firstLine[0] == 1 && thirdLine[2] == 0)
            //{
            //    O7Click();
            //}
            //else if (hardMode && firstLine[2] == 1 && thirdLine[0] == 0)
            //{
            //    O9Click();
            //}
            //LINES
            if (firstLine[0] == 2 && firstLine[1] == 2 && firstLine[2] == 0 && mediumMode)
            {
                O3Click();
            }
            else if (firstLine[0] == 2 && firstLine[2] == 2 && firstLine[1] == 0 && mediumMode)
            {
                O2Click();
            }
            else if (firstLine[1] == 2 && firstLine[2] == 2 && firstLine[0] == 0 && mediumMode)
            {
                O1Click();
            }
            else if (secondLine[1] == 2 && secondLine[2] == 2 && secondLine[0] == 0 && mediumMode)
            {
                O6Click();
            }
            else if (secondLine[0] == 2 && secondLine[2] == 2 && secondLine[1] == 0 && mediumMode)
            {
                O5Click();
            }
            else if (secondLine[0] == 2 && secondLine[1] == 2 && secondLine[2] == 0 && mediumMode)
            {
                O4Click();
            }
            else if (thirdLine[1] == 2 && thirdLine[2] == 2 && thirdLine[0] == 0 && mediumMode)
            {
                O9Click();
            }
            else if (thirdLine[0] == 2 && thirdLine[2] == 2 && thirdLine[1] == 0 && mediumMode)
            {
                O8Click();
            }
            else if (thirdLine[0] == 2 && thirdLine[1] == 2 && thirdLine[2] == 0 && mediumMode)
            {
                O7Click();
            } //COLUMNS
            else if (firstLine[0] == 2 && secondLine[0] == 2 && thirdLine[0] == 0 && mediumMode)
            {
                O9Click();
            }
            else if (firstLine[0] == 2 && secondLine[0] == 0 && thirdLine[0] == 2 && mediumMode)
            {
                O6Click();
            }
            else if (firstLine[0] == 0 && secondLine[0] == 2 && thirdLine[0] == 2 && mediumMode)
            {
                O1Click();
            }
            else if (firstLine[1] == 2 && secondLine[1] == 2 && thirdLine[1] == 0 && mediumMode)
            {
                O8Click();
            }
            else if (firstLine[1] == 2 && secondLine[1] == 0 && thirdLine[1] == 2 && mediumMode)
            {
                O5Click();
            }
            else if (firstLine[1] == 0 && secondLine[1] == 2 && thirdLine[1] == 2 && mediumMode)
            {
                O2Click();
            }
            else if (firstLine[2] == 2 && secondLine[2] == 2 && thirdLine[2] == 0 && mediumMode)
            {
                O7Click();
            }
            else if (firstLine[2] == 2 && secondLine[2] == 0 && thirdLine[2] == 2 && mediumMode)
            {
                O4Click();
            }
            else if (firstLine[2] == 0 && secondLine[2] == 2 && thirdLine[2] == 2 && mediumMode)
            {
                O3Click();
            }//DIAGONALS
            else if (firstLine[0] == 2 && secondLine[1] == 2 && thirdLine[2] == 0 && mediumMode)
            {
                O7Click();
            }
            else if (firstLine[0] == 2 && secondLine[1] == 0 && thirdLine[2] == 2 && mediumMode)
            {
                O5Click();
            }
            else if (firstLine[0] == 0 && secondLine[1] == 2 && thirdLine[2] == 2 && mediumMode)
            {
                O1Click();
            }
            else if (firstLine[2] == 2 && secondLine[1] == 2 && thirdLine[0] == 0 && mediumMode)
            {
                O9Click();
            }
            else if (firstLine[2] == 2 && secondLine[1] == 0 && thirdLine[0] == 2 && mediumMode)
            {
                O5Click();
            }
            else if (firstLine[2] == 0 && secondLine[1] == 2 && thirdLine[0] == 2 && mediumMode)
            {
                O3Click();
            }//LINES2
            else if (firstLine[0] == 1 && firstLine[1] == 1 && firstLine[2] == 0 && mediumMode)
            {
                O3Click();
            }
            else if (firstLine[0] == 1 && firstLine[2] == 1 && firstLine[1] == 0 && mediumMode)
            {
                O2Click();
            }
            else if (firstLine[1] == 1 && firstLine[2] == 1 && firstLine[0] == 0 && mediumMode)
            {
                O1Click();
            }
            else if (secondLine[1] == 1 && secondLine[2] == 1 && secondLine[0] == 0 && mediumMode)
            {
                O6Click();
            }
            else if (secondLine[0] == 1 && secondLine[2] == 1 && secondLine[1] == 0 && mediumMode)
            {
                O5Click();
            }
            else if (secondLine[0] == 1 && secondLine[1] == 1 && secondLine[2] == 0 && mediumMode)
            {
                O4Click();
            }
            else if (thirdLine[1] == 1 && thirdLine[2] == 1 && thirdLine[0] == 0 && mediumMode)
            {
                O9Click();
            }
            else if (thirdLine[0] == 1 && thirdLine[2] == 1 && thirdLine[1] == 0 && mediumMode)
            {
                O8Click();
            }
            else if (thirdLine[0] == 1 && thirdLine[1] == 1 && thirdLine[2] == 0 && mediumMode)
            {
                O7Click();
            }//COLUMNS2
            else if (firstLine[0] == 1 && secondLine[0] == 1 && thirdLine[0] == 0 && mediumMode)
            {
                O9Click();
            }
            else if (firstLine[0] == 1 && secondLine[0] == 0 && thirdLine[0] == 1 && mediumMode)
            {
                O6Click();
            }
            else if (firstLine[0] == 0 && secondLine[0] == 1 && thirdLine[0] == 1 && mediumMode)
            {
                O1Click();
            }
            else if (firstLine[1] == 1 && secondLine[1] == 1 && thirdLine[1] == 0 && mediumMode)
            {
                O8Click();
            }
            else if (firstLine[1] == 1 && secondLine[1] == 0 && thirdLine[1] == 1 && mediumMode)
            {
                O5Click();
            }
            else if (firstLine[1] == 0 && secondLine[1] == 1 && thirdLine[1] == 1 && mediumMode)
            {
                O2Click();
            }
            else if (firstLine[2] == 1 && secondLine[2] == 1 && thirdLine[2] == 0 && mediumMode)
            {
                O7Click();
            }
            else if (firstLine[2] == 1 && secondLine[2] == 0 && thirdLine[2] == 1 && mediumMode)
            {
                O4Click();
            }
            else if (firstLine[2] == 0 && secondLine[2] == 1 && thirdLine[2] == 1 && mediumMode)
            {
                O3Click();
            }//DIAGONALS2
            else if (firstLine[0] == 1 && secondLine[1] == 1 && thirdLine[2] == 0 && mediumMode)
            {
                O7Click();
            }
            else if (firstLine[0] == 1 && secondLine[1] == 0 && thirdLine[2] == 1 && mediumMode)
            {
                O5Click();
            }
            else if (firstLine[0] == 0 && secondLine[1] == 1 && thirdLine[2] == 1 && mediumMode)
            {
                O1Click();
            }
            else if (firstLine[2] == 1 && secondLine[1] == 1 && thirdLine[0] == 0 && mediumMode)
            {
                O9Click();
            }
            else if (firstLine[2] == 1 && secondLine[1] == 0 && thirdLine[0] == 1 && mediumMode)
            {
                O5Click();
            }
            else if (firstLine[2] == 0 && secondLine[1] == 1 && thirdLine[0] == 1 && mediumMode)
            {
                O3Click();
            }//HARDMODE
            else if (hardMode && thirdLine[0] == 2 && thirdLine[1] == 1 && secondLine[0] == 0)
            {
                O6Click();
            }
            else if (hardMode && thirdLine[0] == 2 && thirdLine[1] == 1 && secondLine[0] == 2 && secondLine[1] == 0)
            {
                O5Click();
            }
            else if (hardMode && thirdLine[0] == 2 && secondLine[0] == 1 && thirdLine[1] == 0)
            {
                O8Click();
            }
            else if (hardMode && thirdLine[0] == 2 && secondLine[0] == 1 && thirdLine[1] == 2 && secondLine[1] == 0)
            {
                O5Click();
            }
            else if (hardMode && secondLine[1] == 0 && (thirdLine.Contains(1) || secondLine.Contains(1) || firstLine.Contains(1)))
            {
                O5Click();
            }
            else if (hardMode && thirdLine[0] == 2 && firstLine[2] == 0)
            {
                O3Click();
            }
            else if (hardMode && thirdLine[0] == 2 && firstLine[2] == 2 && firstLine[0] == 0 && firstLine[1] == 0 && secondLine[0] == 0)
            {
                O1Click();
            }
            else if (hardMode && thirdLine[0] == 2 && firstLine[2] == 2 && thirdLine[2] == 0 && thirdLine[1] == 0 && secondLine[2] == 0)
            {
                O7Click();
            }
            else if (hardMode && thirdLine[0] == 1 && firstLine[2] == 1 && secondLine[1] == 2)
            {
                if (thirdLine[1] == 0)
                {
                    O8Click();
                }
                else if (secondLine[0] == 0)
                {
                    O6Click();
                }
                else if (secondLine[2] == 0)
                {
                    O4Click();
                }
                else if (firstLine[1] == 0)
                {
                    O2Click();
                }
            }
            else if (hardMode && thirdLine[2] == 1 && firstLine[0] == 1 && secondLine[1] == 2)
            {
                if (thirdLine[1] == 0)
                {
                    O8Click();
                }
                else if (secondLine[0] == 0)
                {
                    O6Click();
                }
                else if (secondLine[2] == 0)
                {
                    O4Click();
                }
                else if (firstLine[1] == 0)
                {
                    O2Click();
                }
            }
            else if (hardMode && thirdLine[0] == 0 && firstLine[2] == 0)
            {
                O9Click();
            }
            else if (hardMode && secondLine[1] == 0)
            {
                O5Click();
            }
            else
            {
                while ((String.Join("", firstLine) + String.Join("", secondLine) + String.Join("", thirdLine)).Contains("0"))
                {
                    Random randomNumber = new Random();
                    int line = randomNumber.Next(3);
                    int index = randomNumber.Next(3);
                    label1.Text = $"{line} {index}";
                    if (line == 0)
                    {
                        if (firstLine[index] == 0)
                        {
                            if (index == 0)
                            {
                                O1Click();
                            }
                            else if (index == 1)
                            {
                                O2Click();
                            }
                            else if (index == 2)
                            {
                                O3Click();
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (line == 1)
                    {
                        if (secondLine[index] == 0)
                        {
                            if (index == 0)
                            {
                                O6Click();
                            }
                            else if (index == 1)
                            {
                                O5Click();
                            }
                            else if (index == 2)
                            {
                                O4Click();
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (line == 2)
                    {
                        if (thirdLine[index] == 0)
                        {
                            if (index == 0)
                            {
                                O9Click();
                            }
                            else if (index == 1)
                            {
                                O8Click();
                            }
                            else if (index == 2)
                            {
                                O7Click();
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            XTurn = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (EasyModeChecker.Checked)
            {
                easyMode = true;
                mediumMode = false;
                hardMode = false;
                MediumModeChecker.Checked = false;
                HardModeChecker.Checked = false;
            }
            else if (MediumModeChecker.Checked == false && HardModeChecker.Checked == false)
            {
                EasyModeChecker.Checked = true;
                easyMode = true;
                mediumMode = false;
                hardMode = false;
                MediumModeChecker.Checked = false;
                HardModeChecker.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (MediumModeChecker.Checked)
            {
                mediumMode = true;
                easyMode = false;
                hardMode = false;
                EasyModeChecker.Checked = false;
                HardModeChecker.Checked = false;
            }
            else if (EasyModeChecker.Checked == false && HardModeChecker.Checked == false)
            {
                MediumModeChecker.Checked = true;
                mediumMode = true;
                easyMode = false;
                hardMode = false;
                EasyModeChecker.Checked = false;
                HardModeChecker.Checked = false;
            }
        }
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (HardModeChecker.Checked)
            {
                mediumMode = true;
                hardMode = true;
                easyMode = false;
                EasyModeChecker.Checked = false;
                MediumModeChecker.Checked = false;
            }
            else if (EasyModeChecker.Checked == false && MediumModeChecker.Checked == false)
            {
                HardModeChecker.Checked = true;
                mediumMode = true;
                hardMode = true;
                easyMode = false;
                EasyModeChecker.Checked = false;
                MediumModeChecker.Checked = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void X1Click()
        {
            X1.Visible = true;
            XTurn = false;
            firstLine[0] = 1;
            button1.Visible = false;
            button1.Enabled = false;
        }
        public void O1Click()
        {
            O1.Visible = true;
            XTurn = true;
            firstLine[0] = 2;
            button1.Visible = false;
            button1.Enabled = false;
        }
        public void X2Click()
        {
            X2.Visible = true;
            XTurn = false;
            firstLine[1] = 1;
            button2.Visible = false;
            button2.Enabled = false;
        }
        public void O2Click()
        {
            O2.Visible = true;
            XTurn = true;
            firstLine[1] = 2;
            button2.Visible = false;
            button2.Enabled = false;
        }
        public void X3Click()
        {
            X3.Visible = true;
            XTurn = false;
            firstLine[2] = 1;
            button3.Visible = false;
            button3.Enabled = false;
        }            
        public void O3Click()
        {
            O3.Visible = true;
            XTurn = true;
            firstLine[2] = 2;
            button3.Visible = false;
            button3.Enabled = false;
        }
        public void X4Click()
        {

            X4.Visible = true;
            XTurn = false;
            secondLine[2] = 1;
            button4.Visible = false;
            button4.Enabled = false;
        }
        public void O4Click()
        {
            O4.Visible = true;
            XTurn = true;
            secondLine[2] = 2;
            button4.Visible = false;
            button4.Enabled = false;
        }
        public void X5Click()
        {
            X5.Visible = true;
            XTurn = false;
            secondLine[1] = 1;
            button5.Visible = false;
            button5.Enabled = false;
        }
        public void O5Click()
        {
            O5.Visible = true;
            XTurn = true;
            secondLine[1] = 2;
            button5.Visible = false;
            button5.Enabled = false;
        }
        public void X6Click()
        {
            X6.Visible = true;
            XTurn = false;
            secondLine[0] = 1;
            button6.Visible = false;
            button6.Enabled = false;
        }
        public void O6Click()
        {
            O6.Visible = true;
            XTurn = true;
            secondLine[0] = 2;
            button6.Visible = false;
            button6.Enabled = false;
        }
        public void X7Click()
        {
            X7.Visible = true;
            XTurn = false;
            thirdLine[2] = 1;
            button7.Visible = false;
            button7.Enabled = false;
        }
        public void O7Click()
        {
            O7.Visible = true;
            XTurn = true;
            thirdLine[2] = 2;
            button7.Visible = false;
            button7.Enabled = false;
        }
        public void X8Click()
        {
            X8.Visible = true;
            XTurn = false;
            thirdLine[1] = 1;
            button8.Visible = false;
            button8.Enabled = false;
        }
        public void O8Click()
        {
            O8.Visible = true;
            XTurn = true;
            thirdLine[1] = 2;
            button8.Visible = false;
            button8.Enabled = false;
        }
        public void X9Click()
        {
            X9.Visible = true;
            XTurn = false;
            thirdLine[0] = 1;
            button9.Visible = false;
            button9.Enabled = false;
        }
        public void O9Click()
        {
            O9.Visible = true;
            XTurn = true;
            thirdLine[0] = 2;
            button9.Visible = false;
            button9.Enabled = false;
        }

        
    }
}