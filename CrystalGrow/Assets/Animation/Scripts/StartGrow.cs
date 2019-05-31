using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGrow : MonoBehaviour {

    public GameObject crystal;
    public string triggerName;
    public KeyCode keyToPress;
    Animator crystalAnimator;
    Renderer crystalRenderer;

    void Start () {
        crystalAnimator = gameObject.GetComponent<Animator>();
        crystalRenderer = gameObject.GetComponent<SkinnedMeshRenderer>();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

            if (Input.GetKeyDown(keyToPress))
        {
            Debug.Log(" keyToPress is pressed " + keyToPress);
            crystalRenderer.enabled = true;
            crystalAnimator.SetTrigger(triggerName);
        }
	}
}
