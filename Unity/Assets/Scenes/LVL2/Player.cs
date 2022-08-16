using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Transform PlayerTransform;
    [SerializeField] private float speedFactor;

    void Start()
    {
        PlayerTransform = GetComponent<Transform>();
    }

    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        PlayerTransform.Translate((hAxis * speedFactor * Time.deltaTime), 0, 0);
    }
}
