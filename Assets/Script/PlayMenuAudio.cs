using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenuAudio : MonoBehaviour
{
    public GameObject audioObj;
    // Start is called before the first frame update
    public void DropAudio()
    {
        Instantiate(audioObj, transform.position, transform.rotation);
    }
}
