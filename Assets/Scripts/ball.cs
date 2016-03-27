using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "GoalRight") {
			gui.S.player1Goals++;
            gui.S.ScoreGoalText(1);
            ResetObjects.S.Reset();
		}
        if (coll.gameObject.tag == "GoalLeft")
        {
            gui.S.player2Goals++;
            gui.S.ScoreGoalText(2);
            ResetObjects.S.Reset();
        }
    }
}
