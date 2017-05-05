using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject m_Player;

    private Vector3 playerPos;

	// Use this for initialization
	void Start () {
        playerPos = m_Player.GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        playerPos = m_Player.GetComponent<Transform>().position;

        this.GetComponent<Transform>().Translate(this.GetComponent<Transform>().position - playerPos);

    }
}
