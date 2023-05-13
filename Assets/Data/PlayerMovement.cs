using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public Vector2 velocity = new Vector2(0, 0);
    public Rigidbody2D rdb2;
    public float pressHorizontal;
    public float pressVertical;
    public float speedUp = 0.5f;
    float speedDown = 0.5f;
    public float speedMax = 20f;
    public float speedHorizon = 3f;
    public bool autoRun = false;
    private void Awake()
    {
        rdb2 = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pressHorizontal = Input.GetAxis("Horizontal");
        pressVertical = Input.GetAxis("Vertical");
        if (autoRun) pressVertical = 1;
    }
    private void FixedUpdate()
    {
        this.UpdateSpeed();
    }
    public void UpdateSpeed()
    {
        velocity.x = pressHorizontal * speedHorizon;
        this.UpdateSpeedUp();
        this.UpdateSpeedDown();



        rdb2.MovePosition(this.rdb2.position + velocity * Time.fixedDeltaTime);
    }
    public void UpdateSpeedUp()
    {
        if (pressVertical <= 0) return;

        this.velocity.y += speedUp;
        if (velocity.y >= speedMax)
        {
            velocity.y = speedMax;
        }
        if (transform.position.x <= -7 || transform.position.x >= 7)
        {
            this.velocity.y -= 1f;
            if (velocity.y <= 3)
            {
                velocity.y = 3;
            }
        }

    }
    public void UpdateSpeedDown()
    {
        if (pressVertical != 0) return;

        this.velocity.y = speedDown;
        if (velocity.y <= 0)
        {
            velocity.y = 0;
        }

    }
}
