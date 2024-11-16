using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;

    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;

    void Start(){
        if(isPlayer)
        spriteRenderer.color = SaveController.Instance.colorPlayer2;
        else
        spriteRenderer.color = SaveController.Instance.colorPlayer2;
    }

    void Update(){
        float moveInput = Input.GetAxis("Vertical");
        
        Vector3 newPosition = transform.position + Vector3.up * moveInput * speed * Time.deltaTime;

        newPosition.y = Mathf.Clamp(newPosition.y, -4.5f, 4.5f);

        transform.position = newPosition;
    }
}
