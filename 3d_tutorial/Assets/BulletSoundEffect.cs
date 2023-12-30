using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSoundEffect : MonoBehaviour
{
    public AudioClip soundEffect; // 재생할 사운드 파일
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // AudioSource가 없으면 새로 추가합니다.
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // AudioSource의 AudioClip을 설정합니다.
        audioSource.clip = soundEffect;
    }

    // 원하는 함수에서 사운드를 재생합니다.
    public void PlaySoundEffect()
    {
        if (soundEffect != null)
        {
            audioSource.Play();
        }
    }
}
