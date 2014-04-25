namespace Nara
{
    partial class BugStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugStats));
            this.btnFetch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Sheet = new System.Windows.Forms.Label();
            this.listOfSheets = new System.Windows.Forms.ComboBox();
            this.lblSno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnOpenCount = new System.Windows.Forms.Button();
            this.tbSno = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnFetchNext = new System.Windows.Forms.Button();
            this.btnFetchPrevious = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(96, 3);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Inset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Sheet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listOfSheets, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFileSelect, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.lblSno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 14);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 98);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Sheet
            // 
            this.Sheet.AutoSize = true;
            this.Sheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sheet.Location = new System.Drawing.Point(3, 0);
            this.Sheet.Name = "Sheet";
            this.Sheet.Size = new System.Drawing.Size(75, 27);
            this.Sheet.TabIndex = 1;
            this.Sheet.Text = "Select Sheet";
            this.Sheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listOfSheets
            // 
            this.listOfSheets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOfSheets.FormattingEnabled = true;
            this.listOfSheets.Location = new System.Drawing.Point(84, 3);
            this.listOfSheets.Name = "listOfSheets";
            this.listOfSheets.Size = new System.Drawing.Size(591, 21);
            this.listOfSheets.TabIndex = 2;
            this.listOfSheets.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSno.Location = new System.Drawing.Point(3, 27);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(75, 13);
            this.lblSno.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(84, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Location = new System.Drawing.Point(3, 43);
            this.btnFileSelect.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnFileSelect.TabIndex = 8;
            this.btnFileSelect.Text = "SetFilePath";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(358, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(423, 3);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Updata Sheet";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.Update_Click);
            // 
            // btnOpenCount
            // 
            this.btnOpenCount.Location = new System.Drawing.Point(262, 3);
            this.btnOpenCount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnOpenCount.Name = "btnOpenCount";
            this.btnOpenCount.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCount.TabIndex = 3;
            this.btnOpenCount.Text = "Open Count";
            this.btnOpenCount.UseVisualStyleBackColor = true;
            this.btnOpenCount.Click += new System.EventHandler(this.OpenCount_Click);
            // 
            // tbSno
            // 
            this.tbSno.Location = new System.Drawing.Point(10, 3);
            this.tbSno.Name = "tbSno";
            this.tbSno.Size = new System.Drawing.Size(75, 20);
            this.tbSno.TabIndex = 6;
            this.tbSno.Visible = false;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(92, 2);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(100, 20);
            this.tbStatus.TabIndex = 7;
            this.tbStatus.Visible = false;
            // 
            // btnFetchNext
            // 
            this.btnFetchNext.Location = new System.Drawing.Point(178, 3);
            this.btnFetchNext.Name = "btnFetchNext";
            this.btnFetchNext.Size = new System.Drawing.Size(75, 23);
            this.btnFetchNext.TabIndex = 9;
            this.btnFetchNext.Text = "Fecth Next";
            this.btnFetchNext.UseVisualStyleBackColor = true;
            this.btnFetchNext.Click += new System.EventHandler(this.btnFetchNext_Click);
            // 
            // btnFetchPrevious
            // 
            this.btnFetchPrevious.Location = new System.Drawing.Point(3, 3);
            this.btnFetchPrevious.Name = "btnFetchPrevious";
            this.btnFetchPrevious.Size = new System.Drawing.Size(87, 23);
            this.btnFetchPrevious.TabIndex = 10;
            this.btnFetchPrevious.Text = "Fecth Previous";
            this.btnFetchPrevious.UseVisualStyleBackColor = true;
            this.btnFetchPrevious.Click += new System.EventHandler(this.btnFetchPrevious_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnFetchPrevious, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOpenCount, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFetch, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFetchNext, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(591, 32);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // BugStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 98);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BugStats";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BugStats";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Sheet;
        private System.Windows.Forms.ComboBox listOfSheets;
        private System.Windows.Forms.Button btnOpenCount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbSno;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label lblSno;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnFetchPrevious;
        private System.Windows.Forms.Button btnFetchNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

