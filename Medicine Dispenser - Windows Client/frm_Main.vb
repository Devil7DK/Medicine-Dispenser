Imports DevExpress.XtraTab

Public Class frm_Main

#Region "Variables"
    Dim Doctor As Objects.Doctor
    Dim LoginInstance As frm_Login
#End Region

#Region "Properties"
    Private Property Doctors As List(Of Objects.Doctor)
        Get
            Return CType(gc_Doctors.DataSource, List(Of Objects.Doctor))
        End Get
        Set(value As List(Of Objects.Doctor))
            gc_Doctors.DataSource = value
            gc_Doctors.RefreshDataSource()
        End Set
    End Property
#End Region

#Region "Constructor"
    Sub New(Doctor As Objects.Doctor, LoginInstance As frm_Login)
        InitializeComponent()
        Me.Doctor = Doctor
        Me.LoginInstance = LoginInstance
    End Sub
#End Region

#Region "Subs/Functions"
    Private Sub UpdateProgress(ByVal Description As String, Optional ByVal Caption As String = "")
        If InvokeRequired Then
            Invoke(Sub() UpdateProgress(Description, Caption))
        Else
            If Description <> "" Then
                ProgressPanel.Description = Description
            End If
            If Caption <> "" Then
                ProgressPanel.Caption = Caption
            End If
        End If
    End Sub

    Private Function GetDoctorsUsernames(Optional Exclude As String = "") As List(Of String)
        Dim R As New List(Of String)
        If Doctors IsNot Nothing Then
            For Each i As Objects.Doctor In Doctors
                If Exclude <> i.Username Then R.Add(i.Username)
            Next
        End If
        Return R
    End Function
#End Region

#Region "Form Events"
    Private Sub frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoginInstance.BeginInvoke(Sub() LoginInstance.Close())

        If Not DataLoader.IsBusy Then DataLoader.RunWorkerAsync()
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Refresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Refresh.ItemClick
        If Not DataLoader.IsBusy Then DataLoader.RunWorkerAsync()
    End Sub

    Private Sub btn_Patients_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Patients_Add.ItemClick
        Dim D As New frm_Patient(Enums.Mode.Add, Doctors)
        If D.ShowDialog = DialogResult.OK Then
            CType(gc_Patients.DataSource, List(Of Objects.Patient)).Add(D.Patient)
        End If
    End Sub

    Private Sub btn_Patients_Edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Patients_Edit.ItemClick
        If gv_Patients.SelectedRowsCount = 1 Then
            Dim Patient As Objects.Patient = gv_Patients.GetRow(gv_Patients.GetSelectedRows(0))
            Dim D As New frm_Patient(Enums.Mode.Edit, Doctors)
            D.Patient = Patient
            If D.ShowDialog = DialogResult.OK Then
                gc_Patients.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub btn_Patients_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Patients_Remove.ItemClick
        If gv_Patients.SelectedRowsCount > 0 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Do you want to remove selected {0} patient{1}...?", gv_Patients.SelectedRowsCount, If(gv_Patients.SelectedRowsCount = 1, "", "s")), "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim RemovedCount As Integer = 0
                Dim FailedCount As Integer = 0
                Dim Patients2Remove As New List(Of Objects.Patient)
                For Index As Integer = 0 To gv_Patients.SelectedRowsCount - 1
                    Dim Patient As Objects.Patient = gv_Patients.GetRow(gv_Patients.GetSelectedRows(Index))

                    If Database.Patients.Remove(Patient.ID, Index = gv_Patients.SelectedRowsCount - 1) Then
                        Patients2Remove.Add(Patient)
                        RemovedCount += 1
                    Else
                        FailedCount += 1
                        If Index < gv_Patients.SelectedRowsCount - 1 Then
                            If DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Failed to remove patient ""{0}"" from patients list. Do you want to continue removing other patients...?", Patient.Name), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                                Exit For
                            End If
                        End If
                    End If
                Next

                If Patients2Remove.Count > 0 Then
                    For Each Patient As Objects.Patient In Patients2Remove
                        gc_Patients.DataSource.Remove(Patient)
                    Next
                    gc_Patients.RefreshDataSource()
                End If

                If RemovedCount = 0 And FailedCount <> 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Failed to remove {0} patient{1}!", FailedCount, If(FailedCount = 1, "s", "")), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf RemovedCount <> 0 And FailedCount <> 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Successfully removed {0} patients and failed to remove {0} patients!", RemovedCount, FailedCount), "Partially Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf RemovedCount <> 0 And FailedCount = 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Successfully removed {0} patients!", RemovedCount), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btn_Doctor_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Doctor_Add.ItemClick
        Dim D As New frm_Doctor(Enums.Mode.Add, GetDoctorsUsernames)
        If D.ShowDialog = DialogResult.OK Then
            Doctors.Add(D.Doctor)
            gc_Doctors.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Doctor_Edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Doctor_Edit.ItemClick
        If gv_Doctors.SelectedRowsCount = 1 Then
            Dim Doctor As Objects.Doctor = gv_Doctors.GetRow(gv_Doctors.GetSelectedRows(0))
            Dim D As New frm_Doctor(Enums.Mode.Edit, GetDoctorsUsernames(Doctor.Username))
            D.Doctor = Doctor
            If D.ShowDialog = DialogResult.OK Then
                gc_Doctors.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub btn_Doctor_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Doctor_Remove.ItemClick
        If gv_Doctors.SelectedRowsCount > 0 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Do you want to remove selected {0} patient{1}...?", gv_Doctors.SelectedRowsCount, If(gv_Doctors.SelectedRowsCount = 1, "", "s")), "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim RemovedCount As Integer = 0
                Dim FailedCount As Integer = 0
                Dim Doctors2Remove As New List(Of Objects.Doctor)
                For Index As Integer = 0 To gv_Doctors.SelectedRowsCount - 1
                    Dim Doctor As Objects.Doctor = gv_Doctors.GetRow(gv_Doctors.GetSelectedRows(Index))

                    If Database.Doctors.Remove(Doctor.ID, Index = gv_Doctors.SelectedRowsCount - 1) Then
                        Doctors2Remove.Add(Doctor)
                        RemovedCount += 1
                    Else
                        FailedCount += 1
                        If Index < gv_Doctors.SelectedRowsCount - 1 Then
                            If DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Failed to remove patient ""{0}"" from patients list. Do you want to continue removing other patients...?", Doctor.Name), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                                Exit For
                            End If
                        End If
                    End If
                Next

                If Doctors2Remove.Count > 0 Then
                    For Each Doctor As Objects.Doctor In Doctors2Remove
                        gc_Doctors.DataSource.Remove(Doctor)
                    Next
                    gc_Doctors.RefreshDataSource()
                End If

                If RemovedCount = 0 And FailedCount <> 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Failed to remove {0} patient{1}!", FailedCount, If(FailedCount = 1, "s", "")), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf RemovedCount <> 0 And FailedCount <> 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Successfully removed {0} patients and failed to remove {0} patients!", RemovedCount, FailedCount), "Partially Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf RemovedCount <> 0 And FailedCount = 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Successfully removed {0} patients!", RemovedCount), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
#End Region

#Region "Other Events"
    Private Sub DataLoader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DataLoader.DoWork
        Me.Invoke(Sub()
                      Me.RibbonControl.Enabled = False
                      Me.ProgressPanel.Visible = True
                  End Sub)

        UpdateProgress("Loading Doctors Data...", "Please Wait")
        Dim Doctors As List(Of Objects.Doctor) = Database.Doctors.FetchAll
        Me.Invoke(Sub() gc_Doctors.DataSource = Doctors)

        UpdateProgress("Loading Patients Data...")
        Dim Patients As List(Of Objects.Patient) = Database.Patients.FetchAll(Doctors)
        Me.Invoke(Sub() gc_Patients.DataSource = Patients)

        Me.Invoke(Sub()
                      Me.RibbonControl.Enabled = True
                      Me.ProgressPanel.Visible = False
                  End Sub)
    End Sub

    Private Sub tab_Main_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles tab_Main.SelectedPageChanged
        If tab_Main.SelectedTabPage Is tp_Doctor AndAlso Me.Doctor.Username = "admin" Then
            rpg_Doctors.Visible = True
        Else
            rpg_Doctors.Visible = False
        End If
        If tab_Main.SelectedTabPage Is tp_Patients Then
            rpg_Patients.Visible = True
        Else
            rpg_Patients.Visible = False
        End If
    End Sub
#End Region

End Class