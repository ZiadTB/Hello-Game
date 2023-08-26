using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Dart : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LineRenderer lr;
    [SerializeField] private float power = 2f;

    private bool isDragging;
    private bool OnBoard;


    private void Update()
    {
        PlayerInput();
    }

    private void PlayerInput()
    {
        Vector2 InputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(transform.position, InputPos);

        if (Input.GetMouseButtonDown(0) && distance <= 10f) DragStart();
        if (Input.GetMouseButton(0) && isDragging) DragChange(InputPos);
        if (Input.GetMouseButtonUp(0) && isDragging) DragRelease(InputPos);
    }

    private void DragRelease()
    {
        throw new NotImplementedException();
    }

    private void DragStart()
    {
        isDragging = true;
        lr.positionCount = 2;
    }

    private void DragChange(Vector2 pos)
    {
        Vector2 dir = (Vector2)transform.position - pos;

        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, (Vector2)transform.position + Vector2.ClampMagnitude((-dir * power) / 2, power / 2));
    }

    private void DragRelease(Vector2 pos)
    {
        float distance = Vector2.Distance((Vector2)transform.position, pos);
        isDragging = false;

        lr.positionCount = 0;

        if(distance < 1f)
        {
            return;
        }

        Vector2 dir = (Vector2)transform.position - pos;
        rb.velocity = Vector2.ClampMagnitude(dir * power, power);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("HIT!!!");
    }
}
