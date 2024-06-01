using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    //Audio Proximity Logic
    public AudioSource[] audioSources;
    public float audioProximity = 1.0f;

    //Pickup and level complete logic
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    public Text pickupText;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        levelCompleteCheck();
        UpdateGUI();
        PlayAudioSamples();

    }


    //loop for playing audio proximity events - AudioSource based
    private void PlayAudioSamples()
    {

        for (int i = 0; i < audioSources.Length; i++)
            if (Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity)
                if (!audioSources[i].isPlaying)
                    audioSources[i].Play();
    }


    private void UpdateGUI()
    {
        pickupText.text = "Pickups" + currentPickups + "/" + maxPickups;
    }


    private void levelCompleteCheck()
    {

        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;

    }






}
