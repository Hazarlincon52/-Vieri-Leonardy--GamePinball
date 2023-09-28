using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;

    public AudioClip bumperSFX;
    public AudioClip[] highSFX;
    public AudioClip[] midSFX;
    public AudioClip[] lowSFX;
    public AudioClip[] siwtchSFX;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }
    public void PlaySFX(Vector3 spawnPosition)
    {
        sfxAudioSource.clip = bumperSFX;
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlayHighSound(Vector3 spawnPosition)
    {
        sfxAudioSource.clip = highSFX[Random.Range(0, highSFX.Length)];
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
    public void PlayMidSound(Vector3 spawnPosition)
    {
        sfxAudioSource.clip = midSFX[Random.Range(0, midSFX.Length)];
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
    public void PlayLowSound(Vector3 spawnPosition)
    {
        sfxAudioSource.clip = lowSFX[Random.Range(0, lowSFX.Length)];
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchSound(Vector3 spawnPosition)
    {
        sfxAudioSource.clip = siwtchSFX[Random.Range(0, siwtchSFX.Length)];
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

}
