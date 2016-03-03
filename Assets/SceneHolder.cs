using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneHolder : MonoBehaviour {
    
    Scene LoadedScene;
    
    void Start(){
        LoadMainScene(MainScene.Quest);
    }
	
    public void LoadMainScene(MainScene scene){
        SceneManager.UnloadScene(LoadedScene.name);
        SceneManager.LoadScene(scene.ToString(), LoadSceneMode.Additive);
        LoadedScene = SceneManager.GetSceneByName(scene.ToString());
    }
}

public enum MainScene{
    Friend,
    Gacha,
    Monster,
    Quest,
    Shop
}