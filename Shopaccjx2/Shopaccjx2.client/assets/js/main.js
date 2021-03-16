var logo = $('.page_header-logo');
var headerPc = $('#header_nav-PC');
var headerSm = $('#header_nav-sm');
var headerListSm = $('.header_nav-listSm');
var bongMo = $('#bongmo');

function thaydoiwidth() {
    var x = window.innerWidth;
    if (x < 992) {
        logo.css("display", "none");
    } else if (x >= 1200) {
        logo.css("left", "400px");
        logo.css("display", "block");
    } else {
        var lgt = x / 2 - 200;
        logo.css("display", "block");
        logo.css("left", `${lgt}px`);        
    }
    if (x >= 768) {
        headerPc.css("display", "block");
        headerSm.css("display", "none");
        bongMo.removeClass('bongmo');
    } else {
        headerPc.css("display", "none");
        headerSm.css("display", "block");
        headerListSm.addClass('show_off');
    }
}
var y = window.innerWidth;
if (y < 992) {
    logo.css("display", "none");
} else if (y >= 1200) {
    logo.css("left", "400px");

} else {
    var lgt = y / 2 - 200;
    logo.css("left", `${lgt}px`);
}
if (y >= 768) {
    headerPc.css("display", "block");
    headerSm.css("display", "none");
} else {
    headerPc.css("display", "none");
    headerSm.css("display", "block");
}
window.addEventListener("resize", thaydoiwidth);

function showlist() {
    var checkoff = headerListSm.hasClass('show_off');
    if (checkoff) {
        headerListSm.removeClass('show_off');
        bongMo.addClass('bongmo');
    } else {
        headerListSm.addClass('show_off');
        bongMo.removeClass('bongmo');
    }
}