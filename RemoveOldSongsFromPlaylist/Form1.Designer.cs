namespace RemoveOldSongsFromPlaylist {
  partial class Form1 {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent() {
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.labelPlaylistName = new System.Windows.Forms.Label();
      this.labelPlaylistOwner = new System.Windows.Forms.Label();
      this.labelPlaylistTotal = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.labelTrackAlbum = new System.Windows.Forms.Label();
      this.labelTrackArtist = new System.Windows.Forms.Label();
      this.labelTrackName = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 12;
      this.listBox1.Location = new System.Drawing.Point(13, 13);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(210, 424);
      this.listBox1.TabIndex = 0;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.ItemHeight = 12;
      this.listBox2.Location = new System.Drawing.Point(251, 86);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(186, 352);
      this.listBox2.TabIndex = 1;
      this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
      // 
      // labelPlaylistName
      // 
      this.labelPlaylistName.AutoSize = true;
      this.labelPlaylistName.Location = new System.Drawing.Point(292, 13);
      this.labelPlaylistName.Name = "labelPlaylistName";
      this.labelPlaylistName.Size = new System.Drawing.Size(0, 12);
      this.labelPlaylistName.TabIndex = 2;
      // 
      // labelPlaylistOwner
      // 
      this.labelPlaylistOwner.AutoSize = true;
      this.labelPlaylistOwner.Location = new System.Drawing.Point(292, 38);
      this.labelPlaylistOwner.Name = "labelPlaylistOwner";
      this.labelPlaylistOwner.Size = new System.Drawing.Size(0, 12);
      this.labelPlaylistOwner.TabIndex = 3;
      // 
      // labelPlaylistTotal
      // 
      this.labelPlaylistTotal.AutoSize = true;
      this.labelPlaylistTotal.Location = new System.Drawing.Point(292, 61);
      this.labelPlaylistTotal.Name = "labelPlaylistTotal";
      this.labelPlaylistTotal.Size = new System.Drawing.Size(0, 12);
      this.labelPlaylistTotal.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(249, 13);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 12);
      this.label4.TabIndex = 5;
      this.label4.Text = "Name: ";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(249, 38);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(43, 12);
      this.label5.TabIndex = 6;
      this.label5.Text = "Owner: ";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(249, 61);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(37, 12);
      this.label6.TabIndex = 7;
      this.label6.Text = "Total: ";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(455, 353);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(43, 12);
      this.label7.TabIndex = 13;
      this.label7.Text = "Album: ";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(455, 330);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(40, 12);
      this.label8.TabIndex = 12;
      this.label8.Text = "Artist: ";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(455, 305);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(40, 12);
      this.label9.TabIndex = 11;
      this.label9.Text = "Name: ";
      // 
      // labelTrackAlbum
      // 
      this.labelTrackAlbum.AutoSize = true;
      this.labelTrackAlbum.Location = new System.Drawing.Point(498, 353);
      this.labelTrackAlbum.Name = "labelTrackAlbum";
      this.labelTrackAlbum.Size = new System.Drawing.Size(0, 12);
      this.labelTrackAlbum.TabIndex = 10;
      // 
      // labelTrackArtist
      // 
      this.labelTrackArtist.AutoSize = true;
      this.labelTrackArtist.Location = new System.Drawing.Point(498, 330);
      this.labelTrackArtist.Name = "labelTrackArtist";
      this.labelTrackArtist.Size = new System.Drawing.Size(0, 12);
      this.labelTrackArtist.TabIndex = 9;
      // 
      // labelTrackName
      // 
      this.labelTrackName.AutoSize = true;
      this.labelTrackName.Location = new System.Drawing.Point(498, 305);
      this.labelTrackName.Name = "labelTrackName";
      this.labelTrackName.Size = new System.Drawing.Size(0, 12);
      this.labelTrackName.TabIndex = 8;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(456, 86);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(200, 200);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 14;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(672, 450);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.labelTrackAlbum);
      this.Controls.Add(this.labelTrackArtist);
      this.Controls.Add(this.labelTrackName);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.labelPlaylistTotal);
      this.Controls.Add(this.labelPlaylistOwner);
      this.Controls.Add(this.labelPlaylistName);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.listBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.Label labelPlaylistName;
    private System.Windows.Forms.Label labelPlaylistOwner;
    private System.Windows.Forms.Label labelPlaylistTotal;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label labelTrackAlbum;
    private System.Windows.Forms.Label labelTrackArtist;
    private System.Windows.Forms.Label labelTrackName;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

