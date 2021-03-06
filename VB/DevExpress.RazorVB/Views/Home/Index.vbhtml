@Code
    ViewData("Title") = "How to pass complex objects to a callback Action as callback arguments"
End Code

<script type="text/javascript">
    function OnButtonClick() {
        callbackPanel.PerformCallback();
    }
    function OnBeginCallback(s, e) {
        e.customArgs["SerializationData"] = GetSerializationData();
    }
    function GetSerializationData() {
        var editorsNames = ["Name", "Age", "Email", "ArrivalDate"];
        var editorsValues = {};
        for (var i = 0; i < editorsNames.length; i++) {
            var control = ASPxClientControl.GetControlCollection().GetByName(editorsNames[i]);
            editorsValues[control.name] = control.GetValue();
        }
        return $.toJSON(editorsValues);
    }
</script>

@Html.Partial("EditorsPartial")
@Html.Partial("CallbackPanelPartial")
