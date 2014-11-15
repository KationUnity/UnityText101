using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	private enum States {
		cell, sheets_0, lock_0, mirror, cell_mirror, sheets_1, lock_1,
		corridor_0, corridor_1, corridor_2, corridor_3, stair_0, closet_0, stair_1, stair_2, freedom
		};
	private States currState;
	
	// Use this for initialization
	void Start () {
		text.text = "Press Space to start the game!";
		currState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (currState);
		if (currState == States.cell) {
			cell ();
		} else if (currState == States.sheets_0) {
			sheets_0();
		} else if (currState == States.lock_0) {
			lock_0();
		} else if (currState == States.mirror) {
			mirror();
		} else if (currState == States.cell_mirror) {
			cell_mirror();
		} else if (currState == States.lock_1) {
			lock_1();
		} else if (currState == States.sheets_1) {
			sheets_1();
		} else if (currState == States.corridor_0) {
			corridor_0();
		} else if (currState == States.stair_0) {
			stair_0();
		} else if (currState == States.closet_0) {
			closet_0();
		} else if (currState == States.corridor_1) {
			corridor_1();
		} else if (currState == States.stair_1) {
			stair_1();
		} else if (currState == States.corridor_2) {
			corridor_2();
		} else if (currState == States.stair_2) {
			stair_2();
		} else if (currState == States.corridor_3) {
			corridor_3();
		} else if (currState == States.freedom) {
			freedom();
		}

	}
	
	void cell() {
		text.text = "You are in a prison cell and you want to escape. There are some dirty sheets on the bed, " +
					"a mirror on the wall and the door is locked from the outside.\n\n" +
					"You can look at the mirror by pressing M, inspect the Sheets by pressing S and look at the Lock " +
					"by pressing L.";
					
		if(Input.GetKeyDown(KeyCode.S)) {
			currState = States.sheets_0;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			currState = States.lock_0;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			currState = States.mirror;
		}
	}
	
	void sheets_0() {
		text.text = "These sheets are horribad, but you are in prison after all." +
					"There's nothing you can do about that.\n\n" +
					"Return to roaming your cell by pressing R.";
		
		if(Input.GetKeyDown(KeyCode.R)) {
			currState = States.cell;
		}
	}
	
	void lock_0() {
		text.text = "This lock is locked, there is nothing you can do without a proper tool.\n\n" +
					"Return to roaming your cell by pressing R.";
		
		if(Input.GetKeyDown(KeyCode.R)) {
			currState = States.cell;
		}
	}
	
	void mirror() {
		text.text = "You take a mirror in your hand and begin to ponder.\n\n" +
					"Take the mirror with you while roaming the cell by pressing R.";
		
		if(Input.GetKeyDown(KeyCode.R)) {
			currState = States.cell_mirror;
		}
	}
	
	void cell_mirror() {
		text.text = "While holding your mirror, you get an idea to look around again. " +
					"You can inspect the lock and sheets again. \n\n" +
					"Inspect the sheets by pressing S or look at the Lock " +
					"by pressing L.";
		
		if(Input.GetKeyDown(KeyCode.S)) {
			currState = States.sheets_1;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			currState = States.lock_1;
		}
	}
	
	void lock_1() {
		text.text = "With a mirror in your hand, you can see the dirty buttons that were pressed to open the lock. " +
					"You press the buttons and hear a faint click.\n\n" +
					"Push the door open by pressing O, or return to roaming your cell by pressing R.";
		
		if(Input.GetKeyDown(KeyCode.R)) {
			currState = States.cell_mirror;
		} else if (Input.GetKeyDown(KeyCode.O)) {
			currState = States.corridor_0;
		}
	}
	
	void sheets_1() {
		text.text = "These sheets are horribad, even if you look them with a mirror in your hands. " +
					"There's nothing you can do about that. \n\n" +
					"Return to roaming your cell by pressing R.";
		
		if(Input.GetKeyDown(KeyCode.R)) {
			currState = States.cell_mirror;
		}
	}
	
	void corridor_0() {
		text.text = "You are now in a corridor!\n\n" +
					"You can check the stairs by pressing S, check the closet on the right " +
					"by pressing C and look to the floor by pressing H.";
					
		if(Input.GetKeyDown(KeyCode.S)) {
			currState = States.stair_0;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			currState = States.closet_0;
		} else if (Input.GetKeyDown(KeyCode.H)) {
			currState = States.corridor_1;
		}
	
	}
	
	void closet_0() {
		text.text = "You step to the closet on your right, but it's locked, so there is nothing you can do here!\n\n" +
					"Press R to return to the corridor.";
					
		if (Input.GetKeyDown(KeyCode.R)) {
			currState = States.corridor_0;
		}
	}
	
	void stair_0() {
		text.text = "You get closer to the stairs, but you hear sounds coming from above, so you don't " +
					"want to move up the stairs!\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			currState = States.corridor_0;
		}
	}
	
	void corridor_1 () {
		text.text = "You check the floor and find a hairpin. You can go up the stairs and try to overcome " + 
					"the guards with a hairpin or use it for something else! \n\n" +
					"You can check the stairs by pressing S or unlock the closet on the right " +
					"by pressing U.";
		
		if (Input.GetKeyDown(KeyCode.U)) {
			currState = States.corridor_2;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			currState = States.stair_1;
		}
	
	}
	
	void stair_1() {
		text.text = "You get closer to the stairs, but you are not confident that the hairpin will help " +
					"with overcoming the guards so you decide you don't want to move up the stairs!\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			currState = States.corridor_1;
		}
	}
	
	void corridor_2 () {
		text.text = "You unlock the closet and find a cleaner outfit inside! \n\n" +
					"You can check the stairs again by pressing S or dress up as a cleaner " +
					"by pressing D.";
		
		if (Input.GetKeyDown(KeyCode.D)) {
			currState = States.corridor_3;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			currState = States.stair_2;
		}
		
	}
	
	void stair_2() {
		text.text = "You get closer to the stairs, but you are not confident that the hairpin will help " +
					"with overcoming the guards so you decide you don't want to move up the stairs! " +
					"You might want to dress up as a clearner before going up the stairs. \n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			currState = States.corridor_2;
		}
	}
	
	void corridor_3 () {
		text.text = "You are now dressed as a cleaner. No one will recognize you as an escapee! \n\n" +
					"You can run up the stairs by pressing S or undress by pressing " +
					"by pressing U.";
		
		if (Input.GetKeyDown(KeyCode.U)) {
			currState = States.corridor_2;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			currState = States.freedom;
		}
		
	}
	
	void freedom () {
		text.text = "You are now a free man! Congratulations!\n\n" +
					"Press P to play again!";
		
		if (Input.GetKeyDown(KeyCode.P)) {
			currState = States.cell;
		} 
		
	}
	
}
