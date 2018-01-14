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

    private void btn3E29_Click(object sender, EventArgs e)
    {
      int n;

      while (true)
      {
        do
        {
          n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter a positive number: ", "Num", ""));
        }

        while (n <= 0);  // Doesn't handle non integers...but works

        if (n >= 1)
        {
          break;
        }
      }

      txtResult.Text =
        $"Input a number: {n}" + Environment.NewLine +
        $"The Table is:-" + Environment.NewLine;

      for(var i = 1; i <= 10; i++)
      {
        if (i == 10)   // Display's the tenth row properly with this
        {
          txtResult.Text += $"{n}       X       {i}     =       {n * i}" + Environment.NewLine;
        }
        else
        {
          txtResult.Text += $"{n}       X       {i}       =       {n * i}" + Environment.NewLine;
        }
      }

    }

    private void btn3E30_Click(object sender, EventArgs e)
    {
      decimal pos = 0m;
      decimal neg = 0m;
      decimal zer = 0m;
      decimal num;

      for (var i = 1; i <= 5; i++)
      {
        num = decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Enter number {i}: ", "Num", ""));

        if (num < 0)
        {
          neg++;
        }
        else if (num == 0)
        {
          zer++;
        }
        else
        {
          pos++;
        }
      }

      txtResult.Text =
        $"Number of positive numbers: {pos}" + Environment.NewLine +
        $"Number of negative numbers: {neg}" + Environment.NewLine +
        $"Number of zero numbers: {zer}";
    }

    private void btn3E31_Click(object sender, EventArgs e)
    {
      // VARIABLES
      // monthly income
      // monthly expenses
      // monthly savings = monthly income - monthly expenses
      // saving ratio = monthly savings / monthly income
      
      double mIncome = double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Enter your monthly income: ", "Num", ""));
      double mExpenses = double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Enter your monthly expenses: ", "Num", ""));
      double mSavings = mIncome - mExpenses;
      double sRatio = mSavings / mIncome;

      txtResult.Text =
        $"Monthly Income: {mIncome:C}" + Environment.NewLine +
        $"Monthly Expenses: {mExpenses:C}" + Environment.NewLine +
        $"Monthly Savings: {mSavings:C}" + Environment.NewLine;

      // CHART
      // Savings Ratio Analysis
      // < 21% Low on Savings
      // 21% - 40% Moderate
      // 41% - 75% Strong
      // Greater than 75% Insane

      if (sRatio < 0.21 && sRatio >= 0)
      {
        txtResult.Text += $"Saving's Ratio Analysis: {Math.Round(sRatio * 100, 2)}% - Low on Savings";
      }
      else if (sRatio > 0.2 && sRatio < 0.41)
      {
        txtResult.Text += $"Saving's Ratio Analysis: {Math.Round(sRatio * 100, 2)}% - Moderate on Savings";
      }
      else if (sRatio > 0.4 && sRatio < 0.76)
      {
        txtResult.Text += $"Saving's Ratio Analysis: {Math.Round(sRatio * 100, 2)}% - Strong on Savings";
      }
      else if (sRatio > 0.75)
      {
        txtResult.Text += $"Saving's Ratio Analysis: {Math.Round(sRatio * 100, 2)}% - Insane on Savings";
      }
      else if (sRatio < 0)
      {
        txtResult.Text += $"Saving's Ratio Analysis: {Math.Round(sRatio * 100, 2)}% - Deficit on Savings";
      }
    }

    private void btn3E32_Click(object sender, EventArgs e)
    {
      // miles per day
      // cost per gallon
      // mpg average
      // parking fees
      // toll fees
      // total people
      // total cost
      // cost per person = total cost / total people
      // total saved = total cost - (cost per person * (total people - 1))

      double milesPerDay = double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Enter your miles per day: ", "Num", ""));
      double costPerGal = double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Enter your cost per gallon of gas: ", "Num", ""));
      double  avgMPG = double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Enter your vehicles average MPG: ", "Num", ""));
      double parkingFees = double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Enter your daily parking fees: ", "Num", ""));
      double tollFees = double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Enter your daily toll fees: ", "Num", ""));
      double totalPeople = double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Enter the total people carpooling: ", "Num", ""));
      double totalCostInd = ((milesPerDay / avgMPG) * costPerGal) + parkingFees + tollFees;
      double totalCostAll = (((milesPerDay / avgMPG) * costPerGal) + parkingFees + tollFees) * totalPeople;
      double costPerPerson = totalCostInd / totalPeople;
      double totalSavedInd = (totalPeople - 1) * costPerPerson;
      double totalSaved = totalCostAll - totalCostInd;

      txtResult.Text =
        $"Individual miles per day: {milesPerDay}    Total miles per day {milesPerDay * totalPeople}" + Environment.NewLine +
        $"Average MPG of vehicles: {avgMPG}" + Environment.NewLine +
        $"Average cost per gallon of gas: {costPerGal:C}" + Environment.NewLine +
        $"Individual parking fees: {parkingFees:C}    Total parking fees: {parkingFees * totalPeople:C}" + Environment.NewLine +
        $"Individual toll fees: {tollFees:C}    Total toll fees: {tollFees * totalPeople:C}" + Environment.NewLine +
        $"Total people car-pooling: {totalPeople}" + Environment.NewLine +
        $"Total cost individually: {totalCostInd:C}    Total cost for all: {totalCostAll:C}" + Environment.NewLine +
        $"Total saved individually: {totalSavedInd:C}    Total saved for all: {totalSaved:C}";
    }
  }
}
