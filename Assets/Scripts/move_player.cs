using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_player : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость перемещения персонажа.

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Получаем значения клавиш WASD.
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Вычисляем вектор перемещения.
        Vector2 movement = new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime;

        // Применяем перемещение к Rigidbody2D персонажа.
        rb.MovePosition(rb.position + movement);
    }
}
