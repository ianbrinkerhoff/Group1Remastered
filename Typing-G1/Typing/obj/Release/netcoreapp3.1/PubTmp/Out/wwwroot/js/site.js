// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var script = document.createElement('script');
script.src = 'https://code.jquery.com/jquery-3.5.1.js';
script.type = 'text/javascript';
document.getElementsByTagName('head')[0].appendChild(script);

$('#Password, #Password2').on('keyup', function () {
    if ($('#Password').val() == $('#Password2').val()) {
        $('#message').html('Matching').css('color', 'green');
        $('#subReg').removeAttr("disabled");
    } else {
        $('#message').html('Not Matching').css('color', 'red');
        $('#subReg').attr('disabled', true);
    }
});


