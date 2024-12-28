using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Asegúrate de usar TextMeshPro si estás usando TMP en tu proyecto

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalftLapTrig;

    public TMP_Text MinuteDisplay; // Usar TMP_Text para soporte TextMeshPro
    public TMP_Text SecondDisplay;
    public TMP_Text MilliDisplay;

    void OnTriggerEnter () // Se añadió el parámetro "Collider other"
    {
     
        // Actualiza el texto de los segundos con formato adecuado
        if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.text = "" + LapTimeManager.SecondCount + ".";
        }

        // Actualiza el texto de los minutos con formato adecuado
        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.text = "0" + LapTimeManager.MinuteCount + ":";
        }
        else
        {
            MinuteDisplay.text = "" + LapTimeManager.MinuteCount + ":";
        }

        // Actualiza el texto de los milisegundos
        MilliDisplay.text = LapTimeManager.MilliCount.ToString("F0");

        // Reinicia los contadores de tiempo
        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        // Cambia el estado de los triggers
        HalftLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
        }
    }

