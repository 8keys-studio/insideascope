using UnityEngine;
using System.Collections;

public class EnterLoveTower : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            Debug.Log("Trigger Level Change");
            StartCoroutine(ChangeLevel());
        }
    }

    IEnumerator ChangeLevel ()
    {
        Debug.Log("People");
        float fadeTime = GameObject.Find("fadeInOut").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        Debug.Log("Places");
        Application.LoadLevel("gem1"); //make a win message
        //gem1
    }
}
