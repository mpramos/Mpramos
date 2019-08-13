using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public int SaludInicial=100;
    public int SaludActual;
    public Slider barraSlider;
    
    private void Awake(){
        SaludActual=SaludInicial;
    }
    public void TomaDaño(int valorDaño){
        SaludActual -=valorDaño;
        barraSlider.value=SaludActual;
        if(SaludActual<=0)
            Destroy(gameObject);
    }


}
