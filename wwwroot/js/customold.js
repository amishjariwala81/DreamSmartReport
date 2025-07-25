function customJS() {
  $(document).ready(function ($) {

    function OnButtonClick(_string value)
	  {
      JsRuntime.InvokeVoidAsync($"window.{value}");
    }

  });
}
