namespace MemoryManagmentVisualization
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.btn_ok_number_of_process = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ok_number_of_process
            // 
            this.btn_ok_number_of_process.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_ok_number_of_process.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok_number_of_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok_number_of_process.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_number_of_process.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok_number_of_process.Location = new System.Drawing.Point(161, 319);
            this.btn_ok_number_of_process.Name = "btn_ok_number_of_process";
            this.btn_ok_number_of_process.Size = new System.Drawing.Size(502, 46);
            this.btn_ok_number_of_process.TabIndex = 6;
            this.btn_ok_number_of_process.Text = "Worst Fit";
            this.btn_ok_number_of_process.UseVisualStyleBackColor = false;
            this.btn_ok_number_of_process.Click += new System.EventHandler(this.btn_ok_number_of_process_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(161, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(502, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Best Fit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aquamarine;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(161, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(502, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "First Fit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_back.Location = new System.Drawing.Point(357, 447);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 38);
            this.btn_back.TabIndex = 55;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 533);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ok_number_of_process);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose algorithm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok_number_of_process;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_back;
    }
}