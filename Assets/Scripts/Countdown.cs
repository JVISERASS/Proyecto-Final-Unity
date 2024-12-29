using System.Collections;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDown.text = "3";
        GetReady.Play();
        CountDown.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.gameObject.SetActive(false);

        CountDown.text = "2";
        GetReady.Play();
        CountDown.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.gameObject.SetActive(false);

        CountDown.text = "1";
        GetReady.Play();
        CountDown.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.gameObject.SetActive(false);

        CountDown.text = "GO!";
        GoAudio.Play();
        CountDown.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.gameObject.SetActive(false);

        LapTimer.SetActive(true);
        CarControls.SetActive(true);
    }
}
