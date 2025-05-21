using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Export;
using DevExpress.XtraReports.Design.Commands;
using DevExpress.XtraSpreadsheet.Import;
using DevExpress.XtraSpreadsheet.Model;
using Microsoft.VisualBasic.Devices;
using System.Windows.Markup.Localizer;

namespace Taschenrechner
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; //To accept the keydown commands

        }

        string Number = "";
        string Operand;
        double NmbOne;
        double NmbTwo;
        double Result;
        bool Shift;

        private void resultClear()
        {
            lblResult.Text = "";
        }

        private void btnNumberOne_Click(object sender, EventArgs e)
        {
            WritingNumber("1");
            resultClear();
        } //Write the digit....

        private void btnNumberTwo_Click(object sender, EventArgs e)
        {
            WritingNumber("2");
            resultClear();
        }

        private void btnNumberThree_Click(object sender, EventArgs e)
        {
            WritingNumber("3");
            resultClear();
        }

        private void btnNumberFour_Click(object sender, EventArgs e)
        {
            WritingNumber("4");
            resultClear();
        }

        private void btnNumberFive_Click(object sender, EventArgs e)
        {
            WritingNumber("5");
            resultClear();
        }

        private void btnNumberSix_Click(object sender, EventArgs e)
        {
            WritingNumber("6");
            resultClear();
        }

        private void btnNumberSeven_Click(object sender, EventArgs e)
        {
            WritingNumber("7");
            resultClear();
        }

        private void btnNumberEight_Click(object sender, EventArgs e)
        {
            WritingNumber("8");
            resultClear();
        }

        private void btnNumberNine_Click(object sender, EventArgs e)
        {
            WritingNumber("9");
            resultClear();
        }

        private void btnNumberZero_Click(object sender, EventArgs e)
        {
            WritingNumber("0");
            resultClear();
        }
        private void btnKomma_Click(object sender, EventArgs e)
        {
            WritingNumber(",");
        } //Write a comma

        private void btnResult_Click(object sender, EventArgs e) //Calculate & Save NumberTwo for calculation
        {
            Number = lblNumberWriting.Text;
            if (double.TryParse(Number, out NmbTwo))
            {
                calculate(Operand);
            }
        }

        private void btnClearCalcHistorie_Click(object sender, EventArgs e)
        {
            memoEditResults.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //-----Key comb. for random-----
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                        randomNumber();
                        break;
                    case Keys.B:
                        randomOperand();
                        break;
                }
            }

            //-----Keys w/ shift-----
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.Oemplus:
                        btnTimes_Click(sender, e);
                        break;
                    case Keys.D7:
                        btnDivided_Click(sender, e);
                        break;
                }
                return;
            }

            //-----Keys without shift-----
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                case Keys.D1:
                    btnNumberOne.PerformClick(); //Alternative - ohne Bedingungen (sender ,e)
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    btnNumberTwo_Click(sender, e);
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    btnNumberThree_Click(sender, e);
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    btnNumberFour_Click(sender, e);
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    btnNumberFive_Click(sender, e);
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    btnNumberSix_Click(sender, e);
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    btnNumberSeven_Click(sender, e);
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    btnNumberEight_Click(sender, e);
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    btnNumberNine_Click(sender, e);
                    break;
                case Keys.NumPad0:
                case Keys.D0:
                    btnNumberZero_Click(sender, e);
                    break;
                case Keys.Enter:
                    btnResult_Click(sender, e);
                    break;
                case Keys.Oemcomma:
                case Keys.Decimal:
                    btnKomma_Click(sender, e);
                    break;
                case Keys.Delete:
                case Keys.Back:
                    bntClear_Click(sender, e);
                    break;
                case Keys.Oemplus:
                case Keys.Add:
                    btnPlus_Click(sender, e);
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    btnMinus_Click(sender, e);
                    break;
                case Keys.Multiply:
                    btnTimes_Click(sender, e);
                    break;
                case Keys.Divide:
                    btnDivided_Click(sender, e);
                    break;
            }
        } //List of keys

        private void WritingNumber(string No)
        {
            Number += No;
            lblNumberWriting.Text = Number;
        } //Create a 'string' (the number), with single digits

        private void btnPlus_Click(object sender, EventArgs e)
        {
            NumberSave("+");
            Operand = "+";
        } //finish the first number

        private void btnMinus_Click(object sender, EventArgs e)
        {
            NumberSave("-");
            Operand = "-";
        } //finish the first number

        private void btnTimes_Click(object sender, EventArgs e)
        {
            NumberSave("*");
            Operand = "*";
        } //finish the first number

        private void btnDivided_Click(object sender, EventArgs e)
        {
            NumberSave("/");
            Operand = "/";
        } //finish first number

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (Number != "")
            {
                NumberSave("²");
                Operand = "²";
                calcSquare(NmbOne);
            } //Square the first Number
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            NumberSave(" Sqrt");
            Operand = "Sqrt";
            calcSquareRoot(NmbOne);
        } //Square Root from the first Number

        private void NumberSave(string Op) //Save first number
        {
            if (double.TryParse(Number, out NmbOne))
            {
                Number += Op;
                lblNumberReady.Text = Number;
                Number = "";
                lblNumberWriting.Text = "";
            }
        }

        private void bntClear_Click(object sender, EventArgs e) //clear the last digit
        {
            if (lblNumberWriting.Text != "")
            {
                Number = Number.Substring(0, Number.Length - 1);
                lblNumberWriting.Text = Number;
            }

        }

        private void btnClear_DoubleClick(object sender, EventArgs e) //clear all digits
        {
            Number = "";
            lblNumberWriting.Text = Number;
            resultClear();
        }

        private void calculate(string Operand)
        {
            switch (Operand)
            {
                case "+":
                    calcPlus(NmbOne, NmbTwo);
                    break;
                case "-":
                    calcMinus(NmbOne, NmbTwo);
                    break;
                case "*":
                    calcTimes(NmbOne, NmbTwo);
                    break;
                case "/":
                    calcDivided(NmbOne, NmbTwo);
                    break;
                default:
                    MessageBox.Show("ERROR");
                    break;
            }
        } //Choosing operand after calc btn

        private void calcPlus(double NmbOne, double NmbTwo)
        {
            Result = NmbOne + NmbTwo;
            result(Result);
        } //Calculation...

        private void calcMinus(double NmbOne, double NmbTwo)
        {
            Result = NmbOne - NmbTwo;
            result(Result);
        }

        private void calcTimes(double NmbOne, double NmbTwo)
        {
            Result = NmbOne * NmbTwo;
            result(Result);
        }

        private void calcDivided(double NmbOne, double NmbTwo)
        {
            if (NmbTwo != 0)
            {
                Result = NmbOne / NmbTwo;
                result(Result);
            }
            else
            {
                lblResult.Text = "Teilen durch 0 nicht erlaubt!";
                lblNumberReady.Text = "";
                lblNumberWriting.Text = "";
                return;
            }
        }

        private void calcSquare(double NmbOne)
        {
            Result = NmbOne * NmbOne;
            result(Result);
        }

        private void calcSquareRoot(double NmbOne)
        {
            Result = Math.Sqrt(NmbOne);
            result(Result);
        }

        private void result(double Result)
        {
            lblNumberReady.Text = "";
            lblNumberWriting.Text = "";
            Number = "";
            oldResults(Result);
            lblResult.Text = Result.ToString();
        } //Result output

        private void oldResults(double Result)
        {
            if (NmbTwo == 0 || Operand == "Sqrt" || Operand == "²")
            {
                memoEditResults.Text += NmbOne.ToString() + " " + Operand.ToString() + " " + " =" + Environment.NewLine + Result.ToString() + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                memoEditResults.Text += NmbOne.ToString() + " " + Operand.ToString() + " " + NmbTwo.ToString() + " =" + Environment.NewLine + Result.ToString() + Environment.NewLine + Environment.NewLine;
            }
        } //old Results output

        private void btnSwitchNegativ_Click(object sender, EventArgs e)
        {
            if (Number == "")
            {
                WritingNumber("-");
            }
        } //Switch betwenn negativ and positiv numbers

        private void randomNumber()
        {
            double random1;

            resultClear();
            Random rnd = new Random();
            random1 = rnd.Next(-1000001, 1000001);
            double random2 = rnd.Next(0, 1);
            Number = random1.ToString();
            lblNumberWriting.Text = Number;
        }

        private void randomOperand()
        {
            string[] Oprnd = { "+", "-", "*", "/", "²", "Sqrt" };
            Random rndO = new Random();
            int i = rndO.Next(1, 6);
            Operand = Oprnd[i];

            if (Operand == "²")
            {
                calcSquare(NmbOne);
            }
            else if (Operand == "Sqrt")
            {
                calcSquareRoot(NmbOne);
            }
            NumberSave(Oprnd[i]);
        }
    }
}