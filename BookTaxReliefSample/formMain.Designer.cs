
namespace BookTaxReliefSample
{
    partial class formMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMultiEan = new System.Windows.Forms.Button();
            this.btnMultiIsbn = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.btnGetEan = new System.Windows.Forms.Button();
            this.btnGetIsbn = new System.Windows.Forms.Button();
            this.btnGetDaily = new System.Windows.Forms.Button();
            this.btnGetPolicyExpiryDate = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMultiEan
            // 
            this.btnMultiEan.Location = new System.Drawing.Point(499, 95);
            this.btnMultiEan.Name = "btnMultiEan";
            this.btnMultiEan.Size = new System.Drawing.Size(109, 44);
            this.btnMultiEan.TabIndex = 23;
            this.btnMultiEan.Text = "查詢多筆EAN";
            this.btnMultiEan.UseVisualStyleBackColor = true;
            this.btnMultiEan.Click += new System.EventHandler(this.btnMultiEan_Click);
            // 
            // btnMultiIsbn
            // 
            this.btnMultiIsbn.Location = new System.Drawing.Point(384, 95);
            this.btnMultiIsbn.Name = "btnMultiIsbn";
            this.btnMultiIsbn.Size = new System.Drawing.Size(109, 44);
            this.btnMultiIsbn.TabIndex = 22;
            this.btnMultiIsbn.Text = "查詢多筆ISBN";
            this.btnMultiIsbn.UseVisualStyleBackColor = true;
            this.btnMultiIsbn.Click += new System.EventHandler(this.btnMultiIsbn_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(127, 45);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(136, 44);
            this.btnToday.TabIndex = 21;
            this.btnToday.Text = "查詢當日異動公告";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 145);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(596, 433);
            this.txtResult.TabIndex = 20;
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(12, 12);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(596, 22);
            this.txtParameter.TabIndex = 19;
            // 
            // btnGetEan
            // 
            this.btnGetEan.Location = new System.Drawing.Point(499, 45);
            this.btnGetEan.Name = "btnGetEan";
            this.btnGetEan.Size = new System.Drawing.Size(109, 44);
            this.btnGetEan.TabIndex = 18;
            this.btnGetEan.Text = "查詢EAN";
            this.btnGetEan.UseVisualStyleBackColor = true;
            this.btnGetEan.Click += new System.EventHandler(this.btnGetEan_Click);
            // 
            // btnGetIsbn
            // 
            this.btnGetIsbn.Location = new System.Drawing.Point(384, 45);
            this.btnGetIsbn.Name = "btnGetIsbn";
            this.btnGetIsbn.Size = new System.Drawing.Size(109, 44);
            this.btnGetIsbn.TabIndex = 17;
            this.btnGetIsbn.Text = "查詢ISBN";
            this.btnGetIsbn.UseVisualStyleBackColor = true;
            this.btnGetIsbn.Click += new System.EventHandler(this.btnGetIsbn_Click);
            // 
            // btnGetDaily
            // 
            this.btnGetDaily.Location = new System.Drawing.Point(269, 45);
            this.btnGetDaily.Name = "btnGetDaily";
            this.btnGetDaily.Size = new System.Drawing.Size(109, 44);
            this.btnGetDaily.TabIndex = 16;
            this.btnGetDaily.Text = "查詢異動公告";
            this.btnGetDaily.UseVisualStyleBackColor = true;
            this.btnGetDaily.Click += new System.EventHandler(this.btnGetDaily_Click);
            // 
            // btnGetPolicyExpiryDate
            // 
            this.btnGetPolicyExpiryDate.Location = new System.Drawing.Point(12, 45);
            this.btnGetPolicyExpiryDate.Name = "btnGetPolicyExpiryDate";
            this.btnGetPolicyExpiryDate.Size = new System.Drawing.Size(109, 44);
            this.btnGetPolicyExpiryDate.TabIndex = 15;
            this.btnGetPolicyExpiryDate.Text = "政策到期日期";
            this.btnGetPolicyExpiryDate.UseVisualStyleBackColor = true;
            this.btnGetPolicyExpiryDate.Click += new System.EventHandler(this.btnGetPolicyExpiryDate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(130, 100);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(217, 12);
            this.lblMessage.TabIndex = 24;
            this.lblMessage.Text = "1. 查詢異動公告日期格式為YYYYMMDD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(130, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "2.多筆查詢時, 各ISBN/EAN間請以半形逗號間隔";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnMultiEan);
            this.Controls.Add(this.btnMultiIsbn);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.btnGetEan);
            this.Controls.Add(this.btnGetIsbn);
            this.Controls.Add(this.btnGetDaily);
            this.Controls.Add(this.btnGetPolicyExpiryDate);
            this.Name = "formMain";
            this.Text = "Book Tax Relief API Client Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultiEan;
        private System.Windows.Forms.Button btnMultiIsbn;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Button btnGetEan;
        private System.Windows.Forms.Button btnGetIsbn;
        private System.Windows.Forms.Button btnGetDaily;
        private System.Windows.Forms.Button btnGetPolicyExpiryDate;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
    }
}

