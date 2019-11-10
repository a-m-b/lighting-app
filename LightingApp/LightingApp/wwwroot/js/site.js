var $backLink = $('.govuk-back-link');
var $confirm = $('#confirm');

function goToQuestion(question) {
    var validForm = $("#lightingForm").valid();

    if (validForm === false) {
        return;
    }

    hideAll();
    backToggle(question);
    $('#question-' + question).removeClass('hidden');
}

function goToConfirm() {
    var validForm = $("#lightingForm").valid();

    if (validForm === false) {
        return;
    }

    hideAll();
    backToggle(6);
    $confirm.removeClass('hidden');
}

function hideAll() {
    var questions = 5;
    $confirm.addClass('hidden');

    for (i = 1; i <= questions; i++) {
        $('#question-' + i).addClass('hidden');
    } 
}

function backToggle(qestion) {
    $backLink.data('question', qestion);

    if (qestion === 1) {
        $backLink.addClass('hidden');
    } else {
        $backLink.removeClass('hidden');
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

    $backLink.click(function () {
        var question = $(this).data('question');
        var newQuestion = (question - 1);
        hideAll();
        backToggle(newQuestion);
        $('#question-' + newQuestion).removeClass('hidden');
    });

    $.validator.setDefaults({
        onkeyup: true
    });
});