$(document).ready(function () {
    $("button").click(function () {
        var id = $(this).attr('id').match(/\d+/);;
        var qtyid = "#quantity" + id;
        var stockid = "#inStock" + id;
        var qty = $(qtyid).text();
        ;
        if (qty > 1)
            $(qtyid).html(qty - 1);
        else
        {
            $(qtyid).css('color','red');
            $(qtyid).html("Sold out!");
            $(stockid).hide();
        }
    });
});