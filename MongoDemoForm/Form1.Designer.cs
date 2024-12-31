namespace MongoDemoForm;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        TxtID = new System.Windows.Forms.TextBox();
        TxtSehir = new System.Windows.Forms.TextBox();
        TxtSoyad = new System.Windows.Forms.TextBox();
        TxtAd = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        TxtBakiye = new System.Windows.Forms.TextBox();
        BtnListele = new System.Windows.Forms.Button();
        BtnGuncelle = new System.Windows.Forms.Button();
        BtnSil = new System.Windows.Forms.Button();
        BtnIdGetir = new System.Windows.Forms.Button();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        BtnEkle = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // TxtID
        // 
        TxtID.Location = new System.Drawing.Point(23, 46);
        TxtID.Name = "TxtID";
        TxtID.Size = new System.Drawing.Size(186, 27);
        TxtID.TabIndex = 0;
        // 
        // TxtSehir
        // 
        TxtSehir.Location = new System.Drawing.Point(23, 218);
        TxtSehir.Name = "TxtSehir";
        TxtSehir.Size = new System.Drawing.Size(186, 27);
        TxtSehir.TabIndex = 1;
        // 
        // TxtSoyad
        // 
        TxtSoyad.Location = new System.Drawing.Point(23, 161);
        TxtSoyad.Name = "TxtSoyad";
        TxtSoyad.Size = new System.Drawing.Size(186, 27);
        TxtSoyad.TabIndex = 2;
        // 
        // TxtAd
        // 
        TxtAd.Location = new System.Drawing.Point(23, 97);
        TxtAd.Name = "TxtAd";
        TxtAd.Size = new System.Drawing.Size(186, 27);
        TxtAd.TabIndex = 3;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(23, 24);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 4;
        label1.Text = "ID";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(23, 258);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 5;
        label2.Text = "Bakiye";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(23, 76);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 6;
        label3.Text = "Ad";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(23, 135);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 7;
        label4.Text = "Soyad";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(23, 192);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 23);
        label5.TabIndex = 8;
        label5.Text = "Şehir";
        // 
        // TxtBakiye
        // 
        TxtBakiye.Location = new System.Drawing.Point(23, 284);
        TxtBakiye.Name = "TxtBakiye";
        TxtBakiye.Size = new System.Drawing.Size(186, 27);
        TxtBakiye.TabIndex = 9;
        // 
        // BtnListele
        // 
        BtnListele.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)192)), ((int)((byte)0)));
        BtnListele.ForeColor = System.Drawing.Color.White;
        BtnListele.Location = new System.Drawing.Point(74, 327);
        BtnListele.Name = "BtnListele";
        BtnListele.Size = new System.Drawing.Size(135, 44);
        BtnListele.TabIndex = 10;
        BtnListele.Text = "Listele";
        BtnListele.UseVisualStyleBackColor = false;
        BtnListele.Click += BtnListele_Click;
        // 
        // BtnGuncelle
        // 
        BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
        BtnGuncelle.ForeColor = System.Drawing.Color.White;
        BtnGuncelle.Location = new System.Drawing.Point(74, 427);
        BtnGuncelle.Name = "BtnGuncelle";
        BtnGuncelle.Size = new System.Drawing.Size(135, 47);
        BtnGuncelle.TabIndex = 11;
        BtnGuncelle.Text = "Güncelle";
        BtnGuncelle.UseVisualStyleBackColor = false;
        BtnGuncelle.Click += BtnGuncelle_Click;
        // 
        // BtnSil
        // 
        BtnSil.BackColor = System.Drawing.Color.Red;
        BtnSil.ForeColor = System.Drawing.Color.White;
        BtnSil.Location = new System.Drawing.Point(74, 480);
        BtnSil.Name = "BtnSil";
        BtnSil.Size = new System.Drawing.Size(135, 42);
        BtnSil.TabIndex = 12;
        BtnSil.Text = "Sil";
        BtnSil.UseVisualStyleBackColor = false;
        BtnSil.Click += BtnSil_Click;
        // 
        // BtnIdGetir
        // 
        BtnIdGetir.BackColor = System.Drawing.Color.Blue;
        BtnIdGetir.ForeColor = System.Drawing.Color.White;
        BtnIdGetir.Location = new System.Drawing.Point(74, 528);
        BtnIdGetir.Name = "BtnIdGetir";
        BtnIdGetir.Size = new System.Drawing.Size(135, 49);
        BtnIdGetir.TabIndex = 13;
        BtnIdGetir.Text = "Id ye göre getir";
        BtnIdGetir.UseVisualStyleBackColor = false;
        BtnIdGetir.Click += BtnIdGetir_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new System.Drawing.Point(244, 12);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(924, 653);
        dataGridView1.TabIndex = 14;
        // 
        // BtnEkle
        // 
        BtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)((byte)128)), ((int)((byte)128)), ((int)((byte)255)));
        BtnEkle.ForeColor = System.Drawing.Color.White;
        BtnEkle.Location = new System.Drawing.Point(74, 377);
        BtnEkle.Name = "BtnEkle";
        BtnEkle.Size = new System.Drawing.Size(135, 44);
        BtnEkle.TabIndex = 15;
        BtnEkle.Text = "Ekle";
        BtnEkle.UseVisualStyleBackColor = false;
        BtnEkle.Click += BtnEkle_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ButtonFace;
        ClientSize = new System.Drawing.Size(1180, 702);
        Controls.Add(BtnEkle);
        Controls.Add(dataGridView1);
        Controls.Add(BtnIdGetir);
        Controls.Add(BtnSil);
        Controls.Add(BtnGuncelle);
        Controls.Add(BtnListele);
        Controls.Add(TxtBakiye);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(TxtAd);
        Controls.Add(TxtSoyad);
        Controls.Add(TxtSehir);
        Controls.Add(TxtID);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Customer";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button BtnEkle;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Button BtnGuncelle;
    private System.Windows.Forms.Button BtnSil;
    private System.Windows.Forms.Button BtnIdGetir;

    private System.Windows.Forms.Button BtnListele;

    private System.Windows.Forms.TextBox TxtBakiye;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.TextBox TxtID;
    private System.Windows.Forms.TextBox TxtSehir;
    private System.Windows.Forms.TextBox TxtSoyad;
    private System.Windows.Forms.TextBox TxtAd;

    #endregion
}