using IvoKitchen;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/Void/SOIngredientStateFindAndCheckElement", fileName = "SOIngredientStateFindAndCheckElement")]
    public class SOIngredientStateFindAndCheckElement : 
        FindIndexAndCheckEqualityConditionBase<SOIngredientState, SOIngredientStateValueList> {}
}