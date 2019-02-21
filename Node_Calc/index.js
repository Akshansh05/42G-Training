const request = new XMLHttpRequest();

b1.onclick = function(){
    Call("add")
};

b2.onclick = function(){
    Call("sub")
};

b3.onclick = function(){
    Call("mul")
};

b4.onclick = function(){
    Call("div")
};

function Call(method){
    request.open("GET", "http://127.0.0.1:8000/"+method+"?value1="+value1.value+"&value2="+value2.value);
    request.onload = function(){
        answer.value = request.responseText;
    };
    request.send();
};
 