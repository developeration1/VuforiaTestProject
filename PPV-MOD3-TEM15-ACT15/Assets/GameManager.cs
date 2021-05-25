using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject house1, house2, house3;

    public void Button1()
    {
        house1.SetActive(!house1.activeSelf);
    }

    public void Button2()
    {
        house2.SetActive(!house2.activeSelf);
    }

    public void Button3()
    {
        house3.SetActive(!house3.activeSelf);
    }
}
