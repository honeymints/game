using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SoundManager : MonoBehaviour
{
    public static SoundManager instance { get; private set; }
    private AudioSource source;
    private GameObject obj;
    private Scene currentScene;
    // Start is called before the first frame update
    private void Awake()
    {
        
     //    currentScene = SceneManager.GetActiveScene();
    //    string sceneName = currentScene.name;
    //    obj = GameObject.Find("SoundManage");
        source = GetComponent<AudioSource>();
        instance = this;

        //Keep this when scene reloads
        //   if (instance == null)
        //     {

        //       DontDestroyOnLoad(gameObject);
        //   }
        //Destroy duplicate game object
        //  else if((instance!=null && instance != this))
        //   {
        //       Destroy(gameObject);
        //   }
        //   if(sceneName == "Start Menu")
        //   {
        //       Destroy(gameObject);
        //   }

    }
   

    public void PlaySound(AudioClip _sound)
    {
        float volumeScale=0.41f;
        source.PlayOneShot(_sound, volumeScale);
    }
    public void PlaySoundSource(AudioSource audioSource)
    {
        audioSource.Play();
    }
  
    

}
