@Imports DevExpress.RazorVB
@Functions
    Function IsFirstPageLoad() As Boolean
        Return ViewData("ErrorMessage") Is Nothing And ViewData("Data") Is Nothing
    End Function
    
    Function GetStringData(ByVal data As Object) As String
        Dim stringData As String = String.Empty
        If data <> Nothing Then
            stringData = data.ToString()
        End If
        Return stringData
    End Function
End Functions
@Html.DevExpress().CallbackPanel( _
    Sub(settings)
            settings.Name = "callbackPanel"
            settings.CallbackRouteValues = New With {.Action = "CallbackPanelPartial", .Controller = "Home"}
            settings.ClientSideEvents.BeginCallback = "OnBeginCallback"
            
            settings.Width = 200
            settings.ControlStyle.CssClass = "InlineClass"
            
            settings.SetContent( _
                Sub()
                        If IsFirstPageLoad() = False Then
                            ViewContext.Writer.Write("<div style=""float:left"">")
                            Html.DevExpress().RoundPanel( _
                                Sub(panelSettings)
                                        panelSettings.SetContent( _
                                            Sub()
                                                    If (ViewData("ErrorMessage") <> Nothing) Then
                                                        ViewContext.Writer.Write("<span>" + ViewData("ErrorMessage") + "</span>")
                                                    Else
                                                        Dim data As MyData = ViewData("Data")
                                                        ViewContext.Writer.Write("<div><span>Name: " + GetStringData(data.Name) + "</span></div>")
                                                        ViewContext.Writer.Write("<div><span>Age: " + GetStringData(data.Age) + "</span></div>")
                                                        ViewContext.Writer.Write("<div><span>Email: " + GetStringData(data.Email) + "</span></div>")
                                                        ViewContext.Writer.Write("<div><span>Arrival Date: " + GetStringData(data.ArrivalDate) + "</span></div>")
                                                    End If
                                            End Sub
                                        )
                                        panelSettings.Width = 200
                                End Sub
                            ).Render()
                            ViewContext.Writer.Write("</div>")
                        End If
                End Sub
            )
    End Sub
).GetHtml()
