namespace CalculatorWinForms;

public partial class Form1 : Form
{
    private double firstNumber;
    private string operation = "";
    private bool isOperationSelected;

    public Form1()
    {
        InitializeComponent();
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
            lblDisplay.Text = "";

        if (input == "." && lblDisplay.Text.Contains("."))
            return;

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
}