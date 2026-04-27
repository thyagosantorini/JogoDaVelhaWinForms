namespace JogoDaVelhaWinForms
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            label1 = new Label();
            lblStatus = new Label();
            btnResetar = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(40, 27);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 60);
            btn1.TabIndex = 0;
            btn1.TabStop = false;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnsClick;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(106, 27);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 60);
            btn2.TabIndex = 1;
            btn2.TabStop = false;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnsClick;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(172, 27);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 60);
            btn3.TabIndex = 2;
            btn3.TabStop = false;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnsClick;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(172, 93);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 60);
            btn6.TabIndex = 5;
            btn6.TabStop = false;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnsClick;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(106, 93);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 60);
            btn5.TabIndex = 4;
            btn5.TabStop = false;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnsClick;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(40, 93);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 60);
            btn4.TabIndex = 3;
            btn4.TabStop = false;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnsClick;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(172, 159);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 60);
            btn9.TabIndex = 8;
            btn9.TabStop = false;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnsClick;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(106, 159);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 60);
            btn8.TabIndex = 7;
            btn8.TabStop = false;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnsClick;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(40, 159);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 60);
            btn7.TabIndex = 6;
            btn7.TabStop = false;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnsClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 243);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 9;
            label1.Text = "STATUS";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(106, 243);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 10;
            // 
            // btnResetar
            // 
            btnResetar.Location = new Point(40, 282);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(192, 35);
            btnResetar.TabIndex = 11;
            btnResetar.Text = "Resetar";
            btnResetar.UseVisualStyleBackColor = true;
            btnResetar.Click += btnResetar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 369);
            Controls.Add(btnResetar);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo Da Velha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Label label1;
        private Label lblStatus;
        private Button btnResetar;
    }
}
