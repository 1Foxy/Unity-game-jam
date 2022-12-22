using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TreeManager : MonoBehaviour
{
    public float treeHealth = 10f;
    public float newHealth;
    [SerializeField] Image foreground = null;

    public void Start()
    {
        //StartCoroutine(UpdateHealth());
    }

    //private IEnumerator UpdateHealth()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(2);
    //        if (treeHealth < 10)
    //        {
                
    //            newHealth += 0.2f;
    //            foreground.fillAmount += newHealth / 10;
    //            newHealth += treeHealth;
                
    //        }
    //    }
    //}

    public void ChopTree(float damage)
    {
        treeHealth -= damage;

        foreground.fillAmount = treeHealth / 10f;

        if (treeHealth <= 0f)
        {
            GameObject obj = GameObject.Find("Moneyyy");
            COINS Script = obj.GetComponent<COINS>();
            Script.Add();
            Destroy(gameObject);     
        }
        
        
    }

}