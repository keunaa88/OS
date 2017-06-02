namespace OS_FinalProject
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
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtKilometres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveVehicle = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFuelPurchase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFuelCost = new System.Windows.Forms.TextBox();
            this.listViewVehicle = new System.Windows.Forms.ListView();
            this.listViewJourney = new System.Windows.Forms.ListView();
            this.btnSaveJourney = new System.Windows.Forms.Button();
            this.txtVehicleId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.radiobyday = new System.Windows.Forms.RadioButton();
            this.radiobykilo = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(144, 79);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtManufacturer.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(144, 101);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(144, 122);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 2;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(144, 144);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 3;
            // 
            // txtKilometres
            // 
            this.txtKilometres.Location = new System.Drawing.Point(144, 248);
            this.txtKilometres.Name = "txtKilometres";
            this.txtKilometres.Size = new System.Drawing.Size(100, 20);
            this.txtKilometres.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Make Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Registration No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kilometres Travelled";
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Location = new System.Drawing.Point(259, 144);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnSaveVehicle.TabIndex = 4;
            this.btnSaveVehicle.Text = "Save";
            this.btnSaveVehicle.UseVisualStyleBackColor = true;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(271, 269);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fuel Purchase(L)";
            // 
            // txtFuelPurchase
            // 
            this.txtFuelPurchase.Location = new System.Drawing.Point(144, 271);
            this.txtFuelPurchase.Name = "txtFuelPurchase";
            this.txtFuelPurchase.Size = new System.Drawing.Size(100, 20);
            this.txtFuelPurchase.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(25, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vehicle Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Journey";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fuel Cost($)";
            // 
            // txtFuelCost
            // 
            this.txtFuelCost.Location = new System.Drawing.Point(144, 294);
            this.txtFuelCost.Name = "txtFuelCost";
            this.txtFuelCost.Size = new System.Drawing.Size(100, 20);
            this.txtFuelCost.TabIndex = 8;
            // 
            // listViewVehicle
            // 
            this.listViewVehicle.Location = new System.Drawing.Point(345, 50);
            this.listViewVehicle.Name = "listViewVehicle";
            this.listViewVehicle.Size = new System.Drawing.Size(353, 115);
            this.listViewVehicle.TabIndex = 20;
            this.listViewVehicle.UseCompatibleStateImageBehavior = false;
            // 
            // listViewJourney
            // 
            this.listViewJourney.Location = new System.Drawing.Point(28, 320);
            this.listViewJourney.Name = "listViewJourney";
            this.listViewJourney.Size = new System.Drawing.Size(670, 150);
            this.listViewJourney.TabIndex = 21;
            this.listViewJourney.UseCompatibleStateImageBehavior = false;
            // 
            // btnSaveJourney
            // 
            this.btnSaveJourney.Location = new System.Drawing.Point(479, 281);
            this.btnSaveJourney.Name = "btnSaveJourney";
            this.btnSaveJourney.Size = new System.Drawing.Size(75, 23);
            this.btnSaveJourney.TabIndex = 22;
            this.btnSaveJourney.Text = "Save";
            this.btnSaveJourney.UseVisualStyleBackColor = true;
            this.btnSaveJourney.Click += new System.EventHandler(this.btnSaveJourney_Click);
            // 
            // txtVehicleId
            // 
            this.txtVehicleId.Location = new System.Drawing.Point(144, 225);
            this.txtVehicleId.Name = "txtVehicleId";
            this.txtVehicleId.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleId.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Vehicle Id";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(340, 254);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(90, 20);
            this.txtDays.TabIndex = 10;
            // 
            // radiobyday
            // 
            this.radiobyday.AutoSize = true;
            this.radiobyday.Location = new System.Drawing.Point(432, 226);
            this.radiobyday.Name = "radiobyday";
            this.radiobyday.Size = new System.Drawing.Size(56, 17);
            this.radiobyday.TabIndex = 26;
            this.radiobyday.Text = "by day";
            this.radiobyday.UseVisualStyleBackColor = true;
            // 
            // radiobykilo
            // 
            this.radiobykilo.AutoSize = true;
            this.radiobykilo.Checked = true;
            this.radiobykilo.Location = new System.Drawing.Point(340, 226);
            this.radiobykilo.Name = "radiobykilo";
            this.radiobykilo.Size = new System.Drawing.Size(86, 17);
            this.radiobykilo.TabIndex = 9;
            this.radiobykilo.TabStop = true;
            this.radiobykilo.Text = "by kilometres";
            this.radiobykilo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Rental";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(415, 286);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Have you gotten a service?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Rental days";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 502);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.radiobykilo);
            this.Controls.Add(this.radiobyday);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVehicleId);
            this.Controls.Add(this.btnSaveJourney);
            this.Controls.Add(this.listViewJourney);
            this.Controls.Add(this.listViewVehicle);
            this.Controls.Add(this.txtFuelCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFuelPurchase);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSaveVehicle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKilometres);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtKilometres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveVehicle;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFuelPurchase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFuelCost;
        private System.Windows.Forms.ListView listViewVehicle;
        private System.Windows.Forms.ListView listViewJourney;
        private System.Windows.Forms.Button btnSaveJourney;
        private System.Windows.Forms.TextBox txtVehicleId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.RadioButton radiobyday;
        private System.Windows.Forms.RadioButton radiobykilo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

