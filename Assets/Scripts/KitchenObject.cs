using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private IKitchenObjectParent kitenObjectParent;

    public KitchenObjectSO GetKitchenObjectSO() { 
        return kitchenObjectSO; 
    }
    public void SetKitchenObjectParent(IKitchenObjectParent kitenObjectParent)
    {
        if (this.kitenObjectParent != null) { 
            this.kitenObjectParent.ClearKitchenObject();
        }

        this.kitenObjectParent = kitenObjectParent;

        if (kitenObjectParent.HasKitchenObject())
        {
            Debug.LogError("this");
        }
        kitenObjectParent.SetKitchenObject(this);

        transform.parent = kitenObjectParent.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero; 
    }

    public IKitchenObjectParent GetkitenObjectParent()
    {
        return kitenObjectParent;
    }

}
