using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music music_manager;
    private AudioSource music;
    // Start is called before the first frame update
    void Awake()
    {
        music = GetComponent<AudioSource>();
        if(music_manager == null)
        {
            music_manager = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(music_manager);
    }

    // Update is called once per frame
    public void ChangeMusicState()
    {
        if(music.volume == 1)
        {
            music.volume = 0;
        }else if(music.volume == 0)
        {
            music.volume = 1;
        }
    }
}
