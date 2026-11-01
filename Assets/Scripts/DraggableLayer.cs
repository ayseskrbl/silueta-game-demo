using System;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldpos = Camera.main.ScreenToWorldPoint(mousePos);
        worldpos.z = 0f;
        transform.position = worldpos;
    }
}
