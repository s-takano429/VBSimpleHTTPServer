<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWebStart
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWebStart))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TSSLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.TSSBtnStop = New System.Windows.Forms.ToolStripSplitButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDocumentRoot = New System.Windows.Forms.TextBox()
        Me.BtnServerStart = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSLabel, Me.TSProgressBar, Me.TSSBtnStop})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 79)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(384, 23)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'TSSLabel
        '
        Me.TSSLabel.Name = "TSSLabel"
        Me.TSSLabel.Size = New System.Drawing.Size(235, 18)
        Me.TSSLabel.Spring = True
        Me.TSSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TSProgressBar
        '
        Me.TSProgressBar.Name = "TSProgressBar"
        Me.TSProgressBar.Size = New System.Drawing.Size(100, 17)
        '
        'TSSBtnStop
        '
        Me.TSSBtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSSBtnStop.Image = CType(resources.GetObject("TSSBtnStop.Image"), System.Drawing.Image)
        Me.TSSBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSSBtnStop.Name = "TSSBtnStop"
        Me.TSSBtnStop.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.TSSBtnStop.Size = New System.Drawing.Size(32, 21)
        Me.TSSBtnStop.Text = "ToolStripSplitButton1"
        Me.TSSBtnStop.ToolTipText = "中止"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnServerStart, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(384, 79)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 3)
        Me.GroupBox1.Controls.Add(Me.TxtDocumentRoot)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 39)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DocumentRoot　(index.htmlのあるパス)"
        '
        'TxtDocumentRoot
        '
        Me.TxtDocumentRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDocumentRoot.Location = New System.Drawing.Point(3, 15)
        Me.TxtDocumentRoot.Name = "TxtDocumentRoot"
        Me.TxtDocumentRoot.Size = New System.Drawing.Size(372, 19)
        Me.TxtDocumentRoot.TabIndex = 0
        '
        'BtnServerStart
        '
        Me.BtnServerStart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnServerStart.Location = New System.Drawing.Point(220, 48)
        Me.BtnServerStart.Name = "BtnServerStart"
        Me.BtnServerStart.Size = New System.Drawing.Size(161, 28)
        Me.BtnServerStart.TabIndex = 1
        Me.BtnServerStart.Text = "ServerStart"
        Me.BtnServerStart.UseVisualStyleBackColor = True
        '
        'FrmWebStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 102)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip)
        Me.MaximumSize = New System.Drawing.Size(400, 140)
        Me.MinimumSize = New System.Drawing.Size(400, 140)
        Me.Name = "FrmWebStart"
        Me.Text = "Form1"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents TSSLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TSSBtnStop As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDocumentRoot As System.Windows.Forms.TextBox
    Friend WithEvents BtnServerStart As System.Windows.Forms.Button

End Class
