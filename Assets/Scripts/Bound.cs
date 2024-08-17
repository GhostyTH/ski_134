using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
         MainUI.Instance.ShowNotiText("You are dead!");
         Time.timeScale = 0;
    }
}