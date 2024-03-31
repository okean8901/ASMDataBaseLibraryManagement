namespace ASM_library_management_database
{
    partial class ViewBook
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Book = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvViewBook = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvMemberCards = new System.Windows.Forms.DataGridView();
            this.label34 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Book.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Book);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 498);
            this.tabControl1.TabIndex = 0;
            // 
            // Book
            // 
            this.Book.Controls.Add(this.pictureBox1);
            this.Book.Controls.Add(this.dgvViewBook);
            this.Book.Controls.Add(this.btnLogout);
            this.Book.Controls.Add(this.label1);
            this.Book.Location = new System.Drawing.Point(4, 25);
            this.Book.Name = "Book";
            this.Book.Padding = new System.Windows.Forms.Padding(3);
            this.Book.Size = new System.Drawing.Size(816, 469);
            this.Book.TabIndex = 0;
            this.Book.Text = "Book List";
            this.Book.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.dgvReturn);
            this.tabPage2.Controls.Add(this.dgvBorrow);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrow And Return";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Controls.Add(this.dgvMemberCards);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(816, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Member Cards";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ASM_library_management_database.Properties.Resources.FPT_Education_logo_svg__1_;
            this.pictureBox1.Location = new System.Drawing.Point(634, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dgvViewBook
            // 
            this.dgvViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBook.Location = new System.Drawing.Point(6, 130);
            this.dgvViewBook.Name = "dgvViewBook";
            this.dgvViewBook.RowHeadersWidth = 51;
            this.dgvViewBook.RowTemplate.Height = 24;
            this.dgvViewBook.Size = new System.Drawing.Size(804, 333);
            this.dgvViewBook.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(700, 87);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 37);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of Book";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(599, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 20);
            this.label19.TabIndex = 10;
            this.label19.Text = "Return";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(185, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 20);
            this.label18.TabIndex = 9;
            this.label18.Text = "Borrow";
            // 
            // dgvReturn
            // 
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Location = new System.Drawing.Point(456, 194);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.RowHeadersWidth = 51;
            this.dgvReturn.RowTemplate.Height = 24;
            this.dgvReturn.Size = new System.Drawing.Size(354, 270);
            this.dgvReturn.TabIndex = 8;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(7, 194);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowHeadersWidth = 51;
            this.dgvBorrow.RowTemplate.Height = 24;
            this.dgvBorrow.Size = new System.Drawing.Size(443, 269);
            this.dgvBorrow.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ASM_library_management_database.Properties.Resources.FPT_Education_logo_svg__1_;
            this.pictureBox3.Location = new System.Drawing.Point(661, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(296, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(210, 23);
            this.label17.TabIndex = 73;
            this.label17.Text = "Borrow and Return List";
            // 
            // dgvMemberCards
            // 
            this.dgvMemberCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberCards.Location = new System.Drawing.Point(6, 157);
            this.dgvMemberCards.Name = "dgvMemberCards";
            this.dgvMemberCards.RowHeadersWidth = 51;
            this.dgvMemberCards.RowTemplate.Height = 24;
            this.dgvMemberCards.Size = new System.Drawing.Size(804, 306);
            this.dgvMemberCards.TabIndex = 51;
            this.dgvMemberCards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberCards_CellContentClick);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(272, 6);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(247, 32);
            this.label34.TabIndex = 59;
            this.label34.Text = "Member Cards List";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ASM_library_management_database.Properties.Resources.FPT_Education_logo_svg__1_;
            this.pictureBox4.Location = new System.Drawing.Point(661, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 504);
            this.Controls.Add(this.tabControl1);
            this.Name = "ViewBook";
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.tabControl1.ResumeLayout(false);
            this.Book.ResumeLayout(false);
            this.Book.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Book;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvViewBook;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvMemberCards;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}