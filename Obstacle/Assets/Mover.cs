using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 8;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game\nMove your player with wasd/updownleftright arrows\nDon't hit the walls!");
    }

    void MovePlayer()
    {
        //Controls
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
