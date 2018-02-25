namespace dwFotoWisuda
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
            this.grd = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.txt_DBFPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_DBFFile = new System.Windows.Forms.TextBox();
            this.txt_fotoSidangPath = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_resultPath = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.folderBroswer = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_nofoto = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.grd.Location = new System.Drawing.Point(17, 162);
            this.grd.Name = "grd";
            this.grd.Rows.DefaultSize = 17;
            this.grd.Size = new System.Drawing.Size(589, 192);
            this.grd.TabIndex = 0;
            this.grd.AfterSort += new C1.Win.C1FlexGrid.SortColEventHandler(this.grd_AfterSort);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 119);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(448, 25);
            this.progressBar1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Download Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_progress.Location = new System.Drawing.Point(23, 126);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(0, 13);
            this.lbl_progress.TabIndex = 3;
            // 
            // txt_DBFPath
            // 
            this.txt_DBFPath.Location = new System.Drawing.Point(20, 12);
            this.txt_DBFPath.Name = "txt_DBFPath";
            this.txt_DBFPath.Size = new System.Drawing.Size(340, 20);
            this.txt_DBFPath.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "DBF File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_DBFFile
            // 
            this.txt_DBFFile.Location = new System.Drawing.Point(366, 12);
            this.txt_DBFFile.Name = "txt_DBFFile";
            this.txt_DBFFile.Size = new System.Drawing.Size(99, 20);
            this.txt_DBFFile.TabIndex = 6;
            // 
            // txt_fotoSidangPath
            // 
            this.txt_fotoSidangPath.Location = new System.Drawing.Point(20, 44);
            this.txt_fotoSidangPath.Name = "txt_fotoSidangPath";
            this.txt_fotoSidangPath.Size = new System.Drawing.Size(445, 20);
            this.txt_fotoSidangPath.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "Foto sidang path";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_resultPath
            // 
            this.txt_resultPath.Location = new System.Drawing.Point(20, 73);
            this.txt_resultPath.Name = "txt_resultPath";
            this.txt_resultPath.Size = new System.Drawing.Size(445, 20);
            this.txt_resultPath.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(474, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 25);
            this.button4.TabIndex = 10;
            this.button4.Text = "result path";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(623, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 340);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NPM yang tidak ada fotonya";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lbl_nofoto);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(190, 311);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbl_nofoto
            // 
            this.lbl_nofoto.AutoWordSelection = true;
            this.lbl_nofoto.Location = new System.Drawing.Point(3, 3);
            this.lbl_nofoto.Name = "lbl_nofoto";
            this.lbl_nofoto.Size = new System.Drawing.Size(168, 295);
            this.lbl_nofoto.TabIndex = 0;
            this.lbl_nofoto.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_resultPath);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_fotoSidangPath);
            this.Controls.Add(this.txt_DBFFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_DBFPath);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.grd);
            this.Name = "Form1";
            this.Text = "Load foto wisuda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid grd;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.TextBox txt_DBFPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_DBFFile;
        private System.Windows.Forms.TextBox txt_fotoSidangPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_resultPath;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBroswer;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox lbl_nofoto;

    }
}

