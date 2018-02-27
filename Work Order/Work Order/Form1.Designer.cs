namespace Work_Order
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
            this.lb_Database = new System.Windows.Forms.ListBox();
            this.bt_Create_New_WO = new System.Windows.Forms.Button();
            this.bt_Upload = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Change = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bt_woUpdate = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tb_WOnum = new System.Windows.Forms.TextBox();
            this.tb_SEnum = new System.Windows.Forms.TextBox();
            this.bt_seUpdate = new System.Windows.Forms.Button();
            this.tb_DATE = new System.Windows.Forms.TextBox();
            this.bt_dateUpdate = new System.Windows.Forms.Button();
            this.tb_SNnum = new System.Windows.Forms.TextBox();
            this.bt_snUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Database
            // 
            this.lb_Database.FormattingEnabled = true;
            this.lb_Database.Location = new System.Drawing.Point(12, 12);
            this.lb_Database.Name = "lb_Database";
            this.lb_Database.Size = new System.Drawing.Size(292, 615);
            this.lb_Database.TabIndex = 0;
            // 
            // bt_Create_New_WO
            // 
            this.bt_Create_New_WO.Location = new System.Drawing.Point(310, 12);
            this.bt_Create_New_WO.Name = "bt_Create_New_WO";
            this.bt_Create_New_WO.Size = new System.Drawing.Size(162, 35);
            this.bt_Create_New_WO.TabIndex = 1;
            this.bt_Create_New_WO.Text = "Create New Order";
            this.bt_Create_New_WO.UseVisualStyleBackColor = true;
            // 
            // bt_Upload
            // 
            this.bt_Upload.Location = new System.Drawing.Point(310, 53);
            this.bt_Upload.Name = "bt_Upload";
            this.bt_Upload.Size = new System.Drawing.Size(162, 35);
            this.bt_Upload.TabIndex = 2;
            this.bt_Upload.Text = "Upload";
            this.bt_Upload.UseVisualStyleBackColor = true;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(310, 94);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(162, 35);
            this.bt_Delete.TabIndex = 3;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_Change
            // 
            this.bt_Change.Location = new System.Drawing.Point(310, 135);
            this.bt_Change.Name = "bt_Change";
            this.bt_Change.Size = new System.Drawing.Size(162, 35);
            this.bt_Change.TabIndex = 4;
            this.bt_Change.Text = "Change";
            this.bt_Change.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(310, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // bt_woUpdate
            // 
            this.bt_woUpdate.Location = new System.Drawing.Point(406, 217);
            this.bt_woUpdate.Name = "bt_woUpdate";
            this.bt_woUpdate.Size = new System.Drawing.Size(66, 21);
            this.bt_woUpdate.TabIndex = 6;
            this.bt_woUpdate.Text = "Update";
            this.bt_woUpdate.UseVisualStyleBackColor = true;
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(198, 633);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(106, 21);
            this.bt_Search.TabIndex = 7;
            this.bt_Search.Text = "button7";
            this.bt_Search.UseVisualStyleBackColor = true;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(12, 633);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(169, 20);
            this.tb_search.TabIndex = 8;
            // 
            // tb_WOnum
            // 
            this.tb_WOnum.Location = new System.Drawing.Point(310, 218);
            this.tb_WOnum.Name = "tb_WOnum";
            this.tb_WOnum.Size = new System.Drawing.Size(90, 20);
            this.tb_WOnum.TabIndex = 9;
            this.tb_WOnum.Text = "WO#";
            this.tb_WOnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_SEnum
            // 
            this.tb_SEnum.Location = new System.Drawing.Point(310, 244);
            this.tb_SEnum.Name = "tb_SEnum";
            this.tb_SEnum.Size = new System.Drawing.Size(90, 20);
            this.tb_SEnum.TabIndex = 11;
            this.tb_SEnum.Text = "SE#";
            this.tb_SEnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_seUpdate
            // 
            this.bt_seUpdate.Location = new System.Drawing.Point(406, 243);
            this.bt_seUpdate.Name = "bt_seUpdate";
            this.bt_seUpdate.Size = new System.Drawing.Size(66, 21);
            this.bt_seUpdate.TabIndex = 10;
            this.bt_seUpdate.Text = "Update";
            this.bt_seUpdate.UseVisualStyleBackColor = true;
            // 
            // tb_DATE
            // 
            this.tb_DATE.Location = new System.Drawing.Point(310, 270);
            this.tb_DATE.Name = "tb_DATE";
            this.tb_DATE.Size = new System.Drawing.Size(90, 20);
            this.tb_DATE.TabIndex = 13;
            this.tb_DATE.Text = "Date";
            this.tb_DATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_dateUpdate
            // 
            this.bt_dateUpdate.Location = new System.Drawing.Point(406, 269);
            this.bt_dateUpdate.Name = "bt_dateUpdate";
            this.bt_dateUpdate.Size = new System.Drawing.Size(66, 21);
            this.bt_dateUpdate.TabIndex = 12;
            this.bt_dateUpdate.Text = "Update";
            this.bt_dateUpdate.UseVisualStyleBackColor = true;
            // 
            // tb_SNnum
            // 
            this.tb_SNnum.Location = new System.Drawing.Point(310, 296);
            this.tb_SNnum.Name = "tb_SNnum";
            this.tb_SNnum.Size = new System.Drawing.Size(90, 20);
            this.tb_SNnum.TabIndex = 15;
            this.tb_SNnum.Text = "SN#";
            this.tb_SNnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_snUpdate
            // 
            this.bt_snUpdate.Location = new System.Drawing.Point(406, 295);
            this.bt_snUpdate.Name = "bt_snUpdate";
            this.bt_snUpdate.Size = new System.Drawing.Size(66, 21);
            this.bt_snUpdate.TabIndex = 14;
            this.bt_snUpdate.Text = "Update";
            this.bt_snUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.tb_SNnum);
            this.Controls.Add(this.bt_snUpdate);
            this.Controls.Add(this.tb_DATE);
            this.Controls.Add(this.bt_dateUpdate);
            this.Controls.Add(this.tb_SEnum);
            this.Controls.Add(this.bt_seUpdate);
            this.Controls.Add(this.tb_WOnum);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.bt_woUpdate);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_Change);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Upload);
            this.Controls.Add(this.bt_Create_New_WO);
            this.Controls.Add(this.lb_Database);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Database;
        private System.Windows.Forms.Button bt_Create_New_WO;
        private System.Windows.Forms.Button bt_Upload;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Change;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bt_woUpdate;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_WOnum;
        private System.Windows.Forms.TextBox tb_SEnum;
        private System.Windows.Forms.Button bt_seUpdate;
        private System.Windows.Forms.TextBox tb_DATE;
        private System.Windows.Forms.Button bt_dateUpdate;
        private System.Windows.Forms.TextBox tb_SNnum;
        private System.Windows.Forms.Button bt_snUpdate;
    }
}

