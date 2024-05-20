$(document).ready(function () {

    $(".nav-item-button").click(function () {

        const partialName = $(this).data('partial');
        $('.page-container').load('/Next/LoadView?partialName=' + partialName);

        //..display overlay
        on();

        //..slide in page
        $('.page-container').addClass('show-page');

    });

});

function on(){
    $("#overlay").css('display', 'block');
};




