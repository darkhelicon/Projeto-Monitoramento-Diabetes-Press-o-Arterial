
$('form').on('submit', function(event) {
    event.preventDefault();

    var formData = {
        email: $("#txtEmail").val(),
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify($("#txtEmail").val()),
        url: "https://localhost:7136/api/User/forgot",
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