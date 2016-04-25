@ModelType KnightExchange.books
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>books</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.book_info.book_title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book_info.book_title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.users.user_lname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.users.user_lname)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.book_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
