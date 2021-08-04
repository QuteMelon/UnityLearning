using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Game Start");
        //SceneManager.LoadScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Debug.Log("Game Start");
        SceneManager.LoadScene("Scenes/SampleScene");
    }
}
