
$('form').on('submit', function (event) {

    event.preventDefault();
    if ($("#txtPassword").val() != $("#txtPasswordConfirm").val()) {
        $(".error span").show();

        setTimeout(function () {
            $(".error span").hide();
        }, 3000)

        return;
    }

    const urlParam = new URLSearchParams(window.location.search);
    const id = urlParam.get('id');

    var formData = {
        password: $("#txtPassword").val(),
        passwordConfirm: $("#txtPasswordConfirm").val(),
        id: id,
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:7136/api/User/reset",
        success: function (result) {
            if (result.responde = '0K')
                alert("E-mail foi enviado para recuperar a senha")
            else
                alert("Erro inesperado")
        },
        error: function (error) {

        }
    })
});