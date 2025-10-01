using UnityEngine;
using System;

public class TrashCounter : BaseCounter
{

    public static event EventHandler OnAnyObjectTrashed;
   public override void Interact(Player player)
    {
        if (player.HasKitchenObject())
        {
            //Player is carrying something
            player.GetKitchenObject().DestroySelf();

            OnAnyObjectTrashed?.Invoke(this, EventArgs.Empty);
        }
    }
}
