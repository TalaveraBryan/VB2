<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboboxFrom = New System.Windows.Forms.ComboBox()
        Me.ComboboxTo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DiscountCombo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OriginTxt = New System.Windows.Forms.TextBox()
        Me.DestinationTxt = New System.Windows.Forms.TextBox()
        Me.GrossTxt = New System.Windows.Forms.TextBox()
        Me.Discounttext = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NetfareTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FROM:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TO:"
        '
        'ComboboxFrom
        '
        Me.ComboboxFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboboxFrom.FormattingEnabled = True
        Me.ComboboxFrom.Location = New System.Drawing.Point(231, 94)
        Me.ComboboxFrom.Name = "ComboboxFrom"
        Me.ComboboxFrom.Size = New System.Drawing.Size(209, 33)
        Me.ComboboxFrom.TabIndex = 2
        '
        'ComboboxTo
        '
        Me.ComboboxTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboboxTo.FormattingEnabled = True
        Me.ComboboxTo.Location = New System.Drawing.Point(231, 207)
        Me.ComboboxTo.Name = "ComboboxTo"
        Me.ComboboxTo.Size = New System.Drawing.Size(209, 33)
        Me.ComboboxTo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DISCOUNT:"
        '
        'DiscountCombo
        '
        Me.DiscountCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountCombo.FormattingEnabled = True
        Me.DiscountCombo.Items.AddRange(New Object() {"Government Employee(10%)", "Student(15%)", "Children(20%)", "Senior(50%)"})
        Me.DiscountCombo.Location = New System.Drawing.Point(231, 360)
        Me.DiscountCombo.Name = "DiscountCombo"
        Me.DiscountCombo.Size = New System.Drawing.Size(209, 28)
        Me.DiscountCombo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(658, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "GROSS FEE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(658, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 32)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DESTINATION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(658, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 32)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ORIGIN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(658, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 32)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "DISCOUNT:"
        '
        'OriginTxt
        '
        Me.OriginTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OriginTxt.Location = New System.Drawing.Point(895, 99)
        Me.OriginTxt.Multiline = True
        Me.OriginTxt.Name = "OriginTxt"
        Me.OriginTxt.Size = New System.Drawing.Size(224, 31)
        Me.OriginTxt.TabIndex = 10
        Me.OriginTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DestinationTxt
        '
        Me.DestinationTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinationTxt.Location = New System.Drawing.Point(895, 160)
        Me.DestinationTxt.Multiline = True
        Me.DestinationTxt.Name = "DestinationTxt"
        Me.DestinationTxt.Size = New System.Drawing.Size(224, 31)
        Me.DestinationTxt.TabIndex = 11
        Me.DestinationTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GrossTxt
        '
        Me.GrossTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossTxt.Location = New System.Drawing.Point(895, 227)
        Me.GrossTxt.Multiline = True
        Me.GrossTxt.Name = "GrossTxt"
        Me.GrossTxt.Size = New System.Drawing.Size(224, 31)
        Me.GrossTxt.TabIndex = 12
        Me.GrossTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Discounttext
        '
        Me.Discounttext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Discounttext.Location = New System.Drawing.Point(895, 283)
        Me.Discounttext.Multiline = True
        Me.Discounttext.Name = "Discounttext"
        Me.Discounttext.Size = New System.Drawing.Size(224, 31)
        Me.Discounttext.TabIndex = 13
        Me.Discounttext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(752, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 48)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Compute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(929, 449)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 48)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(658, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 32)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "NETFARE:"
        '
        'NetfareTxt
        '
        Me.NetfareTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetfareTxt.Location = New System.Drawing.Point(895, 338)
        Me.NetfareTxt.Multiline = True
        Me.NetfareTxt.Name = "NetfareTxt"
        Me.NetfareTxt.Size = New System.Drawing.Size(224, 31)
        Me.NetfareTxt.TabIndex = 18
        Me.NetfareTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(531, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 32)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "LRT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1257, 644)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NetfareTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Discounttext)
        Me.Controls.Add(Me.GrossTxt)
        Me.Controls.Add(Me.DestinationTxt)
        Me.Controls.Add(Me.OriginTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DiscountCombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboboxTo)
        Me.Controls.Add(Me.ComboboxFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "'"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboboxFrom As ComboBox
    Friend WithEvents ComboboxTo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DiscountCombo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents OriginTxt As TextBox
    Friend WithEvents DestinationTxt As TextBox
    Friend WithEvents GrossTxt As TextBox
    Friend WithEvents Discounttext As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents NetfareTxt As TextBox
    Friend WithEvents Label10 As Label
End Class
