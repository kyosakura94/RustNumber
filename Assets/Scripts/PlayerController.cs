using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Transform Center;

    [SerializeField]
    private Transform Up;

    [SerializeField]
    private Transform Down;

    [SerializeField]
    private Transform Left;

    [SerializeField]
    private Transform Right;

    [SerializeField]
    float speed = 0.005f;

    [SerializeField]
    float step = 9;

    bool input = true;

    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        if (input == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                StartCoroutine(moveUp());
                input = false;
            }
        }

    }


    IEnumerator moveUp()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            transform.RotateAround(Up.position, Vector3.right, step);
            yield return new WaitForSeconds(speed);
        }
        Center.position = transform.position;
        input = true;
    }
}
