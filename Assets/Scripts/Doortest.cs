using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortest : MonoBehaviour
{
    Animation animation;

    // Use this for initialization
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
