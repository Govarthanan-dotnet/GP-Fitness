using System;

namespace GP_Fitness
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update_delete_btn = new System.Windows.Forms.Button();
            this.Payment_btn = new System.Windows.Forms.Button();
            this.Employees_btn = new System.Windows.Forms.Button();
            this.AddMembers_btn = new System.Windows.Forms.Button();
            this.ViewMember_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.Update_delete_btn);
            this.panel1.Controls.Add(this.Payment_btn);
            this.panel1.Controls.Add(this.Employees_btn);
            this.panel1.Controls.Add(this.AddMembers_btn);
            this.panel1.Controls.Add(this.ViewMember_btn);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 517);
            this.panel1.TabIndex = 1;
            // 
            // Update_delete_btn
            // 
            this.Update_delete_btn.BackColor = System.Drawing.Color.Yellow;
            this.Update_delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_delete_btn.ForeColor = System.Drawing.Color.Blue;
            this.Update_delete_btn.Location = new System.Drawing.Point(0, 312);
            this.Update_delete_btn.Name = "Update_delete_btn";
            this.Update_delete_btn.Size = new System.Drawing.Size(136, 40);
            this.Update_delete_btn.TabIndex = 5;
            this.Update_delete_btn.Text = "Update/Delete";
            this.Update_delete_btn.UseVisualStyleBackColor = false;
            this.Update_delete_btn.Click += new System.EventHandler(this.Update_delete_btn_Click);
            // 
            // Payment_btn
            // 
            this.Payment_btn.BackColor = System.Drawing.Color.Yellow;
            this.Payment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_btn.ForeColor = System.Drawing.Color.Blue;
            this.Payment_btn.Location = new System.Drawing.Point(0, 388);
            this.Payment_btn.Name = "Payment_btn";
            this.Payment_btn.Size = new System.Drawing.Size(136, 39);
            this.Payment_btn.TabIndex = 6;
            this.Payment_btn.Text = "Payments";
            this.Payment_btn.UseVisualStyleBackColor = false;
            this.Payment_btn.Click += new System.EventHandler(this.Payment_btn_Click);
            // 
            // Employees_btn
            // 
            this.Employees_btn.BackColor = System.Drawing.Color.Yellow;
            this.Employees_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_btn.ForeColor = System.Drawing.Color.Blue;
            this.Employees_btn.Location = new System.Drawing.Point(0, 69);
            this.Employees_btn.Name = "Employees_btn";
            this.Employees_btn.Size = new System.Drawing.Size(136, 51);
            this.Employees_btn.TabIndex = 4;
            this.Employees_btn.Text = "Employees Details";
            this.Employees_btn.UseVisualStyleBackColor = false;
            this.Employees_btn.Click += new System.EventHandler(this.Employees_btn_Click);
            // 
            // AddMembers_btn
            // 
            this.AddMembers_btn.BackColor = System.Drawing.Color.Yellow;
            this.AddMembers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMembers_btn.ForeColor = System.Drawing.Color.Blue;
            this.AddMembers_btn.Location = new System.Drawing.Point(0, 158);
            this.AddMembers_btn.Name = "AddMembers_btn";
            this.AddMembers_btn.Size = new System.Drawing.Size(136, 41);
            this.AddMembers_btn.TabIndex = 5;
            this.AddMembers_btn.Text = "Add Members";
            this.AddMembers_btn.UseVisualStyleBackColor = false;
            this.AddMembers_btn.Click += new System.EventHandler(this.AddMembers_btn_Click);
            // 
            // ViewMember_btn
            // 
            this.ViewMember_btn.BackColor = System.Drawing.Color.Yellow;
            this.ViewMember_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewMember_btn.ForeColor = System.Drawing.Color.Blue;
            this.ViewMember_btn.Location = new System.Drawing.Point(-3, 237);
            this.ViewMember_btn.Name = "ViewMember_btn";
            this.ViewMember_btn.Size = new System.Drawing.Size(139, 40);
            this.ViewMember_btn.TabIndex = 6;
            this.ViewMember_btn.Text = "ViewMembers";
            this.ViewMember_btn.UseVisualStyleBackColor = false;
            this.ViewMember_btn.Click += new System.EventHandler(this.ViewMember_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "GP FITNESS CENTER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GP_Fitness.Properties.Resources._240_;
            this.pictureBox1.Location = new System.Drawing.Point(135, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Employees_btn;
        private System.Windows.Forms.Button Update_delete_btn;
        private System.Windows.Forms.Button Payment_btn;
        private System.Windows.Forms.Button AddMembers_btn;
        private System.Windows.Forms.Button ViewMember_btn;
    }
}