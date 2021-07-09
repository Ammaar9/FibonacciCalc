<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FibonacciForm
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
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.startAsyncButton = New System.Windows.Forms.Button()
        Me.cancelAsyncButton = New System.Windows.Forms.Button()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(16, 16)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {91, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(80, 20)
        Me.numericUpDown1.TabIndex = 0
        Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'startAsyncButton
        '
        Me.startAsyncButton.Location = New System.Drawing.Point(16, 72)
        Me.startAsyncButton.Name = "startAsyncButton"
        Me.startAsyncButton.Size = New System.Drawing.Size(120, 23)
        Me.startAsyncButton.TabIndex = 1
        Me.startAsyncButton.Text = "Start Async"
        '
        'cancelAsyncButton
        '
        Me.cancelAsyncButton.Enabled = False
        Me.cancelAsyncButton.Location = New System.Drawing.Point(153, 72)
        Me.cancelAsyncButton.Name = "cancelAsyncButton"
        Me.cancelAsyncButton.Size = New System.Drawing.Size(119, 23)
        Me.cancelAsyncButton.TabIndex = 2
        Me.cancelAsyncButton.Text = "Cancel Async"
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultLabel.Location = New System.Drawing.Point(112, 16)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(160, 23)
        Me.resultLabel.TabIndex = 3
        Me.resultLabel.Text = "(no result)"
        Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(18, 48)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(256, 8)
        Me.progressBar1.TabIndex = 4
        '
        'backgroundWorker1
        '
        Me.backgroundWorker1.WorkerReportsProgress = True
        Me.backgroundWorker1.WorkerSupportsCancellation = True
        '
        'FibonacciForm
        '
        Me.ClientSize = New System.Drawing.Size(292, 118)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.cancelAsyncButton)
        Me.Controls.Add(Me.startAsyncButton)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Name = "FibonacciForm"
        Me.Text = "Fibonacci Calculator"
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
