namespace MemoryManagmentVisualization
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox_processDetail = new System.Windows.Forms.Panel();
            this.lbl_priority_r = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_p1_arrival = new System.Windows.Forms.NumericUpDown();
            this.lbl_p1 = new System.Windows.Forms.Label();
            this.lbl_arrival_l = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_processDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_p1_arrival)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_back.Location = new System.Drawing.Point(76, 460);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 38);
            this.btn_back.TabIndex = 57;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox_processDetail
            // 
            this.groupBox_processDetail.AutoScroll = true;
            this.groupBox_processDetail.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.groupBox_processDetail.BackColor = System.Drawing.Color.White;
            this.groupBox_processDetail.Controls.Add(this.lbl_priority_r);
            this.groupBox_processDetail.Controls.Add(this.label1);
            this.groupBox_processDetail.Controls.Add(this.num_p1_arrival);
            this.groupBox_processDetail.Controls.Add(this.lbl_p1);
            this.groupBox_processDetail.Controls.Add(this.lbl_arrival_l);
            this.groupBox_processDetail.Location = new System.Drawing.Point(76, 32);
            this.groupBox_processDetail.Name = "groupBox_processDetail";
            this.groupBox_processDetail.Size = new System.Drawing.Size(666, 391);
            this.groupBox_processDetail.TabIndex = 58;
            // 
            // lbl_priority_r
            // 
            this.lbl_priority_r.AutoSize = true;
            this.lbl_priority_r.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priority_r.ForeColor = System.Drawing.Color.Gray;
            this.lbl_priority_r.Location = new System.Drawing.Point(173, 60);
            this.lbl_priority_r.Name = "lbl_priority_r";
            this.lbl_priority_r.Size = new System.Drawing.Size(336, 21);
            this.lbl_priority_r.TabIndex = 53;
            this.lbl_priority_r.Text = "Just enter number of segments of each process";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(111, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 39);
            this.label1.TabIndex = 52;
            this.label1.Text = "Process Number Of Segments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // num_p1_arrival
            // 
            this.num_p1_arrival.BackColor = System.Drawing.Color.Bisque;
            this.num_p1_arrival.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_p1_arrival.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_p1_arrival.Location = new System.Drawing.Point(209, 144);
            this.num_p1_arrival.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.num_p1_arrival.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_p1_arrival.Name = "num_p1_arrival";
            this.num_p1_arrival.ReadOnly = true;
            this.num_p1_arrival.Size = new System.Drawing.Size(89, 35);
            this.num_p1_arrival.TabIndex = 51;
            this.num_p1_arrival.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_p1_arrival.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_p1_arrival.ValueChanged += new System.EventHandler(this.num_p1_arrival_ValueChanged);
            // 
            // lbl_p1
            // 
            this.lbl_p1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_p1.ForeColor = System.Drawing.Color.Black;
            this.lbl_p1.Location = new System.Drawing.Point(18, 145);
            this.lbl_p1.Name = "lbl_p1";
            this.lbl_p1.Size = new System.Drawing.Size(125, 35);
            this.lbl_p1.TabIndex = 43;
            this.lbl_p1.Text = "Process 1";
            this.lbl_p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_arrival_l
            // 
            this.lbl_arrival_l.AutoSize = true;
            this.lbl_arrival_l.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arrival_l.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_arrival_l.Location = new System.Drawing.Point(172, 105);
            this.lbl_arrival_l.Name = "lbl_arrival_l";
            this.lbl_arrival_l.Size = new System.Drawing.Size(188, 25);
            this.lbl_arrival_l.TabIndex = 24;
            this.lbl_arrival_l.Text = "Number of segments";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(657, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 40);
            this.button2.TabIndex = 56;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 533);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox_processDetail);
            this.Controls.Add(this.button2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process segments";
            this.groupBox_processDetail.ResumeLayout(false);
            this.groupBox_processDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_p1_arrival)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel groupBox_processDetail;
        private System.Windows.Forms.Label lbl_priority_r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_p1_arrival;
        private System.Windows.Forms.Label lbl_p1;
        private System.Windows.Forms.Label lbl_arrival_l;
        private System.Windows.Forms.Button button2;


    }
}