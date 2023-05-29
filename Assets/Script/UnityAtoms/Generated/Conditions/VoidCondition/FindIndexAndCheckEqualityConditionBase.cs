using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/Void/FindIndexAndCheckEqualityCondition", fileName = "FindIndexAndCheckEqualityCondition")]
    public class FindIndexAndCheckEqualityConditionBase<TElement, TList> : VoidCondition
        where TList : BaseAtomValueList
    {
        [SerializeField] IntVariable _instanceId;
        [SerializeField] IntValueList _instanceIdList;

        [SerializeField] TElement _value;
        [SerializeField] TList _valueList;

        public override bool Call()
        {
            int index = _instanceIdList.IndexOf(_instanceId.Value);
            return _valueList.IList[index].Equals(_value);
        }
    }
}