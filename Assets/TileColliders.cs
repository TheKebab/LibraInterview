using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileColliders : MonoBehaviour

{
    public Tile counting;

    


 
    
    


   


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        counting.count++;
        if(counting.count == 3) {

            
        }
        
    }
}
