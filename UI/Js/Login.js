
$(window).load(function () {
    $('.preloader').fadeOut(1000); // set duration in brackets    
});


$(document).ready(function () {

    $(function () {
        $('body').vegas({
            slides: [
            { src: 'images/slide-1.jpg' },
            { src: 'images/slide-2.jpg' }
        ],
            timer: false,
            transition: ['zoomOut', ]
        });
    });


    $(window).scroll(function () {
        if ($(this).scrollTop() > 200) {
            $('.go-top').fadeIn(200);
        } else {
            $('.go-top').fadeOut(200);
        }
    });

    $('.go-top').click(function (event) {
        event.preventDefault();
        $('html, body').animate({ scrollTop: 0 }, 300);
    })

    $(window).scroll(function () {
        if ($(".navbar").offset().top > 50) {
            $(".navbar-fixed-top").addClass("top-nav-collapse");
        } else {
            $(".navbar-fixed-top").removeClass("top-nav-collapse");
        }
    });

    $('#tj')

    new WOW({ mobile: false }).init();

});
  
 


