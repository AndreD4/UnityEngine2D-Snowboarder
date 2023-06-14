using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
  [SerializeField] float crashLoadDelay = 2f;
  [SerializeField] ParticleSystem crashEffect;
  [SerializeField] AudioClip crashSFX;
    void OnTriggerEnter2D(Collider2D other) 
    {
      if(other.tag == "Ground")
      {
        FindObjectOfType<PlayerController>().DisableControls();
        crashEffect.Play();
        GetComponent<AudioSource>().PlayOneShot(crashSFX);
        Debug.Log("crashed");
        Invoke("CrashReload",crashLoadDelay);
      }
    }

    void CrashReload()
    {
      SceneManager.LoadScene(0);
    }
}
