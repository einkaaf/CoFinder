function SearchBTN() {
    debugger
    var nationalCode = document.getElementById("nationalCodeSearch").value;
    window.location.href = '/home/index?nationalCode=' + nationalCode;
}