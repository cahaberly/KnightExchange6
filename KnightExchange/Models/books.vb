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

Partial Public Class books
    <Key>
    <Display(Name:="ID")>
    Public Property book_id As Integer

    <Required>
    <Display(Name:="User ID")>
    Public Property user_id As Integer

    <Required>
    <Display(Name:="Book ID")>
    Public Property bookinfo_id As Integer


    Public Overridable Property book_info As book_info
    Public Overridable Property users As users

End Class
