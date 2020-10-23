"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/messageHub").build();
var msg;

connection.on("ReceiveMessage", function (username, input) {
    msg = input;
});

connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.string());
});

$('#tb1').keyup(function () {
    var username = $('#currentUser').val();
    var input = $('#tb1').val().toUpperCase();
    connection.invoke("SendInput", username, input).catch(function (err) {
        return console.error(err.toString());
    });
});