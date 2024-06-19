using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_player : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� ����������� ���������.

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // �������� �������� ������ WASD.
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // ��������� ������ �����������.
        Vector2 movement = new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime;

        // ��������� ����������� � Rigidbody2D ���������.
        rb.MovePosition(rb.position + movement);
    }
}
