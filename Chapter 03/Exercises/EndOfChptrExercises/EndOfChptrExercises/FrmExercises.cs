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

    private void btn3E26_Click(object sender, EventArgs e)
    {
      const decimal pi = 3.14159m;
      decimal radius = decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter the radius: ", "Num", ""));
      decimal diameter = 2 * radius;
      decimal circumference = pi * diameter;
      decimal area = pi * (radius * radius);
      txtResult.Text = 
        $"Radius: {radius}" + Environment.NewLine + 
        $"Diameter: {diameter}" + Environment.NewLine +
        $"Circumference: {circumference}" + Environment.NewLine + 
        $"Area: {area}";
    }

    private void btn3E27_Click(object sender, EventArgs e)
    {
      txtResult.Text =
        $"The character {'A'} has the value {(int)'A'}" + Environment.NewLine +
        $"The character {'B'} has the value {(int)'B'}" + Environment.NewLine +
        $"The character {'C'} has the value {(int)'C'}" + Environment.NewLine +
        $"The character {'a'} has the value {(int)'a'}" + Environment.NewLine +
        $"The character {'b'} has the value {(int)'b'}" + Environment.NewLine +
        $"The character {'c'} has the value {(int)'c'}" + Environment.NewLine +
        $"The character {'0'} has the value {(int)'0'}" + Environment.NewLine +
        $"The character {'1'} has the value {(int)'1'}" + Environment.NewLine +
        $"The character {'2'} has the value {(int)'2'}" + Environment.NewLine +
        $"The character {'$'} has the value {(int)'$'}" + Environment.NewLine +
        $"The character {'*'} has the value {(int)'*'}" + Environment.NewLine +
        $"The character {'+'} has the value {(int)'+'}" + Environment.NewLine +
        $"The character {'/'} has the value {(int)'/'}" + Environment.NewLine +
        $"The character {' '} has the value {(int)' '}" + Environment.NewLine;
    }

    private void btn3E28_Click(object sender, EventArgs e)
    {
      txtResult.Text = "";

      string userInput = Microsoft.VisualBasic.Interaction.InputBox("Enter a five digit number: ", "Num", "");

      if (userInput.Length <= 5)
      {
        for (int i = 0; i < userInput.Length; i++)
        {
          txtResult.Text += $"{userInput[i]}   ";
        }
      }
      else
      {
        for (int i = 0; i < 5; i++)
        {
          txtResult.Text += $"{userInput[i]}   ";
        }
      }
    }
  }
}
