using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwapper : MonoBehaviour {

    // Use this for initialization
    public List<Sprite> sprites;
    public Sprite current;

    void Start()
    {
        current = sprites[0];
    }

    public void SwapTo(int index)
    {
        current = sprites[index];
        this.GetComponent<SpriteRenderer>().sprite = sprites[index];
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            SwapTo(3);
            SwapTo(7);
            SwapTo(3);
            SwapTo(11);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            SwapTo(2);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            SwapTo(0);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            SwapTo(1);
        }
    }
}
