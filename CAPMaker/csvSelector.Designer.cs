namespace CAPMaker
{
    partial class csvSelector
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbAreaType = new System.Windows.Forms.Label();
            this.cbAREADESC = new System.Windows.Forms.ComboBox();
            this.cbAreaType = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "AREADESC";
            // 
            // lbAreaType
            // 
            this.lbAreaType.AutoSize = true;
            this.lbAreaType.Location = new System.Drawing.Point(43, 86);
            this.lbAreaType.Name = "lbAreaType";
            this.lbAreaType.Size = new System.Drawing.Size(36, 12);
            this.lbAreaType.TabIndex = 1;
            this.lbAreaType.Text = "AREA";
            this.lbAreaType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbAREADESC
            // 
            this.cbAREADESC.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbAREADESC.FormattingEnabled = true;
            this.cbAREADESC.Location = new System.Drawing.Point(85, 43);
            this.cbAREADESC.Name = "cbAREADESC";
            this.cbAREADESC.Size = new System.Drawing.Size(151, 23);
            this.cbAREADESC.TabIndex = 2;
            // 
            // cbAreaType
            // 
            this.cbAreaType.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbAreaType.FormattingEnabled = true;
            this.cbAreaType.Location = new System.Drawing.Point(85, 80);
            this.cbAreaType.Name = "cbAreaType";
            this.cbAreaType.Size = new System.Drawing.Size(151, 23);
            this.cbAreaType.TabIndex = 3;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(89, 128);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "確定";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "請選擇欲匯入的資料欄位";
            // 
            // csvSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 163);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cbAreaType);
            this.Controls.Add(this.cbAREADESC);
            this.Controls.Add(this.lbAreaType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "csvSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "匯入AREA資料";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAreaType;
        private System.Windows.Forms.ComboBox cbAREADESC;
        private System.Windows.Forms.ComboBox cbAreaType;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label2;
    }
}