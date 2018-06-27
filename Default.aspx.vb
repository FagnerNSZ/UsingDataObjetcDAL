
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub details_ItemUpdated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewUpdatedEventArgs) Handles details.ItemUpdated
        grid.DataBind()
    End Sub

    Protected Sub details_ItemInserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewInsertedEventArgs) Handles details.ItemInserted
        grid.DataBind()
    End Sub
End Class
