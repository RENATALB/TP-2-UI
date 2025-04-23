using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    // Crear variables publicos de los componentes q queremos referenciar desde el script. EJ: Input, texto (para modificarlo) y botón.
    public TMP_InputField inputClave;
    public TMP_InputField inputUsername;
    public TextMeshProUGUI txtMensaje;

    string clave = "ELJUEGO";
    string username = "admTIC";
    
    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = "";
    }

    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inputClave.text;
        string usernameIngresado = inputUsername.text;

        if (claveIngresada != clave || usernameIngresado != username)
        {
            txtMensaje.text = "Acceso denegado";
            inputClave.text = "";
            inputUsername.text = "";
        }
        else
        {
            txtMensaje.text = "Le damos la bienvenida ";
        }
    }
}
