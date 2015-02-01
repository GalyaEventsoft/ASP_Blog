

    $(document).ready(function () {
        $('li').on('click', 'div', function () {
            var x = $(this).attr('class').split(' ')[1];
            $('main, .line').removeClass();
            $('section div , hr').addClass('line');
            $('main, .line').toggleClass(x);
        });
    });

  