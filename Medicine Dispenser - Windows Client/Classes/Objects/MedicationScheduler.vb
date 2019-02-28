Namespace Objects
    Public Class MedicationScheduler : Implements IDisposable

#Region "Variables"
        Dim AlertScheduler As Threading.Timer
        Dim ExpiryScheduler As Threading.Timer
#End Region

#Region "Events"
        Public Event Alert(ByVal MedicationScheduler As MedicationScheduler)
        Public Event Expired(ByVal MedicationScheduler As MedicationScheduler)
#End Region

#Region "Properties"
        Property Patient As Patient
        Property Medications As New List(Of Medication)
        Property AlertTime As DateTime
        Property ExpiryTime As DateTime
#End Region

#Region "Constructor"
        Sub New(ByVal Patient As Patient, ByVal Medications As List(Of Medication), ByVal AlertTime As DateTime)
            Me.Patient = Patient
            Me.Medications = Medications
            Me.AlertTime = AlertTime
            Me.ExpiryTime = AlertTime.AddHours(1)

            Dim AlertInterval As TimeSpan = AlertTime.Subtract(Now)
            Dim ExpiryInterval As TimeSpan = ExpiryTime.Subtract(Now)
            Me.AlertScheduler = New Threading.Timer(New Threading.TimerCallback(AddressOf TrigerAlert), Nothing, AlertInterval, Threading.Timeout.InfiniteTimeSpan)
            Me.ExpiryScheduler = New Threading.Timer(New Threading.TimerCallback(AddressOf TriggerExpiry), Nothing, ExpiryInterval, Threading.Timeout.InfiniteTimeSpan)
        End Sub
#End Region

#Region "Subs"
        Private Sub Dispose() Implements IDisposable.Dispose
            If AlertScheduler IsNot Nothing Then
                AlertScheduler.Change(Threading.Timeout.Infinite, Threading.Timeout.Infinite)
                AlertScheduler.Dispose()
            End If
            If ExpiryScheduler IsNot Nothing Then
                ExpiryScheduler.Change(Threading.Timeout.Infinite, Threading.Timeout.Infinite)
                ExpiryScheduler.Dispose()
            End If
        End Sub

        Private Sub TrigerAlert(ByVal State As Object)
            RaiseEvent Alert(Me)
        End Sub

        Private Sub TriggerExpiry(ByVal State As Object)
            RaiseEvent Expired(Me)
        End Sub
#End Region

    End Class
End Namespace