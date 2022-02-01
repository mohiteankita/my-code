function validation() {
    //Username validation
    var user = document.getElementById("uname");
    if (user.value == "") {
        document.getElementById("userMsg").innerHTML = "**Fill the username please!";

    }

    //Password validation
    var pass1 = document.getElementById("pass").value;

    if (pass1 == "") {
        document.getElementById("passMsg").innerHTML = "**Fill the password please!";

    }
    else if (pass1.length < 8) {
        document.getElementById("passMsg").innerHTML = "**Password length must be at least 8 characters";

    }
    else if (pass1.length > 15) {
        document.getElementById("passMsg").innerHTML = "**Password length must not exceed 15 characters";
    }

    var confirmpass1 = document.getElementById("confirmpass").value;
    if (pass1 != confirmpass1) {
        document.getElementById("confirmMsg").innerHTML = "**Password are not same";
        return false;
    }

    //First name validation
    var firstName = document.getElementById("fname").value;
    if (firstName == "" || firstName==null) {
        document.getElementById("fnameMsg").innerHTML = "**Fill the first name please!";
    }

    //Address validation
    var address = document.getElementById("add").value;
    if (address == "") {
        document.getElementById("addMsg").innerHTML = "**Fill the Address please!";
    }

    //Gender validation
    var gender = document.getElementByName("gender");
    var i;
    for (i = 0; i < gender.length; i++) {
        if (gender[i].checked) {
            alert("You have selected " + gender[i].value);
        }
        else
        {
            document.getElementById("genderMsg").innerHTML = "You must select male or female";
        }
    }

}

//First name validation
function OnlyAlphabetAllow(evt) {
    var asciicode = (evt.which) ? evt.which : evt.keyCode;
    if ((asciicode >=65 && asciicode <=90) || (asciicode >=97 && asciicode <= 122))
        return true;
    else
        return false;
}

function displayInfo() {
    alert("You entered");

}

