namespace lms
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.pictureBoxBookImage = new System.Windows.Forms.PictureBox();
            this.gBoxBooks = new System.Windows.Forms.GroupBox();
            this.lblBookNumber = new System.Windows.Forms.Label();
            this.txtBookNumber = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblBookF = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookImage)).BeginInit();
            this.gBoxBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 135);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 367);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(511, 47);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(139, 58);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Book";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(2, 459);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 62;
            this.dataGridViewBook.RowTemplate.Height = 28;
            this.dataGridViewBook.Size = new System.Drawing.Size(1276, 253);
            this.dataGridViewBook.TabIndex = 7;
            // 
            // pictureBoxBookImage
            // 
            this.pictureBoxBookImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookImage.BackgroundImage")));
            this.pictureBoxBookImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBookImage.Location = new System.Drawing.Point(568, 138);
            this.pictureBoxBookImage.Name = "pictureBoxBookImage";
            this.pictureBoxBookImage.Size = new System.Drawing.Size(710, 322);
            this.pictureBoxBookImage.TabIndex = 6;
            this.pictureBoxBookImage.TabStop = false;
            // 
            // gBoxBooks
            // 
            this.gBoxBooks.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gBoxBooks.Controls.Add(this.lblBookNumber);
            this.gBoxBooks.Controls.Add(this.txtBookNumber);
            this.gBoxBooks.Controls.Add(this.btnDisplay);
            this.gBoxBooks.Controls.Add(this.btnUpdate);
            this.gBoxBooks.Controls.Add(this.btnDelete);
            this.gBoxBooks.Controls.Add(this.btnSave);
            this.gBoxBooks.Controls.Add(this.txtBook);
            this.gBoxBooks.Controls.Add(this.txtAuthor);
            this.gBoxBooks.Controls.Add(this.txtPublisher);
            this.gBoxBooks.Controls.Add(this.txtBookId);
            this.gBoxBooks.Controls.Add(this.lblBookF);
            this.gBoxBooks.Controls.Add(this.lblAuthor);
            this.gBoxBooks.Controls.Add(this.lblPublisher);
            this.gBoxBooks.Controls.Add(this.lblNumber);
            this.gBoxBooks.Location = new System.Drawing.Point(2, 138);
            this.gBoxBooks.Name = "gBoxBooks";
            this.gBoxBooks.Size = new System.Drawing.Size(569, 322);
            this.gBoxBooks.TabIndex = 5;
            this.gBoxBooks.TabStop = false;
            this.gBoxBooks.Text = "Books";
            // 
            // lblBookNumber
            // 
            this.lblBookNumber.AutoSize = true;
            this.lblBookNumber.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNumber.Location = new System.Drawing.Point(22, 138);
            this.lblBookNumber.Name = "lblBookNumber";
            this.lblBookNumber.Size = new System.Drawing.Size(111, 29);
            this.lblBookNumber.TabIndex = 21;
            this.lblBookNumber.Text = "Number:";
            // 
            // txtBookNumber
            // 
            this.txtBookNumber.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookNumber.Location = new System.Drawing.Point(236, 134);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.Size = new System.Drawing.Size(304, 33);
            this.txtBookNumber.TabIndex = 20;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDisplay.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisplay.Location = new System.Drawing.Point(423, 272);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(117, 43);
            this.btnDisplay.TabIndex = 19;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(159, 272);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 43);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(292, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 43);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(26, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 43);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBook
            // 
            this.txtBook.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBook.Location = new System.Drawing.Point(236, 95);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(304, 33);
            this.txtBook.TabIndex = 13;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(236, 175);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(304, 33);
            this.txtAuthor.TabIndex = 11;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(236, 215);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(304, 33);
            this.txtPublisher.TabIndex = 10;
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(236, 53);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(304, 33);
            this.txtBookId.TabIndex = 9;
            // 
            // lblBookF
            // 
            this.lblBookF.AutoSize = true;
            this.lblBookF.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookF.Location = new System.Drawing.Point(22, 95);
            this.lblBookF.Name = "lblBookF";
            this.lblBookF.Size = new System.Drawing.Size(75, 29);
            this.lblBookF.TabIndex = 8;
            this.lblBookF.Text = "Book:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(22, 176);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(95, 29);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "Author:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(22, 215);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(125, 29);
            this.lblPublisher.TabIndex = 6;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(22, 53);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(103, 29);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Book Id:";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 694);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.pictureBoxBookImage);
            this.Controls.Add(this.gBoxBooks);
            this.Controls.Add(this.panel1);
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookImage)).EndInit();
            this.gBoxBooks.ResumeLayout(false);
            this.gBoxBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.PictureBox pictureBoxBookImage;
        private System.Windows.Forms.GroupBox gBoxBooks;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookF;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBookNumber;
        private System.Windows.Forms.TextBox txtBookNumber;
    }
}