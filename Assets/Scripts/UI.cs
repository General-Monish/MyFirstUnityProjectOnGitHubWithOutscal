using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButton1Click()
    {
        SceneManager.LoadScene(1);
    }
    public void OnButton2Click()
    {
        SceneManager.LoadScene(2);
    }
    public void OnButton3Click()
    {
        SceneManager.LoadScene(3);
    }
}
