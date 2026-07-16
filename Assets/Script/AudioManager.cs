using UnityEditor;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
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