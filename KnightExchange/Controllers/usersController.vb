﻿Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports KnightExchange

Namespace Controllers
    Public Class usersController
        Inherits System.Web.Mvc.Controller

        Private db As New KnightExchangeDBEntities4
        Function Index(searchString As String) As ActionResult
            Dim users = From u In db.users Select u
            If Not String.IsNullOrEmpty(searchString) Then
                users = users.Where(Function(u) u.user_lname.ToUpper().Contains(searchString.ToUpper()) _
                    Or u.user_fname.ToUpper().Contains(searchString.ToUpper()))
            End If
            Return View(users.ToList())

        End Function

        ' GET: users
        'Function Index() As ActionResult
        '    Return View(db.users.ToList())
        'End Function

        ' GET: users/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim users As users = db.users.Find(id)
            If IsNothing(users) Then
                Return HttpNotFound()
            End If
            Return View(users)
        End Function

        ' GET: users/Create
        <Authorize>
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: users/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="user_id,user_lname,user_fname,user_email,user_permission")> ByVal users As users) As ActionResult
            If ModelState.IsValid Then
                db.users.Add(users)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(users)
        End Function

        ' GET: users/Edit/5
        <Authorize>
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim users As users = db.users.Find(id)
            If IsNothing(users) Then
                Return HttpNotFound()
            End If
            Return View(users)
        End Function

        ' POST: users/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="user_id,user_lname,user_fname,user_email,user_permission")> ByVal users As users) As ActionResult
            If ModelState.IsValid Then
                db.Entry(users).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(users)
        End Function

        ' GET: users/Delete/5
        <Authorize>
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim users As users = db.users.Find(id)
            If IsNothing(users) Then
                Return HttpNotFound()
            End If
            Return View(users)
        End Function

        ' POST: users/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim users As users = db.users.Find(id)
            db.users.Remove(users)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
