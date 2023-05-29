using IvoKitchen;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/Void/SOIngredientPlaceFindAndCheckElement", fileName = "SOIngredientPlaceFindAndCheckElement")]
    public class SOIngredientPlaceFindAndCheckElement : 
        FindIndexAndCheckEqualityConditionBase<SOIngredientPlace, SOIngredientValueList> {}
}
