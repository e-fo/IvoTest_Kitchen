using UnityAtoms;
using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/With Context/SOIngredientPlace List Any Context Condition", fileName = "EqualTo")]
    public class SOIngredientPlaceListAnyContextCondition : AtomConditionWithContext
    {
        [SerializeField] GameObjectValueList _idList;
        [SerializeField] SOIngredientPlaceValueList _valueList;
        [SerializeField] SOIngredientPlace _value;

        public override bool Call(GameObject context)
        {
            int index = _idList.IndexOf(context);
            
            return _valueList == _value;
        }
    }
}