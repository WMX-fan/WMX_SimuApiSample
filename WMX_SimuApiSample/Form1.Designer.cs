
namespace WMX_SimuApiSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.InputONbutton = new System.Windows.Forms.Button();
            this.InputGroup = new System.Windows.Forms.GroupBox();
            this.InputOFFbutton = new System.Windows.Forms.Button();
            this.InputAddres = new System.Windows.Forms.NumericUpDown();
            this.InputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputAddres)).BeginInit();
            this.SuspendLayout();
            // 
            // InputONbutton
            // 
            this.InputONbutton.Location = new System.Drawing.Point(39, 67);
            this.InputONbutton.Name = "InputONbutton";
            this.InputONbutton.Size = new System.Drawing.Size(63, 63);
            this.InputONbutton.TabIndex = 0;
            this.InputONbutton.Text = "ON";
            this.InputONbutton.UseVisualStyleBackColor = true;
            this.InputONbutton.Click += new System.EventHandler(this.InputONbutton_Click);
            // 
            // InputGroup
            // 
            this.InputGroup.Controls.Add(this.InputOFFbutton);
            this.InputGroup.Controls.Add(this.InputAddres);
            this.InputGroup.Controls.Add(this.InputONbutton);
            this.InputGroup.Location = new System.Drawing.Point(22, 27);
            this.InputGroup.Name = "InputGroup";
            this.InputGroup.Size = new System.Drawing.Size(239, 148);
            this.InputGroup.TabIndex = 1;
            this.InputGroup.TabStop = false;
            this.InputGroup.Text = "デジタル入力";
            // 
            // InputOFFbutton
            // 
            this.InputOFFbutton.Location = new System.Drawing.Point(137, 67);
            this.InputOFFbutton.Name = "InputOFFbutton";
            this.InputOFFbutton.Size = new System.Drawing.Size(63, 63);
            this.InputOFFbutton.TabIndex = 3;
            this.InputOFFbutton.Text = "OFF";
            this.InputOFFbutton.UseVisualStyleBackColor = true;
            this.InputOFFbutton.Click += new System.EventHandler(this.InputOFFbutton_Click);
            // 
            // InputAddres
            // 
            this.InputAddres.DecimalPlaces = 1;
            this.InputAddres.Location = new System.Drawing.Point(39, 25);
            this.InputAddres.Name = "InputAddres";
            this.InputAddres.Size = new System.Drawing.Size(116, 19);
            this.InputAddres.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 186);
            this.Controls.Add(this.InputGroup);
            this.Name = "Form1";
            this.Text = "WMX_SimuApiSample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputAddres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InputONbutton;
        private System.Windows.Forms.GroupBox InputGroup;
        private System.Windows.Forms.Button InputOFFbutton;
        private System.Windows.Forms.NumericUpDown InputAddres;
    }
}

