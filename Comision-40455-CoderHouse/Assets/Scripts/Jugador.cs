using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AtaqueCopado()
    {
        Debug.Log("Realizando ataque copado");
    }

    void AtaqueVolador()
    {
        float velocidadAtaque = 20f;
        Debug.Log("Realizando ataque volador con la velocidad: " +velocidadAtaque);
        
    }
}
