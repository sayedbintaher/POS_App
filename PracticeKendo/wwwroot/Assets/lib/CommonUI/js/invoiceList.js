var InvoiceList = [];

$(document).ready(function () {
    $.ajax({
        url: "https://localhost:7032/api/Invoice/GetAllInvoice",
        method: "GET",
        dataType: "json",
        success: function (data) {
            InvoiceList = data;
            BindGrid();
        }
    });
    
});

function BindGrid() {
    $("#grid").kendoGrid({
        dataSource: InvoiceList,
        sortable: true,
        pageable: {
            refresh: true,
            pageSizes: true,
        },
        columns: [
            {
                field: "id",
                title: "Id"
            },
            {
                field: "customerName",
                title: "Customer Name"
            }, {
                field: "customerPhone",
                title: "Customer Phone",
            },
            {
                field: "id",
                template: '<button class="btn btn-primary" onclick=SeeInvoiceDetails(\"#: id #\")>See Details</button>',
                title: "Action",
                width: 150
            }
        ]
    });
}

function SeeInvoiceDetails(id) {
    var url = '/Home/InvoiceDetails?ID=' + id;
    window.location.href = url;
}