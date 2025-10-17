namespace Tic_Tak_Toe
{
    partial class GameForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cell3Lbl = new System.Windows.Forms.Label();
            this.cell2Lbl = new System.Windows.Forms.Label();
            this.cell1Lbl = new System.Windows.Forms.Label();
            this.cell6Lbl = new System.Windows.Forms.Label();
            this.cell5Lbl = new System.Windows.Forms.Label();
            this.cell4Lbl = new System.Windows.Forms.Label();
            this.cell9Lbl = new System.Windows.Forms.Label();
            this.cell8Lbl = new System.Windows.Forms.Label();
            this.cell7Lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p2BgPnl = new System.Windows.Forms.Panel();
            this.p2SymboleLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.p1WinsLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.p1BgPnl = new System.Windows.Forms.Panel();
            this.p1SymboleLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.p2WinsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p2NameLbl = new System.Windows.Forms.Label();
            this.p1NameLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roundWinnerLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.turnOfLbl = new System.Windows.Forms.Label();
            this.roundNumberLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalRoundsLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roundsListCmbBx = new System.Windows.Forms.ComboBox();
            this.roundsRemaindLbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gameWinnerLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nextRoundBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.p2BgPnl.SuspendLayout();
            this.p1BgPnl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.cell3Lbl);
            this.panel1.Controls.Add(this.cell2Lbl);
            this.panel1.Controls.Add(this.cell1Lbl);
            this.panel1.Controls.Add(this.cell6Lbl);
            this.panel1.Controls.Add(this.cell5Lbl);
            this.panel1.Controls.Add(this.cell4Lbl);
            this.panel1.Controls.Add(this.cell9Lbl);
            this.panel1.Controls.Add(this.cell8Lbl);
            this.panel1.Controls.Add(this.cell7Lbl);
            this.panel1.Location = new System.Drawing.Point(333, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 460);
            this.panel1.TabIndex = 1;
            // 
            // cell3Lbl
            // 
            this.cell3Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cell3Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell3Lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cell3Lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell3Lbl.Location = new System.Drawing.Point(299, 32);
            this.cell3Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.cell3Lbl.Name = "cell3Lbl";
            this.cell3Lbl.Size = new System.Drawing.Size(133, 133);
            this.cell3Lbl.TabIndex = 11;
            this.cell3Lbl.Tag = "0,2";
            this.cell3Lbl.Text = "?";
            this.cell3Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cell3Lbl.Click += new System.EventHandler(this.onCellClick);
            // 
            // cell2Lbl
            // 
            this.cell2Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cell2Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell2Lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cell2Lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell2Lbl.Location = new System.Drawing.Point(166, 32);
            this.cell2Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.cell2Lbl.Name = "cell2Lbl";
            this.cell2Lbl.Size = new System.Drawing.Size(133, 133);
            this.cell2Lbl.TabIndex = 10;
            this.cell2Lbl.Tag = "0,1";
            this.cell2Lbl.Text = "?";
            this.cell2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cell2Lbl.Click += new System.EventHandler(this.onCellClick);
            // 
            // cell1Lbl
            // 
            this.cell1Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cell1Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell1Lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cell1Lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell1Lbl.Location = new System.Drawing.Point(33, 32);
            this.cell1Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.cell1Lbl.Name = "cell1Lbl";
            this.cell1Lbl.Size = new System.Drawing.Size(133, 133);
            this.cell1Lbl.TabIndex = 9;
            this.cell1Lbl.Tag = "0,0";
            this.cell1Lbl.Text = "?";
            this.cell1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cell1Lbl.Click += new System.EventHandler(this.onCellClick);
            // 
            // cell6Lbl
            // 
            this.cell6Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cell6Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell6Lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cell6Lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell6Lbl.Location = new System.Drawing.Point(299, 165);
            this.cell6Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.cell6Lbl.Name = "cell6Lbl";
            this.cell6Lbl.Size = new System.Drawing.Size(133, 133);
            this.cell6Lbl.TabIndex = 8;
            this.cell6Lbl.Tag = "1,2";
            this.cell6Lbl.Text = "?";
            this.cell6Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cell6Lbl.Click += new System.EventHandler(this.onCellClick);
            // 
            // cell5Lbl
            // 
            this.cell5Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cell5Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell5Lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cell5Lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell5Lbl.Location = new System.Drawing.Point(166, 165);
            this.cell5Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.cell5Lbl.Name = "cell5Lbl";
            this.cell5Lbl.Size = new System.Drawing.Size(133, 133);
            this.cell5Lbl.TabIndex = 7;
            this.cell5Lbl.Tag = "1,1";
            this.cell5Lbl.Text = "?";
            this.cell5Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cell5Lbl.Click += new System.EventHandler(this.onCellClick);
            // 
            // cell4Lbl
            // 
            this.cell4Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cell4Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell4Lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cell4Lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell4Lbl.Location = new System.Drawing.Point(33, 165);
            this.cell4Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.cell4Lbl.Name = "cell4Lbl";
            this.cell4Lbl.Size = new System.Drawing.Size(133, 133);
            this.cell4Lbl.TabIndex = 6;
            this.cell4Lbl.Tag = "1,0";
            this.cell4Lbl.Text = "?";
            this.cell4Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cell4Lbl.Click += new System.EventHandler(this.onCellClick);
            // 
            // cell9Lbl
            // 
            this.cell9Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cell9Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell9Lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cell9Lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell9Lbl.Location = new System.Drawing.Point(300, 298);
            this.cell9Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.cell9Lbl.Name = "cell9Lbl";
            this.cell9Lbl.Size = new System.Drawing.Size(133, 133);
            this.cell9Lbl.TabIndex = 5;
            this.cell9Lbl.Tag = "2,2";
            this.cell9Lbl.Text = "?";
            this.cell9Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cell9Lbl.Click += new System.EventHandler(this.onCellClick);
            // 
            // cell8Lbl
            // 
            this.cell8Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cell8Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell8Lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cell8Lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell8Lbl.Location = new System.Drawing.Point(166, 298);
            this.cell8Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.cell8Lbl.Name = "cell8Lbl";
            this.cell8Lbl.Size = new System.Drawing.Size(133, 133);
            this.cell8Lbl.TabIndex = 4;
            this.cell8Lbl.Tag = "2,1";
            this.cell8Lbl.Text = "?";
            this.cell8Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cell8Lbl.Click += new System.EventHandler(this.onCellClick);
            // 
            // cell7Lbl
            // 
            this.cell7Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cell7Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell7Lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cell7Lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell7Lbl.Location = new System.Drawing.Point(34, 296);
            this.cell7Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.cell7Lbl.Name = "cell7Lbl";
            this.cell7Lbl.Size = new System.Drawing.Size(133, 133);
            this.cell7Lbl.TabIndex = 3;
            this.cell7Lbl.Tag = "2,0";
            this.cell7Lbl.Text = "?";
            this.cell7Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cell7Lbl.Click += new System.EventHandler(this.onCellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.p2BgPnl);
            this.groupBox1.Controls.Add(this.p1BgPnl);
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // p2BgPnl
            // 
            this.p2BgPnl.Controls.Add(this.p2NameLbl);
            this.p2BgPnl.Controls.Add(this.p2SymboleLbl);
            this.p2BgPnl.Controls.Add(this.label9);
            this.p2BgPnl.Controls.Add(this.p1WinsLbl);
            this.p2BgPnl.Controls.Add(this.label6);
            this.p2BgPnl.Location = new System.Drawing.Point(18, 90);
            this.p2BgPnl.Name = "p2BgPnl";
            this.p2BgPnl.Size = new System.Drawing.Size(220, 52);
            this.p2BgPnl.TabIndex = 17;
            // 
            // p2SymboleLbl
            // 
            this.p2SymboleLbl.AutoSize = true;
            this.p2SymboleLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2SymboleLbl.Location = new System.Drawing.Point(186, 25);
            this.p2SymboleLbl.Name = "p2SymboleLbl";
            this.p2SymboleLbl.Size = new System.Drawing.Size(14, 14);
            this.p2SymboleLbl.TabIndex = 18;
            this.p2SymboleLbl.Text = "O";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "symbole :";
            // 
            // p1WinsLbl
            // 
            this.p1WinsLbl.AutoSize = true;
            this.p1WinsLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1WinsLbl.Location = new System.Drawing.Point(81, 25);
            this.p1WinsLbl.Name = "p1WinsLbl";
            this.p1WinsLbl.Size = new System.Drawing.Size(14, 14);
            this.p1WinsLbl.TabIndex = 14;
            this.p1WinsLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "wins :";
            // 
            // p1BgPnl
            // 
            this.p1BgPnl.Controls.Add(this.p1NameLbl);
            this.p1BgPnl.Controls.Add(this.p1SymboleLbl);
            this.p1BgPnl.Controls.Add(this.label8);
            this.p1BgPnl.Controls.Add(this.p2WinsLbl);
            this.p1BgPnl.Controls.Add(this.label1);
            this.p1BgPnl.Location = new System.Drawing.Point(17, 30);
            this.p1BgPnl.Name = "p1BgPnl";
            this.p1BgPnl.Size = new System.Drawing.Size(220, 52);
            this.p1BgPnl.TabIndex = 16;
            // 
            // p1SymboleLbl
            // 
            this.p1SymboleLbl.AutoSize = true;
            this.p1SymboleLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1SymboleLbl.Location = new System.Drawing.Point(187, 28);
            this.p1SymboleLbl.Name = "p1SymboleLbl";
            this.p1SymboleLbl.Size = new System.Drawing.Size(14, 14);
            this.p1SymboleLbl.TabIndex = 17;
            this.p1SymboleLbl.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "symbole :";
            // 
            // p2WinsLbl
            // 
            this.p2WinsLbl.AutoSize = true;
            this.p2WinsLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2WinsLbl.Location = new System.Drawing.Point(82, 28);
            this.p2WinsLbl.Name = "p2WinsLbl";
            this.p2WinsLbl.Size = new System.Drawing.Size(14, 14);
            this.p2WinsLbl.TabIndex = 15;
            this.p2WinsLbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "wins :";
            // 
            // p2NameLbl
            // 
            this.p2NameLbl.AutoSize = true;
            this.p2NameLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2NameLbl.Location = new System.Drawing.Point(10, 4);
            this.p2NameLbl.Name = "p2NameLbl";
            this.p2NameLbl.Size = new System.Drawing.Size(96, 18);
            this.p2NameLbl.TabIndex = 11;
            this.p2NameLbl.Text = "In progress";
            // 
            // p1NameLbl
            // 
            this.p1NameLbl.AutoSize = true;
            this.p1NameLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1NameLbl.Location = new System.Drawing.Point(11, 4);
            this.p1NameLbl.Name = "p1NameLbl";
            this.p1NameLbl.Size = new System.Drawing.Size(96, 18);
            this.p1NameLbl.TabIndex = 10;
            this.p1NameLbl.Text = "In progress";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.roundWinnerLbl);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.turnOfLbl);
            this.groupBox2.Controls.Add(this.roundNumberLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("JetBrains Mono Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Round State";
            // 
            // roundWinnerLbl
            // 
            this.roundWinnerLbl.AutoSize = true;
            this.roundWinnerLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundWinnerLbl.Location = new System.Drawing.Point(154, 94);
            this.roundWinnerLbl.Name = "roundWinnerLbl";
            this.roundWinnerLbl.Size = new System.Drawing.Size(84, 14);
            this.roundWinnerLbl.TabIndex = 9;
            this.roundWinnerLbl.Text = "In progress";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("JetBrains Mono Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Winner         :";
            // 
            // turnOfLbl
            // 
            this.turnOfLbl.AutoSize = true;
            this.turnOfLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnOfLbl.Location = new System.Drawing.Point(154, 64);
            this.turnOfLbl.Name = "turnOfLbl";
            this.turnOfLbl.Size = new System.Drawing.Size(28, 14);
            this.turnOfLbl.TabIndex = 7;
            this.turnOfLbl.Text = "???";
            // 
            // roundNumberLbl
            // 
            this.roundNumberLbl.AutoSize = true;
            this.roundNumberLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundNumberLbl.Location = new System.Drawing.Point(154, 34);
            this.roundNumberLbl.Name = "roundNumberLbl";
            this.roundNumberLbl.Size = new System.Drawing.Size(14, 14);
            this.roundNumberLbl.TabIndex = 6;
            this.roundNumberLbl.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Turn of        :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Round number   :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.totalRoundsLbl);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.roundsListCmbBx);
            this.groupBox3.Controls.Add(this.roundsRemaindLbl);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.gameWinnerLbl);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("JetBrains Mono Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 448);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game State";
            // 
            // totalRoundsLbl
            // 
            this.totalRoundsLbl.AutoSize = true;
            this.totalRoundsLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRoundsLbl.Location = new System.Drawing.Point(154, 33);
            this.totalRoundsLbl.Name = "totalRoundsLbl";
            this.totalRoundsLbl.Size = new System.Drawing.Size(28, 14);
            this.totalRoundsLbl.TabIndex = 12;
            this.totalRoundsLbl.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total rounds   :";
            // 
            // roundsListCmbBx
            // 
            this.roundsListCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roundsListCmbBx.Font = new System.Drawing.Font("JetBrains Mono Medium", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsListCmbBx.FormattingEnabled = true;
            this.roundsListCmbBx.Location = new System.Drawing.Point(157, 84);
            this.roundsListCmbBx.Name = "roundsListCmbBx";
            this.roundsListCmbBx.Size = new System.Drawing.Size(156, 20);
            this.roundsListCmbBx.TabIndex = 10;
            // 
            // roundsRemaindLbl
            // 
            this.roundsRemaindLbl.AutoSize = true;
            this.roundsRemaindLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsRemaindLbl.Location = new System.Drawing.Point(154, 60);
            this.roundsRemaindLbl.Name = "roundsRemaindLbl";
            this.roundsRemaindLbl.Size = new System.Drawing.Size(28, 14);
            this.roundsRemaindLbl.TabIndex = 9;
            this.roundsRemaindLbl.Text = "???";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("JetBrains Mono Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "Rounds remaind :";
            // 
            // gameWinnerLbl
            // 
            this.gameWinnerLbl.AutoSize = true;
            this.gameWinnerLbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameWinnerLbl.Location = new System.Drawing.Point(154, 115);
            this.gameWinnerLbl.Name = "gameWinnerLbl";
            this.gameWinnerLbl.Size = new System.Drawing.Size(84, 14);
            this.gameWinnerLbl.TabIndex = 7;
            this.gameWinnerLbl.Text = "In progress";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("JetBrains Mono Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Winner         :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("JetBrains Mono Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Rnds completed :";
            // 
            // nextRoundBtn
            // 
            this.nextRoundBtn.Enabled = false;
            this.nextRoundBtn.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextRoundBtn.Location = new System.Drawing.Point(8, 472);
            this.nextRoundBtn.Name = "nextRoundBtn";
            this.nextRoundBtn.Size = new System.Drawing.Size(319, 34);
            this.nextRoundBtn.TabIndex = 9;
            this.nextRoundBtn.Text = "Next Round";
            this.nextRoundBtn.UseVisualStyleBackColor = true;
            this.nextRoundBtn.Click += new System.EventHandler(this.nextRoundBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.nextRoundBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.onLoad);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.p2BgPnl.ResumeLayout(false);
            this.p2BgPnl.PerformLayout();
            this.p1BgPnl.ResumeLayout(false);
            this.p1BgPnl.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label roundWinnerLbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label turnOfLbl;
        private System.Windows.Forms.Label roundNumberLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label roundsRemaindLbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label gameWinnerLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox roundsListCmbBx;
        private System.Windows.Forms.Label totalRoundsLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cell3Lbl;
        private System.Windows.Forms.Label cell2Lbl;
        private System.Windows.Forms.Label cell1Lbl;
        private System.Windows.Forms.Label cell6Lbl;
        private System.Windows.Forms.Label cell5Lbl;
        private System.Windows.Forms.Label cell4Lbl;
        private System.Windows.Forms.Label cell9Lbl;
        private System.Windows.Forms.Label cell8Lbl;
        private System.Windows.Forms.Label cell7Lbl;
        private System.Windows.Forms.Label p2NameLbl;
        private System.Windows.Forms.Label p1NameLbl;
        private System.Windows.Forms.Button nextRoundBtn;
        private System.Windows.Forms.Label p2WinsLbl;
        private System.Windows.Forms.Label p1WinsLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p2BgPnl;
        private System.Windows.Forms.Label p2SymboleLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel p1BgPnl;
        private System.Windows.Forms.Label p1SymboleLbl;
        private System.Windows.Forms.Label label8;
    }
}

