// xóa sách
$('#myModal').on('show.bs.modal', (e) => {
    const link = e.relatedTarget;
    let MaSach = parseInt(jQuery(link).attr('id'));
    jQuery('#btnDelete').click(() => {
        jQuery.ajax({
            url: '/AdminQuanLySach/XoaSach',
            method: 'POST',
            data: { MaSach },
            dataType: 'text',
            success: (response) => {
                response = JSON.parse(response)
                if (response.status == true) {
                    jQuery('#myModal').modal('hide');
                    alert("xóa thành công");
                    location.reload();
                } else {
                    alert('Xóa sản phẩm thất bại!')
                }
            }
        })
    })
});