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
    public AudioClip[] raiseSFX;
    public AudioClip[] releaseSFX;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
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
    public void PlayRaiseHigeSound(Vector3 spawnPosition)
    {
        sfxAudioSource.clip = raiseSFX[Random.Range(0, raiseSFX.Length)];
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
    public void PlayReleaseHigeSound(Vector3 spawnPosition)
    {
        sfxAudioSource.clip = releaseSFX[Random.Range(0, releaseSFX.Length)];
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

}
