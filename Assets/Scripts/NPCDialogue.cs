using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour {

    public GameObject m_Cat;
    public Transform m_PlayerPos;
    public GameObject m_Dialogue;

    void Start()
    {

    }

	// Update is called once per frame
	void Update()
    {
        if (m_Cat.active == true)
            m_Dialogue.GetComponent<TextMesh>().text = "Ha! Goteem! He was\nhere the whole time!";

        Vector3 zoz = m_PlayerPos.position - this.GetComponent<Transform>().transform.position;

        if (zoz.magnitude < 3)
            m_Dialogue.active = true;
        else
            m_Dialogue.active = false;
    }
}
