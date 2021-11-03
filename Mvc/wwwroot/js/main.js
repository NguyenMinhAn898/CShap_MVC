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
                url: '/blog/deleteBlogById',
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
                        }).then(() => {
                            location.reload(true);
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
 * Edit,new blog js 
 */
function blogClear() {

    document.getElementById("Title").value = "";
    document.getElementById("Short_Description").value = "";
    document.getElementById("Description").value = "";

    document.getElementById("inputEditFile").value = "";

    var country = document.getElementById("Category");
    country.options['0'].selected = true;

    $("#placeEditVietName").prop('checked', true);
    $("#placeEditAsian").prop('checked', false);
    $("#placeEditEuro").prop('checked', false);
    $("#placeEditAmerica").prop('checked', false);

    $("#radioEidtPublicNo").checked = true;
    $("#radioEidtPublicYes").checked = false;

    document.getElementById("inputEditPublicDate").value = "";
}


/* Search blog js */
function searchBlog() {
    var search = document.getElementById('inputSearchTitleBlog').value;
    //if (search) {
    //}
}

// Example starter JavaScript for disabling form submissions if there are invalid fields
(function () {
    'use strict'

    // Fetch all the forms we want to apply custom Bootstrap validation styles to
    var forms = document.querySelectorAll('.needs-validation')

    // Loop over them and prevent submission
    Array.prototype.slice.call(forms)
        .forEach(function (form) {
            form.addEventListener('submit', function (event) {
                if (!form.checkValidity()) {
                    event.preventDefault()
                    event.stopPropagation()
                }

                form.classList.add('was-validated')
            }, false)
        })
})()