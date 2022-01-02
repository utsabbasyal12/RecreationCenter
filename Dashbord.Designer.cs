
namespace RecreationCenter
{
    partial class Dashbord
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
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.customerIDLbl = new System.Windows.Forms.Label();
            this.customerTypeCombo = new System.Windows.Forms.ComboBox();
            this.customerTypeLbl = new System.Windows.Forms.Label();
            this.customerIDTxt = new System.Windows.Forms.TextBox();
            this.timeInLbl = new System.Windows.Forms.Label();
            this.CustomerInBtn = new System.Windows.Forms.Button();
            this.timeOutLbl = new System.Windows.Forms.Label();
            this.durationLbl = new System.Windows.Forms.Label();
            this.customerEntryLbl = new System.Windows.Forms.Label();
            this.totalAmountLbl = new System.Windows.Forms.Label();
            this.durationTxt = new System.Windows.Forms.TextBox();
            this.totalAmountTxt = new System.Windows.Forms.TextBox();
            this.dayLbl = new System.Windows.Forms.Label();
            this.dayCombo = new System.Windows.Forms.ComboBox();
            this.customerOutBtn = new System.Windows.Forms.Button();
            this.customerExitLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exitTimeInLbl = new System.Windows.Forms.Label();
            this.exitCustomerIDLbl = new System.Windows.Forms.Label();
            this.exitCustomerIDTxt = new System.Windows.Forms.TextBox();
            this.timeOutTimer = new System.Windows.Forms.Label();
            this.timeInTimer = new System.Windows.Forms.Label();
            this.exitTimeInTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pricePerMinuteTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.dashbordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashbordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(561, 4);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // customerIDLbl
            // 
            this.customerIDLbl.AutoSize = true;
            this.customerIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLbl.Location = new System.Drawing.Point(9, 62);
            this.customerIDLbl.Name = "customerIDLbl";
            this.customerIDLbl.Size = new System.Drawing.Size(81, 16);
            this.customerIDLbl.TabIndex = 1;
            this.customerIDLbl.Text = "Customer ID";
            // 
            // customerTypeCombo
            // 
            this.customerTypeCombo.FormattingEnabled = true;
            this.customerTypeCombo.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group of 5",
            "Group of 10",
            "Group of 15 or More"});
            this.customerTypeCombo.Location = new System.Drawing.Point(128, 98);
            this.customerTypeCombo.Name = "customerTypeCombo";
            this.customerTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.customerTypeCombo.TabIndex = 2;
            this.customerTypeCombo.Text = "Child";
            // 
            // customerTypeLbl
            // 
            this.customerTypeLbl.AutoSize = true;
            this.customerTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTypeLbl.Location = new System.Drawing.Point(9, 103);
            this.customerTypeLbl.Name = "customerTypeLbl";
            this.customerTypeLbl.Size = new System.Drawing.Size(100, 16);
            this.customerTypeLbl.TabIndex = 3;
            this.customerTypeLbl.Text = "Customer Type";
            // 
            // customerIDTxt
            // 
            this.customerIDTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customerIDTxt.Location = new System.Drawing.Point(128, 58);
            this.customerIDTxt.Name = "customerIDTxt";
            this.customerIDTxt.Size = new System.Drawing.Size(121, 20);
            this.customerIDTxt.TabIndex = 4;
            // 
            // timeInLbl
            // 
            this.timeInLbl.AutoSize = true;
            this.timeInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInLbl.Location = new System.Drawing.Point(9, 143);
            this.timeInLbl.Name = "timeInLbl";
            this.timeInLbl.Size = new System.Drawing.Size(52, 16);
            this.timeInLbl.TabIndex = 5;
            this.timeInLbl.Text = "Time In";
            // 
            // CustomerInBtn
            // 
            this.CustomerInBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CustomerInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomerInBtn.Location = new System.Drawing.Point(128, 221);
            this.CustomerInBtn.Name = "CustomerInBtn";
            this.CustomerInBtn.Size = new System.Drawing.Size(121, 32);
            this.CustomerInBtn.TabIndex = 7;
            this.CustomerInBtn.Text = "Customer In";
            this.CustomerInBtn.UseVisualStyleBackColor = false;
            this.CustomerInBtn.Click += new System.EventHandler(this.CustomerInBtn_Click);
            // 
            // timeOutLbl
            // 
            this.timeOutLbl.AutoSize = true;
            this.timeOutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutLbl.Location = new System.Drawing.Point(9, 408);
            this.timeOutLbl.Name = "timeOutLbl";
            this.timeOutLbl.Size = new System.Drawing.Size(62, 16);
            this.timeOutLbl.TabIndex = 8;
            this.timeOutLbl.Text = "Time Out";
            // 
            // durationLbl
            // 
            this.durationLbl.AutoSize = true;
            this.durationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLbl.Location = new System.Drawing.Point(9, 502);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(58, 16);
            this.durationLbl.TabIndex = 11;
            this.durationLbl.Text = "Duration";
            // 
            // customerEntryLbl
            // 
            this.customerEntryLbl.AutoSize = true;
            this.customerEntryLbl.BackColor = System.Drawing.SystemColors.Control;
            this.customerEntryLbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEntryLbl.Location = new System.Drawing.Point(54, 18);
            this.customerEntryLbl.Name = "customerEntryLbl";
            this.customerEntryLbl.Size = new System.Drawing.Size(142, 28);
            this.customerEntryLbl.TabIndex = 12;
            this.customerEntryLbl.Text = "Customer Entry";
            // 
            // totalAmountLbl
            // 
            this.totalAmountLbl.AutoSize = true;
            this.totalAmountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLbl.Location = new System.Drawing.Point(9, 582);
            this.totalAmountLbl.Name = "totalAmountLbl";
            this.totalAmountLbl.Size = new System.Drawing.Size(87, 16);
            this.totalAmountLbl.TabIndex = 14;
            this.totalAmountLbl.Text = "Total Amount";
            // 
            // durationTxt
            // 
            this.durationTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.durationTxt.Location = new System.Drawing.Point(128, 498);
            this.durationTxt.Name = "durationTxt";
            this.durationTxt.Size = new System.Drawing.Size(121, 20);
            this.durationTxt.TabIndex = 15;
            // 
            // totalAmountTxt
            // 
            this.totalAmountTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalAmountTxt.Location = new System.Drawing.Point(128, 578);
            this.totalAmountTxt.Name = "totalAmountTxt";
            this.totalAmountTxt.Size = new System.Drawing.Size(121, 20);
            this.totalAmountTxt.TabIndex = 16;
            // 
            // dayLbl
            // 
            this.dayLbl.AutoSize = true;
            this.dayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLbl.Location = new System.Drawing.Point(12, 178);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(33, 16);
            this.dayLbl.TabIndex = 18;
            this.dayLbl.Text = "Day";
            // 
            // dayCombo
            // 
            this.dayCombo.FormattingEnabled = true;
            this.dayCombo.Items.AddRange(new object[] {
            "Holiday/ Weekend",
            "Normal Day"});
            this.dayCombo.Location = new System.Drawing.Point(128, 178);
            this.dayCombo.Name = "dayCombo";
            this.dayCombo.Size = new System.Drawing.Size(121, 21);
            this.dayCombo.TabIndex = 19;
            this.dayCombo.Text = "Holiday";
            // 
            // customerOutBtn
            // 
            this.customerOutBtn.BackColor = System.Drawing.Color.Firebrick;
            this.customerOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerOutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.customerOutBtn.Location = new System.Drawing.Point(128, 449);
            this.customerOutBtn.Name = "customerOutBtn";
            this.customerOutBtn.Size = new System.Drawing.Size(121, 32);
            this.customerOutBtn.TabIndex = 20;
            this.customerOutBtn.Text = "Customer Out";
            this.customerOutBtn.UseVisualStyleBackColor = false;
            this.customerOutBtn.Click += new System.EventHandler(this.customerOutBtn_Click);
            // 
            // customerExitLbl
            // 
            this.customerExitLbl.AutoSize = true;
            this.customerExitLbl.BackColor = System.Drawing.SystemColors.Control;
            this.customerExitLbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerExitLbl.Location = new System.Drawing.Point(54, 273);
            this.customerExitLbl.Name = "customerExitLbl";
            this.customerExitLbl.Size = new System.Drawing.Size(128, 28);
            this.customerExitLbl.TabIndex = 21;
            this.customerExitLbl.Text = "Customer Exit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 340);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date";
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(306, 139);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(104, 20);
            this.dateTime.TabIndex = 24;
            this.dateTime.Value = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exitTimeInLbl
            // 
            this.exitTimeInLbl.AutoSize = true;
            this.exitTimeInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitTimeInLbl.Location = new System.Drawing.Point(9, 364);
            this.exitTimeInLbl.Name = "exitTimeInLbl";
            this.exitTimeInLbl.Size = new System.Drawing.Size(52, 16);
            this.exitTimeInLbl.TabIndex = 26;
            this.exitTimeInLbl.Text = "Time In";
            // 
            // exitCustomerIDLbl
            // 
            this.exitCustomerIDLbl.AutoSize = true;
            this.exitCustomerIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitCustomerIDLbl.Location = new System.Drawing.Point(9, 318);
            this.exitCustomerIDLbl.Name = "exitCustomerIDLbl";
            this.exitCustomerIDLbl.Size = new System.Drawing.Size(81, 16);
            this.exitCustomerIDLbl.TabIndex = 27;
            this.exitCustomerIDLbl.Text = "Customer ID";
            // 
            // exitCustomerIDTxt
            // 
            this.exitCustomerIDTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitCustomerIDTxt.Location = new System.Drawing.Point(128, 317);
            this.exitCustomerIDTxt.Name = "exitCustomerIDTxt";
            this.exitCustomerIDTxt.Size = new System.Drawing.Size(121, 20);
            this.exitCustomerIDTxt.TabIndex = 28;
            // 
            // timeOutTimer
            // 
            this.timeOutTimer.AutoSize = true;
            this.timeOutTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeOutTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutTimer.Location = new System.Drawing.Point(128, 406);
            this.timeOutTimer.Name = "timeOutTimer";
            this.timeOutTimer.Size = new System.Drawing.Size(41, 18);
            this.timeOutTimer.TabIndex = 29;
            this.timeOutTimer.Text = "Time";
            // 
            // timeInTimer
            // 
            this.timeInTimer.AutoSize = true;
            this.timeInTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeInTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInTimer.Location = new System.Drawing.Point(128, 141);
            this.timeInTimer.Name = "timeInTimer";
            this.timeInTimer.Size = new System.Drawing.Size(41, 18);
            this.timeInTimer.TabIndex = 30;
            this.timeInTimer.Text = "Time";
            // 
            // exitTimeInTxt
            // 
            this.exitTimeInTxt.Location = new System.Drawing.Point(128, 360);
            this.exitTimeInTxt.Name = "exitTimeInTxt";
            this.exitTimeInTxt.Size = new System.Drawing.Size(121, 20);
            this.exitTimeInTxt.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Price Per Minute";
            // 
            // pricePerMinuteTxt
            // 
            this.pricePerMinuteTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pricePerMinuteTxt.Location = new System.Drawing.Point(128, 538);
            this.pricePerMinuteTxt.Name = "pricePerMinuteTxt";
            this.pricePerMinuteTxt.Size = new System.Drawing.Size(121, 20);
            this.pricePerMinuteTxt.TabIndex = 33;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.submitBtn.Location = new System.Drawing.Point(128, 619);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(121, 32);
            this.submitBtn.TabIndex = 35;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Gray;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.saveBtn.Location = new System.Drawing.Point(306, 542);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(121, 32);
            this.saveBtn.TabIndex = 36;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.Gray;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.loadBtn.Location = new System.Drawing.Point(448, 542);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(121, 32);
            this.loadBtn.TabIndex = 37;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // dashbordBindingSource
            // 
            this.dashbordBindingSource.DataSource = typeof(RecreationCenter.Dashbord);
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 663);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.pricePerMinuteTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitTimeInTxt);
            this.Controls.Add(this.timeInTimer);
            this.Controls.Add(this.timeOutTimer);
            this.Controls.Add(this.exitCustomerIDTxt);
            this.Controls.Add(this.exitCustomerIDLbl);
            this.Controls.Add(this.exitTimeInLbl);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customerExitLbl);
            this.Controls.Add(this.customerOutBtn);
            this.Controls.Add(this.dayCombo);
            this.Controls.Add(this.dayLbl);
            this.Controls.Add(this.totalAmountTxt);
            this.Controls.Add(this.durationTxt);
            this.Controls.Add(this.totalAmountLbl);
            this.Controls.Add(this.customerEntryLbl);
            this.Controls.Add(this.durationLbl);
            this.Controls.Add(this.timeOutLbl);
            this.Controls.Add(this.CustomerInBtn);
            this.Controls.Add(this.timeInLbl);
            this.Controls.Add(this.customerIDTxt);
            this.Controls.Add(this.customerTypeLbl);
            this.Controls.Add(this.customerTypeCombo);
            this.Controls.Add(this.customerIDLbl);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Dashbord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashbordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label customerIDLbl;
        private System.Windows.Forms.ComboBox customerTypeCombo;
        private System.Windows.Forms.Label customerTypeLbl;
        private System.Windows.Forms.TextBox customerIDTxt;
        private System.Windows.Forms.Label timeInLbl;
        private System.Windows.Forms.Button CustomerInBtn;
        private System.Windows.Forms.Label timeOutLbl;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.Label customerEntryLbl;
        private System.Windows.Forms.Label totalAmountLbl;
        private System.Windows.Forms.TextBox durationTxt;
        private System.Windows.Forms.TextBox totalAmountTxt;
        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.ComboBox dayCombo;
        private System.Windows.Forms.Button customerOutBtn;
        private System.Windows.Forms.Label customerExitLbl;
        private System.Windows.Forms.BindingSource dashbordBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label exitTimeInLbl;
        private System.Windows.Forms.Label exitCustomerIDLbl;
        private System.Windows.Forms.TextBox exitCustomerIDTxt;
        private System.Windows.Forms.Label timeOutTimer;
        private System.Windows.Forms.Label timeInTimer;
        private System.Windows.Forms.TextBox exitTimeInTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pricePerMinuteTxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
    }
}