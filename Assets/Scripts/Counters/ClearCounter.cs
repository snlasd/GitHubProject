using System.Net.Http.Headers;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;


    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // g ada kitchen object
            if (player.HasKitchenObject()){
                // bawa item kan
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                // g bawa
            }
        }
        else // ni tempat dah di tempatin 
        {
            if (player.HasKitchenObject()) {

            }
            else
            {
                GetKitchenObject().SetKitchenObjectParent(player);
            }

        }
    }
}
