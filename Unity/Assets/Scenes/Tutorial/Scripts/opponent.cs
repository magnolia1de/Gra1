using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opponent : MonoBehaviour
{
    public GameObject LineOfLive;
    public float live;

    private void Start()
    {
        LineOfLive.GetComponent<Slider>().value = live;

    }
}
