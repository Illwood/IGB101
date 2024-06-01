using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animation animation;
    void Start()
    {
        animation = GetComponent<Animation>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
            animation.Play();
    }
}
