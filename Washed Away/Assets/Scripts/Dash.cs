using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour {

    private CircleCollider2D cirlceCollider;
    private Rigidbody2D rigidBody;
    public static float movespeed = PlayerController.moveSpeed;
    public int DashSupply = 100;
    private float nextActionTime = 0f;
    public float period = 10f;

    private void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (DashSupply >= 0)
            {
                dashActive();
            }
        }
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            DashSupply = 100;
            Debug.Log("DashSupply has been reset");
        }
    }
    void dashActive()
    {
        while (Input.GetKey(KeyCode.LeftShift))
        {
            movespeed = movespeed * 2.0f;
            DashSupply = DashSupply - 10;
        }
    }
}
