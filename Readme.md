<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DevExpress.Razor/Controllers/HomeController.cs)
* [MyModel.cs](./CS/DevExpress.Razor/Models/MyModel.cs)
* [CallbackPanelPartial.cshtml](./CS/DevExpress.Razor/Views/Home/CallbackPanelPartial.cshtml)
* [EditorsPartial.cshtml](./CS/DevExpress.Razor/Views/Home/EditorsPartial.cshtml)
* [Index.cshtml](./CS/DevExpress.Razor/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to pass complex objects to a callback Action as callback arguments


<p>This sample demonstrates how to convert custom types to the JSON string on the client side and parse this string on the server. The conversion is performed using $<strong>.toJSON</strong>. This function declared in the <a href="http://code.google.com/p/jquery-json/"><u>jquery.json-2.2.min</u></a> file.<br> The JSON string is converted in a Controller's Action using the <strong>JavaScriptSerializer.Deserialize</strong> method.</p>
<p>In the sample, if it is not possible to deserialize user input, an exception is thrown.<br><br><strong>See also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/T466808">How to pass a complex object as a callback argument</a></p>

<br/>


