using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AshMovement : MonoBehaviour
{
    public AshWalking controller;

    [SerializeField] public Animator animator;

    public float runSpeed = 10f;

    float horizontal = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }
}
