/** Custom JS */

//$('#startDate').datepicker({
//    uiLibrary: 'bootstrap5'
//});
//$('#endDate').datepicker({
//    uiLibrary: 'bootstrap5'
//});

function saveAsFile(filename, bytesBase64) {

  if (navigator.msSaveBlob) {
    //Download document in Edge browser
    var data = window.atob(bytesBase64);
    var bytes = new Uint8Array(data.length);
    for (var i = 0; i < data.length; i++) {
      bytes[i] = data.charCodeAt(i);
    }
    var blob = null;
    if (filename.endsWith(".pdf"))
      blob = new Blob([bytes.buffer], { type: "application/pdf" });
    else if (filename.endsWith(".xlsx"))
      blob = new Blob([bytes.buffer], { type: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" });
    navigator.msSaveBlob(blob, filename);
  }
  else {
    var link = document.createElement('a');
    link.download = filename;
    if (filename.endsWith(".pdf"))
      link.href = "data:application/pdf;base64," + bytesBase64;
    else if (filename.endsWith(".xlsx"))
      link.href = "data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
  }

}

