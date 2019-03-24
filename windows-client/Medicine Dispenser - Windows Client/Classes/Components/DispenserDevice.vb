Imports System.IO.Ports

Namespace Components
    Public Class DispenserDevice

#Region "Variables"
        Dim Dispensed As Boolean = False
#End Region

#Region "Properties"
        Property PortName As String
            Get
                Return SerialPort.PortName
            End Get
            Set(value As String)
                SerialPort.PortName = value
            End Set
        End Property

        Dim isHandPlaced_ As Boolean = False
        Property isHandPlaced As Boolean
            Get
                Return isHandPlaced_
            End Get
            Set(value As Boolean)
                RaiseEvent HandPlaced(Me, New Objects.HandPlacedEventArgs(value))
                isHandPlaced_ = value
            End Set
        End Property
#End Region

#Region "Functions"
        Function Start() As Boolean
            If SerialPort.IsOpen Then
                Return True
            Else
                SerialPort.Open()
                Return SerialPort.IsOpen
            End If
        End Function

        Function Dispense(ByVal Medication As Objects.Medication) As Boolean
            Try
                Dim Timer As New Stopwatch
                SerialPort.WriteLine([Enum].GetName(GetType(Enums.Medicine), Medication.Medicine) & Medication.Dosage)
                Threading.Thread.Sleep(1000)
                Timer.Start()
                Dispensed = False
                Do Until Dispensed Or Timer.Elapsed.TotalSeconds >= 30
                    Application.DoEvents()
                Loop
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
#End Region

#Region "Public Events"
        Public Event HandPlaced(ByVal sender As Object, ByVal e As Objects.HandPlacedEventArgs)
#End Region

#Region "Serial Port Events"
        Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
            Dim Data As String = SerialPort.ReadExisting()
            If Data = "HP" Then
                isHandPlaced = True
            ElseIf Data = "HR" Then
                isHandPlaced = False
            ElseIf Data = "DS" Then
                Dispensed = True
            End If
        End Sub
#End Region

    End Class
End Namespace