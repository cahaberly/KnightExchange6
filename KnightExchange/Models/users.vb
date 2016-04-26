'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System.ComponentModel.DataAnnotations
Imports System
Imports System.Collections.Generic

Partial Public Class users
    <Key>
    <Display(Name:="ID")>
    Public Property user_id As Integer

    <Required>
    <Display(Name:="Last Name")>
    Public Property user_lname As String

    <Required>
    <Display(Name:="First Name")>
    Public Property user_fname As String

    <Required>
    <Display(Name:="Email")>
    Public Property user_email As String

    <Required>
    <Display(Name:="Permission Level")>
    Public Property user_permission As String


    Public Overridable Property books As ICollection(Of books) = New HashSet(Of books)
    Public Overridable Property products As ICollection(Of products) = New HashSet(Of products)

End Class