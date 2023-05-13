using UnityEngine;

namespace IvoKitchen
{
    using ARoute = AssetMenuRoute;
    [CreateAssetMenu(menuName = ARoute.ROOT + ARoute.ENUM + "Ingredient")]
    public class SOIngredient : SOEnumBase {}
}