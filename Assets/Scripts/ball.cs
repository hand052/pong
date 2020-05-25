using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public AudioSource sound;
    public Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        //takes note of where the ball first was
        startPosition = transform.position;
        Launch();
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        //returns the ball to where it started
        transform.position = startPosition;
        Launch();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject)
        {
            sound.Play();
        }
    }

    //sends the ball in a random direction
    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
