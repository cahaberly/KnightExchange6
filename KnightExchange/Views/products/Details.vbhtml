@ModelType KnightExchange.products
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>products</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.product_info.product_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.product_info.product_name)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.product_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
