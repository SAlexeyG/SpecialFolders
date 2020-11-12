using System.Collections;
using System.Collections.Generic;
using CartoonHeroes;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    [SerializeField] private Transform prefabRoot;
    private GameObject obj;

    public void LoadMale()
    {
        var prefab = Resources.Load<GameObject>($"Prafabs/Male A");
        if (obj != null) Destroy(obj);
        obj = Instantiate(prefab, prefabRoot);
    }

    public void LoadFemale()
    {
        var prefab = Resources.Load<GameObject>($"Prafabs/Female A");
        if (obj != null) Destroy(obj);
        obj = Instantiate(prefab, prefabRoot);
    }
}
