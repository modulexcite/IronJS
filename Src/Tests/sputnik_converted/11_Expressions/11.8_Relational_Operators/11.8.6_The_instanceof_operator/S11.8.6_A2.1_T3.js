// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
* @name: S11.8.6_A2.1_T3;
* @section: 11.8.6;
* @assertion: Operator "instanceof" uses GetValue;
* @description: If GetBase(ShiftExpression) is null, throw ReferenceError;
*/


// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S11.8.6_A2.1_T3",

path: "TestCases/11_Expressions/11.8_Relational_Operators/11.8.6_The_instanceof_operator/S11.8.6_A2.1_T3.js",

assertion: "Operator \"instanceof\" uses GetValue",

description: "If GetBase(ShiftExpression) is null, throw ReferenceError",

test: function testcase() {
   //CHECK#1
try {
  ({}) instanceof OBJECT;
  $ERROR('#1.1: ({}) instanceof OBJECT throw ReferenceError. Actual: ' + (({}) instanceof OBJECT));  
}
catch (e) {
  if ((e instanceof ReferenceError) !== true) {
    $ERROR('#1.2: ({}) instanceof OBJECT throw ReferenceError. Actual: ' + (e));  
  }
}

 }
});
