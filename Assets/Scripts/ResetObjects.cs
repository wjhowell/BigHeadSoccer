using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ResetObjects : MonoBehaviour {
    public static ResetObjects S;

    public List<GameObject> ObjectsToReset;
    public List<Vector3> OriginalPositions;

    // Use this for initialization
    void Awake () {
        S = this;

	    foreach(GameObject obj in ObjectsToReset)
        {
            OriginalPositions.Add(obj.transform.position);
        }
	}

    public void Reset ()
    {
        StartCoroutine(ResetEnum());
    }

    IEnumerator ResetEnum()
    {
        for(int i = 0; i < ObjectsToReset.Count; i++)
        {
            ObjectsToReset[i].GetComponent<TrailRenderer>().enabled = false;
        }
        yield return new WaitForSeconds(1f);
        foreach (GameObject obj in ObjectsToReset)
        {
            obj.transform.position = OriginalPositions[ObjectsToReset.IndexOf(obj)];
            obj.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            obj.GetComponent<Rigidbody2D>().angularVelocity = 0f;
        }
        yield return new WaitForSeconds(.25f);
        for (int i = 0; i < ObjectsToReset.Count; i++)
        {
            ObjectsToReset[i].GetComponent<TrailRenderer>().enabled = true;
        }
    }

}
