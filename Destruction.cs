using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public GameObject DestructPrefub; //Префаб разрушеного объекта
    public GameObject ParticlePrefub; //префаб частиц разрушения

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
        Instantiate(DestructPerfub, transform.position, transform.rotation); //создаем разрушенный объект на сцене
        Instantiate(ParticlePerfub, transform.position, transform.rotation); //создаем частицы на сцене
        Destroy(gameObject); //удаляем текущий объект
        }
    }
}
