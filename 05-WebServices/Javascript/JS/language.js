/*function hello(){
    alert('Hi')
}*/

// How can we place JS - Inline, Internal, External
/*
Best
practise is to 
keep JS at the end of the <body>
*/

// 1. Variables, Types, operators, const
//Variables: Block, function, Global
/*x=10; // global variable
//JavaScript  is  un-typed language
x="test";
x=true;
x=1.5;
x=-1;
x=Infinity;
x=NaN; // Not a number but still type is Number
x=null; //type object
var y;// undefined
x={};// denote empty object
x=[];// denotes empty array
x="hello";// type function
//Datatypes: number,string,function,undefined,null,object,Symbol.
x=1/0;
x='a'/1;
x=1/'a'
x=1+'a';
x='a'+1;

//Typecasting
x=10;
//y=String(x);
x=0;
x=null;
x=undefined;
x={};
x=[];
x=Infinity;
x=NaN;
x='';
a="Test me";
x=`${a}`;// String Interpolation
// Truthy and falsy (0,false, undefined, null, NaN,''or "")
//console.log(x);
y=Boolean(x);
//var x=20; // function level
//let x= 20; // block level
//console.log(y);
//console.log(typeof(y));

// OPERATORS: Arithmatic (+,-,*,/,%), Logical(&&,||), Bitwise(&, |, >>, <<), Comparison(<,>,<=,>=,==,===), ternary (condition?true:false), unary(-,!,++,--), Assignment (=, +=.-=...)
var x=10;
var y='10';*/
//console.log(x==y);
//console.log(x===y);// strict equality
//console.log(x===y?"yes":"No");// shorthand for if-else

// LOOPS : Definite (for, foreach, forin), Indefinate (while, do-while)
//var names=["Fred","Pushpinder","Nick","Seal"];
//var a=names.length-1;
//forin returns keys/index
/*while(a){
    debugger;
    console.log(names[a]);
    a--;
}*/
/*for(var name=0;name<names.length;name++)
{
    console.log(names[name]);
}*/
//foreach returns values
/*names.forEach(name => {
    console.log(name);
});*/

// Scope,Hoisting, function, closures
// Functions : Building blocks for performing Events and handling events
//1. Named Function
    //1.1 without parameters and does not retun anything
/*function GetName(){
    console.log("Pushpinder Kaur");
}*/

    //1.2 returns a value
/*function GetName(){
        return "Pushpinder Kaur";
}*/
    //1.3 Parameterized
    // function GetName(firstName, lastName){
    //     return `${firstName} ${lastName}`;
    // }
//var Name=GetName("Pushpinder", 'Kaur');
// 2. Anonymous methods
/*var Name=function(firstName, lastName){
        return `${firstName} ${lastName}`;
};*/

//console.log(Name("Pushpinder","Kaur"));
//3. Arrow Functions
//var Name=x=>{return x+10;}
//var Name=(x,y)=>`${x} ${y}`;
//console.log(Name("Pushpinder", "Kaur"));
//4. IIFE

/*(function(x,y){
    //debugger;
    console.log(`${x} ${y}`);
}("Pushpinder", "Kaur"));*/
/*var Name=(function(x,y){
    //debugger;
    console.log(`${x} ${y}`);
})("Pushpinder", "Kaur");*/
//((x,y)=>{console.log(x+" "+y)})("Fred","Belotte");
// 5. callback functions
/*function GetName(firstName,lastName){
    return `${firstName} ${lastName}`;
}
function Givename(a,b,GetName){
    return `${a} ${b} ${GetName("a","b")}`;
}
console.log(Givename("Test1","Test2",GetName));*/

// SCOPES: Block, Function, global

//var z=10;
/*(function(){
    {
    // let z="test";// block
    z="test";// global
    console.log(`Inside block-${z}`);
    }
    console.log(`Inside function-${z}`);
})();
console.log(`Outside function-${z}`);*/
/*Get();// function hoisting
function Get(){
    {
    const b="My place in America";
    b="that's not fair";// error
    }
    console.log(b);
};*/

// 6. Nested functions and closures:
// closures: it is combination of functions and lexical scoping
var getvalue=function setValue(){
    var abc="outside";
    function display(){
        return abc;
    };
    return display();
};

console.log(getvalue());


function Add(x){
    return function(y){
        return x+y;
    };
}

var with4=Add(4);// outer function is called;
console.log(with4(10));
console.log(Add(5)(20));
//7. currying of functions

function Volume(l)
{
    return function(h)
    {
        return function(w){
            return l*h*w;
        }
    }
}
console.log(Volume(5)(4)(3));