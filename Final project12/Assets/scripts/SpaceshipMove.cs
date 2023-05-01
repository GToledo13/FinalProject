using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMove : MonoBehaviour
{
    public float speed;
    public float Acceleration;
    Rigidbody2D rb;
    public float RotationControl;
    float MovY, MovX = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovY = Input.GetAxis("Vertical"); 
    }

    private void FixedUpdate()
    {
        Vector2 vel = transform.right * (MovX * Acceleration);
        rb.AddForce(vel);
        float Dir = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.right));
        if (Acceleration > 0)
        {
            if (Dir > 0)
            {
                rb.rotation += MovY * RotationControl * (rb.velocity.magnitude / speed);
            }
            else
            {
                rb.rotation -= MovY * RotationControl * (rb.velocity.magnitude / speed)
;
            }
        }
            float thrustforce = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.down))*2.0f;
            Vector2 relforce = Vector2.up * thrustforce;
            rb.AddForce(rb.GetRelativeVector(relforce));

        if (rb.velocity.magnitude>speed)
        {
           rb.velocity= rb.velocity.normalized* speed;
        }

    }





}
