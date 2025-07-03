using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public Isopod isopod;

    public IsopodManagerScript managerScript;

    public void Buy()
    {
        managerScript.CreateIsopods(isopod);
    }
     

    
}
