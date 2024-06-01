using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    GameManager gameManager;

    public AudioSource source;
    public AudioClip clip;


    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
            gameManager.currentPickups += 1;
            source.PlayOneShot(clip);
            Destroy(this.gameObject);


    }

    // Start is called before the first frame update
    void Start()
    {

        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
