$(document).ready(function () {
    loadData();
});

//Load Data function
function loadData() {
    $.ajax({
        url: "/Dept/List",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '< td > ' + item.department_id + '</td > ';
                html += '< td > ' + item.department_name + '</td > ';
                html += '< td > ' + item.manager_id + '</td > ';
                html += '< td > ' + item.location_id + '</td > ';
                html += '< td > <a href="#" onclick="return getbyID(' + item.department_id + ')">Edit</a> | <a href="#" onclick="Delele(' + item.department_id + ')">Delete</a></td > ';
                html += '</tr > ';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//Add Data Function
function Add() {
    //var res = validate();
    //if (res == false) {
    //    return false;
    //}
    var deptObj = {
        department_id: $('#id').val(),
        department_name: $('#name').val(),
        manager_id: $('#manager_id').val(),
        location_id: $('#location_id').val(),

    };
    $.ajax({
        url: "/Dept/InsertDept",
        data: JSON.stringify(deptObj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
           loadData();
            $('#myModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//Function for getting the Data Based upon Employee ID
function getbyID(EmpID) {
    $('#Name').css('border-color', 'lightgrey');
    $('#location').css('border-color', 'lightgrey');
    $('#country').css('border-color', 'lightgrey');
    $.ajax({
        url: "/Home/getbyID/" + EmpID,
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#deptid').val(result.deptid);
            $('#deptname').val(result.dname);
            $('#location').val(result.country);
            $('#country').val(result.location);


            $('#myModal').modal('show');
            $('#btnUpdate').show();
            $('#btnAdd').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

//function for updating employee's record
function Update() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var empObj = {
        deptid: $('#deptid').val(),
        deptname: $('#deptname').val(),
        county: $('#country').val(),
        location: $('#location').val(),

    };
    $.ajax({
        url: "/Dept/Update",
        data: JSON.stringify(empObj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            loadData();
            $('#myModal').modal('hide');
            $('#deptid').val("");
            $('#deptname').val("");
            $('#location').val("");
            $('#country').val("");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//function for deleting employee's record
function Delele(ID) {
    var ans = confirm("Are you sure you want to delete this Record?");
    if (ans) {
        $.ajax({
            url: "/Dept/Delete/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                loadData();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}

//Function for clearing the textboxes
function clearTextBox() {
    $('#deptid').val("");
    $('#dname').val("");
    $('#location').val("");
    $('#country').val("");
    //$('#Country').val("");
    //$('#btnUpdate').hide();
    //$('#btnAdd').show();
    $('#deptid').css('border-color', 'lightgrey');
    $('#dname').css('border-color', 'lightgrey');
    $('#location').css('border-color', 'lightgrey');
    $('#country').css('border-color', 'lightgrey');
}
//Valdidation using jquery
function validate() {
    var isValid = true;
    //if ($('#Name').val().trim() == "") {
    //    $('#Name').css('border-color', 'Red');
    //    isValid = false;
    //}
    //else {
    //    $('#Name').css('border-color', 'lightgrey');
    //}
    //if ($('#Age').val().trim() == "") {
    //    $('#Age').css('border-color', 'Red');
    //    isValid = false;
    //}
    //else {
    //    $('#Age').css('border-color', 'lightgrey');
    //}
    //if ($('#State').val().trim() == "") {
    //    $('#State').css('border-color', 'Red');
    //    isValid = false;
    //}
    //else {
    //    $('#State').css('border-color', 'lightgrey');
    //}
    //if ($('#Country').val().trim() == "") {
    //    $('#Country').css('border-color', 'Red');
    //    isValid = false;
    //}
    //else {
    //    $('#Country').css('border-color', 'lightgrey');
    //}
    return isValid;
}

