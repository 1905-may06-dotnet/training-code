var id=1;
var url=`http://localhost:57854/api/contact`;
window.onload=function(){
    
    var httpRequest=new XMLHttpRequest();
    httpRequest.onreadystatechange=function(){
        if(httpRequest.readyState==4&&httpRequest.status==200)
        {
            var contacts=JSON.parse(httpRequest.response);
            handleResponse(contacts);
        }
    }
    httpRequest.open('GET',url);
    httpRequest.send();

}

function handleResponse(response){
    //code to print response on thr table
    var tbody=document.querySelector('#tbody');
    response.forEach(r => {
        let tr=document.createElement('tr');
        let tdName=document.createElement('td');
        tdName.innerHTML=`${r.firstName} ${r.middleName} ${r.lastName}`;
        tr.appendChild(tdName);
        let tdPhone=document.createElement('td');
        tdPhone.innerHTML=`${r.mobile}`;
        tr.appendChild(tdPhone);
        tbody.appendChild(tr);
    });
}