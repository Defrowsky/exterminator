using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    public float JumpForce;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello word");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("czarnuch");
        if (Input.GetButtonDown("Jump"))
        {
            ;
            rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        
    }

}
