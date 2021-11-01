/* Index Blog js */

/**
 *  Delete blog by id
 * @param {any} id
 */
function deleteBlog(id) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: 'blog/deleteBlogById',
                type: 'DELETE',
                data: JSON.stringify({ Id: id }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    // Do something with the result
                    if (result) {
                        Swal.fire({
                            icon: 'success',
                            title: 'Xóa thành công !',
                            showConfirmButton: false,
                            timer: 1500
                        })
                    } else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Xóa thất bại !',
                            showConfirmButton: false,
                            timer: 1500
                        }
                        )
                    }
                }
            });

        }
    })
}

/*
 * Edit blog js 
 */
function editClear() {

    document.getElementById("inputEditTitleBlog").value = "";
    document.getElementById("inputEditShortDescTitleBlog").value = "";
    document.getElementById("inputEditDescTitleBlog").value = "";

    document.getElementById("inputEditFile").value = "";

    var country = document.getElementById("inputEditCategory");
    country.options['0'].selected = true;

    $("#placeEditVietName").prop('checked', true);
    $("#placeEditAsian").prop('checked', false);
    $("#placeEditEuro").prop('checked', false);
    $("#placeEditAmerica").prop('checked', false);

    $("#radioEidtPublicNo").checked = true;
    $("#radioEidtPublicYes").checked = false;

    document.getElementById("inputEditPublicDate").value = "";
}

/*
 *  News blog js
 */
function newClear() {
    document.getElementById("inputNewTitleBlog").value = "";
    document.getElementById("inputNewShortDescTitleBlog").value = "";
    document.getElementById("inputNewDescTitleBlog").value = "";

    document.getElementById("inputNewFile").value = "";

    var country = document.getElementById("inputNewCategory");
    country.options['0'].selected = true;

    $("#placeNewVietName").prop('checked', true);
    $("#placeNewAsian").prop('checked', false);
    $("#placeNewEuro").prop('checked', false);
    $("#placeNewAmerica").prop('checked', false);

    $("#radioNewPublicNo").checked = true;
    $("#radioNewPublicYes").checked = false;

    document.getElementById("inputEditPublicDate").value = "";
}

