using System.Windows.Forms;
using System.Drawing;

namespace CalculatorWinForms
{
    public class ConfirmClearForm : Form
    {
        private Label lblQuestion;
        private Button buttonYes;
        private Button buttonNo;

        public ConfirmClearForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblQuestion = new Label();
            buttonYes = new Button();
            buttonNo = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Location = new Point(10, 10);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(380, 40);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Ви дійсно хочете очистити вміст калькулятора?";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(86, 80);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(80, 28);
            buttonYes.TabIndex = 1;
            buttonYes.Text = "Так";
            buttonYes.Click += ButtonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.Location = new Point(210, 70);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(80, 28);
            buttonNo.TabIndex = 2;
            buttonNo.Text = "Ні";
            buttonNo.Click += ButtonNo_Click;
            // 
            // ConfirmClearForm
            // 
            ClientSize = new Size(400, 120);
            Controls.Add(lblQuestion);
            Controls.Add(buttonYes);
            Controls.Add(buttonNo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmClearForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Очистка стану калькулятора";
            ResumeLayout(false);
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
