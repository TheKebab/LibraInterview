
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Tile : MonoBehaviour
{

    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    [SerializeField] public GameObject _xMark;

    public bool isMarked = false;

    public int count = 0;


    public List<GameObject> markedOnes;


    public void Init(bool isOffset)
    {
        _renderer.color = isOffset ? Color.gray : Color.black;
    }



    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }


    void OnMouseDown()
    {

        _xMark.SetActive(true);
        isMarked = true;
        count++;
       
        Debug.Log(count);







    }



}






    


    




   

