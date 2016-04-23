@Imports Microsoft.Owin.Security
@Code
    Dim loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes()
End Code
<h4>Authorization is needed!</h4>
<hr />
@If loginProviders.Count() = 0 Then
    @<div>
        <p>
            
        </p>
    </div>
Else
    Dim action As String = Model.Action
    Dim returnUrl As String = Model.ReturnUrl
    @Using Html.BeginForm(action, "Account", New With {.ReturnUrl = returnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
        @Html.AntiForgeryToken()
        @<div id="socialLoginList">
           <p>
               @For Each p As AuthenticationDescription In loginProviders
                   @<button type="submit" class="btn btn-default" id="@p.AuthenticationType" name="provider" value="@p.AuthenticationType" title="Log in using your @p.Caption account">@p.AuthenticationType</button>
               Next
           </p>
        </div>
    End Using
End If
