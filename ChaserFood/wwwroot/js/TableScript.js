$(document).ready(function () {
    $('.btn').click(function (e) {
        e.preventDefault();
        $.ajax({
            url: $(this).attr('href'),
            success: function (response) {
                $('#itemTable').html(response);
            }
        });
    });
});
