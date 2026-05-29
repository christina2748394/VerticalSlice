using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Video;


public class VideoController : MonoBehaviour

{
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Intro.mp4");
        videoPlayer.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
