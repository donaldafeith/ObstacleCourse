using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float yValue = 0;
    public float moveSpeed = 5;

    private void Start()
    {
        PrintInstruction();
    }
    void Update()
    {
        MovePlayer();
        
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue, yValue, zValue);  
    }
    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
    }
}
