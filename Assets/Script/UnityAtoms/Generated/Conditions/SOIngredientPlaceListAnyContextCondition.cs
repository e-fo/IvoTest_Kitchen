using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/With Context/SOIngredientPlace List Any Context Condition", fileName = "EqualTo")]
    public class SOIngredientPlaceListAnyContextCondition : AtomConditionWithContext
    {
        [SerializeField] IntValueList _instanceIdList;
        [SerializeField] SOIngredientPlaceValueList _valueList;
        [SerializeField] SOIngredientPlace _value;

        public override bool Call(GameObject context)
        {
            int index = _instanceIdList.IndexOf(context.GetInstanceID());
            return _valueList[index] == _value;
        }
    }
}