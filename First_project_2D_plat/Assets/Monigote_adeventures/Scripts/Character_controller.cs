using UnityEngine;
using System.Collections;

public class Character_controller : MonoBehaviour {

    private float movex = 0f;
    private float movey = 0f;
    public float maxSpeed = 5F;
    public float jumpSpeed = 8.0F;

    bool facingRight = true;


    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
        
}
