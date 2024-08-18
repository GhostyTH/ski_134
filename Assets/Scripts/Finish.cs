using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        MainUI.Instance.ShowNotiText("You Win!");
        Time.timeScale = 0;
    }
}