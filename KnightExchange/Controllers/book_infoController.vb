Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports KnightExchange

Namespace Controllers
    Public Class book_infoController
        Inherits System.Web.Mvc.Controller

        Private db As New KnightExchangeDBEntities1
        ' GET: book_info
        Function Index(searchString As String) As ActionResult
            Dim myBook = From s In db.book_info Select s
            If Not String.IsNullOrEmpty(searchString) Then
                myBook = myBook.Where(Function(s) s.book_title.ToUpper().Contains(searchString.ToUpper()) _
                    Or s.book_isbn.ToUpper().Contains(searchString.ToUpper()) _
                    Or s.book_author.ToUpper().Contains(searchString.ToUpper()))
            End If
            Return View(myBook.ToList())
            'Return View(db.book_info.ToList())
        End Function

        '' GET: book_info
        'Function Index() As ActionResult
        '    Return View(db.book_info.ToList())
        'End Function

        ' GET: book_info/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book_info As book_info = db.book_info.Find(id)
            If IsNothing(book_info) Then
                Return HttpNotFound()
            End If
            Return View(book_info)
        End Function

        ' GET: book_info/Create
        <Authorize>
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: book_info/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="bookinfo_id,book_title,book_edition,book_isbn,book_author")> ByVal book_info As book_info) As ActionResult
            If ModelState.IsValid Then
                db.book_info.Add(book_info)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(book_info)
        End Function

        ' GET: book_info/Edit/5
        <Authorize>
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book_info As book_info = db.book_info.Find(id)
            If IsNothing(book_info) Then
                Return HttpNotFound()
            End If
            Return View(book_info)
        End Function

        ' POST: book_info/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="bookinfo_id,book_title,book_edition,book_isbn,book_author")> ByVal book_info As book_info) As ActionResult
            If ModelState.IsValid Then
                db.Entry(book_info).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(book_info)
        End Function

        ' GET: book_info/Delete/5
        <Authorize>
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book_info As book_info = db.book_info.Find(id)
            If IsNothing(book_info) Then
                Return HttpNotFound()
            End If
            Return View(book_info)
        End Function

        ' POST: book_info/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim book_info As book_info = db.book_info.Find(id)
            db.book_info.Remove(book_info)
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
