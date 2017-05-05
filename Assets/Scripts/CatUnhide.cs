using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatUnhide : MonoBehaviour {

    public GameObject m_Cat;

	// Use this for initialization
	void Start ()
    {
        m_Cat.active = false;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_Cat.active = true;
        }
    }
}
