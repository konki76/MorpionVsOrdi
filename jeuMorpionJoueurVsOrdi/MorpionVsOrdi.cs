using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeuMorpionJoueurVsOrdi
{
    public partial class MorpionVsOrdi : Form
    {
        bool win = false;
        bool egalite = false;
        bool Joueur = true;
        int[] t = new int[] {0, 0, 0, 0, 0, 0, 0, 0};
        int compteur;
        int scoreJ;
        int scoreO;

        public MorpionVsOrdi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdCase1.Text = "X";
            cmdCase1.Enabled = false;
            gagne();
            Joueur = false;
            t[0] += 3;
            t[5] += 3;
            t[6] += 3;
            compteur++;
            if (win == false)
                ordi();
        }

        private void cmdCase2_Click(object sender, EventArgs e)
        {
            cmdCase2.Text = "X";
            cmdCase2.Enabled = false;
            gagne();
            Joueur = false;
            t[0] += 3;
            t[4] += 3;
            compteur++;
            if (win == false)
                ordi();
        }

        private void cmdCase3_Click(object sender, EventArgs e)
        {
            cmdCase3.Text = "X";
            cmdCase3.Enabled = false;
            gagne();
            Joueur = false;
            t[0] += 3;
            t[3] += 3;
            t[7] += 3;
            compteur++;
            if (win == false)
                ordi();
        }

        private void cmdCase4_Click(object sender, EventArgs e)
        {
            cmdCase4.Text = "X";
            cmdCase4.Enabled = false;
            gagne();
            Joueur = false;
            t[1] += 3;
            t[5] += 3;
            compteur++;
            if (win == false)
                ordi();
        }

        private void cmdCase5_Click(object sender, EventArgs e)
        {
            cmdCase5.Text = "X";
            cmdCase5.Enabled = false;
            gagne();
            Joueur = false;
            t[1] += 3;
            t[4] += 3;
            t[6] += 3;
            t[7] += 3;
            compteur++;
            if (win == false)
                ordi();
        }

        private void cmdCase6_Click(object sender, EventArgs e)
        {
            cmdCase6.Text = "X";
            cmdCase6.Enabled = false;
            gagne();
            Joueur = false;
            t[1] += 3;
            t[3] += 3;
            compteur++;
            if (win == false)
                ordi();
        }

        private void cmdCase7_Click(object sender, EventArgs e)
        {
            cmdCase7.Text = "X";
            cmdCase7.Enabled = false;
            gagne();
            Joueur = false;
            t[2] += 3;
            t[5] += 3;
            t[7] += 3;
            compteur++;
            if (win == false)
                ordi();
        }

        private void cmdCase8_Click(object sender, EventArgs e)
        {
            cmdCase8.Text = "X";
            cmdCase8.Enabled = false;
            gagne();
            Joueur = false;
            t[2] += 3;
            t[4] += 3;
            compteur++; 
            if (win == false)
                ordi();
        }

        private void cmdCase9_Click(object sender, EventArgs e)
        {
            cmdCase9.Text = "X";
            cmdCase9.Enabled = false;
            gagne();
            Joueur = false;
            t[2] += 3;
            t[3] += 3;
            t[6] += 3;
            compteur++;
            if(win == false)
             ordi();
        }
        private void case1()
        {
            cmdCase1.Text = "O"; cmdCase1.Enabled = false;
            t[0] += 5; t[5] += 5; t[6] += 5;
            compteur++;
        }
        private void case2()
        {
            cmdCase2.Text = "O"; cmdCase2.Enabled = false;
            t[0] += 5; t[4] += 5;
            compteur++;
        }
        private void case3()
        {
            cmdCase3.Text = "O"; cmdCase3.Enabled = false;
            t[0] += 5; t[3] += 5; t[7] += 5;
            compteur++;
        }
        private void case4()
        {
            cmdCase4.Text = "O"; cmdCase4.Enabled = false;
            t[1] += 5; t[5] += 5;
            compteur++;
        }
        private void case5()
        {
            cmdCase5.Text = "O"; cmdCase5.Enabled = false;
            t[1] += 5; t[4] += 5; t[6] += 5; t[7] += 5;
            compteur++;
        }
        private void case6()
        {
            cmdCase6.Text = "O"; cmdCase6.Enabled = false;
            t[1] += 5; t[3] += 5;
            compteur++;
        }
        private void case7()
        {
            cmdCase7.Text = "O"; cmdCase7.Enabled = false;
            t[2] += 5; t[5] += 5; t[7] += 5;
            compteur++;
        }
        private void case8()
        {
            cmdCase8.Text = "O"; cmdCase8.Enabled = false;
            t[2] += 5; t[4] += 5;
            compteur++;
        }
        private void case9()
        {
            cmdCase9.Text = "O"; cmdCase9.Enabled = false;
            t[2] += 5; t[3] += 5; t[6] += 5;
            compteur++;
        }
        private void cmdNew_Click(object sender, EventArgs e)
        {
            cmdCase1.Enabled = true; cmdCase1.Text = "";
            cmdCase2.Enabled = true; cmdCase2.Text = "";
            cmdCase3.Enabled = true; cmdCase3.Text = "";
            cmdCase4.Enabled = true; cmdCase4.Text = "";
            cmdCase5.Enabled = true; cmdCase5.Text = "";
            cmdCase6.Enabled = true; cmdCase6.Text = "";
            cmdCase7.Enabled = true; cmdCase7.Text = "";
            cmdCase8.Enabled = true; cmdCase8.Text = "";
            cmdCase9.Enabled = true; cmdCase9.Text = "";
            txtResult.Text = "C'est à vous de jouer.";
            Joueur = true;
            win = false;
            egalite = false;
            compteur = 0;
            for (int i = 0; i < 8; i++)
                t[i] = 0;
        }
        private void gagne()
        {
            if (cmdCase1.Text == cmdCase2.Text && cmdCase1.Text == cmdCase3.Text && cmdCase1.Text != "" ||
                cmdCase1.Text == cmdCase4.Text && cmdCase1.Text == cmdCase7.Text && cmdCase1.Text != "" ||
                cmdCase5.Text == cmdCase4.Text && cmdCase5.Text == cmdCase6.Text && cmdCase5.Text != "" ||
                cmdCase5.Text == cmdCase2.Text && cmdCase5.Text == cmdCase8.Text && cmdCase5.Text != "" ||
                cmdCase5.Text == cmdCase1.Text && cmdCase5.Text == cmdCase9.Text && cmdCase5.Text != "" ||
                cmdCase5.Text == cmdCase3.Text && cmdCase5.Text == cmdCase7.Text && cmdCase5.Text != "" ||
                cmdCase9.Text == cmdCase7.Text && cmdCase9.Text == cmdCase8.Text && cmdCase9.Text != "" ||
                cmdCase9.Text == cmdCase6.Text && cmdCase9.Text == cmdCase3.Text && cmdCase9.Text != ""
               )
            {
                if (Joueur)
                {
                    txtResult.Text = "Vous avez gagné !";
                    win = true;
                }
                else
                {
                    txtResult.Text = "l'ordinateur a gagné !";
                    win = true;
                }
                cmdCase1.Enabled = false;
                cmdCase2.Enabled = false;
                cmdCase3.Enabled = false;
                cmdCase4.Enabled = false;
                cmdCase5.Enabled = false;
                cmdCase6.Enabled = false;
                cmdCase7.Enabled = false;
                cmdCase8.Enabled = false;
                cmdCase9.Enabled = false;
            }
            if (cmdCase1.Text != "" && cmdCase2.Text != "" && cmdCase3.Text != "" && cmdCase4.Text != "" && 
                cmdCase5.Text != "" && cmdCase6.Text != "" && cmdCase7.Text != "" && cmdCase8.Text != "" && 
                cmdCase9.Text != "" && win == false)
            {
                txtResult.Text = "égalité";
                egalite = true;
            }
        }
        private void ordi()
        {
           
            int k = 0, i;
            for (i = 0; i < 8; i++ )
            {
                if (t[i] == 6)
                    k = i;
                if (t[i] == 10)
                {
                    k = i; i = 8;
                }
            }
            if (Joueur == false && egalite == false)
            {
                if (compteur == 1 && cmdCase1.Text == "X" ||
                    compteur == 1 && cmdCase2.Text == "X" ||
                    compteur == 1 && cmdCase3.Text == "X" ||
                    compteur == 1 && cmdCase4.Text == "X" ||
                    compteur == 1 && cmdCase6.Text == "X" ||
                    compteur == 1 && cmdCase7.Text == "X" ||
                    compteur == 1 && cmdCase8.Text == "X" ||
                    compteur == 1 && cmdCase9.Text == "X")
                {
                    case5();
                }


                if (compteur == 1 && cmdCase5.Text == "X")
                {
                    case1();
                }
                /*     X |   |
                 *       | O | 
                 *       |   | X
                 */
                if (compteur == 3 && cmdCase1.Text == "X" && cmdCase5.Text == "O" && cmdCase9.Text == "X")
                {
                    case2();
                }
                /*       |   | X
                 *       | O | 
                 *     X |   |
                 */
                else if (compteur == 3 && cmdCase3.Text == "X" && cmdCase5.Text == "O" && cmdCase7.Text == "X")
                {
                    case2();
                }
                    /*       | X |
                     *     X | O |
                     *       |   |
                     */
                else if (compteur == 3 && cmdCase2.Text == "X" && cmdCase5.Text == "O" && cmdCase4.Text == "X")
                {
                    case1();
                }
                /*       | X |
                 *       | O | X
                 *       |   |
                 */
                else if (compteur == 3 && cmdCase2.Text == "X" && cmdCase5.Text == "O" && cmdCase6.Text == "X")
                {
                    case1();
                }
                /*       | X |
                 *       | O |
                 *       | X |
                 */
                else if (compteur == 3 && cmdCase2.Text == "X" && cmdCase5.Text == "O" && cmdCase8.Text == "X")
                {
                    case1();
                }
                /*       | X |
                 *       | O |
                 *     X |   |
                 */
                else if (compteur == 3 && cmdCase2.Text == "X" && cmdCase5.Text == "O" && cmdCase7.Text == "X")
                {
                    case1();
                }
                /*       | X |
                 *       | O |
                 *       |   | X
                 */
                else if (compteur == 3 && cmdCase2.Text == "X" && cmdCase5.Text == "O" && cmdCase9.Text == "X")
                {
                    case3();
                }
                /*       |   |
                 *     X | O | X
                 *       |   |
                 */
                else if (compteur == 3 && cmdCase4.Text == "X" && cmdCase5.Text == "O" && cmdCase6.Text == "X")
                {
                    case1();
                }
                /*       |   |
                 *     X | O |
                 *       | X |
                 */
                else if (compteur == 3 && cmdCase4.Text == "X" && cmdCase5.Text == "O" && cmdCase8.Text == "X")
                {
                    case1();
                }
                /*       |   | X
                 *     X | O |
                 *       |   |
                 */
                else if (compteur == 3 && cmdCase4.Text == "X" && cmdCase5.Text == "O" && cmdCase3.Text == "X")
                {
                    case1();
                }
                /*       |   |
                 *     X | O |
                 *       |   | X
                 */
                else if (compteur == 3 && cmdCase4.Text == "X" && cmdCase5.Text == "O" && cmdCase9.Text == "X")
                {
                    case7();
                }

                /*     X |   |
                 *       | O |
                 *       | X | 
                 */
                else if (compteur == 3 && cmdCase8.Text == "X" && cmdCase5.Text == "O" && cmdCase1.Text == "X")
                {
                    case7();
                }
                /*       |   | X
                 *       | O |
                 *       | X | 
                 */
                else if (compteur == 3 && cmdCase8.Text == "X" && cmdCase5.Text == "O" && cmdCase3.Text == "X")
                {
                    case9();
                }
                /*     X |   |
                 *       | O | X
                 *       |   | 
                 */
                else if (compteur == 3 && cmdCase6.Text == "X" && cmdCase5.Text == "O" && cmdCase1.Text == "X")
                {
                    case3();
                }
                /*       |   |
                 *       | O | X
                 *     X |   | 
                 */
                else if (compteur == 3 && cmdCase6.Text == "X" && cmdCase5.Text == "O" && cmdCase7.Text == "X")
                {
                    case9();
                }
                /*       |   |
                 *       | O | X
                 *       | X | 
                 */
                else if (compteur == 3 && cmdCase6.Text == "X" && cmdCase5.Text == "O" && cmdCase8.Text == "X")
                {
                    case9();
                }

                else if (t[k] == 6 && compteur > 2 || t[k] == 10 && compteur > 3)
                {
                    switch (k)
                    {
                        case 0:
                            if (cmdCase1.Enabled)
                            {
                                case1();
                            }
                            else if (cmdCase2.Enabled)
                            {
                                case2();
                            }
                            else if (cmdCase3.Enabled)
                            {
                                case3();
                            }
                            break;
                        case 1:
                            if (cmdCase4.Enabled)
                            {
                                case4();
                            }
                            else if (cmdCase5.Enabled)
                            {
                                case5();
                            }
                            else if (cmdCase6.Enabled)
                            {
                                case6();
                            }
                            break;

                        case 2:
                            if (cmdCase7.Enabled)
                            {
                                case7();
                            }
                            else if (cmdCase8.Enabled)
                            {
                                case8();
                            }
                            else if (cmdCase9.Enabled)
                            {
                                case9();
                            }
                            break;

                        case 3:
                            if (cmdCase3.Enabled)
                            {
                                case3();
                            }
                            else if (cmdCase6.Enabled)
                            {
                                case6();
                            }
                            else if (cmdCase9.Enabled)
                            {
                                case9();
                            }
                            break;

                        case 4:
                            if (cmdCase2.Enabled)
                            {
                                case2();
                            }
                            else if (cmdCase5.Enabled)
                            {
                                case5();
                            }
                            else if (cmdCase8.Enabled)
                            {
                                case8();
                            }
                            break;

                        case 5:
                            if (cmdCase1.Enabled)
                            {
                                case1();
                            }
                            else if (cmdCase4.Enabled)
                            {
                                case4();
                            }
                            else if (cmdCase7.Enabled)
                            {
                                case7();
                            }
                            break;

                        case 6:
                            if (cmdCase1.Enabled)
                            {
                                case1();
                            }
                            else if (cmdCase5.Enabled)
                            {
                                case5();
                            }
                            else if (cmdCase9.Enabled)
                            {
                                case9();
                            }
                            break;

                        case 7:
                            if (cmdCase3.Enabled)
                            {
                                case3();
                            }
                            else if (cmdCase5.Enabled)
                            {
                                case5();
                            }
                            else if (cmdCase7.Enabled)
                            {
                                case7();
                            }
                            break;
                    }
                    compteur++;
                }
                else if (compteur > 3)
                {
                    if (cmdCase1.Enabled)
                    {
                        cmdCase1.Text = "O"; cmdCase1.Enabled = false;
                        t[0] += 5; t[5] += 5; t[6] += 5;
                        compteur++;
                    }
                    else if (cmdCase2.Enabled)
                    {
                        case2();
                    }
                    else if (cmdCase3.Enabled)
                    {
                        case3();
                    }
                    else if (cmdCase4.Enabled)
                    {
                        case4();
                    }
                    else if (cmdCase5.Enabled)
                    {
                        case5();
                    }
                    else if (cmdCase6.Enabled)
                    {
                        case6();
                    }
                    else if (cmdCase7.Enabled)
                    {
                        case7();
                    }
                    else if (cmdCase8.Enabled)
                    {
                        case8();
                    }
                    else if (cmdCase9.Enabled)
                    {
                        case9();
                    }
                }
                gagne();
                Joueur = true;
            }
        }
        
    }
}
