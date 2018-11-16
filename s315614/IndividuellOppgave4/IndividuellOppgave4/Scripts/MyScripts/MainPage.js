$(document).ready(function () {
    var faq = $('#faq');
     var main = $('#main');

    $('#btn').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq',
            dataType: 'json',
            success: function (data) {
                faq.empty();
                $.each(data, function (index, val) {
                    var title = val.Title;
                    faq.append('<li>' + title + '</li>');
                });
            }
        });
    });
    $("#searchBox").change(function () {
        var id = document.getElementById("searchBox").value;
        
        $.ajax({
            url: 'api/faq',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                main.empty();
                main.append('<script src="Scripts/jquery-3.3.1.js"></script>');
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                var count = 0;
                $.each(data, function (index, val) {
                    var question = val.Question;
                    
                    var myPattern = new RegExp('(\\w*' + id + '\\w*)', 'gi');
                    var matches = question.search(myPattern);
                    if (matches >= 0) {
                        main.append('<table><tr><button id="answer" onclick="getId(' + val.Id + ')">' + question + '</button></tr></table>');

                        count += 1;
                        
                    }

                });
                main.append('<a href="" class="backsign"  onclick="main.empty()"><b>&larr;</b></a>');
               
                if (count === 0) {
                    main.empty();                    
                    main.append('<p>No word/words was found that matches ' + id + '. Please try again.</p><br/>');
                    main.append('<a href="" class="backsign"  onclick="main.empty()"><b>&larr;</b></a>');
                    
                }
                 
               
            },
            error: function () {
                main.empty();
                main.append('Error')
            }
            
        });
    });
    $('#hjelp').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=hjelp%20og%20feils%C3%B8king',
            dataType: 'json',
            success: function (data) {                
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Hjelp og feilsøking</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId('+ val.Id +')"  >' + question + '</button></tr></table>');
                    
                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#hjelp1').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=hjelp%20og%20feils%C3%B8king',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Hjelp og feilsøking</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#funksjonalitet').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=funksjonalitet',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Funksjonalitet</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#funksjonalitet1').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=funksjonalitet',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Funksjonalitet</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#aktuelt').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=aktuelt',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Aktuelt</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#aktuelt1').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=aktuelt',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Aktuelt</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#konto').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=konto%20og%20betaling',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Konto og betaling</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#konto1').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=konto%20og%20betaling',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Konto og betaling</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#finn').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=finn%20og%20se',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Finn og se</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#finn1').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=finn%20og%20se',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Finn og se</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#om').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=om%20oslomet%20films',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Om Oslomet Films</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    $('#om1').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/faq?title=om%20oslomet%20films',
            dataType: 'json',
            success: function (data) {
                main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
                main.empty();
                main.append('<p>Om Oslomet Films</p>');
                $.each(data, function (index, val) {
                    var question = val.Question;
                    main.append('<table><tr class="answers"><button id="answer" class="btn btn-link" onclick="getId(' + val.Id + ')"  >' + question + '</button></tr></table>');

                });
                main.append('<a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a>');
            }
        });
    });
    
    $('#new').click(function () {
        main.empty();
        main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
        main.append('<script src="Scripts/MyScripts/MainPage.js"></script>');
        main.append('<link href="Content/bootstrap.css" rel="stylesheet" />');
        main.append('<div class="col-md-10 col-md-offset-1"><div class="well"><table class="table table-bordered"><thead><tr class="success"><td colspan="2"><h3>Ny spørsmål</h3></td></tr></thead>'
            + '<tr class="success"><td class="left">Navn: </td><td><input class="form-control input-lg" type="text" id="navn" required autofocus></td></tr>'
            + '<tr class="success"><td class="left">Epost: </td><td><input class="form-control input-lg" type="email" id="epost" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$" required ></td></tr>'
            + '<tr class="success"><td class="left">Spørsmål: </td><td><textarea class="form-control" rows="5" type="text" id="question" required autofocus></textarea></td></tr>'
            + '<tr class="success"><td colspan="2"><button class="btn btn-success" id="submit" value="Submit">Submit</button></td></tr></table>'
            + '</div><div id="divError" class="alert alert-danger collapse">'
            + '<a id="linkClose" href="#" class="close">&times;</a>'
            + '<div id="divErrorText"></div></div ><a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a></div></div>');
        
    });
    $('#linkClose').click(function () {
        $('#divError').hide('fade');
    });
    $('#submit').click(function () {
        
        
        var jsInn = {
            Name: $("#navn").val(),
            Email: $("#epost").val(),
            Question: $("#question").val()

        }
        
        $.ajax({
            type: 'POST',
            url: 'api/faq',
            data: JSON.stringify(jsInn),
            contentType: "application/json;charset=utf-8",
            success: function (ok) {
                
                main.empty();
                main.append('<h2>Thank you for taking the time and posting your question. We will reply to you as soon as possible!</h2>');
                setTimeout(function () {
                    window.location.href = "Index.html";
                }, 2500);
            },
            error: function (jqXHR) {
                $('#divErrorText').text('Alle feltene må fylles ut. Epost-adresse og navn må være riktig.');
                        $('#divError').show('fade');
            }
        });
        
    });
    

});


function getId(val){
    document.getElementById("answer").innerHTML = val;
    var id = parseInt(val);
    var main = $('#main');
    $.ajax({
        type: 'GET',
        url: '/api/faq/' + id,
        dataType: 'json',
        success: function (data) {
            main.append('<link href="Content/bootstrap.css" rel="stylesheet" />' +
                +'<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');           
            main.empty();                        
            main.append('<table><tr><td id="answer">' + data.Answer + '</td></tr>'
                + '<tr><td><a href="javascript:mainPage(' + data.Id + ')" class="glyphicon glyphicon-thumbs-up" >' + data.ThumbsUp + '</a>'
                + '<a href = "javascript: toEmail(' + data.Id + ')" onload = "javascript: toEmail();" class= "glyphicon glyphicon-thumbs-down">' + data.ThumbsDown + '</a ></td ></tr >'
                + '<tr><td><a href="" class="backsign" onclick="main.empty()"><b>&larr;</b></a></td></tr ></table > ');
        }
    });


}


function mainPage(val) {
    var id = parseInt(val);
    $.ajax({
        type: 'GET',
        url: '/api/faq/' + id,
        dataType: 'json',
        success: function (data) {
            var thumbsUp = data.ThumbsUp + 1; 
            var thumbsdown = data.ThumbsDown;
            var innData = new Object();
            innData.ThumbsUp = thumbsUp;  
            innData.ThumbsDown = thumbsdown;
            
            $.ajax({
                type: 'PUT',
                url: '/api/faq/' +id,                
                dataType: "application/json;charset=utf-8",               
                data: innData,
                
            })
            var main = $('#main');
            main.empty();
            main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
            main.append('<p id="msg">Thank you for feedback</p>');
            setTimeout(function () {
                window.location.href = "Index.html";
            }, 1000);
        },
        error: function (x, y, z) {
            alert('can not data');
        }
    });
    


}
function toMail() {
    window.location.href = "mailto:support@oslometfilms.com";
}
function toEmail(val) {
    var id = parseInt(val);
    $.ajax({
        type: 'GET',
        url: '/api/faq/' + id,
        dataType: 'json',
        success: function (data) {
            var thumbsdown = data.ThumbsDown + 1;
            var thumbsUp = data.ThumbsUp;
            var innData = new Object();
            innData.ThumbsDown = thumbsdown;
            innData.ThumbsUp = thumbsUp;
            $.ajax({
                type: 'PUT',
                url: '/api/faq/' + id,
                dataType: "application/json;charset=utf-8",
                data: innData,

            })
            var main = $('#main');
            main.empty(); main.append('<link href="Content/MyCSS/mainPage.css" rel="stylesheet" />');
            main.append('<p id="msg">Thank you for feedback.</p><br><p>Please take your time and submit your question.</p>');
            setTimeout(function () {
                window.location.href = "Index.html";
            }, 3000);
        },
        error: function (x, y, z) {
            alert('can not data');
        }
    });
}
