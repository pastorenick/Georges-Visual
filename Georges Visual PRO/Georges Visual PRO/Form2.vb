Public Class Form2
    Dim allRows As New List(Of systemstucture)
    Dim index As Integer = 0

    Structure systemstucture

        Dim number As Integer
        Dim motion As String
        Dim timeCreated As String
        Dim deviceId As String
        Dim id As String
        Dim occurredAt As String
        Dim timeUpdated As String
        Dim motionValue As String
        Dim sensorName As String
        Dim sensorKind As String
        Dim timeStamp As String
        Dim kitchen As String
        Dim laundry As String
        Dim toilet As String
        Dim medicationArea As String
        Dim livingRoom As String
        Dim masterBedroom As String
        Dim spareBedroom As String
        Dim bathroom As String

    End Structure

    Private Sub csvmanagment()
        'Using csvparser As New FileIO.TextFieldParser("C:\Users\DISTIL\Documents\Visual Studio 2013\Projects\Georges Visual PRO\Georges Visual PRO\bin\Debug")
        '    Dim csValueList As New List(Of String)

        '    csvparser.TextFieldType = FileIO.FieldType.Delimited
        '    csvparser.Delimiters = New String() {","}

        '    csValueList.AddRange(csvparser.ReadFields)
        '    csValueList.AddRange(csvparser.ReadFields)
        '    csValueList.Clear()

        '    While csvparser.EndOfData = False
        '        csValueList.AddRange(csvparser.ReadFields)
        '        Dim systemData As New systemstucture

        '        systemData.number = csValueList(0)
        '        systemData.motion = csValueList(1)
        '        systemData.timeCreated = csValueList(2)
        '        systemData.deviceId = csValueList(3)
        '        systemData.id = csValueList(4)
        '        systemData.occurredAt = csValueList(5)
        '        systemData.timeUpdated = csValueList(6)
        '        systemData.motionValue = csValueList(7)
        '        systemData.sensorName = csValueList(8)
        '        systemData.sensorKind = csValueList(9)
        '        systemData.timeStamp = csValueList(10)
        '        systemData.kitchen = csValueList(11)
        '        systemData.laundry = csValueList(12)
        '        systemData.toilet = csValueList(13)
        '        systemData.medicationArea = csValueList(14)
        '        systemData.livingRoom = csValueList(15)
        '        systemData.masterBedroom = csValueList(16)
        '        systemData.spareBedroom = csValueList(17)
        '        systemData.bathroom = csValueList(18)

        '        allRows.Add(systemData)
        '        csValueList.Clear()
        '    End While
        'End Using
    End Sub

    Private Function timeChanger(ByVal time As String)
        ' remove from the string the non-numeric characters (i.e. T and Z)
        Dim cleanString As String
        Dim dateTimeObj As Date

        cleanString = time.Replace("T", " ").Replace("Z", "")
        ' convert the (clean) string into a datetime variable
        If cleanString <> "" Then
            dateTimeObj = Date.ParseExact(cleanString, "yyyy-MM-dd HH:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Else
            dateTimeObj = ""
        End If
        Return dateTimeObj
    End Function

    Private Sub houseLayout(ByVal room As Object, ByVal cbO As Object, ByVal cbM As Object, ByVal mSensor As Object)
        If Not cbO.Text = "" Then
            room.Visible = True
            room.Text = cbO.Text
        End If
        If cbM.Checked = True And Not cbO.Text = "" Then
            mSensor.Visible = True
        End If
    End Sub
    Private Sub transitSensorLayout(ByVal cbT As Object, ByVal tSensor As Object)
        If cbT.Checked = True Then
            tSensor.Visible = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csvmanagment()
        'House Setup
        houseLayout(lblRoom1, Form1.cbOption1, Form1.cbMotion1, lblMotionSensor1)
        houseLayout(lblRoom2, Form1.cbOption2, Form1.cbMotion2, lblMotionSensor2)
        houseLayout(lblRoom3, Form1.cbOption3, Form1.cbMotion3, lblMotionSensor3)
        houseLayout(lblRoom4, Form1.cbOption4, Form1.cbMotion4, lblMotionSensor4)
        houseLayout(lblRoom5, Form1.cbOption5, Form1.cbMotion5, lblMotionSensor5)
        houseLayout(lblRoom6, Form1.cbOption6, Form1.cbMotion6, lblMotionSensor6)
        houseLayout(lblRoom7, Form1.cbOption7, Form1.cbMotion7, lblMotionSensor7)
        houseLayout(lblRoom8, Form1.cbOption8, Form1.cbMotion8, lblMotionSensor8)
        houseLayout(lblRoom9, Form1.cbOption9, Form1.cbMotion9, lblMotionSensor9)
        houseLayout(lblRoom10, Form1.cbOption10, Form1.cbMotion10, lblMotionSensor10)
        ' Transit Sensor Setup
        transitSensorLayout(Form1.cbTransit1, lblTransitSensor1)
        transitSensorLayout(Form1.cbTransit2, lblTransitSensor2)
        transitSensorLayout(Form1.cbTransit3, lblTransitSensor3)
        transitSensorLayout(Form1.cbTransit4, lblTransitSensor4)
        transitSensorLayout(Form1.cbTransit5, lblTransitSensor5)
        transitSensorLayout(Form1.cbTransit6, lblTransitSensor6)
        transitSensorLayout(Form1.cbTransit7, lblTransitSensor7)
        transitSensorLayout(Form1.cbTransit8, lblTransitSensor8)
        transitSensorLayout(Form1.cbTransit9, lblTransitSensor9)
        transitSensorLayout(Form1.cbTransit10, lblTransitSensor10)
        transitSensorLayout(Form1.cbTransit11, lblTransitSensor11)
        transitSensorLayout(Form1.cbTransit12, lblTransitSensor12)
        transitSensorLayout(Form1.cbTransit13, lblTransitSensor13)


    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show("A red box indicates a motion sensor and a black box indicates a transit sensor when activaed they turn blue.")
    End Sub

    Private Sub getNextRows()
        lblTimeStamp.Text = allRows(index).timeStamp
        index = index + 1

        If index >= allRows.Count Then
            index = 0
            tmrTimeStamp.Enabled = False
            MessageBox.Show("End of Spreedsheet")
        End If
    End Sub

    Private Sub tmrOn_Tick(sender As Object, e As EventArgs) Handles tmrOn.Tick
        If tmrTimeStamp.Enabled = False Then
            lblLine.Visible = True
            lblJumpInstuct.Visible = True
            txtJump.Visible = True
            btnJump.Visible = True
        Else
            lblLine.Visible = False
            lblJumpInstuct.Visible = False
            txtJump.Visible = False
            btnJump.Visible = False
        End If
    End Sub

    Private Sub tmrTimeStamp_Tick(sender As Object, e As EventArgs) Handles tmrTimeStamp.Tick

    End Sub
End Class