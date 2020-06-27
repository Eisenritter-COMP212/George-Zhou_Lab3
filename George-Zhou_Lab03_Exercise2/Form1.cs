using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace George_Zhou_Lab03_Exercise2
{
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }

        // Start Async call to Factorial
        private async void buttonCalculateFac_Click(object sender, EventArgs e)
        {
            int number;
            bool isParsable = Int32.TryParse(tBoxFacInput.Text, out number); // Check if the input can be parsed to int
            if (isParsable && number >= 0) // Run this only if the number is parsable and the number is a positive number
            {
                try
                {
                    // Task to perform Factorial calculation in separate thread
                    Task<BigInteger> factorialTask = Task.Run(() => Factorial(number));
                    // wait for Task in separtate thread to complete
                    await factorialTask;
                    //Display result after Task in separate thread completes
                    tBoxResultFac.Text = factorialTask.Result.ToString();
                }
                catch (Exception ex)
                {
                    tBoxResultFac.Text = ex.Message;
                }
            }
            else
            {
                tBoxResultFac.Text = "Please input a valid positive integer";
            }
        }

        private void btnCalcInterest_Click(object sender, EventArgs e)
        {
            double loan;
            double rate;
            double duration;
            // Check if the input can be parsed to double
            bool isParsable = double.TryParse(tbxLoanAmount.Text, out loan) & double.TryParse(tbxIntRate.Text, out rate)
                & double.TryParse(tbxDuration.Text, out duration);
            // Run this only if inputs are all non-negative
            if (isParsable && loan >= 0 && rate >= 0 && duration >= 0)
            {
                try
                {
                    tbxIntResult.Text = Interest(loan, rate, duration).ToString();

                }
                catch (Exception ex)
                {
                    tBoxResultFac.Text = ex.Message;
                }
            }
            else
            {
                tbxIntResult.Text = "Please input a valid number into Loan, Interest Rate, and Duration";
            }

        }

        // Recursive Factorial calculation that retuns a BigInteger
        public BigInteger Factorial(int n) => n == 1 ? 1 : n * Factorial(n - 1);

        // Simple Interest Calculation - Formula A = P (1 + rt)
        public double Interest(double loan, double rate, double duration) => loan * (1 + rate * duration);


    }
}
