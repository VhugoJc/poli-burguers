using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName="";

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScene()
    {
        Debug.Log("################");
        SceneManager.LoadScene(0);
    }
}
