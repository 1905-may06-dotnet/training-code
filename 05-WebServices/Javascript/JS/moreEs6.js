// OBJECTS in JS:
//window, console, document - predefined JS Objects.
// Different ways to create objects - Function Constructor, Literal or JavaScript Object Notation, function, prototypes
//Recommended way
//Object Literal Notation
/*var Car={
    make:"Ford",
    model:"Fiesta",
    work:function(){
            console.log("Takes your to the places");
        }
}*/

// using Objects
/*var Car=new Object();
Car.make="Mazda";
Car.model="6";
Car.work=function(){
    alert('runs on wheels to take you to the destination');
};
*/

//using functions

function Car(){
    this.color="Blue",
    this.make="Toyota",
    this.year="2019",
    this.model="Camry"
}

// var obj=new Car();
// //var obj2= this._proto_(Car);
// //obj2.gears="6";// 
// obj.work=function(){
//     alert('runs on wheels');
// }
// obj.work();
// obj.color="Red";
// console.log(obj.make);
// console.log(obj.color);
// console.log(typeof(Car))

// OOP Concept in JS
/*class vehicle{
    constructor(make,year, model){
        // make="tata";
        // year="2000";
        // model="something"
        this.make=make;
        this.year=year;
        this.model=model;
    }
}*/

//class expression
var v=class vehicle{
    constructor(){
      this.make="tata";
      this.year="2000";
      this.model="something"
    }
    // constructor(make,model,year){
    //     this.make=make;
    //     this.model=model;
    //     this.year=year;
    // }
    Run(){
        if(this.year>1990)
            console.log("You can use it ");
    }
}
// inherticance and static methods
class MotorBike extends v{

    static work(){        
        console.log("motor bike runs on 2 wheels")
    }
    constructor(){
        super().Run();        
    }
}
// MotorBike.work();
// var bike=new MotorBike();
// var obj=new v("Tesla","t1",2015);
// obj.year=2000;
// obj.model="Civic";
// obj.make="Honda";
// obj.Run();


// Promises:
// function notifyAll(fnSms, fnEmail) {   
//     debugger;
//     console.log('starting notification process');   
//     fnSms();   
//     fnEmail();   
//  }   
//  notifyAll(function() {   
//     console.log("Sms send ..");   
//  }, 
//  function() {   
//     console.log("email send ..");   
//  });   
//  console.log("End of script"); 
 //executes last or blocked by other methods  

 /*function notifyAll(fnSms, fnEmail) {   
     debugger;
    setTimeout(function() {   
       console.log('starting notification process');   
       fnSms();   
       fnEmail();   
    }, 5000);   
 }   
 notifyAll(function() {   
    console.log("Sms send ..");   
 },  
 function() {   
    console.log("email send ..");   
 });   
 console.log("End of script"); //executes first or not blocked by others  


*/

function getSum(n1, n2) {  
    debugger; 
    var isAnyNegative = function() {   
       return n1 < 0 || n2 < 0;   
    }   
    var promise = new Promise(function(resolve, reject) {   
       if (isAnyNegative()) {   
          reject(Error("Negatives not supported"));   
       }   
       resolve(n1 + n2)
    });   
    return promise;   
 } 

getSum(-5, 6)   
.then(function (resolve) {   
   console.log(resolve);   
},   
function (reject) {   
   console.log(reject);   
});