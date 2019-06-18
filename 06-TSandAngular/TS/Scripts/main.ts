export{}
let myname: string;//declaration
myname="10";//assignation
//myname=10;
//let score:number=0xf0089;
let isNew: boolean=true;
let a:number=10;
let b:any=a;
b="Fred";
let c="Lead Trainer";
let anything:void=null;
let paragraph=`Hello I am ${b} and I am a 
${c}. I train on .Net full stack technologies
and also on Azure`;
//ARRAYS:
let batchScores : Array<Number>//:number[]
batchScores=[50,80,89,78,85,65,89];

//ENUMS: named types
enum daysOfWeek{Monday=1,Tuesday,Wednesday, Thursday,Friday,Saturday,Sunday};
//console.log(daysOfWeek[4]);

//TUPLES
let associates:[string, number]=["Nathan",75];

let x;//:any;
x=10;
x="Hello";// non type inference

let y: string|number;
//y=10;
//y="10";
//console.log(y)
//console.log(typeof(y));

//FUNCTIONS
function getValue(num1:number=10, num2?:number):number{
    if(num1 && num2)
        return num1+num2;
    if(!num2)    
        return num1;
}
//console.log(getValue());
/*
function getPerson(person:{firstname:string,lastname:string}):string{
    return `Hello ${person.firstname} ${person.lastname}`;
}*/
interface Person{
    firstname:string,
    middlename?:string,
    lastname:string
}
function getPerson(person:Person):string{
    if(person.middlename)
    return `Hello ${person.firstname} ${person.middlename}  ${person.lastname}`; 
    else   
    return `Hello ${person.firstname} ${person.lastname}`;
}
let person1={
    firstname:"Fred",
    lastname:"Belotte"
};
console.log(getPerson(person1));
