<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_judul = New System.Windows.Forms.Label()
        Me.lbl_daftarmenu = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_kanan = New System.Windows.Forms.Panel()
        Me.num_bayar = New System.Windows.Forms.NumericUpDown()
        Me.btn_hitungkembalian = New System.Windows.Forms.Button()
        Me.tbox_kembalian = New System.Windows.Forms.TextBox()
        Me.lbl_kembalian = New System.Windows.Forms.Label()
        Me.lbl_bayar = New System.Windows.Forms.Label()
        Me.tbox_totalbayar = New System.Windows.Forms.TextBox()
        Me.lbl_pembayaran = New System.Windows.Forms.Label()
        Me.lbl_totalbayar = New System.Windows.Forms.Label()
        Me.pnl_kiri = New System.Windows.Forms.Panel()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.btn_bersihkan = New System.Windows.Forms.Button()
        Me.num_menu9 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_harga9 = New System.Windows.Forms.Label()
        Me.lbl_menu9 = New System.Windows.Forms.Label()
        Me.num_menu8 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_harga8 = New System.Windows.Forms.Label()
        Me.lbl_menu8 = New System.Windows.Forms.Label()
        Me.num_menu7 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_harga7 = New System.Windows.Forms.Label()
        Me.lbl_menu7 = New System.Windows.Forms.Label()
        Me.num_menu6 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_harga6 = New System.Windows.Forms.Label()
        Me.lbl_menu6 = New System.Windows.Forms.Label()
        Me.num_menu5 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_harga5 = New System.Windows.Forms.Label()
        Me.lbl_menu5 = New System.Windows.Forms.Label()
        Me.num_menu4 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_harga4 = New System.Windows.Forms.Label()
        Me.lbl_menu4 = New System.Windows.Forms.Label()
        Me.num_menu3 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_harga3 = New System.Windows.Forms.Label()
        Me.lbl_menu3 = New System.Windows.Forms.Label()
        Me.num_menu2 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_harga2 = New System.Windows.Forms.Label()
        Me.lbl_menu2 = New System.Windows.Forms.Label()
        Me.num_menu1 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_harga1 = New System.Windows.Forms.Label()
        Me.lbl_menu1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnl_kanan.SuspendLayout()
        CType(Me.num_bayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_kiri.SuspendLayout()
        CType(Me.num_menu9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_menu8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_menu7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_menu6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_menu5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_menu4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_menu3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_menu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_menu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_judul
        '
        Me.lbl_judul.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.76471!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_judul.Location = New System.Drawing.Point(494, 9)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(112, 31)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Kasirko"
        '
        'lbl_daftarmenu
        '
        Me.lbl_daftarmenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_daftarmenu.AutoSize = True
        Me.lbl_daftarmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.17647!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_daftarmenu.Location = New System.Drawing.Point(208, 83)
        Me.lbl_daftarmenu.Name = "lbl_daftarmenu"
        Me.lbl_daftarmenu.Size = New System.Drawing.Size(153, 29)
        Me.lbl_daftarmenu.TabIndex = 2
        Me.lbl_daftarmenu.Text = "Daftar Menu"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.pnl_kanan)
        Me.Panel1.Controls.Add(Me.pnl_kiri)
        Me.Panel1.Location = New System.Drawing.Point(1, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1098, 547)
        Me.Panel1.TabIndex = 3
        '
        'pnl_kanan
        '
        Me.pnl_kanan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_kanan.Controls.Add(Me.num_bayar)
        Me.pnl_kanan.Controls.Add(Me.btn_hitungkembalian)
        Me.pnl_kanan.Controls.Add(Me.tbox_kembalian)
        Me.pnl_kanan.Controls.Add(Me.lbl_kembalian)
        Me.pnl_kanan.Controls.Add(Me.lbl_bayar)
        Me.pnl_kanan.Controls.Add(Me.tbox_totalbayar)
        Me.pnl_kanan.Controls.Add(Me.lbl_pembayaran)
        Me.pnl_kanan.Controls.Add(Me.lbl_totalbayar)
        Me.pnl_kanan.Location = New System.Drawing.Point(592, 2)
        Me.pnl_kanan.MinimumSize = New System.Drawing.Size(359, 323)
        Me.pnl_kanan.Name = "pnl_kanan"
        Me.pnl_kanan.Size = New System.Drawing.Size(494, 542)
        Me.pnl_kanan.TabIndex = 38
        '
        'num_bayar
        '
        Me.num_bayar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_bayar.Location = New System.Drawing.Point(176, 129)
        Me.num_bayar.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.num_bayar.Name = "num_bayar"
        Me.num_bayar.Size = New System.Drawing.Size(290, 29)
        Me.num_bayar.TabIndex = 44
        '
        'btn_hitungkembalian
        '
        Me.btn_hitungkembalian.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_hitungkembalian.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_hitungkembalian.Location = New System.Drawing.Point(27, 260)
        Me.btn_hitungkembalian.Name = "btn_hitungkembalian"
        Me.btn_hitungkembalian.Size = New System.Drawing.Size(439, 38)
        Me.btn_hitungkembalian.TabIndex = 36
        Me.btn_hitungkembalian.Text = "Hitung Kembalian"
        Me.btn_hitungkembalian.UseVisualStyleBackColor = False
        '
        'tbox_kembalian
        '
        Me.tbox_kembalian.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbox_kembalian.Location = New System.Drawing.Point(176, 175)
        Me.tbox_kembalian.Name = "tbox_kembalian"
        Me.tbox_kembalian.ReadOnly = True
        Me.tbox_kembalian.Size = New System.Drawing.Size(290, 29)
        Me.tbox_kembalian.TabIndex = 43
        '
        'lbl_kembalian
        '
        Me.lbl_kembalian.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_kembalian.AutoSize = True
        Me.lbl_kembalian.Location = New System.Drawing.Point(23, 178)
        Me.lbl_kembalian.Name = "lbl_kembalian"
        Me.lbl_kembalian.Size = New System.Drawing.Size(99, 24)
        Me.lbl_kembalian.TabIndex = 42
        Me.lbl_kembalian.Text = "Kembalian"
        '
        'lbl_bayar
        '
        Me.lbl_bayar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_bayar.AutoSize = True
        Me.lbl_bayar.Location = New System.Drawing.Point(23, 131)
        Me.lbl_bayar.Name = "lbl_bayar"
        Me.lbl_bayar.Size = New System.Drawing.Size(67, 24)
        Me.lbl_bayar.TabIndex = 40
        Me.lbl_bayar.Text = "Bayar :"
        '
        'tbox_totalbayar
        '
        Me.tbox_totalbayar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbox_totalbayar.Location = New System.Drawing.Point(176, 80)
        Me.tbox_totalbayar.Name = "tbox_totalbayar"
        Me.tbox_totalbayar.ReadOnly = True
        Me.tbox_totalbayar.Size = New System.Drawing.Size(290, 29)
        Me.tbox_totalbayar.TabIndex = 39
        '
        'lbl_pembayaran
        '
        Me.lbl_pembayaran.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_pembayaran.AutoSize = True
        Me.lbl_pembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.17647!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pembayaran.Location = New System.Drawing.Point(138, 20)
        Me.lbl_pembayaran.Name = "lbl_pembayaran"
        Me.lbl_pembayaran.Size = New System.Drawing.Size(158, 29)
        Me.lbl_pembayaran.TabIndex = 38
        Me.lbl_pembayaran.Text = "Pembayaran"
        '
        'lbl_totalbayar
        '
        Me.lbl_totalbayar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_totalbayar.AutoSize = True
        Me.lbl_totalbayar.Location = New System.Drawing.Point(23, 83)
        Me.lbl_totalbayar.Name = "lbl_totalbayar"
        Me.lbl_totalbayar.Size = New System.Drawing.Size(113, 24)
        Me.lbl_totalbayar.TabIndex = 37
        Me.lbl_totalbayar.Text = "Total Bayar :"
        '
        'pnl_kiri
        '
        Me.pnl_kiri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnl_kiri.Controls.Add(Me.btn_hitung)
        Me.pnl_kiri.Controls.Add(Me.btn_bersihkan)
        Me.pnl_kiri.Controls.Add(Me.num_menu9)
        Me.pnl_kiri.Controls.Add(Me.lbl_harga9)
        Me.pnl_kiri.Controls.Add(Me.lbl_menu9)
        Me.pnl_kiri.Controls.Add(Me.num_menu8)
        Me.pnl_kiri.Controls.Add(Me.lbl_harga8)
        Me.pnl_kiri.Controls.Add(Me.lbl_menu8)
        Me.pnl_kiri.Controls.Add(Me.num_menu7)
        Me.pnl_kiri.Controls.Add(Me.lbl_harga7)
        Me.pnl_kiri.Controls.Add(Me.lbl_menu7)
        Me.pnl_kiri.Controls.Add(Me.num_menu6)
        Me.pnl_kiri.Controls.Add(Me.lbl_harga6)
        Me.pnl_kiri.Controls.Add(Me.lbl_menu6)
        Me.pnl_kiri.Controls.Add(Me.num_menu5)
        Me.pnl_kiri.Controls.Add(Me.lbl_harga5)
        Me.pnl_kiri.Controls.Add(Me.lbl_menu5)
        Me.pnl_kiri.Controls.Add(Me.num_menu4)
        Me.pnl_kiri.Controls.Add(Me.lbl_harga4)
        Me.pnl_kiri.Controls.Add(Me.lbl_menu4)
        Me.pnl_kiri.Controls.Add(Me.num_menu3)
        Me.pnl_kiri.Controls.Add(Me.lbl_harga3)
        Me.pnl_kiri.Controls.Add(Me.lbl_menu3)
        Me.pnl_kiri.Controls.Add(Me.num_menu2)
        Me.pnl_kiri.Controls.Add(Me.lbl_harga2)
        Me.pnl_kiri.Controls.Add(Me.lbl_menu2)
        Me.pnl_kiri.Controls.Add(Me.num_menu1)
        Me.pnl_kiri.Controls.Add(Me.lbl_harga1)
        Me.pnl_kiri.Controls.Add(Me.lbl_menu1)
        Me.pnl_kiri.Location = New System.Drawing.Point(11, 2)
        Me.pnl_kiri.MinimumSize = New System.Drawing.Size(437, 530)
        Me.pnl_kiri.Name = "pnl_kiri"
        Me.pnl_kiri.Size = New System.Drawing.Size(554, 542)
        Me.pnl_kiri.TabIndex = 37
        '
        'btn_hitung
        '
        Me.btn_hitung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_hitung.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_hitung.Location = New System.Drawing.Point(395, 477)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(156, 38)
        Me.btn_hitung.TabIndex = 28
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.UseVisualStyleBackColor = False
        '
        'btn_bersihkan
        '
        Me.btn_bersihkan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_bersihkan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_bersihkan.Location = New System.Drawing.Point(3, 477)
        Me.btn_bersihkan.Name = "btn_bersihkan"
        Me.btn_bersihkan.Size = New System.Drawing.Size(156, 38)
        Me.btn_bersihkan.TabIndex = 3
        Me.btn_bersihkan.Text = "Bersihkan"
        Me.btn_bersihkan.UseVisualStyleBackColor = False
        '
        'num_menu9
        '
        Me.num_menu9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_menu9.Location = New System.Drawing.Point(420, 381)
        Me.num_menu9.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_menu9.Name = "num_menu9"
        Me.num_menu9.Size = New System.Drawing.Size(120, 29)
        Me.num_menu9.TabIndex = 27
        '
        'lbl_harga9
        '
        Me.lbl_harga9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_harga9.AutoSize = True
        Me.lbl_harga9.Location = New System.Drawing.Point(169, 383)
        Me.lbl_harga9.Name = "lbl_harga9"
        Me.lbl_harga9.Size = New System.Drawing.Size(94, 24)
        Me.lbl_harga9.TabIndex = 26
        Me.lbl_harga9.Text = "Rp 10.000"
        '
        'lbl_menu9
        '
        Me.lbl_menu9.AutoSize = True
        Me.lbl_menu9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.05882!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu9.Location = New System.Drawing.Point(14, 383)
        Me.lbl_menu9.Name = "lbl_menu9"
        Me.lbl_menu9.Size = New System.Drawing.Size(105, 24)
        Me.lbl_menu9.TabIndex = 25
        Me.lbl_menu9.Text = "Kopi Susu"
        '
        'num_menu8
        '
        Me.num_menu8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_menu8.Location = New System.Drawing.Point(420, 336)
        Me.num_menu8.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_menu8.Name = "num_menu8"
        Me.num_menu8.Size = New System.Drawing.Size(120, 29)
        Me.num_menu8.TabIndex = 24
        '
        'lbl_harga8
        '
        Me.lbl_harga8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_harga8.AutoSize = True
        Me.lbl_harga8.Location = New System.Drawing.Point(169, 338)
        Me.lbl_harga8.Name = "lbl_harga8"
        Me.lbl_harga8.Size = New System.Drawing.Size(84, 24)
        Me.lbl_harga8.TabIndex = 23
        Me.lbl_harga8.Text = "Rp 8.000"
        '
        'lbl_menu8
        '
        Me.lbl_menu8.AutoSize = True
        Me.lbl_menu8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.05882!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu8.Location = New System.Drawing.Point(14, 338)
        Me.lbl_menu8.Name = "lbl_menu8"
        Me.lbl_menu8.Size = New System.Drawing.Size(52, 24)
        Me.lbl_menu8.TabIndex = 22
        Me.lbl_menu8.Text = "Kopi"
        '
        'num_menu7
        '
        Me.num_menu7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_menu7.Location = New System.Drawing.Point(420, 289)
        Me.num_menu7.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_menu7.Name = "num_menu7"
        Me.num_menu7.Size = New System.Drawing.Size(120, 29)
        Me.num_menu7.TabIndex = 21
        '
        'lbl_harga7
        '
        Me.lbl_harga7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_harga7.AutoSize = True
        Me.lbl_harga7.Location = New System.Drawing.Point(169, 291)
        Me.lbl_harga7.Name = "lbl_harga7"
        Me.lbl_harga7.Size = New System.Drawing.Size(84, 24)
        Me.lbl_harga7.TabIndex = 20
        Me.lbl_harga7.Text = "Rp 7.000"
        '
        'lbl_menu7
        '
        Me.lbl_menu7.AutoSize = True
        Me.lbl_menu7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.05882!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu7.Location = New System.Drawing.Point(14, 291)
        Me.lbl_menu7.Name = "lbl_menu7"
        Me.lbl_menu7.Size = New System.Drawing.Size(77, 24)
        Me.lbl_menu7.TabIndex = 19
        Me.lbl_menu7.Text = "Es Teh"
        '
        'num_menu6
        '
        Me.num_menu6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_menu6.Location = New System.Drawing.Point(420, 244)
        Me.num_menu6.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_menu6.Name = "num_menu6"
        Me.num_menu6.Size = New System.Drawing.Size(120, 29)
        Me.num_menu6.TabIndex = 18
        '
        'lbl_harga6
        '
        Me.lbl_harga6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_harga6.AutoSize = True
        Me.lbl_harga6.Location = New System.Drawing.Point(169, 246)
        Me.lbl_harga6.Name = "lbl_harga6"
        Me.lbl_harga6.Size = New System.Drawing.Size(84, 24)
        Me.lbl_harga6.TabIndex = 17
        Me.lbl_harga6.Text = "Rp 6.000"
        '
        'lbl_menu6
        '
        Me.lbl_menu6.AutoSize = True
        Me.lbl_menu6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.05882!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu6.Location = New System.Drawing.Point(14, 246)
        Me.lbl_menu6.Name = "lbl_menu6"
        Me.lbl_menu6.Size = New System.Drawing.Size(47, 24)
        Me.lbl_menu6.TabIndex = 16
        Me.lbl_menu6.Text = "Teh"
        '
        'num_menu5
        '
        Me.num_menu5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_menu5.Location = New System.Drawing.Point(420, 195)
        Me.num_menu5.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_menu5.Name = "num_menu5"
        Me.num_menu5.Size = New System.Drawing.Size(120, 29)
        Me.num_menu5.TabIndex = 15
        '
        'lbl_harga5
        '
        Me.lbl_harga5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_harga5.AutoSize = True
        Me.lbl_harga5.Location = New System.Drawing.Point(169, 197)
        Me.lbl_harga5.Name = "lbl_harga5"
        Me.lbl_harga5.Size = New System.Drawing.Size(84, 24)
        Me.lbl_harga5.TabIndex = 14
        Me.lbl_harga5.Text = "Rp 9.000"
        '
        'lbl_menu5
        '
        Me.lbl_menu5.AutoSize = True
        Me.lbl_menu5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.05882!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu5.Location = New System.Drawing.Point(14, 197)
        Me.lbl_menu5.Name = "lbl_menu5"
        Me.lbl_menu5.Size = New System.Drawing.Size(88, 24)
        Me.lbl_menu5.TabIndex = 13
        Me.lbl_menu5.Text = "Mie Cup"
        '
        'num_menu4
        '
        Me.num_menu4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_menu4.Location = New System.Drawing.Point(420, 148)
        Me.num_menu4.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_menu4.Name = "num_menu4"
        Me.num_menu4.Size = New System.Drawing.Size(120, 29)
        Me.num_menu4.TabIndex = 12
        '
        'lbl_harga4
        '
        Me.lbl_harga4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_harga4.AutoSize = True
        Me.lbl_harga4.Location = New System.Drawing.Point(169, 150)
        Me.lbl_harga4.Name = "lbl_harga4"
        Me.lbl_harga4.Size = New System.Drawing.Size(94, 24)
        Me.lbl_harga4.TabIndex = 11
        Me.lbl_harga4.Text = "Rp 12.000"
        '
        'lbl_menu4
        '
        Me.lbl_menu4.AutoSize = True
        Me.lbl_menu4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.05882!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu4.Location = New System.Drawing.Point(14, 150)
        Me.lbl_menu4.Name = "lbl_menu4"
        Me.lbl_menu4.Size = New System.Drawing.Size(110, 24)
        Me.lbl_menu4.TabIndex = 10
        Me.lbl_menu4.Text = "Mie Rebus"
        '
        'num_menu3
        '
        Me.num_menu3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_menu3.Location = New System.Drawing.Point(420, 103)
        Me.num_menu3.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_menu3.Name = "num_menu3"
        Me.num_menu3.Size = New System.Drawing.Size(120, 29)
        Me.num_menu3.TabIndex = 9
        '
        'lbl_harga3
        '
        Me.lbl_harga3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_harga3.AutoSize = True
        Me.lbl_harga3.Location = New System.Drawing.Point(169, 105)
        Me.lbl_harga3.Name = "lbl_harga3"
        Me.lbl_harga3.Size = New System.Drawing.Size(94, 24)
        Me.lbl_harga3.TabIndex = 8
        Me.lbl_harga3.Text = "Rp 15.000"
        '
        'lbl_menu3
        '
        Me.lbl_menu3.AutoSize = True
        Me.lbl_menu3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.05882!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu3.Location = New System.Drawing.Point(14, 105)
        Me.lbl_menu3.Name = "lbl_menu3"
        Me.lbl_menu3.Size = New System.Drawing.Size(99, 24)
        Me.lbl_menu3.TabIndex = 7
        Me.lbl_menu3.Text = "Mie Aceh"
        '
        'num_menu2
        '
        Me.num_menu2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_menu2.Location = New System.Drawing.Point(420, 56)
        Me.num_menu2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_menu2.Name = "num_menu2"
        Me.num_menu2.Size = New System.Drawing.Size(120, 29)
        Me.num_menu2.TabIndex = 6
        '
        'lbl_harga2
        '
        Me.lbl_harga2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_harga2.AutoSize = True
        Me.lbl_harga2.Location = New System.Drawing.Point(169, 58)
        Me.lbl_harga2.Name = "lbl_harga2"
        Me.lbl_harga2.Size = New System.Drawing.Size(94, 24)
        Me.lbl_harga2.TabIndex = 5
        Me.lbl_harga2.Text = "Rp 14.000"
        '
        'lbl_menu2
        '
        Me.lbl_menu2.AutoSize = True
        Me.lbl_menu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.05882!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu2.Location = New System.Drawing.Point(14, 58)
        Me.lbl_menu2.Name = "lbl_menu2"
        Me.lbl_menu2.Size = New System.Drawing.Size(120, 24)
        Me.lbl_menu2.TabIndex = 4
        Me.lbl_menu2.Text = "Mie Goreng"
        '
        'num_menu1
        '
        Me.num_menu1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_menu1.Location = New System.Drawing.Point(420, 11)
        Me.num_menu1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_menu1.Name = "num_menu1"
        Me.num_menu1.Size = New System.Drawing.Size(120, 29)
        Me.num_menu1.TabIndex = 3
        '
        'lbl_harga1
        '
        Me.lbl_harga1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_harga1.AutoSize = True
        Me.lbl_harga1.Location = New System.Drawing.Point(169, 13)
        Me.lbl_harga1.Name = "lbl_harga1"
        Me.lbl_harga1.Size = New System.Drawing.Size(94, 24)
        Me.lbl_harga1.TabIndex = 3
        Me.lbl_harga1.Text = "Rp 12.000"
        '
        'lbl_menu1
        '
        Me.lbl_menu1.AutoSize = True
        Me.lbl_menu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.05882!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu1.Location = New System.Drawing.Point(14, 13)
        Me.lbl_menu1.Name = "lbl_menu1"
        Me.lbl_menu1.Size = New System.Drawing.Size(127, 24)
        Me.lbl_menu1.TabIndex = 0
        Me.lbl_menu1.Text = "Nasi Goreng"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1099, 675)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_daftarmenu)
        Me.Controls.Add(Me.lbl_judul)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.05882!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.Text = "Kasirko"
        Me.Panel1.ResumeLayout(False)
        Me.pnl_kanan.ResumeLayout(False)
        Me.pnl_kanan.PerformLayout()
        CType(Me.num_bayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_kiri.ResumeLayout(False)
        Me.pnl_kiri.PerformLayout()
        CType(Me.num_menu9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_menu8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_menu7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_menu6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_menu5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_menu4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_menu3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_menu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_menu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_judul As Label
    Friend WithEvents lbl_daftarmenu As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_kanan As Panel
    Friend WithEvents num_bayar As NumericUpDown
    Friend WithEvents btn_hitungkembalian As Button
    Friend WithEvents tbox_kembalian As TextBox
    Friend WithEvents lbl_kembalian As Label
    Friend WithEvents lbl_bayar As Label
    Friend WithEvents tbox_totalbayar As TextBox
    Friend WithEvents lbl_pembayaran As Label
    Friend WithEvents lbl_totalbayar As Label
    Friend WithEvents pnl_kiri As Panel
    Friend WithEvents btn_hitung As Button
    Friend WithEvents btn_bersihkan As Button
    Friend WithEvents num_menu9 As NumericUpDown
    Friend WithEvents lbl_harga9 As Label
    Friend WithEvents lbl_menu9 As Label
    Friend WithEvents num_menu8 As NumericUpDown
    Friend WithEvents lbl_harga8 As Label
    Friend WithEvents lbl_menu8 As Label
    Friend WithEvents num_menu7 As NumericUpDown
    Friend WithEvents lbl_harga7 As Label
    Friend WithEvents lbl_menu7 As Label
    Friend WithEvents num_menu6 As NumericUpDown
    Friend WithEvents lbl_harga6 As Label
    Friend WithEvents lbl_menu6 As Label
    Friend WithEvents num_menu5 As NumericUpDown
    Friend WithEvents lbl_harga5 As Label
    Friend WithEvents lbl_menu5 As Label
    Friend WithEvents num_menu4 As NumericUpDown
    Friend WithEvents lbl_harga4 As Label
    Friend WithEvents lbl_menu4 As Label
    Friend WithEvents num_menu3 As NumericUpDown
    Friend WithEvents lbl_harga3 As Label
    Friend WithEvents lbl_menu3 As Label
    Friend WithEvents num_menu2 As NumericUpDown
    Friend WithEvents lbl_harga2 As Label
    Friend WithEvents lbl_menu2 As Label
    Friend WithEvents num_menu1 As NumericUpDown
    Friend WithEvents lbl_harga1 As Label
    Friend WithEvents lbl_menu1 As Label
End Class
