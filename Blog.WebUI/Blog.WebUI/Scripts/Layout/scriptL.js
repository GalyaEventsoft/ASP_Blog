(function($) {
        var layoutPage = (function(){
            var _private = {};
            var _public = {};


            _public.init = function () {
                var colors = function () {
                    var x = $(this).attr('class').split(' ')[1];
                    $('main, .line').removeClass();
                    $('section div, hr').addClass('line');
                    $('main, .line').toggleClass(x);
                };

                $('li').on('click', 'div', colors);

                var login = function () {
                    var url = "/Login";
                    window.location.href = url;
                };

                $('#loginout').on('click', login);
               
            };
            return _public;
        })();

      
       
        $(function () {  
            layoutPage.init();
        });
       
    })($);

  