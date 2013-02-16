namespace File_System_Monitor
{
    partial class Query
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
            this.lvQuery = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maskExtension = new System.Windows.Forms.MaskedTextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvQuery
            // 
            this.lvQuery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colPath,
            this.colFilename,
            this.colExt,
            this.colEvent,
            this.colTime});
            this.lvQuery.FullRowSelect = true;
            this.lvQuery.GridLines = true;
            this.lvQuery.Location = new System.Drawing.Point(0, 59);
            this.lvQuery.Name = "lvQuery";
            this.lvQuery.Size = new System.Drawing.Size(741, 290);
            this.lvQuery.TabIndex = 0;
            this.lvQuery.UseCompatibleStateImageBehavior = false;
            this.lvQuery.View = System.Windows.Forms.View.Details;
            this.lvQuery.SelectedIndexChanged += new System.EventHandler(this.lvQuery_SelectedIndexChanged);
            // 
            // colIndex
            // 
            this.colIndex.Text = "Index";
            // 
            // colPath
            // 
            this.colPath.Text = "Path";
            this.colPath.Width = 240;
            // 
            // colFilename
            // 
            this.colFilename.Text = "Filename";
            this.colFilename.Width = 140;
            // 
            // colExt
            // 
            this.colExt.Text = "Ext";
            this.colExt.Width = 44;
            // 
            // colEvent
            // 
            this.colEvent.Text = "Event";
            this.colEvent.Width = 105;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 147;
            // 
            // maskExtension
            // 
            this.maskExtension.Location = new System.Drawing.Point(13, 33);
            this.maskExtension.Mask = "*.&";
            this.maskExtension.Name = "maskExtension";
            this.maskExtension.Size = new System.Drawing.Size(53, 20);
            this.maskExtension.TabIndex = 1;
            this.maskExtension.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskExtension_MaskInputRejected);
            this.maskExtension.TextChanged += new System.EventHandler(this.maskExtension_TextChanged);
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(10, 17);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(53, 13);
            this.lblExtension.TabIndex = 2;
            this.lblExtension.Text = "Extension";
            this.lblExtension.Click += new System.EventHandler(this.lblExtension_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(69, 30);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(43, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 350);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.maskExtension);
            this.Controls.Add(this.lvQuery);
            this.Name = "Query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Query";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvQuery;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.Windows.Forms.ColumnHeader colFilename;
        private System.Windows.Forms.ColumnHeader colExt;
        private System.Windows.Forms.ColumnHeader colEvent;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.MaskedTextBox maskExtension;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Button btnQuery;
    }
}