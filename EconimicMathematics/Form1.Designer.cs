
namespace EconimicMathematics
{
    partial class Form1
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.pl_navbar = new System.Windows.Forms.Panel();
            this.lb_app_title = new System.Windows.Forms.Label();
            this.bt_minimize = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.pl_background = new System.Windows.Forms.Panel();
            this.bt_loans = new System.Windows.Forms.Button();
            this.bt_open_weekly_hour_calculator = new System.Windows.Forms.Button();
            this.pnl_loans = new System.Windows.Forms.Panel();
            this.lb_timeline = new System.Windows.Forms.Label();
            this.tf_timeline = new System.Windows.Forms.TextBox();
            this.lb_interestRateOnLoanPeriod = new System.Windows.Forms.Label();
            this.tf_interestRateOnLoanPeriod = new System.Windows.Forms.TextBox();
            this.lb_annualInterestRate = new System.Windows.Forms.Label();
            this.tf_annualInterestRate = new System.Windows.Forms.TextBox();
            this.lb_equals_1 = new System.Windows.Forms.Label();
            this.lb_algoritmType = new System.Windows.Forms.Label();
            this.tf_result = new System.Windows.Forms.TextBox();
            this.tf_loan = new System.Windows.Forms.TextBox();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.cb_mathAlgorithmType = new System.Windows.Forms.ComboBox();
            this.bt_investmentCalculation = new System.Windows.Forms.Button();
            this.bt_calculatingOfAVT = new System.Windows.Forms.Button();
            this.bt_calculatingOfIncomeTax = new System.Windows.Forms.Button();
            this.bt_basicPercentageCalculations = new System.Windows.Forms.Button();
            this.msp_menubar = new System.Windows.Forms.MenuStrip();
            this.msp_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.msp_item_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.msp_operations = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pl_navbar.SuspendLayout();
            this.pl_background.SuspendLayout();
            this.pnl_loans.SuspendLayout();
            this.msp_menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_navbar
            // 
            this.pl_navbar.BackColor = System.Drawing.Color.Black;
            this.pl_navbar.Controls.Add(this.lb_app_title);
            this.pl_navbar.Controls.Add(this.bt_minimize);
            this.pl_navbar.Controls.Add(this.bt_close);
            this.pl_navbar.Location = new System.Drawing.Point(0, 0);
            this.pl_navbar.Name = "pl_navbar";
            this.pl_navbar.Size = new System.Drawing.Size(1130, 35);
            this.pl_navbar.TabIndex = 0;
            // 
            // lb_app_title
            // 
            this.lb_app_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_app_title.ForeColor = System.Drawing.Color.White;
            this.lb_app_title.Location = new System.Drawing.Point(43, 0);
            this.lb_app_title.Name = "lb_app_title";
            this.lb_app_title.Size = new System.Drawing.Size(180, 35);
            this.lb_app_title.TabIndex = 2;
            this.lb_app_title.Text = "Talousmatematiikka laskin";
            this.lb_app_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_minimize
            // 
            this.bt_minimize.BackColor = System.Drawing.Color.Transparent;
            this.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimize.ForeColor = System.Drawing.Color.White;
            this.bt_minimize.Location = new System.Drawing.Point(1068, 6);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(23, 23);
            this.bt_minimize.TabIndex = 1;
            this.bt_minimize.Text = "_";
            this.bt_minimize.UseVisualStyleBackColor = false;
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Transparent;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.ForeColor = System.Drawing.Color.White;
            this.bt_close.Location = new System.Drawing.Point(1101, 6);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(23, 23);
            this.bt_close.TabIndex = 0;
            this.bt_close.Text = "X";
            this.bt_close.UseVisualStyleBackColor = false;
            // 
            // pl_background
            // 
            this.pl_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pl_background.Controls.Add(this.button1);
            this.pl_background.Controls.Add(this.bt_loans);
            this.pl_background.Controls.Add(this.bt_open_weekly_hour_calculator);
            this.pl_background.Controls.Add(this.pnl_loans);
            this.pl_background.Controls.Add(this.bt_investmentCalculation);
            this.pl_background.Controls.Add(this.bt_calculatingOfAVT);
            this.pl_background.Controls.Add(this.bt_calculatingOfIncomeTax);
            this.pl_background.Controls.Add(this.bt_basicPercentageCalculations);
            this.pl_background.Controls.Add(this.msp_menubar);
            this.pl_background.Location = new System.Drawing.Point(0, 35);
            this.pl_background.Name = "pl_background";
            this.pl_background.Size = new System.Drawing.Size(1130, 537);
            this.pl_background.TabIndex = 1;
            // 
            // bt_loans
            // 
            this.bt_loans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_loans.ForeColor = System.Drawing.Color.White;
            this.bt_loans.Location = new System.Drawing.Point(634, 76);
            this.bt_loans.Name = "bt_loans";
            this.bt_loans.Size = new System.Drawing.Size(120, 23);
            this.bt_loans.TabIndex = 47;
            this.bt_loans.Text = "Lainat";
            this.bt_loans.UseVisualStyleBackColor = true;
            // 
            // bt_open_weekly_hour_calculator
            // 
            this.bt_open_weekly_hour_calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_open_weekly_hour_calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_open_weekly_hour_calculator.ForeColor = System.Drawing.Color.White;
            this.bt_open_weekly_hour_calculator.Location = new System.Drawing.Point(760, 76);
            this.bt_open_weekly_hour_calculator.Name = "bt_open_weekly_hour_calculator";
            this.bt_open_weekly_hour_calculator.Size = new System.Drawing.Size(120, 23);
            this.bt_open_weekly_hour_calculator.TabIndex = 46;
            this.bt_open_weekly_hour_calculator.Text = "Avaa palkkalaskuri";
            this.bt_open_weekly_hour_calculator.UseVisualStyleBackColor = true;
            // 
            // pnl_loans
            // 
            this.pnl_loans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_loans.Controls.Add(this.lb_timeline);
            this.pnl_loans.Controls.Add(this.tf_timeline);
            this.pnl_loans.Controls.Add(this.lb_interestRateOnLoanPeriod);
            this.pnl_loans.Controls.Add(this.tf_interestRateOnLoanPeriod);
            this.pnl_loans.Controls.Add(this.lb_annualInterestRate);
            this.pnl_loans.Controls.Add(this.tf_annualInterestRate);
            this.pnl_loans.Controls.Add(this.lb_equals_1);
            this.pnl_loans.Controls.Add(this.lb_algoritmType);
            this.pnl_loans.Controls.Add(this.tf_result);
            this.pnl_loans.Controls.Add(this.tf_loan);
            this.pnl_loans.Controls.Add(this.bt_calculate);
            this.pnl_loans.Controls.Add(this.cb_mathAlgorithmType);
            this.pnl_loans.ForeColor = System.Drawing.Color.Black;
            this.pnl_loans.Location = new System.Drawing.Point(12, 105);
            this.pnl_loans.Name = "pnl_loans";
            this.pnl_loans.Size = new System.Drawing.Size(868, 420);
            this.pnl_loans.TabIndex = 8;
            this.pnl_loans.Visible = false;
            // 
            // lb_timeline
            // 
            this.lb_timeline.AutoSize = true;
            this.lb_timeline.BackColor = System.Drawing.Color.Transparent;
            this.lb_timeline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeline.ForeColor = System.Drawing.Color.White;
            this.lb_timeline.Location = new System.Drawing.Point(22, 161);
            this.lb_timeline.Name = "lb_timeline";
            this.lb_timeline.Size = new System.Drawing.Size(65, 13);
            this.lb_timeline.TabIndex = 76;
            this.lb_timeline.Text = "Aikaväli - kk";
            // 
            // tf_timeline
            // 
            this.tf_timeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_timeline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_timeline.ForeColor = System.Drawing.Color.White;
            this.tf_timeline.Location = new System.Drawing.Point(25, 181);
            this.tf_timeline.Name = "tf_timeline";
            this.tf_timeline.Size = new System.Drawing.Size(100, 20);
            this.tf_timeline.TabIndex = 75;
            this.tf_timeline.Text = "12kk";
            this.tf_timeline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_interestRateOnLoanPeriod
            // 
            this.lb_interestRateOnLoanPeriod.AutoSize = true;
            this.lb_interestRateOnLoanPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lb_interestRateOnLoanPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_interestRateOnLoanPeriod.ForeColor = System.Drawing.Color.White;
            this.lb_interestRateOnLoanPeriod.Location = new System.Drawing.Point(147, 108);
            this.lb_interestRateOnLoanPeriod.Name = "lb_interestRateOnLoanPeriod";
            this.lb_interestRateOnLoanPeriod.Size = new System.Drawing.Size(86, 13);
            this.lb_interestRateOnLoanPeriod.TabIndex = 74;
            this.lb_interestRateOnLoanPeriod.Text = "Laina-ajan korko";
            // 
            // tf_interestRateOnLoanPeriod
            // 
            this.tf_interestRateOnLoanPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_interestRateOnLoanPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_interestRateOnLoanPeriod.ForeColor = System.Drawing.Color.White;
            this.tf_interestRateOnLoanPeriod.Location = new System.Drawing.Point(150, 128);
            this.tf_interestRateOnLoanPeriod.Name = "tf_interestRateOnLoanPeriod";
            this.tf_interestRateOnLoanPeriod.Size = new System.Drawing.Size(100, 20);
            this.tf_interestRateOnLoanPeriod.TabIndex = 73;
            this.tf_interestRateOnLoanPeriod.Text = "0,00€";
            this.tf_interestRateOnLoanPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_annualInterestRate
            // 
            this.lb_annualInterestRate.AutoSize = true;
            this.lb_annualInterestRate.BackColor = System.Drawing.Color.Transparent;
            this.lb_annualInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_annualInterestRate.ForeColor = System.Drawing.Color.White;
            this.lb_annualInterestRate.Location = new System.Drawing.Point(22, 108);
            this.lb_annualInterestRate.Name = "lb_annualInterestRate";
            this.lb_annualInterestRate.Size = new System.Drawing.Size(60, 13);
            this.lb_annualInterestRate.TabIndex = 72;
            this.lb_annualInterestRate.Text = "Vuosikorko";
            // 
            // tf_annualInterestRate
            // 
            this.tf_annualInterestRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_annualInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_annualInterestRate.ForeColor = System.Drawing.Color.White;
            this.tf_annualInterestRate.Location = new System.Drawing.Point(25, 128);
            this.tf_annualInterestRate.Name = "tf_annualInterestRate";
            this.tf_annualInterestRate.Size = new System.Drawing.Size(100, 20);
            this.tf_annualInterestRate.TabIndex = 71;
            this.tf_annualInterestRate.Text = "0%";
            this.tf_annualInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_equals_1
            // 
            this.lb_equals_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_equals_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_equals_1.ForeColor = System.Drawing.Color.White;
            this.lb_equals_1.Location = new System.Drawing.Point(125, 73);
            this.lb_equals_1.Name = "lb_equals_1";
            this.lb_equals_1.Size = new System.Drawing.Size(25, 20);
            this.lb_equals_1.TabIndex = 50;
            this.lb_equals_1.Text = "=";
            this.lb_equals_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_algoritmType
            // 
            this.lb_algoritmType.AutoSize = true;
            this.lb_algoritmType.BackColor = System.Drawing.Color.Transparent;
            this.lb_algoritmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_algoritmType.ForeColor = System.Drawing.Color.White;
            this.lb_algoritmType.Location = new System.Drawing.Point(22, 53);
            this.lb_algoritmType.Name = "lb_algoritmType";
            this.lb_algoritmType.Size = new System.Drawing.Size(171, 17);
            this.lb_algoritmType.TabIndex = 48;
            this.lb_algoritmType.Text = "Laske verotettu määrä";
            // 
            // tf_result
            // 
            this.tf_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_result.ForeColor = System.Drawing.Color.White;
            this.tf_result.Location = new System.Drawing.Point(150, 73);
            this.tf_result.Name = "tf_result";
            this.tf_result.ReadOnly = true;
            this.tf_result.Size = new System.Drawing.Size(100, 20);
            this.tf_result.TabIndex = 47;
            this.tf_result.Text = "0,00€";
            this.tf_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_loan
            // 
            this.tf_loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_loan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_loan.ForeColor = System.Drawing.Color.White;
            this.tf_loan.Location = new System.Drawing.Point(25, 73);
            this.tf_loan.Name = "tf_loan";
            this.tf_loan.Size = new System.Drawing.Size(100, 20);
            this.tf_loan.TabIndex = 46;
            this.tf_loan.Text = "0";
            this.tf_loan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_calculate
            // 
            this.bt_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calculate.ForeColor = System.Drawing.Color.White;
            this.bt_calculate.Location = new System.Drawing.Point(25, 370);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(124, 23);
            this.bt_calculate.TabIndex = 9;
            this.bt_calculate.Text = "LASKE";
            this.bt_calculate.UseVisualStyleBackColor = true;
            // 
            // cb_mathAlgorithmType
            // 
            this.cb_mathAlgorithmType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cb_mathAlgorithmType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_mathAlgorithmType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_mathAlgorithmType.ForeColor = System.Drawing.Color.White;
            this.cb_mathAlgorithmType.FormattingEnabled = true;
            this.cb_mathAlgorithmType.Location = new System.Drawing.Point(25, 12);
            this.cb_mathAlgorithmType.Name = "cb_mathAlgorithmType";
            this.cb_mathAlgorithmType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_mathAlgorithmType.Size = new System.Drawing.Size(194, 21);
            this.cb_mathAlgorithmType.TabIndex = 56;
            this.cb_mathAlgorithmType.Text = "Laskukaavat";
            // 
            // bt_investmentCalculation
            // 
            this.bt_investmentCalculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_investmentCalculation.ForeColor = System.Drawing.Color.White;
            this.bt_investmentCalculation.Location = new System.Drawing.Point(508, 76);
            this.bt_investmentCalculation.Name = "bt_investmentCalculation";
            this.bt_investmentCalculation.Size = new System.Drawing.Size(120, 23);
            this.bt_investmentCalculation.TabIndex = 7;
            this.bt_investmentCalculation.Text = "Sijoittaminen";
            this.bt_investmentCalculation.UseVisualStyleBackColor = true;
            // 
            // bt_calculatingOfAVT
            // 
            this.bt_calculatingOfAVT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calculatingOfAVT.ForeColor = System.Drawing.Color.White;
            this.bt_calculatingOfAVT.Location = new System.Drawing.Point(382, 76);
            this.bt_calculatingOfAVT.Name = "bt_calculatingOfAVT";
            this.bt_calculatingOfAVT.Size = new System.Drawing.Size(120, 23);
            this.bt_calculatingOfAVT.TabIndex = 5;
            this.bt_calculatingOfAVT.Text = "Arvonlisävero laskuri";
            this.bt_calculatingOfAVT.UseVisualStyleBackColor = true;
            // 
            // bt_calculatingOfIncomeTax
            // 
            this.bt_calculatingOfIncomeTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calculatingOfIncomeTax.ForeColor = System.Drawing.Color.White;
            this.bt_calculatingOfIncomeTax.Location = new System.Drawing.Point(231, 76);
            this.bt_calculatingOfIncomeTax.Name = "bt_calculatingOfIncomeTax";
            this.bt_calculatingOfIncomeTax.Size = new System.Drawing.Size(145, 23);
            this.bt_calculatingOfIncomeTax.TabIndex = 3;
            this.bt_calculatingOfIncomeTax.Text = "Ansiotuloveron laskeminen";
            this.bt_calculatingOfIncomeTax.UseVisualStyleBackColor = true;
            // 
            // bt_basicPercentageCalculations
            // 
            this.bt_basicPercentageCalculations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_basicPercentageCalculations.ForeColor = System.Drawing.Color.White;
            this.bt_basicPercentageCalculations.Location = new System.Drawing.Point(105, 76);
            this.bt_basicPercentageCalculations.Name = "bt_basicPercentageCalculations";
            this.bt_basicPercentageCalculations.Size = new System.Drawing.Size(120, 23);
            this.bt_basicPercentageCalculations.TabIndex = 1;
            this.bt_basicPercentageCalculations.Text = "Perus prosenttilaskut";
            this.bt_basicPercentageCalculations.UseVisualStyleBackColor = true;
            // 
            // msp_menubar
            // 
            this.msp_menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.msp_menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msp_menu,
            this.msp_operations,
            this.toolStripMenuItem1});
            this.msp_menubar.Location = new System.Drawing.Point(0, 0);
            this.msp_menubar.Name = "msp_menubar";
            this.msp_menubar.Size = new System.Drawing.Size(1130, 24);
            this.msp_menubar.TabIndex = 0;
            this.msp_menubar.Text = "Menubar";
            // 
            // msp_menu
            // 
            this.msp_menu.BackColor = System.Drawing.Color.Gray;
            this.msp_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msp_item_quit});
            this.msp_menu.ForeColor = System.Drawing.Color.Black;
            this.msp_menu.ImageTransparentColor = System.Drawing.Color.Black;
            this.msp_menu.Name = "msp_menu";
            this.msp_menu.Size = new System.Drawing.Size(50, 20);
            this.msp_menu.Text = "Menu";
            // 
            // msp_item_quit
            // 
            this.msp_item_quit.Name = "msp_item_quit";
            this.msp_item_quit.Size = new System.Drawing.Size(97, 22);
            this.msp_item_quit.Text = "Quit";
            // 
            // msp_operations
            // 
            this.msp_operations.BackColor = System.Drawing.Color.Gray;
            this.msp_operations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.msp_operations.ForeColor = System.Drawing.Color.Black;
            this.msp_operations.Name = "msp_operations";
            this.msp_operations.Size = new System.Drawing.Size(46, 20);
            this.msp_operations.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Aloitus";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 572);
            this.Controls.Add(this.pl_background);
            this.Controls.Add(this.pl_navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msp_menubar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Economics Mathematic Tool";
            this.pl_navbar.ResumeLayout(false);
            this.pl_background.ResumeLayout(false);
            this.pl_background.PerformLayout();
            this.pnl_loans.ResumeLayout(false);
            this.pnl_loans.PerformLayout();
            this.msp_menubar.ResumeLayout(false);
            this.msp_menubar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_navbar;
        private System.Windows.Forms.Button bt_minimize;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label lb_app_title;
        private System.Windows.Forms.Panel pl_background;
        private System.Windows.Forms.MenuStrip msp_menubar;
        private System.Windows.Forms.ToolStripMenuItem msp_menu;
        private System.Windows.Forms.ToolStripMenuItem msp_item_quit;
        private System.Windows.Forms.ToolStripMenuItem msp_operations;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button bt_investmentCalculation;
        private System.Windows.Forms.Button bt_calculatingOfAVT;
        private System.Windows.Forms.Button bt_calculatingOfIncomeTax;
        private System.Windows.Forms.Button bt_basicPercentageCalculations;
        private System.Windows.Forms.Panel pnl_loans;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Button bt_open_weekly_hour_calculator;
        private System.Windows.Forms.Label lb_algoritmType;
        private System.Windows.Forms.TextBox tf_result;
        private System.Windows.Forms.TextBox tf_loan;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.Label lb_equals_1;
        private System.Windows.Forms.ComboBox cb_mathAlgorithmType;
        private System.Windows.Forms.Label lb_annualInterestRate;
        private System.Windows.Forms.TextBox tf_annualInterestRate;
        private System.Windows.Forms.Label lb_interestRateOnLoanPeriod;
        private System.Windows.Forms.TextBox tf_interestRateOnLoanPeriod;
        private System.Windows.Forms.Label lb_timeline;
        private System.Windows.Forms.TextBox tf_timeline;
        private System.Windows.Forms.Button bt_loans;
        private System.Windows.Forms.Button button1;
    }
}

/*{/// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.pl_navbar = new System.Windows.Forms.Panel();
            this.lb_app_title = new System.Windows.Forms.Label();
            this.bt_minimize = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.pl_background = new System.Windows.Forms.Panel();
            this.bt_open_weekly_hour_calculator = new System.Windows.Forms.Button();
            this.pnl_taxRate = new System.Windows.Forms.Panel();
            this.bt_loadMathAlgorithm = new System.Windows.Forms.Button();
            this.cb_mathAlgorithmType = new System.Windows.Forms.ComboBox();
            this.lb_equals_1 = new System.Windows.Forms.Label();
            this.tf_1_result_1 = new System.Windows.Forms.TextBox();
            this.lb_algoritmType = new System.Windows.Forms.Label();
            this.tf_1_number_1 = new System.Windows.Forms.TextBox();
            this.tf_1_percentage_1 = new System.Windows.Forms.TextBox();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_basicPercentageCalculations = new System.Windows.Forms.Button();
            this.msp_menubar = new System.Windows.Forms.MenuStrip();
            this.msp_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.msp_item_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.msp_operations = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pl_navbar.SuspendLayout();
            this.pl_background.SuspendLayout();
            this.pnl_taxRate.SuspendLayout();
            this.msp_menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_navbar
            // 
            this.pl_navbar.BackColor = System.Drawing.Color.Black;
            this.pl_navbar.Controls.Add(this.lb_app_title);
            this.pl_navbar.Controls.Add(this.bt_minimize);
            this.pl_navbar.Controls.Add(this.bt_close);
            this.pl_navbar.Location = new System.Drawing.Point(0, 0);
            this.pl_navbar.Name = "pl_navbar";
            this.pl_navbar.Size = new System.Drawing.Size(1130, 35);
            this.pl_navbar.TabIndex = 0;
            // 
            // lb_app_title
            // 
            this.lb_app_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_app_title.ForeColor = System.Drawing.Color.White;
            this.lb_app_title.Location = new System.Drawing.Point(43, 0);
            this.lb_app_title.Name = "lb_app_title";
            this.lb_app_title.Size = new System.Drawing.Size(180, 35);
            this.lb_app_title.TabIndex = 2;
            this.lb_app_title.Text = "Talousmatematiikka laskin";
            this.lb_app_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_minimize
            // 
            this.bt_minimize.BackColor = System.Drawing.Color.Transparent;
            this.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimize.ForeColor = System.Drawing.Color.White;
            this.bt_minimize.Location = new System.Drawing.Point(1068, 6);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(23, 23);
            this.bt_minimize.TabIndex = 1;
            this.bt_minimize.Text = "_";
            this.bt_minimize.UseVisualStyleBackColor = false;
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Transparent;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.ForeColor = System.Drawing.Color.White;
            this.bt_close.Location = new System.Drawing.Point(1101, 6);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(23, 23);
            this.bt_close.TabIndex = 0;
            this.bt_close.Text = "X";
            this.bt_close.UseVisualStyleBackColor = false;
            // 
            // pl_background
            // 
            this.pl_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pl_background.Controls.Add(this.bt_open_weekly_hour_calculator);
            this.pl_background.Controls.Add(this.pnl_taxRate);
            this.pl_background.Controls.Add(this.button7);
            this.pl_background.Controls.Add(this.button6);
            this.pl_background.Controls.Add(this.button5);
            this.pl_background.Controls.Add(this.button3);
            this.pl_background.Controls.Add(this.bt_basicPercentageCalculations);
            this.pl_background.Controls.Add(this.msp_menubar);
            this.pl_background.Location = new System.Drawing.Point(0, 35);
            this.pl_background.Name = "pl_background";
            this.pl_background.Size = new System.Drawing.Size(1130, 538);
            this.pl_background.TabIndex = 1;
            // 
            // bt_open_weekly_hour_calculator
            // 
            this.bt_open_weekly_hour_calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_open_weekly_hour_calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_open_weekly_hour_calculator.ForeColor = System.Drawing.Color.White;
            this.bt_open_weekly_hour_calculator.Location = new System.Drawing.Point(579, 76);
            this.bt_open_weekly_hour_calculator.Name = "bt_open_weekly_hour_calculator";
            this.bt_open_weekly_hour_calculator.Size = new System.Drawing.Size(124, 23);
            this.bt_open_weekly_hour_calculator.TabIndex = 46;
            this.bt_open_weekly_hour_calculator.Text = "Avaa palkkalaskuri";
            this.bt_open_weekly_hour_calculator.UseVisualStyleBackColor = true;
            // 
            // pnl_taxRate
            // 
            this.pnl_taxRate.Controls.Add(this.bt_loadMathAlgorithm);
            this.pnl_taxRate.Controls.Add(this.cb_mathAlgorithmType);
            this.pnl_taxRate.Controls.Add(this.lb_equals_1);
            this.pnl_taxRate.Controls.Add(this.tf_1_result_1);
            this.pnl_taxRate.Controls.Add(this.lb_algoritmType);
            this.pnl_taxRate.Controls.Add(this.tf_1_number_1);
            this.pnl_taxRate.Controls.Add(this.tf_1_percentage_1);
            this.pnl_taxRate.Controls.Add(this.bt_calculate);
            this.pnl_taxRate.ForeColor = System.Drawing.Color.Black;
            this.pnl_taxRate.Location = new System.Drawing.Point(12, 105);
            this.pnl_taxRate.Name = "pnl_taxRate";
            this.pnl_taxRate.Size = new System.Drawing.Size(868, 420);
            this.pnl_taxRate.TabIndex = 8;
            this.pnl_taxRate.Visible = false;
            // 
            // bt_loadMathAlgorithm
            // 
            this.bt_loadMathAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_loadMathAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_loadMathAlgorithm.ForeColor = System.Drawing.Color.White;
            this.bt_loadMathAlgorithm.Location = new System.Drawing.Point(25, 44);
            this.bt_loadMathAlgorithm.Name = "bt_loadMathAlgorithm";
            this.bt_loadMathAlgorithm.Size = new System.Drawing.Size(194, 23);
            this.bt_loadMathAlgorithm.TabIndex = 57;
            this.bt_loadMathAlgorithm.Text = "Lataa laskukaava";
            this.bt_loadMathAlgorithm.UseVisualStyleBackColor = true;
            // 
            // cb_mathAlgorithmType
            // 
            this.cb_mathAlgorithmType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cb_mathAlgorithmType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_mathAlgorithmType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_mathAlgorithmType.ForeColor = System.Drawing.Color.White;
            this.cb_mathAlgorithmType.FormattingEnabled = true;
            this.cb_mathAlgorithmType.Location = new System.Drawing.Point(25, 12);
            this.cb_mathAlgorithmType.Name = "cb_mathAlgorithmType";
            this.cb_mathAlgorithmType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_mathAlgorithmType.Size = new System.Drawing.Size(194, 21);
            this.cb_mathAlgorithmType.TabIndex = 56;
            this.cb_mathAlgorithmType.Text = "Laskukaavat";
            // 
            // lb_equals_1
            // 
            this.lb_equals_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_equals_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_equals_1.ForeColor = System.Drawing.Color.White;
            this.lb_equals_1.Location = new System.Drawing.Point(250, 105);
            this.lb_equals_1.Name = "lb_equals_1";
            this.lb_equals_1.Size = new System.Drawing.Size(25, 20);
            this.lb_equals_1.TabIndex = 50;
            this.lb_equals_1.Text = "=";
            this.lb_equals_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tf_1_result_1
            // 
            this.tf_1_result_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_1_result_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_1_result_1.ForeColor = System.Drawing.Color.White;
            this.tf_1_result_1.Location = new System.Drawing.Point(275, 105);
            this.tf_1_result_1.Name = "tf_1_result_1";
            this.tf_1_result_1.ReadOnly = true;
            this.tf_1_result_1.Size = new System.Drawing.Size(100, 20);
            this.tf_1_result_1.TabIndex = 49;
            this.tf_1_result_1.Text = "0";
            this.tf_1_result_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_algoritmType
            // 
            this.lb_algoritmType.AutoSize = true;
            this.lb_algoritmType.BackColor = System.Drawing.Color.Transparent;
            this.lb_algoritmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_algoritmType.ForeColor = System.Drawing.Color.White;
            this.lb_algoritmType.Location = new System.Drawing.Point(22, 85);
            this.lb_algoritmType.Name = "lb_algoritmType";
            this.lb_algoritmType.Size = new System.Drawing.Size(177, 17);
            this.lb_algoritmType.TabIndex = 48;
            this.lb_algoritmType.Text = "Laske prosentit luvusta";
            // 
            // tf_1_number_1
            // 
            this.tf_1_number_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_1_number_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_1_number_1.ForeColor = System.Drawing.Color.White;
            this.tf_1_number_1.Location = new System.Drawing.Point(150, 105);
            this.tf_1_number_1.Name = "tf_1_number_1";
            this.tf_1_number_1.Size = new System.Drawing.Size(100, 20);
            this.tf_1_number_1.TabIndex = 47;
            this.tf_1_number_1.Text = "0";
            this.tf_1_number_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_1_percentage_1
            // 
            this.tf_1_percentage_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_1_percentage_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_1_percentage_1.ForeColor = System.Drawing.Color.White;
            this.tf_1_percentage_1.Location = new System.Drawing.Point(25, 105);
            this.tf_1_percentage_1.Name = "tf_1_percentage_1";
            this.tf_1_percentage_1.Size = new System.Drawing.Size(100, 20);
            this.tf_1_percentage_1.TabIndex = 46;
            this.tf_1_percentage_1.Text = "0";
            this.tf_1_percentage_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_calculate
            // 
            this.bt_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calculate.ForeColor = System.Drawing.Color.White;
            this.bt_calculate.Location = new System.Drawing.Point(25, 370);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(124, 23);
            this.bt_calculate.TabIndex = 9;
            this.bt_calculate.Text = "LASKE";
            this.bt_calculate.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(498, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(417, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(336, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(174, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ansiotuloveron laskeminen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bt_basicPercentageCalculations
            // 
            this.bt_basicPercentageCalculations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_basicPercentageCalculations.ForeColor = System.Drawing.Color.White;
            this.bt_basicPercentageCalculations.Location = new System.Drawing.Point(12, 76);
            this.bt_basicPercentageCalculations.Name = "bt_basicPercentageCalculations";
            this.bt_basicPercentageCalculations.Size = new System.Drawing.Size(156, 23);
            this.bt_basicPercentageCalculations.TabIndex = 1;
            this.bt_basicPercentageCalculations.Text = "Perus prosenttilaskut";
            this.bt_basicPercentageCalculations.UseVisualStyleBackColor = true;
            // 
            // msp_menubar
            // 
            this.msp_menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.msp_menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msp_menu,
            this.msp_operations,
            this.toolStripMenuItem1});
            this.msp_menubar.Location = new System.Drawing.Point(0, 0);
            this.msp_menubar.Name = "msp_menubar";
            this.msp_menubar.Size = new System.Drawing.Size(1130, 24);
            this.msp_menubar.TabIndex = 0;
            this.msp_menubar.Text = "Menubar";
            // 
            // msp_menu
            // 
            this.msp_menu.BackColor = System.Drawing.Color.Gray;
            this.msp_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msp_item_quit});
            this.msp_menu.ForeColor = System.Drawing.Color.Black;
            this.msp_menu.ImageTransparentColor = System.Drawing.Color.Black;
            this.msp_menu.Name = "msp_menu";
            this.msp_menu.Size = new System.Drawing.Size(50, 20);
            this.msp_menu.Text = "Menu";
            // 
            // msp_item_quit
            // 
            this.msp_item_quit.Name = "msp_item_quit";
            this.msp_item_quit.Size = new System.Drawing.Size(97, 22);
            this.msp_item_quit.Text = "Quit";
            // 
            // msp_operations
            // 
            this.msp_operations.BackColor = System.Drawing.Color.Gray;
            this.msp_operations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.msp_operations.ForeColor = System.Drawing.Color.Black;
            this.msp_operations.Name = "msp_operations";
            this.msp_operations.Size = new System.Drawing.Size(46, 20);
            this.msp_operations.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 572);
            this.Controls.Add(this.pl_background);
            this.Controls.Add(this.pl_navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msp_menubar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Economics Mathematic Tool";
            this.pl_navbar.ResumeLayout(false);
            this.pl_background.ResumeLayout(false);
            this.pl_background.PerformLayout();
            this.pnl_taxRate.ResumeLayout(false);
            this.pnl_taxRate.PerformLayout();
            this.msp_menubar.ResumeLayout(false);
            this.msp_menubar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_navbar;
        private System.Windows.Forms.Button bt_minimize;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label lb_app_title;
        private System.Windows.Forms.Panel pl_background;
        private System.Windows.Forms.MenuStrip msp_menubar;
        private System.Windows.Forms.ToolStripMenuItem msp_menu;
        private System.Windows.Forms.ToolStripMenuItem msp_item_quit;
        private System.Windows.Forms.ToolStripMenuItem msp_operations;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_basicPercentageCalculations;
        private System.Windows.Forms.Panel pnl_taxRate;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Button bt_open_weekly_hour_calculator;
        private System.Windows.Forms.Label lb_equals_1;
        private System.Windows.Forms.TextBox tf_1_result_1;
        private System.Windows.Forms.Label lb_algoritmType;
        private System.Windows.Forms.TextBox tf_1_number_1;
        private System.Windows.Forms.TextBox tf_1_percentage_1;
        private System.Windows.Forms.ComboBox cb_mathAlgorithmType;
        private System.Windows.Forms.Button bt_loadMathAlgorithm;
    }*/