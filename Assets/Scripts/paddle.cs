using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{

    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector2 startPosition;

    private float movement;

    // Start is called before the first frame update
    void Start()
    {
        //takes note on players starting pos and archives it
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //changes player's method of movement, sw if P1 up and down if P2
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(0, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        //returns the players to their starting positions
        transform.position = startPosition;
    }
}
