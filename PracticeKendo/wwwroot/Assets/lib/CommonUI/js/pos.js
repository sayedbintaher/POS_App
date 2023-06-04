var productList;
var addedProduct = [

]
var invoice;

var i = 1

$(document).ready(function () {
    bindDropDownData();
});

function CreateDropdowns() {
    $("#ddlProduct1").kendoComboBox({
        placeholder: 'Select Product',
        dataTextField: "productName",
        dataValueField: "id",
        dataSource: []
    });
}

function bindDropDownData() {
    $.ajax({
        url: "https://localhost:7032/api/Product",
        method: "GET",
        dataType: "json",
        success: function (data) {
            console.log(data);
            productList = data;
             $("#ddlProduct1").data('kendoComboBox').dataSource.data(productList);
            CreateDropdowns();
        }
    });
}

function showConsole() {
    var grid = $("#grid").data("kendoGrid");
    var dataSource = grid.dataSource.options.data;
    console.log(dataSource);
}

function AddNewRow() {
    var html = "";
    ++i;
    html += '<tr>' +
        '<td>' + i + '</td>' +
        '<td><input id="ddlProduct' + i + '" style="width:100%" /></td>' +
        '<td><input id="productPrice' + i + '" class="textbox" style="width:100%" /></td>' +
        '<td><input id="productQuantity' + i + '" class="textbox" style="width:100%" /></td>' +
        '</tr>'
    $('#tbodyRowAdd').append(html);
    var newComboBox = $('#ddlProduct' + i).kendoComboBox({
        dataSource: productList,
        placeholder: "Select an option",
        dataTextField: "productName",
        dataValueField: "id",
        filter: "contains"
    });
    console.log(i);
}

function Create(options) {
    console.log(options);
}

function getAddedItems() {
    return addedItems;
}
function SaveSingleInvoice() {
    var o = new Object();
    o.customerName = $('#customerName').val()
    o.customerPhone = $('#customerPhone').val()
    o.productId = $('#ddlProduct1' ).data('kendoComboBox').value()
    o.price = $('#productPrice1').val();
    o.quantity = $('#productQuantity1').val();
    $.ajax({
        url: "https://localhost:7032/api/Invoice/SingleInvoice",
        method: "POST",
        contentType: "application/json",
        data: JSON.stringify(o),
        success: function (response) {
            console.log("Data posted successfully.");
        },
        error: function (xhr, textStatus, errorThrown) {
            console.error("Error:", errorThrown);
        }
    });
}

function saveInvoice() {
    var a = 1;
    for (a = 1; a <= i; a++) {
        var o = new Object();
        o.productId = $('#ddlProduct' + a).data('kendoComboBox').value()
        o.price = $('#productPrice' + a).val();
        o.quantity = $('#productQuantity' + a).val();
        addedProduct.push(o);
    }
    var o1 = new Object();
    o1.customerName = $('#customerName').val()
    o1.customerPhone = $('#customerPhone').val()
    o1.invoiceDetails = addedProduct;
    invoice = o1;
    $.ajax({
        url: "https://localhost:7032/api/Invoice",
        method: "POST",
        contentType: "application/json",
        data: JSON.stringify(invoice),
        success: function (response) {
            alert("Data posted successfully.");
            var url = "/Home/Privacy";
            window.location.href = url;
        },
        error: function (xhr, textStatus, errorThrown) {
            console.error("Error:", errorThrown);
        }
    });
}

