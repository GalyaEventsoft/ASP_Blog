(function($) {
        var commentPage = (function(){
            var _private = {};
            var _public = {};


            _public.init = function () {
                var addComment = function () {
                    var comment = {
                        Comment_user: $("#comment_user").val(),
                        Comment_articleId: $("#comment_articleId").val(),
                        Comment_content: $("#comment_content").val()
                    };

                    $.ajax({
                        url: "Article/AddComment",
                        dataType: "json",
                        type: "POST",

                        data: comment,
                        success: function (data) {
                            showNewComment(data);
                        },
                        error: function (xhr) {
                            alert("Error");
                        }
                    });
                };

                var showNewComment = function (data) {
                    var date = new Date(parseInt(data.CreationDate.substr(6))).toLocaleDateString();
                    var html =
                        '<div class="line default">'+
                        '<p class="publishdate">' + date + '</p></div>'+
                        '<article>' + data.Comment_content + '</article>'+
                        '<p class="publishdate">' + data.Comment_user + '</p>';

                    $("#update_container").prepend(html);
                    $("#comment_content").val('');
                };

                $("#add_comment").on("click",addComment);
            };
            return _public;
        })();

      
       
        $(function () {  
            commentPage.init();
        });
       
    })($);
