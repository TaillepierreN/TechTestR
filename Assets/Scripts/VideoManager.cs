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
        vPlayer.loopPointReached += EndReached;
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
    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        GameObject.Find("SceneManager").GetComponent<SceneManager>().NextScene();
    }
}
