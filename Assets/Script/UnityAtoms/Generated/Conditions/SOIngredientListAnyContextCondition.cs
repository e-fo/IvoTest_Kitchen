using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/With Context/SOIngredient List Any Context Condition", fileName = "EqualTo")]
    public class SOIngredientListAnyContextCondition : ListAnyContextConditionBase<SOIngredient, SOIngredientValueList>{}
}