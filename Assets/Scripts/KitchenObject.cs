using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private ClearCounter clearCounter;

    public KitchenObjectSO GetKitchenObjectSO()
    {
        return kitchenObjectSO;
    }

    public void SetClearCounter(ClearCounter clearCounter)
    {
        //REMOVE KitchenObject from old parent
        if(this.clearCounter != null)
        this.clearCounter.ClearKitchenObject();
        
        //Update the KitchenObject to the new one
        this.clearCounter = clearCounter;
        clearCounter.SetKitchenObject(this);

        //Update the visual transform of the KitchenObject
        transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }
    public ClearCounter GetClearCounter()
    {
        return clearCounter;
    }
}
