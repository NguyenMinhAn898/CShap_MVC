
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

