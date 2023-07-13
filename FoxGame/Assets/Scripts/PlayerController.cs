using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public Rigidbody2D theRB;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(moveSpeed = Input.GetAxis("Horizontal"), theRB.velocity.y);
    }
}
