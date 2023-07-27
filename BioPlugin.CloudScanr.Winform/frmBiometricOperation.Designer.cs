using System.Windows.Forms;

namespace BioPlugin.CloudScanr.Winform
{
    partial class frmBiometricOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiometricOperation));
            this.label1 = new System.Windows.Forms.Label();
            this.registrationId = new System.Windows.Forms.TextBox();
            this.btnIsRegistered = new System.Windows.Forms.Button();
            this.txtBiometricOperationStatus = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangeId = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtOldID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Id";
            // 
            // registrationId
            // 
            this.registrationId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationId.BackColor = System.Drawing.Color.White;
            this.registrationId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registrationId.Location = new System.Drawing.Point(104, 39);
            this.registrationId.Multiline = true;
            this.registrationId.Name = "registrationId";
            this.registrationId.Size = new System.Drawing.Size(454, 25);
            this.registrationId.TabIndex = 1;
            // 
            // btnIsRegistered
            // 
            this.btnIsRegistered.BackColor = System.Drawing.Color.Transparent;
            this.btnIsRegistered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIsRegistered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIsRegistered.Location = new System.Drawing.Point(10, 118);
            this.btnIsRegistered.Name = "btnIsRegistered";
            this.btnIsRegistered.Size = new System.Drawing.Size(126, 39);
            this.btnIsRegistered.TabIndex = 2;
            this.btnIsRegistered.Text = "Is Registerd";
            this.btnIsRegistered.UseVisualStyleBackColor = false;
            this.btnIsRegistered.Click += new System.EventHandler(this.btnIsRegistered_Click);
            // 
            // txtBiometricOperationStatus
            // 
            this.txtBiometricOperationStatus.Location = new System.Drawing.Point(13, 249);
            this.txtBiometricOperationStatus.Name = "txtBiometricOperationStatus";
            this.txtBiometricOperationStatus.Size = new System.Drawing.Size(546, 223);
            this.txtBiometricOperationStatus.TabIndex = 9;
            this.txtBiometricOperationStatus.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Biometric Operation Status";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Location = new System.Drawing.Point(151, 118);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(126, 39);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnIdentify
            // 
            this.btnIdentify.BackColor = System.Drawing.Color.Transparent;
            this.btnIdentify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIdentify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentify.Location = new System.Drawing.Point(292, 118);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(126, 39);
            this.btnIdentify.TabIndex = 12;
            this.btnIdentify.Text = "Identify";
            this.btnIdentify.UseVisualStyleBackColor = false;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Transparent;
            this.btnVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Location = new System.Drawing.Point(432, 118);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(126, 39);
            this.btnVerify.TabIndex = 13;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(10, 163);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 39);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(292, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 39);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete ID";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChangeId
            // 
            this.btnChangeId.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeId.Location = new System.Drawing.Point(151, 163);
            this.btnChangeId.Name = "btnChangeId";
            this.btnChangeId.Size = new System.Drawing.Size(126, 39);
            this.btnChangeId.TabIndex = 14;
            this.btnChangeId.Text = "Change ID";
            this.btnChangeId.UseVisualStyleBackColor = false;
            this.btnChangeId.Click += new System.EventHandler(this.btnChangeId_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(533, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 25);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtOldID
            // 
            this.txtOldID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldID.BackColor = System.Drawing.Color.White;
            this.txtOldID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldID.Location = new System.Drawing.Point(104, 82);
            this.txtOldID.Multiline = true;
            this.txtOldID.Name = "txtOldID";
            this.txtOldID.Size = new System.Drawing.Size(454, 25);
            this.txtOldID.TabIndex = 19;
            this.txtOldID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Old Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmBiometricOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(570, 493);
            this.Controls.Add(this.txtOldID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChangeId);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBiometricOperationStatus);
            this.Controls.Add(this.btnIsRegistered);
            this.Controls.Add(this.registrationId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBiometricOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biometric Operation";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registrationId;
        private System.Windows.Forms.Button btnIsRegistered;
        private System.Windows.Forms.RichTextBox txtBiometricOperationStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangeId;
        private System.Windows.Forms.Button btnClose;
        private TextBox txtOldID;
        private Label label3;
    }
}

