﻿Imports System.ComponentModel

Namespace Objects
    Public Class Patient

#Region "Properties/Fields"
        Property ID As Integer
        Property Name As String
        Property Diseases As BindingList(Of String)
        Property Allergies As BindingList(Of String)
        Property Medication As BindingList(Of Medication)
        Property Doctor As Doctor
#End Region

#Region "Constructors"
        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal Diseases As BindingList(Of String), ByVal Allergies As BindingList(Of String), ByVal Medication As BindingList(Of Medication), ByVal Doctor As Doctor)
            Me.ID = ID
            Me.Name = Name
            Me.Diseases = Diseases
            Me.Allergies = Allergies
            Me.Medication = Medication
            Me.Doctor = Doctor
        End Sub

        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal Diseases As Byte(), ByVal Allergies As Byte(), ByVal Medication As Byte(), ByVal Doctor As Doctor)
            Me.ID = ID
            Me.Name = Name
            Me.Doctor = Doctor

            If Diseases IsNot Nothing Then
                Me.Diseases = Utils.Serializer.FromZXML(Of BindingList(Of String))(Diseases)
            End If

            If Allergies IsNot Nothing Then
                Me.Allergies = Utils.Serializer.FromZXML(Of BindingList(Of String))(Allergies)
            End If

            If Medication IsNot Nothing Then
                Me.Medication = Utils.Serializer.FromZXML(Of BindingList(Of Medication))(Medication)
            End If

            If Me.Diseases Is Nothing Then Me.Diseases = New BindingList(Of String)
            If Me.Allergies Is Nothing Then Me.Allergies = New BindingList(Of String)
            If Me.Medication Is Nothing Then Me.Medication = New BindingList(Of Medication)
        End Sub
#End Region

    End Class
End Namespace
