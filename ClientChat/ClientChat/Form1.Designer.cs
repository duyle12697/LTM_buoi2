namespace ClientChat
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.lbClient = new System.Windows.Forms.ListBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(111, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(148, 20);
            this.txtIP.TabIndex = 0;
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(286, 13);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 20);
            this.btnConn.TabIndex = 1;
            this.btnConn.Text = "button1";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // lbClient
            // 
            this.lbClient.FormattingEnabled = true;
            this.lbClient.Location = new System.Drawing.Point(12, 51);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(517, 186);
            this.lbClient.TabIndex = 2;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(373, 243);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 51);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "button2";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(454, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "button3";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(12, 243);
            this.txtClient.Multiline = true;
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(355, 51);
            this.txtClient.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 304);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.txtIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.ListBox lbClient;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtClient;
    }
}

