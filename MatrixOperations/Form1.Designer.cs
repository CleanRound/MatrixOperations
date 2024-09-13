namespace MatrixApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            matrixTextBox = new TextBox();
            task1Button = new Button();
            task2Button = new Button();
            resultsTextBox = new TextBox();
            SuspendLayout();

            matrixTextBox.Location = new Point(30, 50);
            matrixTextBox.Multiline = true;
            matrixTextBox.Name = "matrixTextBox";
            matrixTextBox.ReadOnly = true;
            matrixTextBox.ScrollBars = ScrollBars.Vertical;
            matrixTextBox.Size = new Size(300, 200);
            matrixTextBox.TabIndex = 0;

            task1Button.Location = new Point(30, 300);
            task1Button.Name = "task1Button";
            task1Button.Size = new Size(100, 40);
            task1Button.TabIndex = 2;
            task1Button.Text = "Task 1";
            task1Button.Click += Task1Button_Click;

            task2Button.Location = new Point(150, 300);
            task2Button.Name = "task2Button";
            task2Button.Size = new Size(100, 40);
            task2Button.TabIndex = 3;
            task2Button.Text = "Task 2";
            task2Button.Click += Task2Button_Click;

            resultsTextBox.CausesValidation = false;
            resultsTextBox.Location = new Point(350, 50);
            resultsTextBox.Multiline = true;
            resultsTextBox.Name = "resultsTextBox";
            resultsTextBox.ReadOnly = true;
            resultsTextBox.ScrollBars = ScrollBars.Vertical;
            resultsTextBox.Size = new Size(200, 200);
            resultsTextBox.TabIndex = 1;

            ClientSize = new Size(600, 400);
            Controls.Add(matrixTextBox);
            Controls.Add(resultsTextBox);
            Controls.Add(task1Button);
            Controls.Add(task2Button);
            Name = "Form1";
            Text = "Matrix Tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox matrixTextBox;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button task1Button;
        private System.Windows.Forms.Button task2Button;
    }
}
