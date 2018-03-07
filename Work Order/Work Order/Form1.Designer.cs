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
            this.bt_Create_New_WO = new System.Windows.Forms.Button();
            this.bt_Upload = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Change = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tb_WOnum = new System.Windows.Forms.TextBox();
            this.tb_SEnum = new System.Windows.Forms.TextBox();
            this.tb_DATE = new System.Windows.Forms.TextBox();
            this.tb_SNnum = new System.Windows.Forms.TextBox();
            this.lv_Database = new System.Windows.Forms.ListView();
            this.tb_CLname = new System.Windows.Forms.TextBox();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.rb_Inprogress = new System.Windows.Forms.RadioButton();
            this.rb_Delivered = new System.Windows.Forms.RadioButton();
            this.lb_links = new System.Windows.Forms.ListBox();
            this.ofd_uploadFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bt_Create_New_WO
            // 
            this.bt_Create_New_WO.Location = new System.Drawing.Point(12, 588);
            this.bt_Create_New_WO.Name = "bt_Create_New_WO";
            this.bt_Create_New_WO.Size = new System.Drawing.Size(162, 35);
            this.bt_Create_New_WO.TabIndex = 10;
            this.bt_Create_New_WO.Text = "Create New Order";
            this.bt_Create_New_WO.UseVisualStyleBackColor = true;
            this.bt_Create_New_WO.Click += new System.EventHandler(this.bt_Create_New_WO_Click);
            // 
            // bt_Upload
            // 
            this.bt_Upload.Location = new System.Drawing.Point(180, 588);
            this.bt_Upload.Name = "bt_Upload";
            this.bt_Upload.Size = new System.Drawing.Size(162, 35);
            this.bt_Upload.TabIndex = 1;
            this.bt_Upload.Text = "Upload";
            this.bt_Upload.UseVisualStyleBackColor = true;
            this.bt_Upload.Click += new System.EventHandler(this.bt_Upload_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(348, 588);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(162, 35);
            this.bt_Delete.TabIndex = 2;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_Change
            // 
            this.bt_Change.Location = new System.Drawing.Point(516, 588);
            this.bt_Change.Name = "bt_Change";
            this.bt_Change.Size = new System.Drawing.Size(162, 35);
            this.bt_Change.TabIndex = 3;
            this.bt_Change.Text = "Add 50 random";
            this.bt_Change.UseVisualStyleBackColor = true;
            this.bt_Change.Click += new System.EventHandler(this.bt_Change_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(348, 655);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(162, 21);
            this.bt_Search.TabIndex = 16;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = true;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(11, 655);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(331, 20);
            this.tb_search.TabIndex = 15;
            // 
            // tb_WOnum
            // 
            this.tb_WOnum.Location = new System.Drawing.Point(107, 629);
            this.tb_WOnum.Name = "tb_WOnum";
            this.tb_WOnum.Size = new System.Drawing.Size(66, 20);
            this.tb_WOnum.TabIndex = 5;
            this.tb_WOnum.Text = "WO#";
            this.tb_WOnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_WOnum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_WOnum_MouseClick);
            this.tb_WOnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_WOnum_KeyPress);
            // 
            // tb_SEnum
            // 
            this.tb_SEnum.Location = new System.Drawing.Point(444, 629);
            this.tb_SEnum.Name = "tb_SEnum";
            this.tb_SEnum.Size = new System.Drawing.Size(66, 20);
            this.tb_SEnum.TabIndex = 8;
            this.tb_SEnum.Text = "SE#";
            this.tb_SEnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_SEnum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_SEnum_MouseClick);
            // 
            // tb_DATE
            // 
            this.tb_DATE.Location = new System.Drawing.Point(12, 629);
            this.tb_DATE.Name = "tb_DATE";
            this.tb_DATE.Size = new System.Drawing.Size(90, 20);
            this.tb_DATE.TabIndex = 4;
            this.tb_DATE.Text = "Date";
            this.tb_DATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_SNnum
            // 
            this.tb_SNnum.Location = new System.Drawing.Point(348, 629);
            this.tb_SNnum.Name = "tb_SNnum";
            this.tb_SNnum.Size = new System.Drawing.Size(90, 20);
            this.tb_SNnum.TabIndex = 7;
            this.tb_SNnum.Text = "SN#";
            this.tb_SNnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_SNnum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_SNnum_MouseClick);
            // 
            // lv_Database
            // 
            this.lv_Database.FullRowSelect = true;
            this.lv_Database.GridLines = true;
            this.lv_Database.HideSelection = false;
            this.lv_Database.Location = new System.Drawing.Point(12, 12);
            this.lv_Database.MultiSelect = false;
            this.lv_Database.Name = "lv_Database";
            this.lv_Database.Size = new System.Drawing.Size(960, 560);
            this.lv_Database.TabIndex = 17;
            this.lv_Database.UseCompatibleStateImageBehavior = false;
            this.lv_Database.View = System.Windows.Forms.View.Details;
            this.lv_Database.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_Database_ColumnClick);
            this.lv_Database.SelectedIndexChanged += new System.EventHandler(this.lv_Database_SelectedIndexChanged);
            // 
            // tb_CLname
            // 
            this.tb_CLname.Location = new System.Drawing.Point(180, 629);
            this.tb_CLname.Name = "tb_CLname";
            this.tb_CLname.Size = new System.Drawing.Size(162, 20);
            this.tb_CLname.TabIndex = 6;
            this.tb_CLname.Text = "Client";
            this.tb_CLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_CLname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_CLname_MouseClick);
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(516, 629);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(162, 20);
            this.tb_description.TabIndex = 9;
            this.tb_description.Text = "Description";
            this.tb_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb_Inprogress
            // 
            this.rb_Inprogress.AutoSize = true;
            this.rb_Inprogress.Checked = true;
            this.rb_Inprogress.Location = new System.Drawing.Point(684, 588);
            this.rb_Inprogress.Name = "rb_Inprogress";
            this.rb_Inprogress.Size = new System.Drawing.Size(74, 17);
            this.rb_Inprogress.TabIndex = 21;
            this.rb_Inprogress.TabStop = true;
            this.rb_Inprogress.Text = "Inprogress";
            this.rb_Inprogress.UseVisualStyleBackColor = true;
            // 
            // rb_Delivered
            // 
            this.rb_Delivered.AutoSize = true;
            this.rb_Delivered.Location = new System.Drawing.Point(684, 606);
            this.rb_Delivered.Name = "rb_Delivered";
            this.rb_Delivered.Size = new System.Drawing.Size(70, 17);
            this.rb_Delivered.TabIndex = 22;
            this.rb_Delivered.Text = "Delivered";
            this.rb_Delivered.UseVisualStyleBackColor = true;
            // 
            // lb_links
            // 
            this.lb_links.FormattingEnabled = true;
            this.lb_links.Location = new System.Drawing.Point(764, 588);
            this.lb_links.Name = "lb_links";
            this.lb_links.Size = new System.Drawing.Size(208, 108);
            this.lb_links.TabIndex = 23;
            this.lb_links.TabStop = false;
            // 
            // ofd_uploadFile
            // 
            this.ofd_uploadFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.lb_links);
            this.Controls.Add(this.rb_Delivered);
            this.Controls.Add(this.rb_Inprogress);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.tb_CLname);
            this.Controls.Add(this.lv_Database);
            this.Controls.Add(this.tb_SNnum);
            this.Controls.Add(this.tb_DATE);
            this.Controls.Add(this.tb_SEnum);
            this.Controls.Add(this.tb_WOnum);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.bt_Change);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Upload);
            this.Controls.Add(this.bt_Create_New_WO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Create_New_WO;
        private System.Windows.Forms.Button bt_Upload;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Change;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_WOnum;
        private System.Windows.Forms.TextBox tb_SEnum;
        private System.Windows.Forms.TextBox tb_DATE;
        private System.Windows.Forms.TextBox tb_SNnum;
        private System.Windows.Forms.ListView lv_Database;
        private System.Windows.Forms.TextBox tb_CLname;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.RadioButton rb_Inprogress;
        private System.Windows.Forms.RadioButton rb_Delivered;
        private System.Windows.Forms.ListBox lb_links;
        private System.Windows.Forms.OpenFileDialog ofd_uploadFile;
    }
}

