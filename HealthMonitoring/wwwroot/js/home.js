$('form').on('submit', function (event) {
    event.preventDefault();

    var formData = {
        "personId": 2,
        "days": 3
    }
    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:7136/api/Hiper/GetPeriod",
        success: function (result) {
            if (result.responde = 'ERROR')
                alert("Credenciais inválidas")
            else {
                console.log(result)
            }
        },
        error: function (error) {

        }
    })
});