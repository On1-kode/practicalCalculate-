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
        radioOn = new RadioButton();
        radioOff = new RadioButton();
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
        SuspendLayout();
        // 
        // pnlDisplay
        // 
        pnlDisplay.BackColor = SystemColors.Control;
        pnlDisplay.Controls.Add(lblDisplay);
        pnlDisplay.Controls.Add(radioOn);
        pnlDisplay.Controls.Add(radioOff);
        pnlDisplay.Dock = DockStyle.Top;
        pnlDisplay.Location = new Point(0, 0);
        pnlDisplay.Margin = new Padding(3, 4, 3, 4);
        pnlDisplay.Name = "pnlDisplay";
        pnlDisplay.Padding = new Padding(6, 7, 6, 7);
        pnlDisplay.Size = new Size(439, 133);
        pnlDisplay.TabIndex = 0;
        // 
        // lblDisplay
        // 
        lblDisplay.BackColor = Color.White;
        lblDisplay.Dock = DockStyle.Top;
        lblDisplay.Font = new Font("Segoe UI", 24F);
        lblDisplay.Location = new Point(6, 7);
        lblDisplay.Name = "lblDisplay";
        lblDisplay.Size = new Size(427, 93);
        lblDisplay.TabIndex = 0;
        lblDisplay.Text = "0";
        lblDisplay.TextAlign = ContentAlignment.MiddleRight;
        lblDisplay.TextChanged += lblDisplay_TextChanged;
        // 
        // radioOn
        // 
        radioOn.AutoSize = true;
        radioOn.Checked = true;
        radioOn.Location = new Point(14, 104);
        radioOn.Margin = new Padding(3, 4, 3, 4);
        radioOn.Name = "radioOn";
        radioOn.Size = new Size(52, 24);
        radioOn.TabIndex = 1;
        radioOn.TabStop = true;
        radioOn.Text = "ON";
        radioOn.UseVisualStyleBackColor = true;
        radioOn.CheckedChanged += radioOn_CheckedChanged;
        // 
        // radioOff
        // 
        radioOff.AutoSize = true;
        radioOff.Location = new Point(80, 104);
        radioOff.Margin = new Padding(3, 4, 3, 4);
        radioOff.Name = "radioOff";
        radioOff.Size = new Size(55, 24);
        radioOff.TabIndex = 2;
        radioOff.TabStop = true;
        radioOff.Text = "OFF";
        radioOff.UseVisualStyleBackColor = true;
        radioOff.CheckedChanged += radioOff_CheckedChanged;
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
        tlpButtonsPanel.Location = new Point(0, 133);
        tlpButtonsPanel.Margin = new Padding(3, 4, 3, 4);
        tlpButtonsPanel.Name = "tlpButtonsPanel";
        tlpButtonsPanel.RowCount = 5;
        tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tlpButtonsPanel.Size = new Size(439, 482);
        tlpButtonsPanel.TabIndex = 1;
        // 
        // btnClearEntry
        // 
        btnClearEntry.Dock = DockStyle.Fill;
        btnClearEntry.Font = new Font("Segoe UI", 14F);
        btnClearEntry.ForeColor = Color.OrangeRed;
        btnClearEntry.Location = new Point(3, 4);
        btnClearEntry.Margin = new Padding(2, 3, 2, 3);
        btnClearEntry.Name = "btnClearEntry";
        btnClearEntry.Size = new Size(104, 89);
        btnClearEntry.TabIndex = 0;
        btnClearEntry.Text = "CE";
        btnClearEntry.UseVisualStyleBackColor = true;
        btnClearEntry.Click += btnClearEntry_Click;
        // 
        // btnBackspace
        // 
        btnBackspace.Dock = DockStyle.Fill;
        btnBackspace.Font = new Font("Segoe UI", 14F);
        btnBackspace.Location = new Point(112, 4);
        btnBackspace.Margin = new Padding(2, 3, 2, 3);
        btnBackspace.Name = "btnBackspace";
        btnBackspace.Size = new Size(104, 89);
        btnBackspace.TabIndex = 1;
        btnBackspace.Text = "←";
        btnBackspace.UseVisualStyleBackColor = true;
        btnBackspace.Click += btnBackspace_Click;
        // 
        // btnPercent
        // 
        btnPercent.Dock = DockStyle.Fill;
        btnPercent.Font = new Font("Segoe UI", 14F);
        btnPercent.Location = new Point(221, 4);
        btnPercent.Margin = new Padding(2, 3, 2, 3);
        btnPercent.Name = "btnPercent";
        btnPercent.Size = new Size(104, 89);
        btnPercent.TabIndex = 2;
        btnPercent.Text = "%";
        btnPercent.UseVisualStyleBackColor = true;
        btnPercent.Click += btnPercent_Click;
        // 
        // btnDivide
        // 
        btnDivide.Dock = DockStyle.Fill;
        btnDivide.Font = new Font("Segoe UI", 14F);
        btnDivide.Location = new Point(330, 4);
        btnDivide.Margin = new Padding(2, 3, 2, 3);
        btnDivide.Name = "btnDivide";
        btnDivide.Size = new Size(106, 89);
        btnDivide.TabIndex = 3;
        btnDivide.Text = "/";
        btnDivide.UseVisualStyleBackColor = true;
        btnDivide.Click += btnDivide_Click;
        // 
        // btnSeven
        // 
        btnSeven.Dock = DockStyle.Fill;
        btnSeven.Font = new Font("Segoe UI", 14F);
        btnSeven.Location = new Point(3, 100);
        btnSeven.Margin = new Padding(2, 3, 2, 3);
        btnSeven.Name = "btnSeven";
        btnSeven.Size = new Size(104, 89);
        btnSeven.TabIndex = 4;
        btnSeven.Text = "7";
        btnSeven.UseVisualStyleBackColor = true;
        btnSeven.Click += numberButton_Click;
        // 
        // btnEight
        // 
        btnEight.Dock = DockStyle.Fill;
        btnEight.Font = new Font("Segoe UI", 14F);
        btnEight.Location = new Point(112, 100);
        btnEight.Margin = new Padding(2, 3, 2, 3);
        btnEight.Name = "btnEight";
        btnEight.Size = new Size(104, 89);
        btnEight.TabIndex = 5;
        btnEight.Text = "8";
        btnEight.UseVisualStyleBackColor = true;
        btnEight.Click += numberButton_Click;
        // 
        // btnNine
        // 
        btnNine.Dock = DockStyle.Fill;
        btnNine.Font = new Font("Segoe UI", 14F);
        btnNine.Location = new Point(221, 100);
        btnNine.Margin = new Padding(2, 3, 2, 3);
        btnNine.Name = "btnNine";
        btnNine.Size = new Size(104, 89);
        btnNine.TabIndex = 6;
        btnNine.Text = "9";
        btnNine.UseVisualStyleBackColor = true;
        btnNine.Click += numberButton_Click;
        // 
        // btnMultiply
        // 
        btnMultiply.Dock = DockStyle.Fill;
        btnMultiply.Font = new Font("Segoe UI", 14F);
        btnMultiply.Location = new Point(330, 100);
        btnMultiply.Margin = new Padding(2, 3, 2, 3);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Size = new Size(106, 89);
        btnMultiply.TabIndex = 7;
        btnMultiply.Text = "*";
        btnMultiply.UseVisualStyleBackColor = true;
        btnMultiply.Click += btnMultiply_Click;
        // 
        // btnFour
        // 
        btnFour.Dock = DockStyle.Fill;
        btnFour.Font = new Font("Segoe UI", 14F);
        btnFour.Location = new Point(3, 196);
        btnFour.Margin = new Padding(2, 3, 2, 3);
        btnFour.Name = "btnFour";
        btnFour.Size = new Size(104, 89);
        btnFour.TabIndex = 8;
        btnFour.Text = "4";
        btnFour.UseVisualStyleBackColor = true;
        btnFour.Click += numberButton_Click;
        // 
        // btnFive
        // 
        btnFive.Dock = DockStyle.Fill;
        btnFive.Font = new Font("Segoe UI", 14F);
        btnFive.Location = new Point(112, 196);
        btnFive.Margin = new Padding(2, 3, 2, 3);
        btnFive.Name = "btnFive";
        btnFive.Size = new Size(104, 89);
        btnFive.TabIndex = 9;
        btnFive.Text = "5";
        btnFive.UseVisualStyleBackColor = true;
        btnFive.Click += numberButton_Click;
        // 
        // btnSix
        // 
        btnSix.Dock = DockStyle.Fill;
        btnSix.Font = new Font("Segoe UI", 14F);
        btnSix.Location = new Point(221, 196);
        btnSix.Margin = new Padding(2, 3, 2, 3);
        btnSix.Name = "btnSix";
        btnSix.Size = new Size(104, 89);
        btnSix.TabIndex = 10;
        btnSix.Text = "6";
        btnSix.UseVisualStyleBackColor = true;
        btnSix.Click += numberButton_Click;
        // 
        // btnSubtract
        // 
        btnSubtract.Dock = DockStyle.Fill;
        btnSubtract.Font = new Font("Segoe UI", 14F);
        btnSubtract.Location = new Point(330, 196);
        btnSubtract.Margin = new Padding(2, 3, 2, 3);
        btnSubtract.Name = "btnSubtract";
        btnSubtract.Size = new Size(106, 89);
        btnSubtract.TabIndex = 11;
        btnSubtract.Text = "-";
        btnSubtract.UseVisualStyleBackColor = true;
        btnSubtract.Click += btnSubtract_Click;
        // 
        // btnOne
        // 
        btnOne.Dock = DockStyle.Fill;
        btnOne.Font = new Font("Segoe UI", 14F);
        btnOne.Location = new Point(3, 292);
        btnOne.Margin = new Padding(2, 3, 2, 3);
        btnOne.Name = "btnOne";
        btnOne.Size = new Size(104, 89);
        btnOne.TabIndex = 12;
        btnOne.Text = "1";
        btnOne.UseVisualStyleBackColor = true;
        btnOne.Click += numberButton_Click;
        // 
        // btnTwo
        // 
        btnTwo.Dock = DockStyle.Fill;
        btnTwo.Font = new Font("Segoe UI", 14F);
        btnTwo.Location = new Point(112, 292);
        btnTwo.Margin = new Padding(2, 3, 2, 3);
        btnTwo.Name = "btnTwo";
        btnTwo.Size = new Size(104, 89);
        btnTwo.TabIndex = 13;
        btnTwo.Text = "2";
        btnTwo.UseVisualStyleBackColor = true;
        btnTwo.Click += numberButton_Click;
        // 
        // btnThree
        // 
        btnThree.Dock = DockStyle.Fill;
        btnThree.Font = new Font("Segoe UI", 14F);
        btnThree.Location = new Point(221, 292);
        btnThree.Margin = new Padding(2, 3, 2, 3);
        btnThree.Name = "btnThree";
        btnThree.Size = new Size(104, 89);
        btnThree.TabIndex = 14;
        btnThree.Text = "3";
        btnThree.UseVisualStyleBackColor = true;
        btnThree.Click += numberButton_Click;
        // 
        // btnAdd
        // 
        btnAdd.Dock = DockStyle.Fill;
        btnAdd.Font = new Font("Segoe UI", 14F);
        btnAdd.Location = new Point(330, 292);
        btnAdd.Margin = new Padding(2, 3, 2, 3);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(106, 89);
        btnAdd.TabIndex = 15;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnZero
        // 
        btnZero.Dock = DockStyle.Fill;
        btnZero.Font = new Font("Segoe UI", 14F);
        btnZero.Location = new Point(3, 388);
        btnZero.Margin = new Padding(2, 3, 2, 3);
        btnZero.Name = "btnZero";
        btnZero.Size = new Size(104, 90);
        btnZero.TabIndex = 16;
        btnZero.Text = "0";
        btnZero.UseVisualStyleBackColor = true;
        btnZero.Click += numberButton_Click;
        // 
        // btnDecimal
        // 
        btnDecimal.Dock = DockStyle.Fill;
        btnDecimal.Font = new Font("Segoe UI", 14F);
        btnDecimal.Location = new Point(112, 388);
        btnDecimal.Margin = new Padding(2, 3, 2, 3);
        btnDecimal.Name = "btnDecimal";
        btnDecimal.Size = new Size(104, 90);
        btnDecimal.TabIndex = 17;
        btnDecimal.Text = ".";
        btnDecimal.UseVisualStyleBackColor = true;
        btnDecimal.Click += numberButton_Click;
        // 
        // btnEquals
        // 
        tlpButtonsPanel.SetColumnSpan(btnEquals, 2);
        btnEquals.Dock = DockStyle.Fill;
        btnEquals.Font = new Font("Segoe UI", 14F);
        btnEquals.Location = new Point(221, 388);
        btnEquals.Margin = new Padding(2, 3, 2, 3);
        btnEquals.Name = "btnEquals";
        btnEquals.Size = new Size(215, 90);
        btnEquals.TabIndex = 18;
        btnEquals.Text = "=";
        btnEquals.UseVisualStyleBackColor = true;
        btnEquals.Click += btnEquals_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(439, 615);
        Controls.Add(tlpButtonsPanel);
        Controls.Add(pnlDisplay);
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        MinimumSize = new Size(409, 544);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Калькулятор";
        pnlDisplay.ResumeLayout(false);
        pnlDisplay.PerformLayout();
        tlpButtonsPanel.ResumeLayout(false);
        ResumeLayout(false);
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
    private RadioButton radioOn;
    private RadioButton radioOff;
}
