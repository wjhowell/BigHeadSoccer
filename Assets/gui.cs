using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gui : MonoBehaviour {
	public Text rightScore;

	// Use this for initialization
	void Start () {
		rightScore = GetComponentInChildren<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		rightScore.text = playerMovement.S.goalsScored.ToString();
	}
}
