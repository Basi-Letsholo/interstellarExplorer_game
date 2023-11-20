using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astro_script : MonoBehaviour
{
    public Rigidbody2D astroBody;
    public float runSpeed;
    public float jumpStrength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") == true)
        {
            astroBody.velocity = Vector2.up * jumpStrength;
        }

        if (Input.GetKey("left") == true)
        {
            astroBody.velocity = new Vector2(-runSpeed, astroBody.velocity.y);
        }
        else if (Input.GetKey("right") == true)
        {
            astroBody.velocity = new Vector2(runSpeed, astroBody.velocity.y);
        }
        else
        {
            astroBody.velocity = new Vector2(0, astroBody.velocity.y);
        }
    }
}
