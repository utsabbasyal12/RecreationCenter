
namespace RecreationCenter
{
    partial class PriceList
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
            this.dgvPriceList = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            this.saveCSV = new System.Windows.Forms.Button();
            this.weekdayPriceTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hourTxt = new System.Windows.Forms.TextBox();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.weekendPriceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.importPriceBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPriceList);
            this.panel1.Location = new System.Drawing.Point(36, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 306);
            this.panel1.TabIndex = 46;
            // 
            // dgvPriceList
            // 
            this.dgvPriceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriceList.Location = new System.Drawing.Point(118, 3);
            this.dgvPriceList.Name = "dgvPriceList";
            this.dgvPriceList.Size = new System.Drawing.Size(574, 303);
            this.dgvPriceList.TabIndex = 0;
            this.dgvPriceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPriceList_CellClick);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(373, 500);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 45;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveCSV
            // 
            this.saveCSV.Location = new System.Drawing.Point(477, 500);
            this.saveCSV.Name = "saveCSV";
            this.saveCSV.Size = new System.Drawing.Size(75, 23);
            this.saveCSV.TabIndex = 56;
            this.saveCSV.Text = "Save";
            this.saveCSV.UseVisualStyleBackColor = true;
            this.saveCSV.Click += new System.EventHandler(this.saveCSV_Click);
            // 
            // weekdayPriceTxt
            // 
            this.weekdayPriceTxt.Location = new System.Drawing.Point(570, 444);
            this.weekdayPriceTxt.Name = "weekdayPriceTxt";
            this.weekdayPriceTxt.Size = new System.Drawing.Size(121, 20);
            this.weekdayPriceTxt.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Weekday Price";
            // 
            // hourTxt
            // 
            this.hourTxt.Location = new System.Drawing.Point(570, 402);
            this.hourTxt.Name = "hourTxt";
            this.hourTxt.Size = new System.Drawing.Size(121, 20);
            this.hourTxt.TabIndex = 53;
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(284, 402);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(121, 20);
            this.categoryTxt.TabIndex = 52;
            // 
            // weekendPriceTxt
            // 
            this.weekendPriceTxt.Location = new System.Drawing.Point(284, 444);
            this.weekendPriceTxt.Name = "weekendPriceTxt";
            this.weekendPriceTxt.Size = new System.Drawing.Size(121, 20);
            this.weekendPriceTxt.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Weekend Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Category";
            // 
            // importPriceBtn
            // 
            this.importPriceBtn.Location = new System.Drawing.Point(372, 26);
            this.importPriceBtn.Name = "importPriceBtn";
            this.importPriceBtn.Size = new System.Drawing.Size(139, 23);
            this.importPriceBtn.TabIndex = 47;
            this.importPriceBtn.Text = "Import Ticket Price";
            this.importPriceBtn.UseVisualStyleBackColor = true;
            this.importPriceBtn.Click += new System.EventHandler(this.importPriceBtn_Click);
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.saveCSV);
            this.Controls.Add(this.weekdayPriceTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourTxt);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.weekendPriceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.importPriceBtn);
            this.Name = "PriceList";
            this.Text = "PriceList";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPriceList;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button saveCSV;
        private System.Windows.Forms.TextBox weekdayPriceTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hourTxt;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.TextBox weekendPriceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button importPriceBtn;
    }
}