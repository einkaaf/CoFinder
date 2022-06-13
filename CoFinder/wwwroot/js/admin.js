function SearchBTN() {
    debugger
    var nationalCode = document.getElementById("nationalCodeSearch").value;
    window.location.href = '/home/index?nationalCode=' + nationalCode;
}

function isNumber(evt) {
    evt = (evt) ? evt : window.event;
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
    }
    return true;
}

