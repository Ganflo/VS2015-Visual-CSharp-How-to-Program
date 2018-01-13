using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndOfChptrExercises
{
  public partial class FrmExercises : Form
  {
    public FrmExercises()
    {
      InitializeComponent();
    }

    private void btn3E24_Click(object sender, EventArgs e)
    {
      int num;

      while (true)
      {
        do
        {
          num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Input a number equal to or higher than zero: ", "Num", ""));
        }

        while (num < 0);  // Still doesn't handle non integers...but works

        if(num >= 0)
        {
          break;
        }
      }

      if (num % 2 == 0)
      {
        txtResult.Text = "The number is even";
      }
      else if (num % 2 != 0)
      {
        txtResult.Text = "The number is odd";
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtResult.Text = "";
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btn3E25_Click(object sender, EventArgs e)
    {
      int num1;
      int num2;

      while (true)
      {
        do
        {
          MessageBox.Show("To complete this exercise you will need to input two positive numbers and we will determine if the first number is a multiple of the second number.");
          num1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("First number: ", "Num", ""));
          num2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Second number: ", "Num", ""));
        }

        while (num1 <= 0 || num2 <= 0);  // Still doesn't handle non integers...but works

        if (num1 >= 1 && num2 >= 1)
        {
          break;
        }
      }

      if ( num2 % num1 == 0)
      {
        txtResult.Text = $"The first number {num1} is a multiple of the second number {num2}.";
      }
      else
      {
        txtResult.Text = $"The first number {num1} is not a multiple of the second number {num2}.";
      }
    }
  }
}
