using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float m_MaxSpeed = 0.5f;

    private SpriteRenderer thisSprite;
    private Animator anim;
    private bool onGround;
    private Transform PlayerTransform;
    private int cooldown;

	// Use this for initialization
	void Start ()
    {
        SpriteRenderer thisSprite = this.GetComponent<SpriteRenderer>() as SpriteRenderer;
        anim = GetComponent<Animator>();
        onGround = false;
        PlayerTransform = this.GetComponent<Transform>() as Transform;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Inputs
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        
        //Move around
        Vector3 Dir = new Vector3(-h * m_MaxSpeed, 0, -v * m_MaxSpeed);
        PlayerTransform.transform.Translate(Dir);

        //Animation stuff
        anim.SetFloat("h", h);
        anim.SetFloat("v", v);

        //Jump Cooldown
        if (cooldown > 0)
            cooldown--;

        //Jump!
        if (Input.GetAxis("Jump") == 1 && onGround == true && cooldown == 0)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 350, 0));
            onGround = false;
            cooldown = 100;
        }

        //Keeps her upright and aligned
        PlayerTransform.Rotate(-PlayerTransform.rotation.ToEulerAngles() * 10);

    }

    void OnCollisionEnter(Collision other)
    {
        //If colliding with something below me, I'm most likely on ground
        if (other.transform.position.y < this.transform.position.y)
            onGround = true;
    }
}
