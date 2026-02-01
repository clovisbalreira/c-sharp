namespace olamunndo_forms
{
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
            btn = new Button();
            ltlImg = new Label();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new Point(264, 292);
            btn.Name = "btn";
            btn.Size = new Size(108, 23);
            btn.TabIndex = 0;
            btn.Text = "Clique em mim";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // ltlImg
            // 
            ltlImg.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ltlImg.Location = new Point(25, 16);
            ltlImg.Name = "ltlImg";
            ltlImg.Size = new Size(534, 57);
            ltlImg.TabIndex = 1;
            ltlImg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ltlImg);
            Controls.Add(btn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Primeiro programa C#";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn;
        private Label ltlImg;
    }
}
