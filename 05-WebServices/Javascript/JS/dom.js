function validate(){
    var t1=document.getElementById("t1");
    var s1=document.querySelector("#s1");
    if(t1.value==""||t1.value==null){
        s1.innerHTML="First name is mandatory";
        //s1.style.color="Red";
        s1.classList.add("red");
    }
}
var t1=document.querySelector("#t1").addEventListener("blur", validate);
//var b1=document.getElementById("b1").addEventListener("click",validate);
//b1.addEventListener("click",validate);