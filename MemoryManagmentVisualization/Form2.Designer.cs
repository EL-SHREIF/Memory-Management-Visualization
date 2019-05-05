namespace MemoryManagmentVisualization
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ok_number_of_process = new System.Windows.Forms.Button();
            this.groupBox_numberProcess = new System.Windows.Forms.GroupBox();
            this.numeric_numProcess = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox_numberProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numProcess)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_back.Location = new System.Drawing.Point(352, 479);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 42);
            this.btn_back.TabIndex = 51;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_ok_number_of_process);
            this.panel1.Controls.Add(this.groupBox_numberProcess);
            this.panel1.Location = new System.Drawing.Point(89, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 427);
            this.panel1.TabIndex = 52;
            // 
            // btn_ok_number_of_process
            // 
            this.btn_ok_number_of_process.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_ok_number_of_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok_number_of_process.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_number_of_process.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok_number_of_process.Location = new System.Drawing.Point(64, 367);
            this.btn_ok_number_of_process.Name = "btn_ok_number_of_process";
            this.btn_ok_number_of_process.Size = new System.Drawing.Size(502, 46);
            this.btn_ok_number_of_process.TabIndex = 5;
            this.btn_ok_number_of_process.Text = "Next";
            this.btn_ok_number_of_process.UseVisualStyleBackColor = false;
            this.btn_ok_number_of_process.Click += new System.EventHandler(this.btn_ok_number_of_process_Click);
            // 
            // groupBox_numberProcess
            // 
            this.groupBox_numberProcess.Controls.Add(this.numeric_numProcess);
            this.groupBox_numberProcess.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_numberProcess.ForeColor = System.Drawing.Color.Gray;
            this.groupBox_numberProcess.Location = new System.Drawing.Point(64, 40);
            this.groupBox_numberProcess.Name = "groupBox_numberProcess";
            this.groupBox_numberProcess.Size = new System.Drawing.Size(502, 103);
            this.groupBox_numberProcess.TabIndex = 6;
            this.groupBox_numberProcess.TabStop = false;
            this.groupBox_numberProcess.Text = "Total Memory Size ";
            // 
            // numeric_numProcess
            // 
            this.numeric_numProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numeric_numProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_numProcess.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_numProcess.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numeric_numProcess.Location = new System.Drawing.Point(26, 38);
            this.numeric_numProcess.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.numeric_numProcess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_numProcess.Name = "numeric_numProcess";
            this.numeric_numProcess.ReadOnly = true;
            this.numeric_numProcess.Size = new System.Drawing.Size(450, 46);
            this.numeric_numProcess.TabIndex = 4;
            this.numeric_numProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_numProcess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(64, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of Holes";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numericUpDown1.Location = new System.Drawing.Point(26, 38);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(450, 46);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(64, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 103);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number of process";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numericUpDown2.Location = new System.Drawing.Point(26, 38);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(450, 46);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "please enter the memory size in the smallest unit so no need for floats :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 533);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input for data";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_numberProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numProcess)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_ok_number_of_process;
        private System.Windows.Forms.GroupBox groupBox_numberProcess;
        private System.Windows.Forms.NumericUpDown numeric_numProcess;
        private System.Windows.Forms.Label label1;
    }
}