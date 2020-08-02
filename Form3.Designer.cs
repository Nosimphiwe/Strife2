namespace Strife
{
    partial class Form3
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
            this.Response = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCancel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtsafeSentence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Response
            // 
            this.Response.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Response.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Response.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Response.Location = new System.Drawing.Point(509, 227);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(164, 39);
            this.Response.TabIndex = 4;
            this.Response.Text = "Trigger response";
            this.Response.UseVisualStyleBackColor = false;
            this.Response.Click += new System.EventHandler(this.Response_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Strife.Properties.Resources.StrifeApp_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(179, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 57;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCancel
            // 
            this.txtCancel.AutoSize = true;
            this.txtCancel.Location = new System.Drawing.Point(290, 368);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(173, 13);
            this.txtCancel.TabIndex = 58;
            this.txtCancel.Text = "Enter password to cancel response";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 20);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "submit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtsafeSentence
            // 
            this.txtsafeSentence.Location = new System.Drawing.Point(311, 237);
            this.txtsafeSentence.Name = "txtsafeSentence";
            this.txtsafeSentence.Size = new System.Drawing.Size(152, 20);
            this.txtsafeSentence.TabIndex = 60;
            this.txtsafeSentence.TextChanged += new System.EventHandler(this.txtsafeSentence_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Please enter safe sentence";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsafeSentence);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Response);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Response;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtsafeSentence;
        private System.Windows.Forms.Label label1;
    }
}