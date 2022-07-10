// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function toggle() {
    var element = document.getElementById('word_list'); 
    if(element.style.display === "none") {
         element.style.display = "block";
    }else{
         element.style.display = "none";
    }
}