using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSoundEffect : MonoBehaviour
{
    public AudioClip soundEffect; // ����� ���� ����
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // AudioSource�� ������ ���� �߰��մϴ�.
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // AudioSource�� AudioClip�� �����մϴ�.
        audioSource.clip = soundEffect;
    }

    // ���ϴ� �Լ����� ���带 ����մϴ�.
    public void PlaySoundEffect()
    {
        if (soundEffect != null)
        {
            audioSource.Play();
        }
    }
}
