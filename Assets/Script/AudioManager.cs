using UnityEditor;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static public AudioManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public AudioClip[] audioClips;
    public AudioSource seAudioSource;
    public AudioClip[] bgmAudioClips; 
    public AudioSource bgmAudioSource;


  
    public void PlaySE()
    {
        seAudioSource.clip = audioClips[1];
        seAudioSource.Play();
    }

    public void PlayBGM()
    {
        bgmAudioSource.clip = bgmAudioClips[0];
        bgmAudioSource.Play();
    }
    void Start()
    {
        seAudioSource = this.gameObject.AddComponent<AudioSource>();
        bgmAudioSource = this.gameObject.AddComponent<AudioSource>();
        bgmAudioSource.loop = true; 

        PlayBGM();
    }


}