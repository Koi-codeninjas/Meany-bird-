using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerControls : MonoBehaviour
{
    [Header("Game Controller Object for controlling the game")]
    public GameController gameController;
    [Header("Default Velocity")]
    private float velocity= 5;
    //bird physics
    private Rigidbody2D rb;
    //the height of the bird on the y axis
    private float objectHeight;

    void Start()
    {
        //GameController Component
        gameController = GetComponent<GameController>();
        //speed for game is playing at a slate
        Time.timeScale = 1;

        rb = GetComponent<Rigidbody2D>();
        //object height equals the height of the spirte
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;


    }

    void Update()
    {
        if (UnityEngine.Input.GetMouseButtonDown(0))
        {


            //the bird will float up on y and down on y
            rb.velocity = Vector2.up * velocity;

        }
    }
}