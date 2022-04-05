using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

    
{
  public CharacterController2D controller;
  public Transform PlayerTransform;
  Vector2 movement = new Vector2();

  public float MoveForce;
  public float MoveForceMultiplier;
    

  // Start is called before the first frame update
  void Start()
  {

    PlayerTransform = GetComponent<Transform>();

  }

  // Update is called once per frame
  void Update()
  {
    GetPlayerInput();
    // print("movement.x = " + movement.x);
       
  }

  void GetPlayerInput()
  {
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");
  }

  void FixedUpdate()
  {

    controller.Move(movement.x * MoveForce * Time.fixedDeltaTime, false, false); 
  }
}