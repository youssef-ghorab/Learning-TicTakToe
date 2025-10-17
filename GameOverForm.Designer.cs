namespace Tic_Tak_Toe
{
    partial class GameOverForm
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
            this.creatBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.roundsListCmbBx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.winnerNameLbl = new System.Windows.Forms.Label();
            this.p2WinsLbl = new System.Windows.Forms.Label();
            this.p1WinsLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.p2NameLbl = new System.Windows.Forms.Label();
            this.p1NameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creatBtn
            // 
            this.creatBtn.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatBtn.Location = new System.Drawing.Point(19, 386);
            this.creatBtn.Name = "creatBtn";
            this.creatBtn.Size = new System.Drawing.Size(162, 36);
            this.creatBtn.TabIndex = 30;
            this.creatBtn.Text = "New Game";
            this.creatBtn.UseVisualStyleBackColor = true;
            this.creatBtn.Click += new System.EventHandler(this.onNewGame);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Rounds list";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Wins :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Player 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Wins :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Player 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Game Over";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(200, 386);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(162, 36);
            this.cancelBtn.TabIndex = 31;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.onCloseClicked);
            // 
            // roundsListCmbBx
            // 
            this.roundsListCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roundsListCmbBx.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsListCmbBx.FormattingEnabled = true;
            this.roundsListCmbBx.Location = new System.Drawing.Point(92, 264);
            this.roundsListCmbBx.Name = "roundsListCmbBx";
            this.roundsListCmbBx.Size = new System.Drawing.Size(211, 22);
            this.roundsListCmbBx.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Winner";
            // 
            // winnerNameLbl
            // 
            this.winnerNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winnerNameLbl.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerNameLbl.Location = new System.Drawing.Point(-2, 325);
            this.winnerNameLbl.Name = "winnerNameLbl";
            this.winnerNameLbl.Size = new System.Drawing.Size(382, 38);
            this.winnerNameLbl.TabIndex = 34;
            this.winnerNameLbl.Text = "XXXX";
            this.winnerNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2WinsLbl
            // 
            this.p2WinsLbl.AutoSize = true;
            this.p2WinsLbl.Font = new System.Drawing.Font("JetBrains Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2WinsLbl.Location = new System.Drawing.Point(287, 189);
            this.p2WinsLbl.Name = "p2WinsLbl";
            this.p2WinsLbl.Size = new System.Drawing.Size(16, 18);
            this.p2WinsLbl.TabIndex = 36;
            this.p2WinsLbl.Text = "0";
            // 
            // p1WinsLbl
            // 
            this.p1WinsLbl.AutoSize = true;
            this.p1WinsLbl.Font = new System.Drawing.Font("JetBrains Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1WinsLbl.Location = new System.Drawing.Point(287, 134);
            this.p1WinsLbl.Name = "p1WinsLbl";
            this.p1WinsLbl.Size = new System.Drawing.Size(16, 18);
            this.p1WinsLbl.TabIndex = 35;
            this.p1WinsLbl.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("JetBrains Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(89, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 18);
            this.label12.TabIndex = 38;
            this.label12.Text = "Name :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("JetBrains Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(89, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 37;
            this.label13.Text = "Name :";
            // 
            // p2NameLbl
            // 
            this.p2NameLbl.AutoSize = true;
            this.p2NameLbl.Font = new System.Drawing.Font("JetBrains Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2NameLbl.Location = new System.Drawing.Point(141, 189);
            this.p2NameLbl.Name = "p2NameLbl";
            this.p2NameLbl.Size = new System.Drawing.Size(40, 18);
            this.p2NameLbl.TabIndex = 40;
            this.p2NameLbl.Text = "XXXX";
            // 
            // p1NameLbl
            // 
            this.p1NameLbl.AutoSize = true;
            this.p1NameLbl.Font = new System.Drawing.Font("JetBrains Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1NameLbl.Location = new System.Drawing.Point(141, 135);
            this.p1NameLbl.Name = "p1NameLbl";
            this.p1NameLbl.Size = new System.Drawing.Size(40, 18);
            this.p1NameLbl.TabIndex = 39;
            this.p1NameLbl.Text = "YYYY";
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.p2NameLbl);
            this.Controls.Add(this.p1NameLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.p2WinsLbl);
            this.Controls.Add(this.p1WinsLbl);
            this.Controls.Add(this.winnerNameLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roundsListCmbBx);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.creatBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GameOverForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creatBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox roundsListCmbBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label winnerNameLbl;
        private System.Windows.Forms.Label p2WinsLbl;
        private System.Windows.Forms.Label p1WinsLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label p2NameLbl;
        private System.Windows.Forms.Label p1NameLbl;
    }
}