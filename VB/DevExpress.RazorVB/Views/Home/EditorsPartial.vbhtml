<div class="edit_form">
    <div class="line">
        @Html.DevExpress().Label( _
            Sub(editorSettings)
                    editorSettings.ControlStyle.CssClass = "label"
                    editorSettings.Text = "Name:"
                    editorSettings.AssociatedControlName = "Name"
            End Sub
        ).GetHtml()
        @Html.DevExpress().TextBox( _
            Sub(editorSettings)
                    editorSettings.Name = "Name"
                    editorSettings.ControlStyle.CssClass = "editor"
            End Sub
        ).GetHtml()
    </div>
    <div class="line">
        @Html.DevExpress().Label( _
            Sub(editorSettings)
                    editorSettings.ControlStyle.CssClass = "label"
                    editorSettings.Text = "Age:"
                    editorSettings.AssociatedControlName = "Age"
            End Sub
        ).GetHtml()
        @Html.DevExpress().TextBox( _
            Sub(editorSettings)
                    editorSettings.Name = "Age"
                    editorSettings.ControlStyle.CssClass = "editor"
            End Sub
        ).GetHtml()
    </div>
    <div class="line">
        @Html.DevExpress().Label( _
            Sub(editorSettings)
                    editorSettings.ControlStyle.CssClass = "label"
                    editorSettings.Text = "Email:"
                    editorSettings.AssociatedControlName = "Email"
            End Sub
        ).GetHtml()
        @Html.DevExpress().TextBox( _
            Sub(editorSettings)
                    editorSettings.Name = "Email"
                    editorSettings.ControlStyle.CssClass = "editor"
            End Sub
        ).GetHtml()
    </div>
    <div class="line">
        @Html.DevExpress().Label( _
            Sub(editorSettings)
                    editorSettings.ControlStyle.CssClass = "label"
                    editorSettings.Text = "Arrival Date:"
                    editorSettings.AssociatedControlName = "ArrivalDate"
            End Sub
        ).GetHtml()
        @Html.DevExpress().DateEdit( _
            Sub(editorSettings)
                    editorSettings.Name = "ArrivalDate"
                    editorSettings.ControlStyle.CssClass = "editor"
            End Sub
        ).GetHtml()
    </div>
    <div class="line">
        @Html.DevExpress().Label( _
            Sub(editorSettings)
                    editorSettings.ControlStyle.CssClass = "label"
            End Sub
        ).GetHtml()
        @Html.DevExpress().Button( _
            Sub(buttonSettings)
                    buttonSettings.Name = "btnUpdate"
                    buttonSettings.ControlStyle.CssClass = "button"
                    buttonSettings.Text = "Update"
                    buttonSettings.ClientSideEvents.Click = "OnButtonClick"
            End Sub
        ).GetHtml()
        @Html.DevExpress().Button( _
            Sub(buttonSettings)
                    buttonSettings.Name = "btnClear"
                    buttonSettings.ControlStyle.CssClass = "button"
                    buttonSettings.Text = "Clear"
                    buttonSettings.ClientSideEvents.Click = "function(s, e){ ASPxClientEdit.ClearEditorsInContainer(); }"
            End Sub
        ).GetHtml()
    </div>
</div>