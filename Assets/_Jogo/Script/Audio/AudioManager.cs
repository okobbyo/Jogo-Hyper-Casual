using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixerGroup audioMixer;
    public Sound[] sounds;

    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = false;

    public static AudioManager instance;


    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source  = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

            s.source.outputAudioMixerGroup = audioMixer;
        }

    }

    void Start()
    {
        UpdateButtonIcon();
        AudioListener.pause = muted;
        //Play("Theme");
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.Play();

    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }

    public void OnButtonPress()
    {
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }

        else
        {
            muted = false;
            AudioListener.pause = false;
        }

        Save();
        UpdateButtonIcon();

    }

    private void UpdateButtonIcon()
    {
        if(muted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }

        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

}
