using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip MonsterDieSound;
    public AudioClip MonsterFoundPlayerSound;
    public AudioClip GotWordSound;
    public AudioClip PlayerDieSound;
    public AudioClip WeopenDoneSound;
    public AudioClip BtnSound;

    public static bool MonsterDie;
    public static bool MonsterFoundPlayer;
    public static bool GotWord;
    public static bool PlayerDie;
    public static bool WeopenDone;
    public static bool Btn;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (MonsterDie == true)
        {
            audioSource.PlayOneShot(MonsterDieSound);
            MonsterDie = false;
        }

        if (MonsterFoundPlayer == true)
        {
            audioSource.PlayOneShot(MonsterFoundPlayerSound);
            MonsterFoundPlayer = false;
        }

        if (GotWord == true)
        {
            audioSource.PlayOneShot(GotWordSound);
            GotWord = false;
        }

        if (PlayerDie == true)
        {
            audioSource.PlayOneShot(PlayerDieSound);
            PlayerDie = false;
        }
        if (WeopenDone == true)
        {
            audioSource.PlayOneShot(WeopenDoneSound);
            WeopenDone = false;
        }
        if (Btn == true)
        {
            audioSource.PlayOneShot(BtnSound);
            Btn = false;
        }
	}
}
