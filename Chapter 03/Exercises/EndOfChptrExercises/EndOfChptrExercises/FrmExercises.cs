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
  }
}
