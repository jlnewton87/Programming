<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
      Me.components = New System.ComponentModel.Container()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.btnGenerateReport = New System.Windows.Forms.Button()
      Me.btnClear = New System.Windows.Forms.Button()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.lblRoomsOccupied = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.lblTotalOccupancy = New System.Windows.Forms.Label()
      Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      Me.dgvReport = New System.Windows.Forms.DataGridView()
      Me.rowFloor = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.rowRoomsOccupied = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.rowOccupancyRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.GroupBox1.SuspendLayout()
      CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.dgvReport)
      Me.GroupBox1.Location = New System.Drawing.Point(-3, 30)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(388, 173)
      Me.GroupBox1.TabIndex = 7
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Floor Occupancy Information"
      '
      'btnGenerateReport
      '
      Me.btnGenerateReport.Location = New System.Drawing.Point(48, 308)
      Me.btnGenerateReport.Name = "btnGenerateReport"
      Me.btnGenerateReport.Size = New System.Drawing.Size(75, 43)
      Me.btnGenerateReport.TabIndex = 0
      Me.btnGenerateReport.Text = "Complete &Report"
      Me.ToolTip1.SetToolTip(Me.btnGenerateReport, "Generate Occupancy Report")
      Me.btnGenerateReport.UseVisualStyleBackColor = True
      '
      'btnClear
      '
      Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnClear.Location = New System.Drawing.Point(153, 308)
      Me.btnClear.Name = "btnClear"
      Me.btnClear.Size = New System.Drawing.Size(75, 43)
      Me.btnClear.TabIndex = 1
      Me.btnClear.Text = "&Clear"
      Me.ToolTip1.SetToolTip(Me.btnClear, "Clear Form")
      Me.btnClear.UseVisualStyleBackColor = True
      '
      'btnExit
      '
      Me.btnExit.Location = New System.Drawing.Point(258, 308)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(75, 43)
      Me.btnExit.TabIndex = 2
      Me.btnExit.Text = "E&xit"
      Me.ToolTip1.SetToolTip(Me.btnExit, "Exit Application")
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(75, 214)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(119, 13)
      Me.Label1.TabIndex = 5
      Me.Label1.Text = "Total Rooms Occupied:"
      '
      'lblRoomsOccupied
      '
      Me.lblRoomsOccupied.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblRoomsOccupied.Location = New System.Drawing.Point(223, 214)
      Me.lblRoomsOccupied.Name = "lblRoomsOccupied"
      Me.lblRoomsOccupied.Size = New System.Drawing.Size(58, 21)
      Me.lblRoomsOccupied.TabIndex = 6
      Me.lblRoomsOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.ToolTip1.SetToolTip(Me.lblRoomsOccupied, "Total number of Occupied Rooms")
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(75, 253)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(127, 13)
      Me.Label3.TabIndex = 7
      Me.Label3.Text = "Overall Occupancy Rate:"
      '
      'lblTotalOccupancy
      '
      Me.lblTotalOccupancy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblTotalOccupancy.Location = New System.Drawing.Point(223, 253)
      Me.lblTotalOccupancy.Name = "lblTotalOccupancy"
      Me.lblTotalOccupancy.Size = New System.Drawing.Size(58, 19)
      Me.lblTotalOccupancy.TabIndex = 8
      Me.lblTotalOccupancy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.ToolTip1.SetToolTip(Me.lblTotalOccupancy, "Rate of rooms Occupied out of total number")
      '
      'dgvReport
      '
      Me.dgvReport.AllowUserToAddRows = False
      Me.dgvReport.AllowUserToDeleteRows = False
      Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rowFloor, Me.rowRoomsOccupied, Me.rowOccupancyRate})
      Me.dgvReport.Location = New System.Drawing.Point(27, 19)
      Me.dgvReport.Name = "dgvReport"
      Me.dgvReport.ReadOnly = True
      Me.dgvReport.Size = New System.Drawing.Size(343, 150)
      Me.dgvReport.TabIndex = 0
      '
      'rowFloor
      '
      Me.rowFloor.HeaderText = "Floor"
      Me.rowFloor.Name = "rowFloor"
      '
      'rowRoomsOccupied
      '
      Me.rowRoomsOccupied.HeaderText = "Rooms Occupied"
      Me.rowRoomsOccupied.Name = "rowRoomsOccupied"
      '
      'rowOccupancyRate
      '
      Me.rowOccupancyRate.HeaderText = "Occupancy Rate"
      Me.rowOccupancyRate.Name = "rowOccupancyRate"
      '
      'Form1
      '
      Me.AcceptButton = Me.btnGenerateReport
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.btnClear
      Me.ClientSize = New System.Drawing.Size(397, 363)
      Me.Controls.Add(Me.lblTotalOccupancy)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.lblRoomsOccupied)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnClear)
      Me.Controls.Add(Me.btnGenerateReport)
      Me.Controls.Add(Me.GroupBox1)
      Me.Name = "Form1"
      Me.Text = "Hotel Occupancy"
      Me.GroupBox1.ResumeLayout(False)
      CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents btnGenerateReport As System.Windows.Forms.Button
   Friend WithEvents btnClear As System.Windows.Forms.Button
   Friend WithEvents btnExit As System.Windows.Forms.Button
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents lblRoomsOccupied As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents lblTotalOccupancy As System.Windows.Forms.Label
   Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
   Friend WithEvents rowFloor As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents rowRoomsOccupied As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents rowOccupancyRate As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
