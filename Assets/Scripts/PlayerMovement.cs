using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float gravity = 9.8f;
    public float speed = 5.0f;

    public Rigidbody2D rigidbody;
    void Update()
    {
        var result = new Vector2(0.0f, -gravity);
        //  0 não está apertando nada
        // > 0 está apertando para a direita
        // < 0 está apertando para a esquerda
        var axis = Input.GetAxis("Horizontal");
        // axis = 90000
        // apertando pra direita clamp(axis, -1,1 ) --> 1
        // apertando pra esquerda clamp(-90000, -1, 1 ) --> -1
        axis = Mathf.Clamp(axis, -1f, 1f);
        var velocidadeNoEixoX = axis * speed;

        result.x = velocidadeNoEixoX;
        rigidbody.velocity = result;
    }
}
