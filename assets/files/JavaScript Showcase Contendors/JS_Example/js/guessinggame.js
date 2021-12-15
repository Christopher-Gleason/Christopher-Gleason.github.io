"use strict";

const MINNUMBER		=	  1;
const MAXNUMBER		=	100;

let rn 				=	  0;	
let numGuesses		=	  0;
let guessedIt		=	true;

let $ = function(id) {
	return document.getElementById(id);
};

let processEntries = function()
{
	let guess = parseInt($("guess").value);
	
	$("guessStatus").value = "";
	
	if (guessedIt)
	{
		getNewNumber();	
	}

	if (isNaN(guess) || (guess < MINNUMBER) || (guess > MAXNUMBER))
	{
		$("guess").nextElementSibling.firstChild.nodeValue = "Invalid Guess";
		$("guess").value = "";
		$("guess").focus();
		guessedIt = false;
		return;
	}
	else
	{
		$("guess").nextElementSibling.firstChild.nodeValue = "";
		checkYourGuess(guess);	
	}
};

let checkYourGuess = function(g) {
	let retVal = "";
	
	numGuesses++;

	if (g < rn)
	{
		retVal = "Your Guess Of " + g + " Was Too Low.  Try Again";
		guessedIt = false;
	}
	else if (g > rn)
	{
		retVal = "Your Guess Of " + g + " Was Too High.  Try Again";
		guessedIt = false;
	}
	else if (g === rn)
	{
		retVal = "Correct Guess Of " + g + " In " + numGuesses + " guesses";
		guessedIt = true;
	}
	
	$("guessStatus").value = retVal;
};

let resetTheForm = function() {
	$("guess").value 			= "";
	$("guessStatus").value	= "";
	$("guess").nextElementSibling.firstChild.nodeValue = "*";
	$("guess").focus();
};

let getNewNumber = function() {
	//	Generate a new random number
	resetTheForm();
	numGuesses = 0;
	rn = Math.floor(Math.random() * 100) + 1;
}

window.onload = function() {
	$("calculate").onclick = processEntries;	//	"Register" calculate button
	$("reset").onclick = resetTheForm;			//	"Register" reset button
	$("newNumber").onclick = getNewNumber;		//	"Register" new number button
	$("guess").focus();							//	Set focus to height text box
};