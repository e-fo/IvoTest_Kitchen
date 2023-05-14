using IvoKitchen;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-sand")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/Void/IngridientEqualTo", fileName = "EqualTo")]
    public class SOIngredientVariableEqualityCondition : VoidCondition
    {
        [SerializeField] SOIngredient _value;
        [SerializeField] SOIngredientVariable _variable;
        public override bool Call()
        {
            return _variable.Value == _value;
        }
    }
}