using UnityEngine;

public class SistemaSolar : MonoBehaviour
{
    public string tagTierra = "Tierra";
    public string tagLuna = "Luna";
    public float velocidadOrbitalTierra = 10f;
    public float velocidadOrbitalLuna = 30f;
    public float velocidadRotacionSol = 5f; // Nueva variable para la rotación del Sol

    private Transform tierra;
    private Transform luna;
    private Transform sol; // Variable para el Transform del Sol

    void Start()
    {
        // Busca los objetos por tag
        GameObject objetoTierra = GameObject.FindGameObjectWithTag(tagTierra);
        GameObject objetoLuna = GameObject.FindGameObjectWithTag(tagLuna);

        // Verifica si se encontraron los objetos
        if (objetoTierra == null)
        {
            Debug.LogError("No se encontró ningún objeto con el tag '" + tagTierra + "'");
            return; // Sale del script si no se encuentra el objeto
        }
        if (objetoLuna == null)
        {
            Debug.LogError("No se encontró ningún objeto con el tag '" + tagLuna + "'");
            return; // Sale del script si no se encuentra el objeto
        }

        // Obtiene los componentes Transform
        tierra = objetoTierra.transform;
        luna = objetoLuna.transform;
        sol = transform; // El Sol es el objeto al que está adjunto este script
    }

    void Update()
    {
        if (tierra != null && luna != null && sol != null) // Verifica si se encontraron los objetos
        {
            // Rotación del Sol sobre su propio eje
            sol.Rotate(Vector3.forward * velocidadRotacionSol * Time.deltaTime);

            // Rotación de la Tierra alrededor del Sol
            tierra.RotateAround(sol.position, Vector3.forward, velocidadOrbitalTierra * Time.deltaTime);

            // Rotación de la Luna alrededor de la Tierra
            luna.RotateAround(tierra.position, Vector3.forward, velocidadOrbitalLuna * Time.deltaTime);
        }
    }
}