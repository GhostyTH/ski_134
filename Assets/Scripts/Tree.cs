using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;

    void Sart()
    {
        rd = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;

        Player player = collision.gameObject.GetComponent<Player>();
        player.HP -= 15;
        MainUI.Instance.ShowNotiText("Hit -15\nHP: " + player.HP);

        if (player.HP < 0)
        {
            player.HP = 0;
            MainUI.Instance.ShowNotiText("You are dead!");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(192, 117, 77, 255);
    }
}
