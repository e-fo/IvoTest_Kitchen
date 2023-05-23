using IvoKitchen;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/Void/IngridientPlaceEqualTo", fileName = "EqualTo")]
    public class SOIngredientPlaceVariableEqualityCondition : VoidCondition
    {
        [SerializeField] SOIngredientPlace _value;
        [SerializeField] SOIngredientPlaceVariable _variable;
        [SerializeField] bool _contradictory;
        public override bool Call()
        {
            bool ret = (_contradictory) ? !(_variable.Value == _value) : (_variable.Value == _value);
            return ret;
        }
    }
}