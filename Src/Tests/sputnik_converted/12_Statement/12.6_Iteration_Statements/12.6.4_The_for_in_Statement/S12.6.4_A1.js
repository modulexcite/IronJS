// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
* @name: S12.6.4_A1;
* @section: 12.6.4;
* @assertion: "for(key in undefined)" Statement is allowed;
* @description: Checking if execution of "for(key in undefined)" passes; 
*/


// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S12.6.4_A1",

path: "TestCases/12_Statement/12.6_Iteration_Statements/12.6.4_The_for_in_Statement/S12.6.4_A1.js",

assertion: "\"for(key in undefined)\" Statement is allowed",

description: "Checking if execution of \"for(key in undefined)\" passes",

test: function testcase() {
   //////////////////////////////////////////////////////////////////////////////
//CHECK#1
try {
	for(__key in undefined){
	    var key=__key;
	};
} catch (e) {
	$ERROR('#1: "for(key in undefined){}" does not lead to throwing exception');
}
//
//////////////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////////////////
//CHECK#2
if (key!==undefined) {
	$ERROR('#2: key === undefined. Actual: key === '+key);
}
//
//////////////////////////////////////////////////////////////////////////////



 }
});
