using UnityEngine;

public class CubeInteract : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        rend.material.color = Color.green;
    }
}