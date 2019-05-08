namespace AdvancedCalculator
{
    partial class Fibonacci
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
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Calculator");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Standard");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Scientific");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Programmer");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Temperature");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Length");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Fibonacci");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Matrix");
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtdisplay1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblList2 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "For more information visit this link";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(338, 497);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(235, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://en.wikipedia.org/wiki/Fibonacci_number";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fibonacci Number Formula: Fn = Fn-1 + Fn-2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Result";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(298, 385);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 14);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "0";
            // 
            // txtdisplay1
            // 
            this.txtdisplay1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtdisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdisplay1.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplay1.Location = new System.Drawing.Point(295, 140);
            this.txtdisplay1.Name = "txtdisplay1";
            this.txtdisplay1.Size = new System.Drawing.Size(103, 14);
            this.txtdisplay1.TabIndex = 12;
            this.txtdisplay1.Text = "0";
            this.txtdisplay1.TextChanged += new System.EventHandler(this.txtdisplay1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(298, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 143);
            this.listBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter The Number";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Result_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(11, 46);
            this.lblList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(39, 42);
            this.lblList.TabIndex = 238;
            this.lblList.Text = "≡";
            this.lblList.Click += new System.EventHandler(this.lblList_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(41, 36);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeView1.Name = "treeView1";
            treeNode31.Name = "Node0";
            treeNode31.Text = "Calculator";
            treeNode32.Name = "Node1";
            treeNode32.Text = "";
            treeNode33.Name = "Standard";
            treeNode33.Text = "Standard";
            treeNode34.Name = "Node3";
            treeNode34.Text = "";
            treeNode35.Name = "Scientific";
            treeNode35.Text = "Scientific";
            treeNode36.Name = "Node0";
            treeNode36.Text = "";
            treeNode37.Name = "Programmer";
            treeNode37.Text = "Programmer";
            treeNode38.Name = "";
            treeNode38.Text = "";
            treeNode39.Name = "Temperature";
            treeNode39.Text = "Temperature";
            treeNode40.Name = "";
            treeNode40.Text = "";
            treeNode41.Name = "Length";
            treeNode41.Text = "Length";
            treeNode42.Name = "";
            treeNode42.Text = "";
            treeNode43.Name = "Fibonacci";
            treeNode43.Text = "Fibonacci";
            treeNode44.Name = "";
            treeNode44.Text = "";
            treeNode45.Name = "Matrix";
            treeNode45.Text = "Matrix";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45});
            this.treeView1.Size = new System.Drawing.Size(175, 369);
            this.treeView1.TabIndex = 239;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lblList2
            // 
            this.lblList2.AutoSize = true;
            this.lblList2.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList2.Location = new System.Drawing.Point(139, 46);
            this.lblList2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblList2.Name = "lblList2";
            this.lblList2.Size = new System.Drawing.Size(39, 42);
            this.lblList2.TabIndex = 279;
            this.lblList2.Text = "≡";
            this.lblList2.Visible = false;
            this.lblList2.Click += new System.EventHandler(this.lblList2_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(14, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(78, 22);
            this.lbltitle.TabIndex = 280;
            this.lbltitle.Text = "Fibonacci";
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 651);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblList2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtdisplay1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(789, 690);
            this.MinimumSize = new System.Drawing.Size(420, 396);
            this.Name = "Fibonacci";
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Fibonacci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtdisplay1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblList2;
        private System.Windows.Forms.Label lbltitle;
    }
}