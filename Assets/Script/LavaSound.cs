using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaSound : MonoBehaviour
{
    [SerializeField] private Transform listenerTransform;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private float maxDist = 50f;
    [SerializeField] private float minDist = 1f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
         float dist = Vector3.Distance(transform.position, listenerTransform.position);
        if (dist < minDist)
        {
            audioSource.volume = 1;
        }
        else if (dist > maxDist)
        {
            audioSource.volume = 0;
        }
        else
        {
            audioSource.volume = 1 - ((dist - minDist) /  (maxDist-minDist));
        }
    }
}
