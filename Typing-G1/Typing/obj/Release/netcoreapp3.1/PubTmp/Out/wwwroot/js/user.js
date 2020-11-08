var dataTable;

$(document).ready(function () {
    loadList();
});

function loadList() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/user",
            "type": "Get",
            "data": "json"
        },
        "columns": [
            { data: "userName", width: "40%" },
            { data: "score", width: "30%" },
            {data: "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href=""
                            class="btn btn-success text-white style="cursor:pointer; width: 100px;">
                            <i class="fas fa-fist-raised"></i>
                            Challenge 
                            </a>
                            <a onClick=Delete('/api/user/'+${data})
                            class="btn btn-danger text-white style="cursor:pointer; width: 100px;">
                            <i class="far fa-trash-alt"></i>
                            Delete
                            </a>
                        </div>`;
                }, width: "30%"
            }
        ],
        "language": {
            "emptyTable": "no data found."
        },
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "You wil not be able to restore the data!",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: 'DELETE',
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }

                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}