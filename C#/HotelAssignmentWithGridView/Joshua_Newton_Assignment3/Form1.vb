Public Class Form1

    'Constants - Could change if used by another hotel, or they add rooms or something
    Const NUMBER_OF_FLOORS = 8
    Const ROOMS_PER_FLOOR = 30

    'Generates the report
    Private Sub btnGenerateReport_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerateReport.Click
        getFloorOccupancy()
    End Sub

    'Clear the form
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lblRoomsOccupied.Text = String.Empty
        lblTotalOccupancy.Text = String.Empty
      dgvReport.Rows.Clear()
    End Sub

    'Exit the application
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub getFloorOccupancy()
        Dim totalNumberOfRooms As Integer = ROOMS_PER_FLOOR * NUMBER_OF_FLOORS
        Dim totalRoomsOccupied As Integer
        Dim totalOccupancy As Decimal
        For floors As Integer = 1 To NUMBER_OF_FLOORS
            Dim intOccupiedRooms As Integer
            'If entry is not an integer, tell the user, and make them start over
            Try
                intOccupiedRooms = CInt(InputBox("How many rooms occupied on floor " + floors.ToString, "Floor " + floors.ToString))
            Catch RoomsOccupiedNotInteger As InvalidCastException
                MessageBox.Show("Number of rooms must be entered as a number." & vbNewLine & "Please try again", "Invalid Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                Return
            End Try
            'Get Occupancy for current floor as a decimal
            Dim decOccupancy As Decimal = intOccupiedRooms / ROOMS_PER_FLOOR
            'Add current floor's occupied rooms to total
            totalRoomsOccupied += intOccupiedRooms
            'Create string for report, and add it to the list box
         getFloorReport(floors, intOccupiedRooms, decOccupancy)
        Next
        lblRoomsOccupied.Text = totalRoomsOccupied
        'Get total Hotel Occupancy Rate
        totalOccupancy = totalRoomsOccupied / totalNumberOfRooms
        lblTotalOccupancy.Text = FormatPercent(totalOccupancy, 2)
    End Sub

    'Creates the string for the Occupancy Report based on floor #, # of rooms occupied, and the occupancy rate
   Public Function getFloorReport(intFloorNumber As Integer, intRoomsOccupied As Integer, decOccupancyRate As Decimal)
      Dim floorReport As New DataGridViewRow
      Dim floorcell As New DataGridViewTextBoxCell
      Dim roomsCell As New DataGridViewTextBoxCell
      Dim occupancyCell As New DataGridViewTextBoxCell
      floorcell.Value = intFloorNumber
      roomsCell.Value = intRoomsOccupied
      occupancyCell.Value = FormatPercent(decOccupancyRate, 2)
      floorReport.Cells.Add(floorcell)
      floorReport.Cells.Add(roomsCell)
      floorReport.Cells.Add(occupancyCell)
      dgvReport.Rows.Add(floorReport)
   End Function

End Class
