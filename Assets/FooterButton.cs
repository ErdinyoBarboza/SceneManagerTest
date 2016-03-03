using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class FooterButton : MonoBehaviour {
    
    public MainScene scene;
    
    void Start(){
        GetComponent<Button>().onClick.AddListener(LoadScene);
    }    
    
    public void LoadScene(){
        FindObjectOfType<SceneHolder>().LoadMainScene(scene);
    }
}


