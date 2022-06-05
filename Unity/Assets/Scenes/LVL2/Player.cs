using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Transform PlayerTransform;
    [SerializeField] private float speedFactor;

    // Start is called before the first frame update
    void Start()
    {
        PlayerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        PlayerTransform.Translate((hAxis * speedFactor * Time.deltaTime), 0, 0);
    }
}
