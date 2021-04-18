

$(document).ready(() => {
    // variaveis globais
    var scroll = 50;
    var searchArea = document.querySelector(".search-area");
    var scrolling = document.getElementById("scrolling-top");
   
    document.onscroll = function () {
        if (window.innerWidth > 991) {
            if ($(document).scrollTop() > scroll) {
                searchArea.style = "right: -1000px;";
            } else {
                searchArea.style = "right: 20px;";
            }
        }
        
    }

    $(scrolling).click(() => {
        $(document).scrollTop(0);
    });
    // more code here
});
