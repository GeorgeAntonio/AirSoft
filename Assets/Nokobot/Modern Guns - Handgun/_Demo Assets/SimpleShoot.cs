using UnityEngine;

public class ArmaScript : MonoBehaviour
{
    public GameObject bbPrefab;
    public Transform canoArma;
    public float energiaDisparo = 1.49f;
    public float massaBB = 0.2f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DispararBB();
        }
    }

    private void DispararBB()
    {
        GameObject novaBB = Instantiate(bbPrefab, canoArma.position, canoArma.rotation);
        Rigidbody rb = novaBB.GetComponent<Rigidbody>();

        Vector3 direcaoDisparo = canoArma.forward;
        rb.AddForce(direcaoDisparo * CalculaVelocidadeInicial(), ForceMode.VelocityChange);
    }

    private float CalculaVelocidadeInicial()
    {
        float velocidadeInicial = Mathf.Sqrt(energiaDisparo * 2 / massaBB);
        return velocidadeInicial;
    }
}
