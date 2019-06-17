window.onload=function(){
    var url='https://mdn.github.io/learning-area/javascript/oojs/json/superheroes.json'
    var superheroes=document.getElementById('superheroes');
    //1. create object of XMLHttpRequest
    if(XMLHttpRequest)
        var request=new XMLHttpRequest();// mozilla, chrome, IE>7
    else
        var request=new ActiveXObject();//IE<=7
    //2. handle the ReadyStateChange Event for responses
    request.onreadystatechange=function(){
        //console.log(`${request.readyState}-${request.status}`);
        //console.log(typeof(request.response));
        if(request.readyState===4 && request.status==200){
        var result=JSON.parse(request.response);
        //console.log(typeof(result));

        
        result.members.forEach(member => {
            var h3=document.createElement("h3");
            h3.innerHTML=member.name;    
            superheroes.appendChild(h3);
            
            var p=document.createElement('p');
            p.innerHTML=`Age: ${member.age} ${member.secretIdentity}`
            superheroes.appendChild(p);
        });
        
        
    }
    }
    //3. Open request
    request.open('GET',url,true);
    //4. Send request
    request.send();

}