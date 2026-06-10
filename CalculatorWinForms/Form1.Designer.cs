namespace CalculatorWinForms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pnlDisplay = new Panel();
        lblDisplay = new Label();
        tlpButtonsPanel = new TableLayoutPanel();
        btnClearEntry = new Button();
        btnBackspace = new Button();
        btnPercent = new Button();
        btnDivide = new Button();
        btnSeven = new Button();
        btnEight = new Button();
        btnNine = new Button();
        btnMultiply = new Button();
        btnFour = new Button();
        btnFive = new Button();
        btnSix = new Button();
        btnSubtract = new Button();
        btnOne = new Button();
        btnTwo = new Button();
        btnThree = new Button();
        btnAdd = new Button();
        btnZero = new Button();
        btnDecimal = new Button();
        btnEquals = new Button();
        pnlDisplay.SuspendLayout();
        tlpButtonsPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlDisplay
        // 
        pnlDisplay.BackColor = SystemColors.Control;
        pnlDisplay.Controls.Add(lblDisplay);
        pnlDisplay.Dock = DockStyle.Top;
        pnlDisplay.Location = new Point(0, 0);
        pnlDisplay.Name = "pnlDisplay";
        pnlDisplay.Padding = new Padding(5);
        pnlDisplay.Size = new Size(384, 80);
        pnlDisplay.TabIndex = 0;
        // 
        // lblDisplay
        // 
        lblDisplay.BackColor = Color.White;
        lblDisplay.Dock = DockStyle.Fill;
        lblDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        lblDisplay.Location = new Point(5, 5);
        lblDisplay.Name = "lblDisplay";
        lblDisplay.Size = new Size(374, 70);
        lblDisplay.TabIndex = 0;
        lblDisplay.Text = "0";
        lblDisplay.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tlpButtonsPanel
        // 
        tlpButtonsPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        tlpButtonsPanel.ColumnCount = 4;
        tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpButtonsPanel.Controls.Add(btnClearEntry, 0, 0);
        tlpButtonsPanel.Controls.Add(btnBackspace, 1, 0);
        tlpButtonsPanel.Controls.Add(btnPercent, 2, 0);
        tlpButtonsPanel.Controls.Add(btnDivide, 3, 0);
        tlpButtonsPanel.Controls.Add(btnSeven, 0, 1);
        tlpButtonsPanel.Controls.Add(btnEight, 1, 1);
        tlpButtonsPanel.Controls.Add(btnNine, 2, 1);
        tlpButtonsPanel.Controls.Add(btnMultiply, 3, 1);
        tlpButtonsPanel.Controls.Add(btnFour, 0, 2);
        tlpButtonsPanel.Controls.Add(btnFive, 1, 2);
        tlpButtonsPanel.Controls.Add(btnSix, 2, 2);
        tlpButtonsPanel.Controls.Add(btnSubtract, 3, 2);
        tlpButtonsPanel.Controls.Add(btnOne, 0, 3);
        tlpButtonsPanel.Controls.Add(btnTwo, 1, 3);
        tlpButtonsPanel.Controls.Add(btnThree, 2, 3);
        tlpButtonsPanel.Controls.Add(btnAdd, 3, 3);
        tlpButtonsPanel.Controls.Add(btnZero, 0, 4);
        tlpButtonsPanel.Controls.Add(btnDecimal, 1, 4);
        tlpButtonsPanel.Controls.Add(btnEquals, 2, 4);
        tlpButtonsPanel.Dock = DockStyle.Fill;
        tlpButtonsPanel.Location = new Point(0, 80);
        tlpButtonsPanel.Name = "tlpButtonsPanel";
        tlpButtonsPanel.RowCount = 5;
        tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tlpButtonsPanel.Size = new Size(384, 381);
        tlpButtonsPanel.TabIndex = 1;
        // 
        // btnClearEntry
        // 
        btnClearEntry.Dock = DockStyle.Fill;
        btnClearEntry.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnClearEntry.ForeColor = Color.OrangeRed;
        btnClearEntry.Location = new Point(3, 3);
        btnClearEntry.Margin = new Padding(2);
        btnClearEntry.Name = "btnClearEntry";
        btnClearEntry.Size = new Size(90, 71);
        btnClearEntry.TabIndex = 0;
        btnClearEntry.Text = "CE";
        btnClearEntry.UseVisualStyleBackColor = true;
        // 
        // btnBackspace
        // 
        btnBackspace.Dock = DockStyle.Fill;
        btnBackspace.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnBackspace.Location = new Point(98, 3);
        btnBackspace.Margin = new Padding(2);
        btnBackspace.Name = "btnBackspace";
        btnBackspace.Size = new Size(90, 71);
        btnBackspace.TabIndex = 1;
        btnBackspace.Text = "←";
        btnBackspace.UseVisualStyleBackColor = true;
        // 
        // btnPercent
        // 
        btnPercent.Dock = DockStyle.Fill;
        btnPercent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnPercent.Location = new Point(193, 3);
        btnPercent.Margin = new Padding(2);
        btnPercent.Name = "btnPercent";
        btnPercent.Size = new Size(90, 71);
        btnPercent.TabIndex = 2;
        btnPercent.Text = "%";
        btnPercent.UseVisualStyleBackColor = true;
        // 
        // btnDivide
        // 
        btnDivide.Dock = DockStyle.Fill;
        btnDivide.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnDivide.Location = new Point(288, 3);
        btnDivide.Margin = new Padding(2);
        btnDivide.Name = "btnDivide";
        btnDivide.Size = new Size(91, 71);
        btnDivide.TabIndex = 3;
        btnDivide.Text = "/";
        btnDivide.UseVisualStyleBackColor = true;
        btnDivide.Click += btnDivide_Click;
        // 
        // btnSeven
        // 
        btnSeven.Dock = DockStyle.Fill;
        btnSeven.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnSeven.Location = new Point(3, 79);
        btnSeven.Margin = new Padding(2);
        btnSeven.Name = "btnSeven";
        btnSeven.Size = new Size(90, 71);
        btnSeven.TabIndex = 4;
        btnSeven.Text = "7";
        btnSeven.UseVisualStyleBackColor = true;
        btnSeven.Click += numberButton_Click;
        // 
        // btnEight
        // 
        btnEight.Dock = DockStyle.Fill;
        btnEight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnEight.Location = new Point(98, 79);
        btnEight.Margin = new Padding(2);
        btnEight.Name = "btnEight";
        btnEight.Size = new Size(90, 71);
        btnEight.TabIndex = 5;
        btnEight.Text = "8";
        btnEight.UseVisualStyleBackColor = true;
        btnEight.Click += numberButton_Click;
        // 
        // btnNine
        // 
        btnNine.Dock = DockStyle.Fill;
        btnNine.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnNine.Location = new Point(193, 79);
        btnNine.Margin = new Padding(2);
        btnNine.Name = "btnNine";
        btnNine.Size = new Size(90, 71);
        btnNine.TabIndex = 6;
        btnNine.Text = "9";
        btnNine.UseVisualStyleBackColor = true;
        btnNine.Click += numberButton_Click;
        // 
        // btnMultiply
        // 
        btnMultiply.Dock = DockStyle.Fill;
        btnMultiply.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnMultiply.Location = new Point(288, 79);
        btnMultiply.Margin = new Padding(2);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Size = new Size(91, 71);
        btnMultiply.TabIndex = 7;
        btnMultiply.Text = "*";
        btnMultiply.UseVisualStyleBackColor = true;
        btnMultiply.Click += btnMultiply_Click;
        // 
        // btnFour
        // 
        btnFour.Dock = DockStyle.Fill;
        btnFour.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnFour.Location = new Point(3, 155);
        btnFour.Margin = new Padding(2);
        btnFour.Name = "btnFour";
        btnFour.Size = new Size(90, 71);
        btnFour.TabIndex = 8;
        btnFour.Text = "4";
        btnFour.UseVisualStyleBackColor = true;
        btnFour.Click += numberButton_Click;
        // 
        // btnFive
        // 
        btnFive.Dock = DockStyle.Fill;
        btnFive.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnFive.Location = new Point(98, 155);
        btnFive.Margin = new Padding(2);
        btnFive.Name = "btnFive";
        btnFive.Size = new Size(90, 71);
        btnFive.TabIndex = 9;
        btnFive.Text = "5";
        btnFive.UseVisualStyleBackColor = true;
        btnFive.Click += numberButton_Click;
        // 
        // btnSix
        // 
        btnSix.Dock = DockStyle.Fill;
        btnSix.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnSix.Location = new Point(193, 155);
        btnSix.Margin = new Padding(2);
        btnSix.Name = "btnSix";
        btnSix.Size = new Size(90, 71);
        btnSix.TabIndex = 10;
        btnSix.Text = "6";
        btnSix.UseVisualStyleBackColor = true;
        btnSix.Click += numberButton_Click;
        // 
        // btnSubtract
        // 
        btnSubtract.Dock = DockStyle.Fill;
        btnSubtract.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnSubtract.Location = new Point(288, 155);
        btnSubtract.Margin = new Padding(2);
        btnSubtract.Name = "btnSubtract";
        btnSubtract.Size = new Size(91, 71);
        btnSubtract.TabIndex = 11;
        btnSubtract.Text = "-";
        btnSubtract.UseVisualStyleBackColor = true;
        btnSubtract.Click += btnSubtract_Click;
        // 
        // btnOne
        // 
        btnOne.Dock = DockStyle.Fill;
        btnOne.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnOne.Location = new Point(3, 231);
        btnOne.Margin = new Padding(2);
        btnOne.Name = "btnOne";
        btnOne.Size = new Size(90, 71);
        btnOne.TabIndex = 12;
        btnOne.Text = "1";
        btnOne.UseVisualStyleBackColor = true;
        btnOne.Click += numberButton_Click;
        // 
        // btnTwo
        // 
        btnTwo.Dock = DockStyle.Fill;
        btnTwo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnTwo.Location = new Point(98, 231);
        btnTwo.Margin = new Padding(2);
        btnTwo.Name = "btnTwo";
        btnTwo.Size = new Size(90, 71);
        btnTwo.TabIndex = 13;
        btnTwo.Text = "2";
        btnTwo.UseVisualStyleBackColor = true;
        btnTwo.Click += numberButton_Click;
        // 
        // btnThree
        // 
        btnThree.Dock = DockStyle.Fill;
        btnThree.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnThree.Location = new Point(193, 231);
        btnThree.Margin = new Padding(2);
        btnThree.Name = "btnThree";
        btnThree.Size = new Size(90, 71);
        btnThree.TabIndex = 14;
        btnThree.Text = "3";
        btnThree.UseVisualStyleBackColor = true;
        btnThree.Click += numberButton_Click;
        // 
        // btnAdd
        // 
        btnAdd.Dock = DockStyle.Fill;
        btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnAdd.Location = new Point(288, 231);
        btnAdd.Margin = new Padding(2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(91, 71);
        btnAdd.TabIndex = 15;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnZero
        // 
        btnZero.Dock = DockStyle.Fill;
        btnZero.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnZero.Location = new Point(3, 307);
        btnZero.Margin = new Padding(2);
        btnZero.Name = "btnZero";
        btnZero.Size = new Size(90, 71);
        btnZero.TabIndex = 16;
        btnZero.Text = "0";
        btnZero.UseVisualStyleBackColor = true;
        btnZero.Click += numberButton_Click;
        // 
        // btnDecimal
        // 
        btnDecimal.Dock = DockStyle.Fill;
        btnDecimal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnDecimal.Location = new Point(98, 307);
        btnDecimal.Margin = new Padding(2);
        btnDecimal.Name = "btnDecimal";
        btnDecimal.Size = new Size(90, 71);
        btnDecimal.TabIndex = 17;
        btnDecimal.Text = ".";
        btnDecimal.UseVisualStyleBackColor = true;
        btnDecimal.Click += numberButton_Click;
        // 
        // btnEquals
        // 
        tlpButtonsPanel.SetColumnSpan(btnEquals, 2);
        btnEquals.Dock = DockStyle.Fill;
        btnEquals.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        btnEquals.Location = new Point(193, 307);
        btnEquals.Margin = new Padding(2);
        btnEquals.Name = "btnEquals";
        btnEquals.Size = new Size(185, 71);
        btnEquals.TabIndex = 18;
        btnEquals.Text = "=";
        btnEquals.UseVisualStyleBackColor = true;
        btnEquals.Click += btnEquals_Click;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(384, 461);
        this.Controls.Add(tlpButtonsPanel);
        this.Controls.Add(pnlDisplay);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.MinimumSize = new Size(360, 420);
        this.Name = "mainCalculatorForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Калькулятор";
        pnlDisplay.ResumeLayout(false);
        tlpButtonsPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel pnlDisplay;
    private Label lblDisplay;
    private TableLayoutPanel tlpButtonsPanel;
    private Button btnClearEntry;
    private Button btnBackspace;
    private Button btnPercent;
    private Button btnDivide;
    private Button btnSeven;
    private Button btnEight;
    private Button btnNine;
    private Button btnMultiply;
    private Button btnFour;
    private Button btnFive;
    private Button btnSix;
    private Button btnSubtract;
    private Button btnOne;
    private Button btnTwo;
    private Button btnThree;
    private Button btnAdd;
    private Button btnZero;
    private Button btnDecimal;
    private Button btnEquals;
}
