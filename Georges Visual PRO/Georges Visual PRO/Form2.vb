Public Class Form2

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
End Class