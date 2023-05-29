using UnityEngine;

namespace IvoKitchen
{
    using ARoute = AssetMenuRoute;
    [CreateAssetMenu(menuName = ARoute.ROOT + ARoute.ENUM + "IngredientState")]
    public class SOIngredientState : SOEnumBase {}
}