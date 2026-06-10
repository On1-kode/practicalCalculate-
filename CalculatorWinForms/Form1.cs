namespace CalculatorWinForms;

public partial class Form1 : Form
{
    private double firstNumber;
    private string operation = "";
    private bool isOperationSelected;

    public Form1()
    {
        InitializeComponent();

        this.KeyPreview = true;
        this.KeyDown += Form1_KeyDown;
    }

    private void numberButton_Click(object sender, EventArgs e)
    {
        string input = ((Button)sender).Text;

        if (isOperationSelected)
        {
            lblDisplay.Text = "";
            isOperationSelected = false;
        }

        if (lblDisplay.Text == "0" && input != ".")
        {
            lblDisplay.Text = "";
        }

        if (input == "." && lblDisplay.Text.Contains("."))
        {
            return;
        }

        lblDisplay.Text += input;
    }

    private void SetOperation(string op)
    {
        firstNumber = double.Parse(lblDisplay.Text);
        operation = op;
        isOperationSelected = true;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        SetOperation("+");
    }

    private void btnSubtract_Click(object sender, EventArgs e)
    {
        SetOperation("-");
    }

    private void btnMultiply_Click(object sender, EventArgs e)
    {
        SetOperation("*");
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
        SetOperation("/");
    }

    private void btnEquals_Click(object sender, EventArgs e)
    {
        double secondNumber = double.Parse(lblDisplay.Text);
        double result = 0;

        switch (operation)
        {
            case "+":
                result = firstNumber + secondNumber;
                break;

            case "-":
                result = firstNumber - secondNumber;
                break;

            case "*":
                result = firstNumber * secondNumber;
                break;

            case "/":
                if (secondNumber == 0)
                {
                    MessageBox.Show("Ділення на нуль неможливе");
                    return;
                }

                result = firstNumber / secondNumber;
                break;
        }

        lblDisplay.Text = result.ToString();
        isOperationSelected = false;
        operation = "";
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        string digit = "";

        if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
        {
            digit = "0";
        }
        else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
        {
            digit = "1";
        }
        else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
        {
            digit = "2";
        }
        else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
        {
            digit = "3";
        }
        else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
        {
            digit = "4";
        }
        else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
        {
            digit = "5";
        }
        else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
        {
            digit = "6";
        }
        else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
        {
            digit = "7";
        }
        else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
        {
            digit = "8";
        }
        else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
        {
            digit = "9";
        }

        if (digit != "")
        {
            if (isOperationSelected)
            {
                lblDisplay.Text = "";
                isOperationSelected = false;
            }

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }

            lblDisplay.Text += digit;
        }
    }

    private void SetCalculatorButtonsEnabled(bool enabled)
    {
        foreach (Control c in tlpButtonsPanel.Controls)
        {
            c.Enabled = enabled;
        }
    }

    private void radioOn_CheckedChanged(object? sender, EventArgs e)
    {
        if (radioOn.Checked)
        {
            SetCalculatorButtonsEnabled(true);
            this.KeyPreview = true;
        }
    }

    private void radioOff_CheckedChanged(object? sender, EventArgs e)
    {
        if (radioOff.Checked)
        {
            SetCalculatorButtonsEnabled(false);
            this.KeyPreview = false;
            lblDisplay.Text = "";
        }
    }

    private void lblDisplay_TextChanged(object? sender, EventArgs e)
    {
        int len = lblDisplay.Text?.Length ?? 0;
        if (len <= 3)
        {
            lblDisplay.ForeColor = Color.Black;
        }
        else if (len <= 8)
        {
            lblDisplay.ForeColor = Color.DarkGreen;
        }
        else
        {
            lblDisplay.ForeColor = Color.DarkRed;
        }
    }

    private void btnClearEntry_Click(object sender, EventArgs e)
    {

    }
}