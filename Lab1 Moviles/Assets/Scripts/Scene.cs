using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
    public Button btnLoad;
    public string SceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        btnLoad.onClick.AddListener(() => LoadScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
