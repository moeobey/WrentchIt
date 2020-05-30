var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
     dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/services/GetAll",
            "type": "Get",
            "datatype": "json"
        },
        "columns": [
          
            { "data": "name", "width": "20%" },
            { "data": "serviceType.name", "width": "20%" },
            { "data": "image", "width": "20%" },
            { "data": "description", "width": "20%" },
            
          
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                                <a href="/services/Edit/${data}" class='btn btn-success text-white' style='cursor:pointer; width:100px;'>
                                <i class ='far fa-edit'></i> Edit </a>
                                &nbsp;
                                <a onclick=Delete("/services/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
                                <i class ='far fa-trash-alt'></i> Delete </a>
                            </div>`;
                }, "width": "30%"
            }
        ],//display data when there is none
        "language": {
            "emptyTable": "No records found."
        },
        "width": "100%"
    });
}

function Delete(url) {
    sweetAlert({
        title: "Are you sure you want to delete?",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "red",
        closeONconfirm: true

    }, function () {
        $.ajax({
            type: 'Delete',
            url: url,
            success: function (data) {
                if (data.success) {
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message);
                }
            }
        });
    });
}


//<table id="tblData" class="table table table-striped table-bordered">
//    <thead>
//        <tr>
//            <th>Name</th>
//            <th>Category Name</th>
//            <th>Price</th>
//            <th>Time of Job</th>
//            <th>Price per Hour</th>
//        </tr>
//    </thead>
//    <tbody>
//        @foreach (var data in Model)
//            {
//            <tr>
//                <td>@data.Name</td>
//                <td>@data.ServiceType</td>
//                <td>@data.Description</td>
//                <td>@data.Description</td>

//                <td>@data.Description</td>



//                    @*<td>

//                    <div class="text-center">
//                        <a href="/ServiceType/Edit/@data.Id" class='btn btn-success text-white' style='cursor:pointer; width:100px;'>
//                            <i class='far fa-edit'></i> Edit
//                            </a>
//                            &nbsp;
//                            <a onclick=Delete("/ServiceType/Delete/@data.Id") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
//                                <i class='far fa-trash-alt'></i> Delete
//                            </a>
//                        </div>
//                    </td> *@


//                </tr>

//            }
//        </tbody>
//    </table >
