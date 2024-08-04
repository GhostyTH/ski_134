using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        player.HP -= 15;
        MainUI.Instance.ShowNotiText("Hit -15\nHP: " + player.HP);

        if (player.HP < 0)
        {
            player.HP = 0;
            MainUI.Instance.ShowNotiText("You are dead!");
        }
    }
}
