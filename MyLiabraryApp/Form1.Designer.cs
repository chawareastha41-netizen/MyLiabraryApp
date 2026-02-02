namespace MyLiabraryApp
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(168, 76);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(171, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(380, 76);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(202, 22);
            this.txtAuthor.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.IndianRed;
            this.btnAdd.Location = new System.Drawing.Point(200, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLoad.Location = new System.Drawing.Point(417, 108);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(121, 43);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Books";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author Name";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(111, 167);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(583, 247);
            this.dgvBooks.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBooks;
    }
}

