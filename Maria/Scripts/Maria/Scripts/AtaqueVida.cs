using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueVida : MonoBehaviour
{
   public int dañoEnemigo=18;
   GameObject Mplayer;
   Vida playerVida;

    // Start is called before the first frame update
   private void Awake(){
       Mplayer=GameObject.FindGameObjectWithTag("Player");
       playerVida=Mplayer.GetComponent<Vida>();
        
   }
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player"))
        {
            playerVida.TomaDaño(dañoEnemigo);
        }
    }
}
