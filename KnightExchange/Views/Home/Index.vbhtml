@Code
    ViewData("Title") = "KnightExchange"
End Code

<div class="jumbotron">
    <h1>Knight Exchange</h1>
    <div style="float:left;"><img src="~/Images/KnightExchangeLogo.png" style="width: 300px; height: 248px;" /></div>
    <p class="lead">Welcome to the Knight Exchange!!
Your place to trade books, supplies and find tutoring</p>
    
</div>

   
<div class="row">
    <div class="col-md-4">
        <h2>Search our books:</h2>
        <p>
            Type a title, ISBN or author to see what we may have in stock.
        
     
            @Using Html.BeginForm("Index", "book_info", FormMethod.Get)
                @<p>
                @Html.TextBox("SearchString", TryCast(ViewBag.CurrentFilter, String))
                <input type="submit" value="Search" /></p>
            End Using
        
    </div>
   
    
     <div class="col-md-4">
        <h2>Search our products:</h2>
         <p>
             Type in a product name or a brief description to see what others may have to offer.
             @Using Html.BeginForm("Index", "product_info", FormMethod.Get)
                 @<p>
                @Html.TextBox("SearchString", TryCast(ViewBag.CurrentFilter, String))
                <input type="submit" value="Search" />
            </p>
             End Using    </div>
    <div class="col-md-4">
        <h2>User Search:</h2>
        <p>
            Search for a specific user. Type the last name or first name.
            @Using Html.BeginForm("Index", "users", FormMethod.Get)
                @<p>
                @Html.TextBox("SearchString", TryCast(ViewBag.CurrentFilter, String))
                <input type="submit" value="Search" />
            </p>
            End Using  </div>
</div>
