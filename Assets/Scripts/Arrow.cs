using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Player_5 t;
    public float maxTForward;
    public bool Tforward;
    // Start is called before the first frame update
    void Start()
    {
        Tforward = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (t.text == true)
        {
            VisibilityToggle();
        }
    }
    void VisibilityToggle()
    {

        if (Tforward)
        {
            return;
        }
        transform.position = transform.position + new Vector3(0, 1f * Time.deltaTime, 0);

        if (transform.position.y >= maxTForward)
        {

            Tforward = true;
        }
    }
}

