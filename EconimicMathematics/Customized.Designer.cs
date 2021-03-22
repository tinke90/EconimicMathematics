
namespace EconimicMathematics
{
    partial class Customized
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
            this.pnl_taxRate = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tf_overtimeSalary = new System.Windows.Forms.TextBox();
            this.tf_totalSalary = new System.Windows.Forms.TextBox();
            this.tf_weeklySalary = new System.Windows.Forms.TextBox();
            this.tf_hourlySalary = new System.Windows.Forms.TextBox();
            this.bt_zero = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.tf_totalOvertimeHours = new System.Windows.Forms.TextBox();
            this.tf_totalWeeklyHours = new System.Windows.Forms.TextBox();
            this.tf_sunday = new System.Windows.Forms.TextBox();
            this.tf_saturday = new System.Windows.Forms.TextBox();
            this.tf_friday = new System.Windows.Forms.TextBox();
            this.tf_thursday = new System.Windows.Forms.TextBox();
            this.tf_wednesday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tf_thuesday = new System.Windows.Forms.TextBox();
            this.tf_monday = new System.Windows.Forms.TextBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lb_week = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tf_taxRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tf_extraTaxRate = new System.Windows.Forms.TextBox();
            this.cb_taxOption = new System.Windows.Forms.CheckBox();
            this.cb_taxSwitch = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tf_workingHours = new System.Windows.Forms.TextBox();
            this.pl_navbar.SuspendLayout();
            this.pl_background.SuspendLayout();
            this.pnl_taxRate.SuspendLayout();
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
            this.pl_navbar.Size = new System.Drawing.Size(639, 35);
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
            this.lb_app_title.Text = "Ylityö laskin";
            this.lb_app_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_minimize
            // 
            this.bt_minimize.BackColor = System.Drawing.Color.Transparent;
            this.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimize.ForeColor = System.Drawing.Color.White;
            this.bt_minimize.Location = new System.Drawing.Point(565, 6);
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
            this.bt_close.Location = new System.Drawing.Point(603, 6);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(23, 23);
            this.bt_close.TabIndex = 0;
            this.bt_close.Text = "X";
            this.bt_close.UseVisualStyleBackColor = false;
            // 
            // pl_background
            // 
            this.pl_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pl_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_background.Controls.Add(this.pnl_taxRate);
            this.pl_background.Location = new System.Drawing.Point(0, 35);
            this.pl_background.Name = "pl_background";
            this.pl_background.Size = new System.Drawing.Size(639, 329);
            this.pl_background.TabIndex = 1;
            // 
            // pnl_taxRate
            // 
            this.pnl_taxRate.Controls.Add(this.label5);
            this.pnl_taxRate.Controls.Add(this.tf_workingHours);
            this.pnl_taxRate.Controls.Add(this.cb_taxSwitch);
            this.pnl_taxRate.Controls.Add(this.cb_taxOption);
            this.pnl_taxRate.Controls.Add(this.label7);
            this.pnl_taxRate.Controls.Add(this.tf_extraTaxRate);
            this.pnl_taxRate.Controls.Add(this.label6);
            this.pnl_taxRate.Controls.Add(this.tf_taxRate);
            this.pnl_taxRate.Controls.Add(this.lb_week);
            this.pnl_taxRate.Controls.Add(this.label1);
            this.pnl_taxRate.Controls.Add(this.label3);
            this.pnl_taxRate.Controls.Add(this.label11);
            this.pnl_taxRate.Controls.Add(this.label12);
            this.pnl_taxRate.Controls.Add(this.label10);
            this.pnl_taxRate.Controls.Add(this.tf_overtimeSalary);
            this.pnl_taxRate.Controls.Add(this.tf_totalSalary);
            this.pnl_taxRate.Controls.Add(this.tf_weeklySalary);
            this.pnl_taxRate.Controls.Add(this.tf_hourlySalary);
            this.pnl_taxRate.Controls.Add(this.bt_zero);
            this.pnl_taxRate.Controls.Add(this.label9);
            this.pnl_taxRate.Controls.Add(this.label8);
            this.pnl_taxRate.Controls.Add(this.bt_calculate);
            this.pnl_taxRate.Controls.Add(this.tf_totalOvertimeHours);
            this.pnl_taxRate.Controls.Add(this.tf_totalWeeklyHours);
            this.pnl_taxRate.Controls.Add(this.tf_sunday);
            this.pnl_taxRate.Controls.Add(this.tf_saturday);
            this.pnl_taxRate.Controls.Add(this.tf_friday);
            this.pnl_taxRate.Controls.Add(this.tf_thursday);
            this.pnl_taxRate.Controls.Add(this.tf_wednesday);
            this.pnl_taxRate.Controls.Add(this.label2);
            this.pnl_taxRate.Controls.Add(this.tf_thuesday);
            this.pnl_taxRate.Controls.Add(this.tf_monday);
            this.pnl_taxRate.Location = new System.Drawing.Point(12, 12);
            this.pnl_taxRate.Name = "pnl_taxRate";
            this.pnl_taxRate.Size = new System.Drawing.Size(614, 304);
            this.pnl_taxRate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tuntipalkka";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(366, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Ylityön palkka";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(482, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Kokonais palkka";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(250, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Viikon palkka";
            // 
            // tf_overtimeSalary
            // 
            this.tf_overtimeSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_overtimeSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_overtimeSalary.ForeColor = System.Drawing.Color.White;
            this.tf_overtimeSalary.Location = new System.Drawing.Point(369, 212);
            this.tf_overtimeSalary.Name = "tf_overtimeSalary";
            this.tf_overtimeSalary.ReadOnly = true;
            this.tf_overtimeSalary.Size = new System.Drawing.Size(100, 20);
            this.tf_overtimeSalary.TabIndex = 36;
            this.tf_overtimeSalary.Text = "0 €";
            this.tf_overtimeSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_totalSalary
            // 
            this.tf_totalSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_totalSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_totalSalary.ForeColor = System.Drawing.Color.White;
            this.tf_totalSalary.Location = new System.Drawing.Point(485, 212);
            this.tf_totalSalary.Name = "tf_totalSalary";
            this.tf_totalSalary.ReadOnly = true;
            this.tf_totalSalary.Size = new System.Drawing.Size(100, 20);
            this.tf_totalSalary.TabIndex = 35;
            this.tf_totalSalary.Text = "0 €";
            this.tf_totalSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_weeklySalary
            // 
            this.tf_weeklySalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_weeklySalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_weeklySalary.ForeColor = System.Drawing.Color.White;
            this.tf_weeklySalary.Location = new System.Drawing.Point(253, 212);
            this.tf_weeklySalary.Name = "tf_weeklySalary";
            this.tf_weeklySalary.ReadOnly = true;
            this.tf_weeklySalary.Size = new System.Drawing.Size(100, 20);
            this.tf_weeklySalary.TabIndex = 34;
            this.tf_weeklySalary.Text = "0 €";
            this.tf_weeklySalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_hourlySalary
            // 
            this.tf_hourlySalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_hourlySalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_hourlySalary.ForeColor = System.Drawing.Color.White;
            this.tf_hourlySalary.Location = new System.Drawing.Point(21, 161);
            this.tf_hourlySalary.Name = "tf_hourlySalary";
            this.tf_hourlySalary.Size = new System.Drawing.Size(100, 20);
            this.tf_hourlySalary.TabIndex = 29;
            this.tf_hourlySalary.Text = "Tuntipalkka";
            this.tf_hourlySalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_zero
            // 
            this.bt_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_zero.ForeColor = System.Drawing.Color.White;
            this.bt_zero.Location = new System.Drawing.Point(313, 253);
            this.bt_zero.Name = "bt_zero";
            this.bt_zero.Size = new System.Drawing.Size(124, 23);
            this.bt_zero.TabIndex = 28;
            this.bt_zero.Text = "TYHJENNÄ";
            this.bt_zero.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(135, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ylityötunnit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Koko viikon tunnit";
            // 
            // bt_calculate
            // 
            this.bt_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calculate.ForeColor = System.Drawing.Color.White;
            this.bt_calculate.Location = new System.Drawing.Point(171, 253);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(124, 23);
            this.bt_calculate.TabIndex = 22;
            this.bt_calculate.Text = "LASKE";
            this.bt_calculate.UseVisualStyleBackColor = true;
            // 
            // tf_totalOvertimeHours
            // 
            this.tf_totalOvertimeHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_totalOvertimeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_totalOvertimeHours.ForeColor = System.Drawing.Color.White;
            this.tf_totalOvertimeHours.Location = new System.Drawing.Point(137, 212);
            this.tf_totalOvertimeHours.Name = "tf_totalOvertimeHours";
            this.tf_totalOvertimeHours.ReadOnly = true;
            this.tf_totalOvertimeHours.Size = new System.Drawing.Size(100, 20);
            this.tf_totalOvertimeHours.TabIndex = 21;
            this.tf_totalOvertimeHours.Text = "0 h";
            this.tf_totalOvertimeHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_totalWeeklyHours
            // 
            this.tf_totalWeeklyHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_totalWeeklyHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_totalWeeklyHours.ForeColor = System.Drawing.Color.White;
            this.tf_totalWeeklyHours.Location = new System.Drawing.Point(21, 212);
            this.tf_totalWeeklyHours.Name = "tf_totalWeeklyHours";
            this.tf_totalWeeklyHours.ReadOnly = true;
            this.tf_totalWeeklyHours.Size = new System.Drawing.Size(100, 20);
            this.tf_totalWeeklyHours.TabIndex = 20;
            this.tf_totalWeeklyHours.Text = "0 h";
            this.tf_totalWeeklyHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_sunday
            // 
            this.tf_sunday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_sunday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_sunday.ForeColor = System.Drawing.Color.White;
            this.tf_sunday.Location = new System.Drawing.Point(137, 84);
            this.tf_sunday.Name = "tf_sunday";
            this.tf_sunday.Size = new System.Drawing.Size(100, 20);
            this.tf_sunday.TabIndex = 19;
            this.tf_sunday.Text = "Sunnuntai";
            this.tf_sunday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_saturday
            // 
            this.tf_saturday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_saturday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_saturday.ForeColor = System.Drawing.Color.White;
            this.tf_saturday.Location = new System.Drawing.Point(21, 84);
            this.tf_saturday.Name = "tf_saturday";
            this.tf_saturday.Size = new System.Drawing.Size(100, 20);
            this.tf_saturday.TabIndex = 18;
            this.tf_saturday.Text = "Lauantai";
            this.tf_saturday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_friday
            // 
            this.tf_friday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_friday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_friday.ForeColor = System.Drawing.Color.White;
            this.tf_friday.Location = new System.Drawing.Point(485, 42);
            this.tf_friday.Name = "tf_friday";
            this.tf_friday.Size = new System.Drawing.Size(100, 20);
            this.tf_friday.TabIndex = 17;
            this.tf_friday.Text = "Perjantai";
            this.tf_friday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_thursday
            // 
            this.tf_thursday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_thursday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_thursday.ForeColor = System.Drawing.Color.White;
            this.tf_thursday.Location = new System.Drawing.Point(369, 42);
            this.tf_thursday.Name = "tf_thursday";
            this.tf_thursday.Size = new System.Drawing.Size(100, 20);
            this.tf_thursday.TabIndex = 16;
            this.tf_thursday.Text = "Torstai";
            this.tf_thursday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_wednesday
            // 
            this.tf_wednesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_wednesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_wednesday.ForeColor = System.Drawing.Color.White;
            this.tf_wednesday.Location = new System.Drawing.Point(253, 42);
            this.tf_wednesday.Name = "tf_wednesday";
            this.tf_wednesday.Size = new System.Drawing.Size(100, 20);
            this.tf_wednesday.TabIndex = 12;
            this.tf_wednesday.Text = "Keskiviikko";
            this.tf_wednesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Viikon tunnit";
            // 
            // tf_thuesday
            // 
            this.tf_thuesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_thuesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_thuesday.ForeColor = System.Drawing.Color.White;
            this.tf_thuesday.Location = new System.Drawing.Point(137, 42);
            this.tf_thuesday.Name = "tf_thuesday";
            this.tf_thuesday.Size = new System.Drawing.Size(100, 20);
            this.tf_thuesday.TabIndex = 1;
            this.tf_thuesday.Text = "Tiistai";
            this.tf_thuesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_monday
            // 
            this.tf_monday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_monday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_monday.ForeColor = System.Drawing.Color.White;
            this.tf_monday.Location = new System.Drawing.Point(21, 42);
            this.tf_monday.Name = "tf_monday";
            this.tf_monday.Size = new System.Drawing.Size(100, 20);
            this.tf_monday.TabIndex = 0;
            this.tf_monday.Text = "Maanantai";
            this.tf_monday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Viikko:";
            // 
            // lb_week
            // 
            this.lb_week.AutoSize = true;
            this.lb_week.BackColor = System.Drawing.Color.Transparent;
            this.lb_week.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_week.ForeColor = System.Drawing.Color.White;
            this.lb_week.Location = new System.Drawing.Point(70, 0);
            this.lb_week.Name = "lb_week";
            this.lb_week.Size = new System.Drawing.Size(13, 13);
            this.lb_week.TabIndex = 44;
            this.lb_week.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(250, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Veroprosentti";
            // 
            // tf_taxRate
            // 
            this.tf_taxRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_taxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_taxRate.ForeColor = System.Drawing.Color.White;
            this.tf_taxRate.Location = new System.Drawing.Point(253, 161);
            this.tf_taxRate.Name = "tf_taxRate";
            this.tf_taxRate.Size = new System.Drawing.Size(100, 20);
            this.tf_taxRate.TabIndex = 45;
            this.tf_taxRate.Text = "12 %";
            this.tf_taxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(366, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Lisäveroprosentti";
            // 
            // tf_extraTaxRate
            // 
            this.tf_extraTaxRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_extraTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_extraTaxRate.ForeColor = System.Drawing.Color.White;
            this.tf_extraTaxRate.Location = new System.Drawing.Point(369, 161);
            this.tf_extraTaxRate.Name = "tf_extraTaxRate";
            this.tf_extraTaxRate.Size = new System.Drawing.Size(100, 20);
            this.tf_extraTaxRate.TabIndex = 47;
            this.tf_extraTaxRate.Text = "32 %";
            this.tf_extraTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_taxOption
            // 
            this.cb_taxOption.AutoSize = true;
            this.cb_taxOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_taxOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_taxOption.ForeColor = System.Drawing.Color.White;
            this.cb_taxOption.Location = new System.Drawing.Point(20, 274);
            this.cb_taxOption.Name = "cb_taxOption";
            this.cb_taxOption.Size = new System.Drawing.Size(89, 21);
            this.cb_taxOption.TabIndex = 49;
            this.cb_taxOption.Text = "Perusvero";
            this.cb_taxOption.UseVisualStyleBackColor = true;
            // 
            // cb_taxSwitch
            // 
            this.cb_taxSwitch.AutoSize = true;
            this.cb_taxSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_taxSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_taxSwitch.ForeColor = System.Drawing.Color.White;
            this.cb_taxSwitch.Location = new System.Drawing.Point(20, 253);
            this.cb_taxSwitch.Name = "cb_taxSwitch";
            this.cb_taxSwitch.Size = new System.Drawing.Size(103, 21);
            this.cb_taxSwitch.TabIndex = 50;
            this.cb_taxSwitch.Text = "Bruttopalkka";
            this.cb_taxSwitch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(134, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Työaika";
            // 
            // tf_workingHours
            // 
            this.tf_workingHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_workingHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_workingHours.ForeColor = System.Drawing.Color.White;
            this.tf_workingHours.Location = new System.Drawing.Point(137, 161);
            this.tf_workingHours.Name = "tf_workingHours";
            this.tf_workingHours.Size = new System.Drawing.Size(100, 20);
            this.tf_workingHours.TabIndex = 51;
            this.tf_workingHours.Text = "0 h";
            this.tf_workingHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Customized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 364);
            this.Controls.Add(this.pl_background);
            this.Controls.Add(this.pl_navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customized";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Economics Mathematic Tool";
            this.pl_navbar.ResumeLayout(false);
            this.pl_background.ResumeLayout(false);
            this.pnl_taxRate.ResumeLayout(false);
            this.pnl_taxRate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_navbar;
        private System.Windows.Forms.Button bt_minimize;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label lb_app_title;
        private System.Windows.Forms.Panel pl_background;
        private System.Windows.Forms.Panel pnl_taxRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tf_thuesday;
        private System.Windows.Forms.TextBox tf_monday;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.TextBox tf_wednesday;
        private System.Windows.Forms.TextBox tf_sunday;
        private System.Windows.Forms.TextBox tf_saturday;
        private System.Windows.Forms.TextBox tf_friday;
        private System.Windows.Forms.TextBox tf_thursday;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.TextBox tf_totalOvertimeHours;
        private System.Windows.Forms.TextBox tf_totalWeeklyHours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_zero;
        private System.Windows.Forms.TextBox tf_hourlySalary;
        private System.Windows.Forms.TextBox tf_overtimeSalary;
        private System.Windows.Forms.TextBox tf_totalSalary;
        private System.Windows.Forms.TextBox tf_weeklySalary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_week;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tf_extraTaxRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tf_taxRate;
        private System.Windows.Forms.CheckBox cb_taxOption;
        private System.Windows.Forms.CheckBox cb_taxSwitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tf_workingHours;
    }
}