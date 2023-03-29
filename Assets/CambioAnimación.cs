using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioAnimación : MonoBehaviour
{
    public static bool In_ground = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        In_ground = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        In_ground = true;
    }
}

