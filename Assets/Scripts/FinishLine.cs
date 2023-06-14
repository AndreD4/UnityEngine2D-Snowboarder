using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

  [SerializeField] float delayFinished = 2f;
  [SerializeField] ParticleSystem finishedEffect;
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      finishedEffect.Play();
      GetComponent<AudioSource>().Play();
      Invoke("ReloadScene", delayFinished);
      
    }
  }

  void ReloadScene()
  {
    SceneManager.LoadScene(0);
  }
}
