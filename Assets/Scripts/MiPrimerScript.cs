using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{

    int numeroDeSaltos = 0;

    public int primerLogroSaltos = 5;
    public int segundoLogroSaltos = 10;
    public int tercerLogroSaltos = 15;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        numeroDeSaltos++;
        Debug.Log("Veces que ha chocado " + numeroDeSaltos + " " + gameObject.name);
        Debug.Log("Ha chocado con " + collision.gameObject.name);


        if (numeroDeSaltos == primerLogroSaltos || numeroDeSaltos == segundoLogroSaltos || numeroDeSaltos == tercerLogroSaltos)
        {
            Debug.Log(gameObject.name + " ha chocado " + numeroDeSaltos + " veces con " + collision.gameObject.name);
        }
    }
}
