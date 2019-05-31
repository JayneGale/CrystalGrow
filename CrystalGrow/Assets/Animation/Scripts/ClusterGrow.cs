using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClusterGrow : MonoBehaviour {

    public GameObject crystal;
    public string triggerName;
    public KeyCode keyToPress;
    Animator crystalAnimator;
    Renderer crystalRenderer;

    // Use this for initialization
    void Start () {
        crystalAnimator = gameObject.GetComponent<Animator>();
        crystalRenderer = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(keyToPress))
        {
            Debug.Log(" keyToPress is pressed " + keyToPress);
            crystalRenderer.enabled = true;
            crystalAnimator.SetTrigger(triggerName);
        }
	}
}
