function showText() {
    document.getElementById("paratext").style.display = "block";
    document.getElementById("paratext").style.fontSize = "30px";
    document.getElementById("paratext").style.color = "violet";
}

function hideText() {
    document.getElementById("paratext").style.display = "none";
}

//change button color
function changeBtn()
{
    var btns = document.getElementsByClassName('btnstyle1');
    btns[0].style.backgroundColor = "blue";
    btns[1].style.backgroundColor = "grey";
}