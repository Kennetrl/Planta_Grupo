using UnityEngine;

public class TubeRotation : MonoBehaviour
{
    public float selfRotationSpeed = 50f; // Velocidad de rotaci�n del tubo

    void Update()
    {
        transform.Rotate(Vector3.forward * selfRotationSpeed * Time.deltaTime); 
    }
}
