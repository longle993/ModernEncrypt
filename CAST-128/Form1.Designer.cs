namespace CAST_128
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            lblInput = new Label();
            label1 = new Label();
            txtKey = new TextBox();
            label2 = new Label();
            txtCipherText = new TextBox();
            btnGenerateKey = new Button();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            txtCipherTextBit = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 12F);
            txtInput.Location = new Point(193, 56);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(225, 34);
            txtInput.TabIndex = 0;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(76, 66);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(73, 20);
            lblInput.TabIndex = 1;
            lblInput.Text = "Plain text:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 150);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 3;
            label1.Text = "Key:";
            // 
            // txtKey
            // 
            txtKey.Font = new Font("Segoe UI", 12F);
            txtKey.Location = new Point(193, 140);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(225, 34);
            txtKey.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 232);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 5;
            label2.Text = "Cipher Text:";
            // 
            // txtCipherText
            // 
            txtCipherText.Font = new Font("Segoe UI", 12F);
            txtCipherText.Location = new Point(193, 222);
            txtCipherText.Name = "txtCipherText";
            txtCipherText.Size = new Size(225, 34);
            txtCipherText.TabIndex = 4;
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateKey.Location = new Point(76, 307);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(160, 58);
            btnGenerateKey.TabIndex = 6;
            btnGenerateKey.Text = "Generate Key";
            btnGenerateKey.UseVisualStyleBackColor = true;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncrypt.Location = new Point(258, 307);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(160, 58);
            btnEncrypt.TabIndex = 7;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecrypt.Location = new Point(458, 307);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(160, 58);
            btnDecrypt.TabIndex = 8;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtCipherTextBit
            // 
            txtCipherTextBit.Font = new Font("Segoe UI", 12F);
            txtCipherTextBit.Location = new Point(458, 222);
            txtCipherTextBit.Name = "txtCipherTextBit";
            txtCipherTextBit.Size = new Size(225, 34);
            txtCipherTextBit.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCipherTextBit);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnGenerateKey);
            Controls.Add(label2);
            Controls.Add(txtCipherText);
            Controls.Add(label1);
            Controls.Add(txtKey);
            Controls.Add(lblInput);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label lblInput;
        private Label label1;
        private TextBox txtKey;
        private Label label2;
        private TextBox txtCipherText;
        private Button btnGenerateKey;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private TextBox txtCipherTextBit;
    }
}
