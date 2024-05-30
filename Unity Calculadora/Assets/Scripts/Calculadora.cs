//librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//clases

public class Calculadora : MonoBehaviour
{
    // variables
    public TMP_InputField primerNumero;
    public TMP_InputField segundoNumero;
    public TMP_Text resultadoText;
    
    public float resultado;
    
    // Metodos

    public void Suma() 
    {
        float numero1 = float.Parse(primerNumero.text);
        float numero2 = float.Parse(segundoNumero.text);

        resultado = numero1 + numero2;

        resultadoText.text = resultado.ToString();
    }

    public void Resta()
    {
        float numero1 = float.Parse(primerNumero.text);
        float numero2 = float.Parse(segundoNumero.text);

        resultado = numero1 - numero2;

        resultadoText.text = resultado.ToString();
    }

    public void Multiplicacion()
    {
        float numero1 = float.Parse(primerNumero.text);
        float numero2 = float.Parse(segundoNumero.text);

        resultado = numero1 * numero2;

        resultadoText.text = resultado.ToString();
    }

    public void Division()
    {
        float numero1 = float.Parse(primerNumero.text);
        float numero2 = float.Parse(segundoNumero.text);

        resultado = numero1 / numero2;

        resultadoText.text = resultado.ToString();
    }
}
