﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour {

    public DashState dashState;
    public float dashTimer;
    public float maxDash = 20f;
    Rigidbody2D rigidbody;
    public Vector2 savedVelocity;

    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        switch (dashState)
        {
            case DashState.Ready:
                var isDashKeyDown = Input.GetKeyDown(KeyCode.LeftShift);
                if (isDashKeyDown)
                {
                    savedVelocity = rigidbody.velocity;
                    rigidbody.velocity = new Vector2(rigidbody.velocity.x * 3f, rigidbody.velocity.y);
                    dashState = DashState.Dashing;
                }
                break;
            case DashState.Dashing:
                dashTimer += Time.deltaTime * 3;
                if (dashTimer >= maxDash)
                {
                    dashTimer = maxDash;
                    rigidbody.velocity = savedVelocity;
                    dashState = DashState.Cooldown;
                }
                break;
            case DashState.Cooldown:
                dashTimer -= Time.deltaTime;
                if (dashTimer <= 0)
                {
                    dashTimer = 0;
                    dashState = DashState.Ready;
                }
                break;
        }
    }
}
public enum DashState
{
    Ready,
    Dashing,
    Cooldown
}
