using UnityEngine;

public class ColorChange : MonoBehaviour
{
    void Update()
    {
        GetComponent<Renderer>().material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );
    }
}