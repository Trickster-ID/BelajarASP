//$(document).ready(function () {
//    $('#SuppTable').dataTable({
//        "ajax": loadDataDepartment(),
//        "responsive": true,
//    });
//    $('[data-toggle="tooltip"]').tooltip();
//});

//function loadDataDepartment() {
//    $.ajax({
//        url: "/Supplier/List",
//        type: "GET",
//        contentType: "aplication/json;charset=utf-8",
//        dataType: "json",
//        success: function (result) {
//            var html = '';
//            $.each(result, function (key, Supplier) {
//                debugger;
//                html += '<tr>';
//                html += '<td>', Supplier.Name + '</td>';
//                html += '<td>', Supplier.Address + '</td>';
//                html += '<td>', Supplier.Email + '</td>';
//                html += '<td><button type="button class="btn btn-warning" id="update" oneclick="return GetById(' + Supplier.Id + ')">Edit</button>';
//                html += '<button type="button" class="btn btn-danger" id="Delete" oneclick="return Delete(' + Supplier.Id + ')" >Delete</button></td>';
//                html += '</tr>';
//                html += '</tr>';
//                html += '</tr>';
//            });
//            $('.supplierbody').html(html);
//        },
//        error: function (errormessage) {
//            alert(errormessage.responseText);
//        }
//    });
//}