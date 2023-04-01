// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
console.log("Loading js")
$(".dropdown").hover(function () {
    $(this).toggleClass("open");
});

$(".nav-item").on('click', function () {
    $(this).toggleClass("active");
})

console.log("fin")