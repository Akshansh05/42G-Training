$(document).ready(function () {
    $("#but1").on("click", function () {
        $.ajax({
            type: "POST",
            url: "WebForm1.aspx/GetData",
            contentType: "application/json; charset=utf-8",
           // data: JSON.stringify({ id: "24" }),
            dataType: "json",
            success: function (result) {
                alert('ok' + JSON.stringify(result));
            },
            error: function (result) {
                alert('error');
            }

        });
    });
});