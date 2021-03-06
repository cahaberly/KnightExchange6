﻿@ModelType IEnumerable(Of KnightExchange.books)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.book_info.book_title)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.users.user_lname)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.book_info.book_title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.users.user_lname)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.book_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.book_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.book_id })
        </td>
    </tr>
Next

</table>
