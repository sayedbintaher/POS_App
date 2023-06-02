var InvoiceDetailsList = []
var productList = []

function getUrlParameter(sParam) {
    var sPageURL = window.location.search.substring(1);
    var sURLVariables = sPageURL.split('=');
    return sURLVariables[1];
}

var InvoiceId;


$(document).ready(function () {
    InvoiceId = getUrlParameter('ID');
    GetInvoiceDetails(InvoiceId);
})

function GetInvoiceDetails(id) {
    $.ajax({
        url: "https://localhost:7032/api/InvoiceDetails?id=" + id,
        method: "GET",
        dataType: "json",
        success: function (data) {
            InvoiceDetailsList = data;   
            $('#customerName').text(InvoiceDetailsList[0].customerName);
            $('#customerPhone').text(InvoiceDetailsList[0].customerPhone);
            GetProductList();
        }
    });
}

function GetProductList() {
    $.ajax({
        url: "https://localhost:7032/api/Product",
        method: "GET",
        dataType: "json",
        success: function (data) {
            productList = data;
            console.log(data);
            MergeProductName();
            BindGrid();
        }
    });
}

function MergeProductName() {
    for (var i = 0; i < InvoiceDetailsList.length; i++) {
        for (var j = 0; j < productList.length; j++) {
            if (InvoiceDetailsList[i].productId == productList[j].id) {
                InvoiceDetailsList[i].productName = productList[j].productName;
            }
        }
    }
}

function BindGrid() {
    var i = 1;
    _.map(InvoiceDetailsList, function (o) {
        o.sl = i;
        i++;
    });
    $("#grid").kendoGrid({
        dataSource: InvoiceDetailsList,
        sortable: true,
        columns: [
            {
                field: "sl",
                title: "Sl No"
            },
            {
                field: "productName",
                title: "Product Name"
            },
            {
                field: "price",
                title: "Price",
            },
            {
                field: "quantity",
                title: "Quantity",
            }   
        ]
    });
}