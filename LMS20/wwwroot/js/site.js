﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/*$(document).ready(function () {*/

//     Get the container element ul
//var navContainer = document.getElementById("myNavbar");
// Get all links with class="nav-item" inside the container eg li
//var navItems = navContainer.getElementsByClassName("nav-item");

// Loop through the lis and add the active class to the current/clicked button
//for (var i = 0; i < navItems.length; i++) {
//    navItems[i].addEventListener("click", function () {
//        console.log("så här ");
        //var current = document.getElementsByClassName("navItems");
        //current[0].className = current[0].className.replace("active", "");
        //this.className += "active" ;
//    })
//}


document.querySelectorAll('.deleteBtn').forEach(b => b.addEventListener('click', function () {

    var myCourseId = $(this).data('id');
    var myCourseName = $(this).data('name');

    $("#courseId").val(myCourseId);
    $("#courseName").text(myCourseName);
    
    console.log("CoursId: " + myCourseId + ", CourseName: " + myCourseName);

}));

$(document).ready(function () {
    console.log("Killroy igen 1");
    $("#formClose").click(function () {
        $("#createCourseForm").trigger("reset");
        console.log("Killroy igen 2");
    });
});

//$('#myModal').on('shown.bs.modal', function () {
//    $('#myInput').trigger('focus')
//})

$(document).ready(function () {
    console.log("Killroy igen 1");
    $("#formClose").click(function () {
        $("#createCourseForm").trigger("reset");
        console.log("Killroy igen 2");
    });
});

function removeCreateCourseForm() {
    // Workaround for modal hide bug
    $('#createCourseModal').modal('hide');
    $('#createCourseModal').on('hidden.bs.modal', function () {
        $('#formClose').trigger('click');
    });
    console.log("killroy was here");
}

function removeDeleteCourseForm() {

    $('#confirmDeleteModal').modal('hide');
    $('#confirmDeleteModal').on('hidden.bs.modal', function () {
        $('#formClose').trigger('click');
    });
}

function failCreate(response) {

    let validationSummary = document.querySelector('#validationSummary');
    validationSummary.innerHTML = "Någonting gick fel";
}
