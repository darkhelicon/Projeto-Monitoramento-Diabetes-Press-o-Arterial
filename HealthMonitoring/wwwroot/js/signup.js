$('form').on('submit', function (event) {
    event.preventDefault();

    if ($("#txtPassword").val() != $("#txtPasswordConfirm").val()) {
        $(".error span").show();

        setTimeout(function () {
            $(".error span").hide();
        }, 3000)

        return;
    }

    var formData = {
        email: $("#txtEmail").val(),
        username: $("#txtUsername").val(),
        password: $("#txtPassword").val(),
        passwordConfirm: $("#txtPasswordConfirm").val(),

    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:7136/api/user/create",
        success: function (result) {
            if (result.responde = '0K')
                alert("Logado")
            else
                alert("Credenciais inválidas")
        },
        error: function (error) {

        }
    })
});