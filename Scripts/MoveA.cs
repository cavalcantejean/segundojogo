using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveA : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10F;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions ();
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue, 0, zValue);
    }

    void PrintInstructions ()
    {
        Debug.Log("Bem-vindo ao jogo");
        Debug.Log("Espero que goste");
        Debug.Log("Este é o meu segundo jogo");
    }
}
