using UnityEngine;
using System.Collections;
using UnityEngine.SceneManager;

public class LevelManager : MonoBehaviour {

    static LevelManager instance = null;
    

    // public variables
    public float autoLoadNextLevelAfter;
 

//    void Awake() {
//        if (instance != null && instance != this)
//        {
//            Destroy(gameObject);
//        } else {
//            instance = this;
//            DontDestroyOnLoad(gameObject);
//        }
//    }

    void Start(){
        if(autoLoadNextLevelAfter <= 0){
            Debug.Log("Auto level disabled");
        } else{
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
     }

	public void LoadLevel(string name)  {
	
		Debug.Log ("New Level load: " + name);
        SceneManager.LoadScene(name);
	}

	public void QuitRequest()   {
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

    public void LoadNextLevel() {
        Debug.Log("Loading next scene");
        SceneManager.LoadScene(Application.loadedLevel + 1);
    }
}
