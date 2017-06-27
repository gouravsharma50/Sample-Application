
$("#registeruser").click(function () {

    var form = $("#registerForm").serialize();
    service.Post("/api/User/Register", form, function (result) {

        window.location.href = "/register/login";


    })


});