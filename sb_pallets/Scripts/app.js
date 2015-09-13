$(document).ready(function () {

    $("#vendor_addr").val("new val");

    $("#item_desc").val("item desc");

    var i = 1;

    //var itemClicked = function (event) {

    //    itemID = event.target.id;
    //    itemDesc = itemID + "d";

    //    alert(itemID);

    //  //  $(itemID).keyup(function () {

    //        if ($.isNumeric($(itemID).val())) {


    //            var serviceUrl = "/Purchase/FindItem/" + $(itemID).val();

    //            console.log(serviceUrl);

    //            $.ajax({

    //                url: serviceUrl,
    //                success: function (data) {
    //                    console.log(data);
    //                    $(itemDesc).val(data["item_description"]);
    //                }

    //            });
    //        }

    //   // }).keypress();


    //};

    
    $(document).on('keyup', '.citems', function () {

        item = event.target
        itemID = item.id;
        val = item.value;
        itemDesc = document.getElementById(itemID + "d");
        
        //itemDesc.value = "yes";

        

        console.log(itemID);
        console.log(val);

        if ($.isNumeric(val)) {


            var serviceUrl = "/Purchase/FindItem/" + val;

            console.log(serviceUrl);

            $.ajax({

                url: serviceUrl,
                success: function (data) {
                    console.log(data);
                    itemDesc.value=data["item_description"];
                },
                error: function () {
                    console.log("error");
                    itemDesc.value ="Does not Exist!";
                }
               
            });
        }
        else {
            itemDesc.value = "";
        }

    });


    $("#addItem").click(function () {
        $("<div />", { "class": "newItems", id: "item" + i })
           .append($("<input />", { type: "text", id: "itemid" + i, class: "citems", value: ""  }))
           .append($("<textarea />", { id: "itemid" + i + "d", disabled: "disabled" }))
           .append($("<input />", { type: "text", id: "itemid" + i + "q" }))
           .append($("<input />", { type: "text", id: "itemid" + i + "u" }))
           .append($("<input />", { type: "text", id: "itemid" + i + "p" }))
           .append($("<input />", { type: "text", id: "itemid" + i + "a", disabled: "disabled" }))
           .appendTo("#allItems");
        i++;
    });


});