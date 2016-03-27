using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gui : MonoBehaviour {
    public static gui S;

	public Text rightScore;
    public GameObject goalText;

	// Use this for initialization
	void Start () {
        S = this;
		rightScore = GameObject.Find("ScoreRight").GetComponent<Text> ();
        goalText = GameObject.Find("GoalText");
        goalText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		rightScore.text = playerMovement.S.goalsScored.ToString();
	}

    public void ScoreGoalText(int i)
    {
        StartCoroutine(ScoreGoalTextEnum(i));
    }

    IEnumerator ScoreGoalTextEnum(int i)
    {
        goalText.SetActive(true);
        goalText.GetComponent<Text>().text = "Player " + i + " goal!";
        yield return new WaitForSeconds(1f);
        goalText.SetActive(false);
    }
}
