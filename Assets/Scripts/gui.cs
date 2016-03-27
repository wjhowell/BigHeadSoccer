using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gui : MonoBehaviour {
    public static gui S;

	public Text rightScore;
    public Text leftScore;
    public GameObject goalText;

    public int player1Goals;
    public int player2Goals;

	// Use this for initialization
	void Start () {
        S = this;
        player1Goals = 0;
        player2Goals = 0;
		rightScore = GameObject.Find("ScoreRight").GetComponent<Text> ();
        leftScore = GameObject.Find("ScoreLeft").GetComponent<Text>();
        goalText = GameObject.Find("GoalText");
        goalText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		rightScore.text = player2Goals.ToString();
        leftScore.text = player1Goals.ToString();
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
