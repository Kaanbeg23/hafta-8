using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class baslabutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startbutton()
    {
        SceneManager.LoadScene("level1");
    }
    public void anamenu()
    {
        SceneManager.LoadScene("basla");
    }
    public void level()
    {
        SceneManager.LoadScene("level2");
    }
}
