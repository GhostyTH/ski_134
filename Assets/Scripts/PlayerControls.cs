using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int forcePower;

    [SerializeField]
    private float xInput;

    [SerializeField]
    public int hp = 100;

    public int HP { get { return hp; } set { hp = value; } }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void Update()
    {
        MoveLeftOrRight();
    }

    private void MoveLeftOrRight()
    {
        xInput = Input.GetAxis("Horizontal");
        rb.AddForce(xInput * Vector3.right * forcePower);
    }
}