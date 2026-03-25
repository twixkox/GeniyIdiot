namespace GeniyIdiotWinForm
{
    partial class UserResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(272, 30);
            label1.TabIndex = 1;
            label1.Text = "Статистика прошлых игр";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(69, 42);
            listBox.Name = "listBox";
            listBox.Size = new Size(647, 214);
            listBox.TabIndex = 2;
            // 
            // UserResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox);
            Controls.Add(label1);
            Name = "UserResultForm";
            Text = "UserResultForm";
            Load += UserResultForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox listBox;
    }
}