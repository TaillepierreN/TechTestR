using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    VideoPlayer vPlayer;
    void Start()
    {
        vPlayer = GameObject.Find("Videoplayer").GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseUnpause()
    {
        if(!vPlayer.isPlaying)
        {
            vPlayer.Play();
        }
        else
        {
            vPlayer.Pause();
        }
    }
}
