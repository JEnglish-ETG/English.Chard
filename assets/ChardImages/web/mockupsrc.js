function HelpUser() {
    alert("I'm here to help.");
}
/*
    KeepCount() of clicks on the page. 
    Variable i had to be declared OUTSelemE OF the function.
    If it was INSelemE KeepCount(), every mention of KeepCount() would set i = 0.
*/
var i = 0;
function KeepCount() {
    i++; // short for i = i + 1.
    document.getElementById("score").innerHTML = "Clicked " + i;
}
dragElement(document.getElementById("c1"));
function dragElement(elem) {
    var pos1 = 0, pos2 = 0, pos3 = 0, pos4 = 0;
    elem.onmousedown = dragMouseDown;


    function dragMouseDown(e) {
        e = e || window.event;
        pos3 = e.clientX;
        pos4 = e.clientY;
        document.onmouseup = closeDragElement;
        document.onmousemove = elementDrag;
    }

    function elementDrag(e) {
        e = e || window.event;
        pos1 = pos3 - e.clientX;
        pos2 = pos4 - e.clientY;
        pos3 = e.clientX;
        pos4 = e.clientY;
        elem.style.top = (elem.offsetTop - pos2) + "px";
        elem.style.left = (elem.offsetLeft - pos1) + "px";
    }

    function closeDragElement() {
        document.onmouseup = null;
        document.onmousemove = null;
    }
}
/*
    I wanted to display the click count in real time, but I couldn't figure that out.
    document always refers to the HTML page that calls the function (I think).
    EDIT: Line 8 of index.html titles the page as "Document."
    GetElementByelem().innerHTML seems to replace any HTML line that has <... elem="demo"...> in it.
*/
function ShowClick() {
    document.getElementByelem("score").innerHTML = "Clicked " + i; // Adding to the end of the string.
}

