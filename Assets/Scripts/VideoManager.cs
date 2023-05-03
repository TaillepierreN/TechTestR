using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    VideoPlayer vPlayer;
    [SerializeField]GameObject pausePanel;
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
            pausePanel.SetActive(false);
        }
        else
        {
            vPlayer.Pause();
            pausePanel.SetActive(true);

        }
    }
}
