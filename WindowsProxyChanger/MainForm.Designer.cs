namespace WindowsProxyChanger
{
    partial class MainForm
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
            this.tbt_inputProxy = new System.Windows.Forms.TextBox();
            this.lb_import = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.layout_grb = new System.Windows.Forms.GroupBox();
            this.cb_AuthProxy = new System.Windows.Forms.CheckBox();
            this.lb_authenticate = new System.Windows.Forms.Label();
            this.tbt_passwordProxy = new System.Windows.Forms.TextBox();
            this.tbt_usernameProxy = new System.Windows.Forms.TextBox();
            this.lb_dotProxy = new System.Windows.Forms.Label();
            this.tbt_portProxy = new System.Windows.Forms.TextBox();
            this.tbt_ipProxy = new System.Windows.Forms.TextBox();
            this.btn_changeProxy = new System.Windows.Forms.Button();
            this.btn_removeProxy = new System.Windows.Forms.Button();
            this.lb_infomationProxy = new System.Windows.Forms.Label();
            this.infomationProxy = new System.Windows.Forms.Label();
            this.layout_grb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbt_inputProxy
            // 
            this.tbt_inputProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbt_inputProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbt_inputProxy.Location = new System.Drawing.Point(82, 24);
            this.tbt_inputProxy.Name = "tbt_inputProxy";
            this.tbt_inputProxy.Size = new System.Drawing.Size(202, 27);
            this.tbt_inputProxy.TabIndex = 0;
            this.tbt_inputProxy.Text = "Nhập proxy tại đây...";
            this.tbt_inputProxy.Click += new System.EventHandler(this.tbt_inputProxy_Click);
            // 
            // lb_import
            // 
            this.lb_import.AutoSize = true;
            this.lb_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_import.Location = new System.Drawing.Point(10, 26);
            this.lb_import.Name = "lb_import";
            this.lb_import.Size = new System.Drawing.Size(66, 20);
            this.lb_import.TabIndex = 1;
            this.lb_import.Text = "Import :";
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.Location = new System.Drawing.Point(290, 22);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(46, 31);
            this.btn_import.TabIndex = 2;
            this.btn_import.Text = "...";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // layout_grb
            // 
            this.layout_grb.Controls.Add(this.cb_AuthProxy);
            this.layout_grb.Controls.Add(this.lb_authenticate);
            this.layout_grb.Controls.Add(this.tbt_passwordProxy);
            this.layout_grb.Controls.Add(this.tbt_usernameProxy);
            this.layout_grb.Controls.Add(this.lb_dotProxy);
            this.layout_grb.Controls.Add(this.tbt_portProxy);
            this.layout_grb.Controls.Add(this.tbt_ipProxy);
            this.layout_grb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layout_grb.Location = new System.Drawing.Point(12, 124);
            this.layout_grb.Name = "layout_grb";
            this.layout_grb.Size = new System.Drawing.Size(347, 183);
            this.layout_grb.TabIndex = 3;
            this.layout_grb.TabStop = false;
            this.layout_grb.Text = "Thông tin";
            // 
            // cb_AuthProxy
            // 
            this.cb_AuthProxy.AutoSize = true;
            this.cb_AuthProxy.Location = new System.Drawing.Point(212, 103);
            this.cb_AuthProxy.Name = "cb_AuthProxy";
            this.cb_AuthProxy.Size = new System.Drawing.Size(126, 24);
            this.cb_AuthProxy.TabIndex = 10;
            this.cb_AuthProxy.Text = "Auth Proxy ?";
            this.cb_AuthProxy.UseVisualStyleBackColor = true;
            this.cb_AuthProxy.CheckedChanged += new System.EventHandler(this.cb_AuthProxy_CheckedChanged);
            // 
            // lb_authenticate
            // 
            this.lb_authenticate.AutoSize = true;
            this.lb_authenticate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_authenticate.Location = new System.Drawing.Point(20, 76);
            this.lb_authenticate.Name = "lb_authenticate";
            this.lb_authenticate.Size = new System.Drawing.Size(112, 20);
            this.lb_authenticate.TabIndex = 4;
            this.lb_authenticate.Text = "Authenticate :";
            // 
            // tbt_passwordProxy
            // 
            this.tbt_passwordProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbt_passwordProxy.Enabled = false;
            this.tbt_passwordProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbt_passwordProxy.Location = new System.Drawing.Point(24, 137);
            this.tbt_passwordProxy.Name = "tbt_passwordProxy";
            this.tbt_passwordProxy.Size = new System.Drawing.Size(166, 27);
            this.tbt_passwordProxy.TabIndex = 9;
            this.tbt_passwordProxy.Text = "Password";
            this.tbt_passwordProxy.Click += new System.EventHandler(this.tbt_passwordProxy_Click);
            // 
            // tbt_usernameProxy
            // 
            this.tbt_usernameProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbt_usernameProxy.Enabled = false;
            this.tbt_usernameProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbt_usernameProxy.Location = new System.Drawing.Point(24, 103);
            this.tbt_usernameProxy.Name = "tbt_usernameProxy";
            this.tbt_usernameProxy.Size = new System.Drawing.Size(166, 27);
            this.tbt_usernameProxy.TabIndex = 8;
            this.tbt_usernameProxy.Text = "Username";
            this.tbt_usernameProxy.Click += new System.EventHandler(this.tbt_usernameProxy_Click);
            // 
            // lb_dotProxy
            // 
            this.lb_dotProxy.AutoSize = true;
            this.lb_dotProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dotProxy.Location = new System.Drawing.Point(196, 43);
            this.lb_dotProxy.Name = "lb_dotProxy";
            this.lb_dotProxy.Size = new System.Drawing.Size(14, 20);
            this.lb_dotProxy.TabIndex = 4;
            this.lb_dotProxy.Text = ":";
            // 
            // tbt_portProxy
            // 
            this.tbt_portProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbt_portProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbt_portProxy.Location = new System.Drawing.Point(212, 40);
            this.tbt_portProxy.Name = "tbt_portProxy";
            this.tbt_portProxy.Size = new System.Drawing.Size(97, 27);
            this.tbt_portProxy.TabIndex = 6;
            this.tbt_portProxy.Text = "Port";
            this.tbt_portProxy.Click += new System.EventHandler(this.tbt_portProxy_Click);
            // 
            // tbt_ipProxy
            // 
            this.tbt_ipProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbt_ipProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbt_ipProxy.Location = new System.Drawing.Point(24, 40);
            this.tbt_ipProxy.Name = "tbt_ipProxy";
            this.tbt_ipProxy.Size = new System.Drawing.Size(169, 27);
            this.tbt_ipProxy.TabIndex = 4;
            this.tbt_ipProxy.Text = "Ip";
            this.tbt_ipProxy.Click += new System.EventHandler(this.tbt_ipProxy_Click);
            // 
            // btn_changeProxy
            // 
            this.btn_changeProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeProxy.Location = new System.Drawing.Point(46, 313);
            this.btn_changeProxy.Name = "btn_changeProxy";
            this.btn_changeProxy.Size = new System.Drawing.Size(98, 31);
            this.btn_changeProxy.TabIndex = 4;
            this.btn_changeProxy.Text = "Change";
            this.btn_changeProxy.UseVisualStyleBackColor = true;
            this.btn_changeProxy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_removeProxy
            // 
            this.btn_removeProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeProxy.Location = new System.Drawing.Point(212, 313);
            this.btn_removeProxy.Name = "btn_removeProxy";
            this.btn_removeProxy.Size = new System.Drawing.Size(98, 31);
            this.btn_removeProxy.TabIndex = 12;
            this.btn_removeProxy.Text = "Remove";
            this.btn_removeProxy.UseVisualStyleBackColor = true;
            this.btn_removeProxy.Click += new System.EventHandler(this.btn_removeProxy_Click);
            // 
            // lb_infomationProxy
            // 
            this.lb_infomationProxy.AutoSize = true;
            this.lb_infomationProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_infomationProxy.Location = new System.Drawing.Point(12, 73);
            this.lb_infomationProxy.Name = "lb_infomationProxy";
            this.lb_infomationProxy.Size = new System.Drawing.Size(61, 20);
            this.lb_infomationProxy.TabIndex = 13;
            this.lb_infomationProxy.Text = "Proxy :";
            // 
            // infomationProxy
            // 
            this.infomationProxy.AutoSize = true;
            this.infomationProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infomationProxy.Location = new System.Drawing.Point(79, 73);
            this.infomationProxy.Name = "infomationProxy";
            this.infomationProxy.Size = new System.Drawing.Size(112, 20);
            this.infomationProxy.TabIndex = 14;
            this.infomationProxy.Text = "Chưa thiết lập";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(364, 361);
            this.Controls.Add(this.infomationProxy);
            this.Controls.Add(this.lb_infomationProxy);
            this.Controls.Add(this.btn_removeProxy);
            this.Controls.Add(this.layout_grb);
            this.Controls.Add(this.btn_changeProxy);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.lb_import);
            this.Controls.Add(this.tbt_inputProxy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Proxy Changer - ZyrM";
            this.layout_grb.ResumeLayout(false);
            this.layout_grb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbt_inputProxy;
        private System.Windows.Forms.Label lb_import;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.GroupBox layout_grb;
        private System.Windows.Forms.TextBox tbt_ipProxy;
        private System.Windows.Forms.TextBox tbt_portProxy;
        private System.Windows.Forms.Label lb_dotProxy;
        private System.Windows.Forms.Label lb_authenticate;
        private System.Windows.Forms.TextBox tbt_passwordProxy;
        private System.Windows.Forms.TextBox tbt_usernameProxy;
        private System.Windows.Forms.Button btn_removeProxy;
        private System.Windows.Forms.Button btn_changeProxy;
        private System.Windows.Forms.CheckBox cb_AuthProxy;
        private System.Windows.Forms.Label lb_infomationProxy;
        private System.Windows.Forms.Label infomationProxy;
    }
}

