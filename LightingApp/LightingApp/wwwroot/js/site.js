// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function goToQuestion(qestion) {
    var validForm = $("#lightingForm").valid();

    if (validForm === false) {
        return;
    }

    hideAll();
    $('#question-' + qestion).removeClass('hidden');
}

function goToConfirm() {
    var validForm = $("#lightingForm").valid();

    if (validForm === false) {
        return;
    }

    hideAll();
    $('#confirm').removeClass('hidden');
}

function hideAll() {
    var questions = 5;
    $('#confirm').addClass('hidden');

    for (i = 1; i <= questions; i++) {
        $('#question-' + i).addClass('hidden');
    } 
}

function updateField(id, value) {
    document.getElementById(id).value = value;
}

$(document).ready(function () {
    $('button').click(function () {
        var name = $('#Name').val();
        var email = $('#EmailAddress').val();
        var addressName = $('#AddressNameOrNumber').val().trim();
        var addressLine1 = $('#AddressLine1').val().trim();
        var addressLin12 = $('#AddressLine2').val().trim();
        var addressTown = $('#AddressTown').val().trim();
        var addressPostcode = $('#AddressPostcode').val().trim();
        var address = addressName;

        if (addressLine1.length > 0) {
            address += ' ' + addressLine1;
        }
        if (addressLin12.length > 0) {
            address += ', ' + addressLin12;
        }
        if (addressTown.length > 0) {
            address += ', ' + addressTown;
        }
        if (addressPostcode.length > 0) {
            address += ', ' + addressPostcode;
        }
        
        var acceptLighting = $('#AcceptableLighting:checked').val() === 'true' ? 'Yes' : 'No';
        var brightness = $('#BrightnessLevel').val();
        
        $('#confirm-name').text(name);
        $('#confirm-emailAddress').text(email);
        $('#confirm-homeAddress').text(address);
        $('#confirm-happy').text(acceptLighting);
        $('#confirm-brightness').text(brightness);
    });

    $.validator.setDefaults({
        onkeyup: true
    });
});