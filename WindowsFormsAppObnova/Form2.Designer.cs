namespace WindowsFormsAppObnova
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.txb_songname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_album = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_composer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_unitprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_bytes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_milisec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_mediaType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_genre = new System.Windows.Forms.ComboBox();
            this.playlistCheckbox = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_songname
            // 
            this.txb_songname.Location = new System.Drawing.Point(91, 57);
            this.txb_songname.Name = "txb_songname";
            this.txb_songname.Size = new System.Drawing.Size(131, 20);
            this.txb_songname.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Song name";
            // 
            // cbx_album
            // 
            this.cbx_album.FormattingEnabled = true;
            this.cbx_album.Location = new System.Drawing.Point(91, 104);
            this.cbx_album.Name = "cbx_album";
            this.cbx_album.Size = new System.Drawing.Size(131, 21);
            this.cbx_album.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Album";
            // 
            // txb_composer
            // 
            this.txb_composer.Location = new System.Drawing.Point(90, 153);
            this.txb_composer.Name = "txb_composer";
            this.txb_composer.Size = new System.Drawing.Size(131, 20);
            this.txb_composer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Composer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unit price";
            // 
            // txb_unitprice
            // 
            this.txb_unitprice.Location = new System.Drawing.Point(90, 210);
            this.txb_unitprice.Name = "txb_unitprice";
            this.txb_unitprice.Size = new System.Drawing.Size(131, 20);
            this.txb_unitprice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bytes";
            // 
            // txb_bytes
            // 
            this.txb_bytes.Location = new System.Drawing.Point(90, 264);
            this.txb_bytes.Name = "txb_bytes";
            this.txb_bytes.Size = new System.Drawing.Size(131, 20);
            this.txb_bytes.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Miliseconds";
            // 
            // txb_milisec
            // 
            this.txb_milisec.Location = new System.Drawing.Point(90, 317);
            this.txb_milisec.Name = "txb_milisec";
            this.txb_milisec.Size = new System.Drawing.Size(131, 20);
            this.txb_milisec.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Media type";
            // 
            // cbx_mediaType
            // 
            this.cbx_mediaType.FormattingEnabled = true;
            this.cbx_mediaType.Location = new System.Drawing.Point(90, 368);
            this.cbx_mediaType.Name = "cbx_mediaType";
            this.cbx_mediaType.Size = new System.Drawing.Size(131, 21);
            this.cbx_mediaType.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Genre";
            // 
            // cbx_genre
            // 
            this.cbx_genre.FormattingEnabled = true;
            this.cbx_genre.Location = new System.Drawing.Point(90, 424);
            this.cbx_genre.Name = "cbx_genre";
            this.cbx_genre.Size = new System.Drawing.Size(131, 21);
            this.cbx_genre.TabIndex = 17;
            // 
            // playlistCheckbox
            // 
            this.playlistCheckbox.FormattingEnabled = true;
            this.playlistCheckbox.Location = new System.Drawing.Point(287, 64);
            this.playlistCheckbox.Name = "playlistCheckbox";
            this.playlistCheckbox.Size = new System.Drawing.Size(132, 109);
            this.playlistCheckbox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Playlist";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 498);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.playlistCheckbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbx_genre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_mediaType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_milisec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_bytes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_unitprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_composer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_album);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_songname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_songname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_album;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_composer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_unitprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_bytes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_milisec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_mediaType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_genre;
        private System.Windows.Forms.CheckedListBox playlistCheckbox;
        private System.Windows.Forms.Label label9;
    }
}