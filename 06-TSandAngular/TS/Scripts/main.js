"use strict";
exports.__esModule = true;
var myname; //declaration
myname = "10"; //assignation
//myname=10;
//let score:number=0xf0089;
var isNew = true;
var a = 10;
var b = a;
b = "Fred";
var c = "Lead Trainer";
var anything = null;
var paragraph = "Hello I am " + b + " and I am a \n" + c + ". I train on .Net full stack technologies\nand also on Azure";
//ARRAYS:
var batchScores; //:number[]
batchScores = [50, 80, 89, 78, 85, 65, 89];
//ENUMS: named types
var daysOfWeek;
(function (daysOfWeek) {
    daysOfWeek[daysOfWeek["Monday"] = 1] = "Monday";
    daysOfWeek[daysOfWeek["Tuesday"] = 2] = "Tuesday";
    daysOfWeek[daysOfWeek["Wednesday"] = 3] = "Wednesday";
    daysOfWeek[daysOfWeek["Thursday"] = 4] = "Thursday";
    daysOfWeek[daysOfWeek["Friday"] = 5] = "Friday";
    daysOfWeek[daysOfWeek["Saturday"] = 6] = "Saturday";
    daysOfWeek[daysOfWeek["Sunday"] = 7] = "Sunday";
})(daysOfWeek || (daysOfWeek = {}));
;
//console.log(daysOfWeek[4]);
//TUPLES
var associates = ["Nathan", 75];
var x; //:any;
x = 10;
x = "Hello"; // non type inference
var y;
//y=10;
//y="10";
//console.log(y)
//console.log(typeof(y));
//FUNCTIONS
function getValue(num1, num2) {
    if (num1 === void 0) { num1 = 10; }
    if (num1 && num2)
        return num1 + num2;
    if (!num2)
        return num1;
}
function getPerson(person) {
    if (person.middlename)
        return "Hello " + person.firstname + " " + person.middlename + "  " + person.lastname;
    else
        return "Hello " + person.firstname + " " + person.lastname;
}
var person1 = {
    firstname: "Fred",
    lastname: "Belotte"
};
console.log(getPerson(person1));
