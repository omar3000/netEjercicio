$(document).ready(function () {
    $("#btnBuscar").click(I => {
        let id = $("#UserId").val();

        $.ajax({
            contentType: "application/json; charset=Utf-8;",
            dataType: "json",
            type: "Get",
            url: "/Home/GetById",
            data: { UserId: id },
            success: function (data) {
                let convert = jQuery.parseJSON(data);
                let htmlString = `<table class:"table table-hover table-sm"> <tr> <th>Id </th> <td>${convert.Id} </td> </tr> <tr> <th>Nombre </th> <td>${convert.Name} </td> </tr> </table>`;

                $("#busqueda").html(htmlString);
            }
        })
    })

    $("#btnMostrar").click(function () {
        $.ajax({
            type: "Get",
            dataType: "json",
            contentType: "application/json; charset=Utf-8;",
            url: "/Home/List",
            beforeSend: function () {
                $("#loader").show();
            },
            success: function (data) {
                $("#loader").hide();
                let users = jQuery.parseJSON(data);
                let htmlString = "<table class='EstiloBAMSA'> <tr> <th>Id </th> <th>Nombre</th> </tr> "

                $.each(users, (index, value) => {
                    htmlString += `<tr> <td> ${value.Id} </td> <td> ${value.Name}</td> </tr>`;
                });
                htmlString += "</table>";

                $("#lista").html(htmlString);
            }

        });
    });

    $("#userAdd").click(function () {
        let user = {
            Name: $("#frmUserName").val(),
            Id: $("#frmUserId").val()
        };
        $.ajax({
            type: "Post",
            url: "/Home/Add",
            data: user,
            success: function (gelenCevap) {
                let gelenObje = jQuery.parseJSON(gelenCevap);
            }
        });

    });
});