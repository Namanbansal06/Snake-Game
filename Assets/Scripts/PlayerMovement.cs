using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 position;
    private float move;
    void Start()
    {
        position = gameObject.transform.position;
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");
    }
}
