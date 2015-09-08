$(document).ready(function () {

    $("#vendor_addr").val("new val");

    $("#item_desc").val("item desc");




    $("#item_id").keyup(function () {

        if ($.isNumeric($("#item_id").val())) {


            var serviceUrl = "/Purchase/FindItem/" + $("#item_id").val();

            console.log(serviceUrl);

            $.ajax({

                url: serviceUrl,
                success: function (data) {
                    console.log(data);
                    $("#item_desc").val(data["item_description"]);
                }

            });
        }

}).keypress();

$("#item_id").keydown(function () {

   // alert("item changed");

});

});