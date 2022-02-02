function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;

    return true;
}

function markRequiredControl(element) {
    var isBlank;
    if (!element.value) {
        element.classList.add('mark-error');
        isBlank = true;
    } else {
        element.classList.remove('mark-error');
        isBlank = false;
    }
    return isBlank;
}

function removeErrorMarkClass(element) {
    element.classList.remove('mark-error');
}

function addErrorMarkClass(element) {
    element.classList.add('mark-error');
}