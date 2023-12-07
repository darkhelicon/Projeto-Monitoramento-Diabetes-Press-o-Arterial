
$('form').on('submit', function(event) {
    event.preventDefault();

    var formData = {
        "password": $("#txtPassword").val(),
        "person": {
            "email": $("#txtEmail").val(),
            "username": $("#txtEmail").val()
        }
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:7136/api/User/",
        success: function (result) {
            if (result.responde = 'ERROR')
                alert("Credenciais inválidas")
            else {
                let baseUrl = $('#btnLogin').data('baseUrl')
                window.location = baseUrl + "?" +
                    "UserId=" + result.userId +
                    "&PersonId=" + result.personId +
                    "&Username=" + result.username +
                    "&Email=" + result.email;
            }
        },
        error: function (error) {

        }
    })
});