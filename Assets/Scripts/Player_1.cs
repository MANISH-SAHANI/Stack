using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public float speed;
    public float maxForward;
    public float maxBackWord;
    public float maxRight;
    public bool forward;
    public bool side;
    public bool down;
    public bool P2;
    public bool text;

    // Start is called before the first frame update
    void Start()
    {
        forward = false;
        side = false;
        down = false;
        P2 = false;
        text = false;


    }

    // Update is called once per frame
    void Update()
    {
        moveUP();
        moveSide();
        moveDown();
    }

    void moveUP()
    {
        if (forward)
        {
            return;
        }

        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);

        if (transform.position.x >= maxForward)
        {

            forward = true;
        }
    }

    void moveSide()
    {
        if (forward && side)
        {
            return;
        }
        if (forward && !side)
        {

            transform.position = transform.position + new Vector3(0, 0, -speed * Time.deltaTime);

            if (transform.position.z <= maxRight)
            {
                side = true;
                P2 = true;

            }
        }

    }

    void moveDown()
    {
        if (forward && side && !down)
        {
            transform.position = transform.position + new Vector3( -speed * Time.deltaTime,0, 0);
            if (transform.position.x <= maxBackWord)
            {
                down = true;
                text = true;

            }
        }

    }

}
//transform.position += new Vector3(0f, 0f, -1f) * speed * Time.deltaTime;
