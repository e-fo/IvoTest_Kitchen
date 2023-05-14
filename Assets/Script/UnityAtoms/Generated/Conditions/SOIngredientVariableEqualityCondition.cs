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
        [SerializeField] bool _contradictory;
        public override bool Call()
        {
            bool ret = (_contradictory) ? !(_variable.Value == _value) : (_variable.Value == _value);
            return ret;
        }
    }
}