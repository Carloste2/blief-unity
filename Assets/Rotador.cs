using UnityEngine;

public class Rotador : MonoBehaviour
{
    public Vector3 velocidadRotacion = new Vector3(0, 30, 0); // grados por segundo

    void Update()
    {
        transform.Rotate(velocidadRotacion * Time.deltaTime);
    }
}
