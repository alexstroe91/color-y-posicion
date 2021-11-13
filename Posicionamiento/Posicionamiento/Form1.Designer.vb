<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbxColor = New System.Windows.Forms.GroupBox()
        Me.rbnAmarillo = New System.Windows.Forms.RadioButton()
        Me.rbnVerde = New System.Windows.Forms.RadioButton()
        Me.rbnAzul = New System.Windows.Forms.RadioButton()
        Me.rbnRojo = New System.Windows.Forms.RadioButton()
        Me.gbxPosicion = New System.Windows.Forms.GroupBox()
        Me.rbnDerecha = New System.Windows.Forms.RadioButton()
        Me.rbnIzquierda = New System.Windows.Forms.RadioButton()
        Me.rbnCentro = New System.Windows.Forms.RadioButton()
        Me.rbnAbajo = New System.Windows.Forms.RadioButton()
        Me.rbnArriba = New System.Windows.Forms.RadioButton()
        Me.lblCuadro = New System.Windows.Forms.Label()
        Me.gbxColor.SuspendLayout()
        Me.gbxPosicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxColor
        '
        Me.gbxColor.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbxColor.Controls.Add(Me.rbnAmarillo)
        Me.gbxColor.Controls.Add(Me.rbnVerde)
        Me.gbxColor.Controls.Add(Me.rbnAzul)
        Me.gbxColor.Controls.Add(Me.rbnRojo)
        Me.gbxColor.Location = New System.Drawing.Point(12, 12)
        Me.gbxColor.Name = "gbxColor"
        Me.gbxColor.Size = New System.Drawing.Size(201, 141)
        Me.gbxColor.TabIndex = 0
        Me.gbxColor.TabStop = False
        Me.gbxColor.Text = "Color"
        '
        'rbnAmarillo
        '
        Me.rbnAmarillo.AutoSize = True
        Me.rbnAmarillo.Location = New System.Drawing.Point(73, 96)
        Me.rbnAmarillo.Name = "rbnAmarillo"
        Me.rbnAmarillo.Size = New System.Drawing.Size(61, 17)
        Me.rbnAmarillo.TabIndex = 3
        Me.rbnAmarillo.TabStop = True
        Me.rbnAmarillo.Text = "Amarillo"
        Me.rbnAmarillo.UseVisualStyleBackColor = True
        '
        'rbnVerde
        '
        Me.rbnVerde.AutoSize = True
        Me.rbnVerde.Location = New System.Drawing.Point(73, 73)
        Me.rbnVerde.Name = "rbnVerde"
        Me.rbnVerde.Size = New System.Drawing.Size(53, 17)
        Me.rbnVerde.TabIndex = 2
        Me.rbnVerde.TabStop = True
        Me.rbnVerde.Text = "Verde"
        Me.rbnVerde.UseVisualStyleBackColor = True
        '
        'rbnAzul
        '
        Me.rbnAzul.AutoSize = True
        Me.rbnAzul.Location = New System.Drawing.Point(73, 50)
        Me.rbnAzul.Name = "rbnAzul"
        Me.rbnAzul.Size = New System.Drawing.Size(45, 17)
        Me.rbnAzul.TabIndex = 1
        Me.rbnAzul.TabStop = True
        Me.rbnAzul.Text = "Azul"
        Me.rbnAzul.UseVisualStyleBackColor = True
        '
        'rbnRojo
        '
        Me.rbnRojo.AutoSize = True
        Me.rbnRojo.Location = New System.Drawing.Point(73, 27)
        Me.rbnRojo.Name = "rbnRojo"
        Me.rbnRojo.Size = New System.Drawing.Size(47, 17)
        Me.rbnRojo.TabIndex = 0
        Me.rbnRojo.TabStop = True
        Me.rbnRojo.Text = "Rojo"
        Me.rbnRojo.UseVisualStyleBackColor = True
        '
        'gbxPosicion
        '
        Me.gbxPosicion.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbxPosicion.Controls.Add(Me.rbnDerecha)
        Me.gbxPosicion.Controls.Add(Me.rbnIzquierda)
        Me.gbxPosicion.Controls.Add(Me.rbnCentro)
        Me.gbxPosicion.Controls.Add(Me.rbnAbajo)
        Me.gbxPosicion.Controls.Add(Me.rbnArriba)
        Me.gbxPosicion.Location = New System.Drawing.Point(12, 259)
        Me.gbxPosicion.Name = "gbxPosicion"
        Me.gbxPosicion.Size = New System.Drawing.Size(207, 127)
        Me.gbxPosicion.TabIndex = 1
        Me.gbxPosicion.TabStop = False
        Me.gbxPosicion.Text = "Posicion"
        '
        'rbnDerecha
        '
        Me.rbnDerecha.AutoSize = True
        Me.rbnDerecha.Location = New System.Drawing.Point(135, 56)
        Me.rbnDerecha.Name = "rbnDerecha"
        Me.rbnDerecha.Size = New System.Drawing.Size(66, 17)
        Me.rbnDerecha.TabIndex = 8
        Me.rbnDerecha.TabStop = True
        Me.rbnDerecha.Text = "Derecha"
        Me.rbnDerecha.UseVisualStyleBackColor = True
        '
        'rbnIzquierda
        '
        Me.rbnIzquierda.AutoSize = True
        Me.rbnIzquierda.Location = New System.Drawing.Point(0, 56)
        Me.rbnIzquierda.Name = "rbnIzquierda"
        Me.rbnIzquierda.Size = New System.Drawing.Size(68, 17)
        Me.rbnIzquierda.TabIndex = 7
        Me.rbnIzquierda.TabStop = True
        Me.rbnIzquierda.Text = "Izquierda"
        Me.rbnIzquierda.UseVisualStyleBackColor = True
        '
        'rbnCentro
        '
        Me.rbnCentro.AutoSize = True
        Me.rbnCentro.Location = New System.Drawing.Point(73, 56)
        Me.rbnCentro.Name = "rbnCentro"
        Me.rbnCentro.Size = New System.Drawing.Size(56, 17)
        Me.rbnCentro.TabIndex = 6
        Me.rbnCentro.TabStop = True
        Me.rbnCentro.Text = "Centro"
        Me.rbnCentro.UseVisualStyleBackColor = True
        '
        'rbnAbajo
        '
        Me.rbnAbajo.AutoSize = True
        Me.rbnAbajo.Location = New System.Drawing.Point(73, 91)
        Me.rbnAbajo.Name = "rbnAbajo"
        Me.rbnAbajo.Size = New System.Drawing.Size(52, 17)
        Me.rbnAbajo.TabIndex = 5
        Me.rbnAbajo.TabStop = True
        Me.rbnAbajo.Text = "Abajo"
        Me.rbnAbajo.UseVisualStyleBackColor = True
        '
        'rbnArriba
        '
        Me.rbnArriba.AutoSize = True
        Me.rbnArriba.Location = New System.Drawing.Point(73, 19)
        Me.rbnArriba.Name = "rbnArriba"
        Me.rbnArriba.Size = New System.Drawing.Size(52, 17)
        Me.rbnArriba.TabIndex = 4
        Me.rbnArriba.TabStop = True
        Me.rbnArriba.Text = "Arriba"
        Me.rbnArriba.UseVisualStyleBackColor = True
        '
        'lblCuadro
        '
        Me.lblCuadro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCuadro.Location = New System.Drawing.Point(411, 171)
        Me.lblCuadro.Name = "lblCuadro"
        Me.lblCuadro.Size = New System.Drawing.Size(182, 76)
        Me.lblCuadro.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 413)
        Me.Controls.Add(Me.lblCuadro)
        Me.Controls.Add(Me.gbxPosicion)
        Me.Controls.Add(Me.gbxColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxColor.ResumeLayout(False)
        Me.gbxColor.PerformLayout()
        Me.gbxPosicion.ResumeLayout(False)
        Me.gbxPosicion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxColor As GroupBox
    Friend WithEvents gbxPosicion As GroupBox
    Friend WithEvents rbnAmarillo As RadioButton
    Friend WithEvents rbnVerde As RadioButton
    Friend WithEvents rbnAzul As RadioButton
    Friend WithEvents rbnRojo As RadioButton
    Friend WithEvents rbnDerecha As RadioButton
    Friend WithEvents rbnIzquierda As RadioButton
    Friend WithEvents rbnCentro As RadioButton
    Friend WithEvents rbnAbajo As RadioButton
    Friend WithEvents rbnArriba As RadioButton
    Friend WithEvents lblCuadro As Label
End Class
