using UnityEngine;
using System.Collections;

public class ChangeSound : MonoBehaviour {

    static public GameObject target;
    static GameObject oldTarget;

	// Use this for initialization
	void Start () {
	    if (target == null)
        {
            target = GameObject.Find("Sun");
            oldTarget = target;
        }

	}
	
	// Update is called once per frame
	void Update () {
	    if (oldTarget != null)
        {
            if (target.name != oldTarget.name)
            {
                oldTarget.GetComponent<AudioSource>().Stop();
                oldTarget = target;

                target.GetComponent<AudioSource>().Play();
            }
        }
	}
}
