using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour{

    GameManager gameManager;
    public string nextLevel;

    // Start is called before the first frame update
    void Start(){
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider otherObject){

    if(otherObject.transform.transform.tag == "Player"){
            if (gameManager.levelComplete){
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}
