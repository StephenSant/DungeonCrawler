using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    public CharacterController controller;

    private float inputH, inputV;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    float ToDiagonal(float x, float y)
    {
        return x + y;
    }

    void Update()
    {
        Vector3 prevVector = transform.position;
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        controller.SimpleMove(new Vector3 (ToDiagonal(-inputV,inputH),0, ToDiagonal(inputV, inputH)) * speed * Time.deltaTime);
        Debug.Log(prevVector-transform.position);
    }
}
