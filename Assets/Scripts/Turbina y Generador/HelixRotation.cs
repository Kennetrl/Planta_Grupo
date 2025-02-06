using UnityEngine;

public class HelixRotation : MonoBehaviour
{
    public float selfRotationSpeed = 200f; // Velocidad de rotaci�n propia

    void Update()
    {
        transform.Rotate(Vector3.right * selfRotationSpeed * Time.deltaTime); // Prueba con Vector3.up si no gira bien
    }
}
