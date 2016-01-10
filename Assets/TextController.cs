using UnityEngine;using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {washing_machine, clothes, detergent, tea, whites, colours, all, pub, wrong};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.washing_machine;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.washing_machine) {washing_machine ();}
		else if (myState == States.clothes) 		{clothes ();}
		else if (myState == States.detergent) 		{detergent ();}
		else if (myState == States.tea) 			{tea ();}
		else if (myState == States.whites) 			{whites ();}
		else if (myState == States.colours) 		{colours ();}
		else if (myState == States.all) 			{all ();}
		else if (myState == States.pub) 			{pub ();}
		else if (myState == States.wrong) 			{wrong ();}
	}
	
	#region State Handler Methods
	
	void washing_machine() {
		text.text = "It's a beautiful day today, but before venturing outside, you vow to finally get around to doing the laundry. " +
					"You're stood in front of the washing machine and the sooner you can get this finished, the quicker you can "+
					"get down the pub.  What do you want to do?\n\nPress [D] to add Detergent\nPress [C] to add the Clothes\n" +
					"Press [T] to brew a good cup of Tea";
		if 		(Input.GetKeyDown (KeyCode.D)) {myState = States.detergent;} 
		else if (Input.GetKeyDown (KeyCode.C)) {myState = States.clothes;}
		else if (Input.GetKeyDown (KeyCode.T)) {myState = States.tea;}
	}
	
	void detergent() {
		text.text = "You go pull the cap off the detergent and in your eagerness you yank a little too hard.  The top flies off the " +
					"bottle and detergent splashes all over the room.  Cursing, you go to clean it up only to slip on the wet floor " +
					"and end up cracking your head on the counter.  You wake up 2 days later in hospital.  After nearly a week in " +
					"A&E you are finally allowed to go home once the doctor is happy that no pemanent damage has been done. " +
					"You step through the door to be greeted by a huge stack of laundry.  You should probably get that done.\n\n" +
					"Press [L] to head to the washing machine and start the Laundry.";
		if (Input.GetKeyDown (KeyCode.L)) {myState = States.washing_machine;}
	}
	
	void clothes() {
		text.text = "You empty the contents of the washing basket onto the floor and have an important choice to make...\n\n" +
					"Press [W] to sort the Whites and put them in the washing machine\nPress [C] to sort the Colours and put " +
					"them in the washing machine\nPress [A] to shove everything in the washing machine and get to the pub ASAP";
		if 		(Input.GetKeyDown (KeyCode.C)) {myState = States.colours;}
		else if (Input.GetKeyDown (KeyCode.A)) {myState = States.all;}
		else if (Input.GetKeyDown (KeyCode.W)) {myState = States.whites;}
	}
	
	void tea() {
		text.text = "You go to brew a cuppa and then realise that even the most divine cup of tea will still be a poor substitute " +
					"for an icy cold pint.  You should probably just get your laundry done.  You slacker.\n\nPress [L] to head back " +
					"to the washing machine and start the laundry.";
		if (Input.GetKeyDown (KeyCode.L)) {myState = States.washing_machine;}
	}
	
	void whites() {
		text.text = "You add the whites to the washing machine and despite not having nearly enough clothes for a full load, " +
					"you hit the \"Start\" button anyway.  After decades of wasting away energy like this, the earth finally succombs " +
					"to the persistant abuse of humanity, and global warming takes grip.  The icebergs melt and rising sea " +
					"waters eventually render the planet inhospitable.  How does it feel to be part of humanity's downfall?\n\n" +
					"GAME OVER\n\n Press [N] to start a New Game";
		if (Input.GetKeyDown (KeyCode.N)) {myState = States.washing_machine;}
	}
	
	void colours() {
		text.text = "You bundle the coloured clothes into the washing machine before CAREFULLY adding the detergent, taking care not " +
					"to spill any on the floor.  You gleefully hammer the \"Start\" button and revel in the pride that washes " +
					"over you (pun very much intended).  Now, do you want to head to the pub for a frothy pint and a game of arrows?\n\n" +
					"Press [Y] to head to The Dog and Duck\nPress [N] to have that nice cup of tea";
		if 		(Input.GetKeyDown (KeyCode.Y)) {myState = States.pub;}
		else if (Input.GetKeyDown (KeyCode.N)) {myState = States.wrong;}
	}
	
	void all() {
		text.text = "You throw all your clothes into the washing machine with reckless abandon, only to discover that after 2 hours " +
					"on a soapy wash, a pair of red socks that Uncle Joe got you for Christmas in 2003 has transformed your cricket kit " +
					"from brilliant white, to a hideous shade of pink.  The following Sunday you immediately get dropped from the cricket " +
					"team and sprial into a deep emotional depression as cricket was the one thing that you cherished more than " +
					"anything else in the world.  You turn to alcohol and then hard drugs.  You get sacked from your job and fall behind " +
					"on your mortgage repayments before ending up a washed out homeless bum, ruing that fateful laundry day back in 2015." +
					"\n\nGAME OVER\n\nPress [N] to start a New Game";
		if (Input.GetKeyDown (KeyCode.N)) {myState = States.washing_machine;}
	}
	
	void pub() {
		text.text = "You head to the pub, and all the regulars are already there; Little Jimmy, Uncle Joe, Dave... and before you even " +
					"perch your bum on your favourite stool, Carol has already poured you a perfect pint of your usual.  Ray is " +
					"setting up the mobile disco in the corner and is fussing over the smoke machine.  Afternoon turns to evening, and " +
					"evening turns to night.  Several pints later and more Motown than you can shake a stick at, you stumble home. " +
					"You wake up the next morning still fully clothed and half in bed with a monster hangover.  Shambling into the " +
					"bathroom you catch a glance of your dishevelled self in the mirror and notice a red wine stain running from your " +
					"right shoulder, all the way down your front to your left toe.  It looks like you're going to have to do some laundry " +
					"today.\n\nPress [L] to do some Laundry";
		if (Input.GetKeyDown (KeyCode.L)) {myState = States.washing_machine;}
	}
	
	void wrong() {
		text.text = "Erm... this is embarrassing.  I think you must have slipped and pressed \"N\" by mistake. You meant to press " +
		"\"Y\" didn't you?!\n\nPress [Y] to confirm that you're a plonker that can't type, and head to the pub";
		if (Input.GetKeyDown (KeyCode.Y)) {myState = States.pub;}
	}
	#endregion
}