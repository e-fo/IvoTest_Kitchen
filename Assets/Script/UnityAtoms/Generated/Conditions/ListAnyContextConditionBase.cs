using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    public class ListAnyContextConditionBase<T, TList> : AtomConditionWithContext where TList : BaseAtomValueList
    {
        [SerializeField] IntValueList _instanceIdList;
        [SerializeField] TList _valueList;
        [SerializeField] T _value;

        [SerializeField] bool _checkLowerSiblingIndciesBeFalse;

        public override bool Call(GameObject context)
        {
            int contextIdx = _instanceIdList.IndexOf(context.GetInstanceID());
            bool ret = _valueList.IList[contextIdx].Equals(_value);

            if(_checkLowerSiblingIndciesBeFalse)
            {
                for(int i=_instanceIdList.Count-1; i>=0; i--) 
                {
                    int siblingIndex = InstanceId.FindObject(_instanceIdList[i]).transform.GetSiblingIndex();
                    bool hasHigherSiblingIndex = siblingIndex > context.transform.GetSiblingIndex();
                    if(i == contextIdx || hasHigherSiblingIndex) continue;

                    ret = (_valueList.IList[i].Equals(_value))?false:ret;
                }
            }

            return ret;
        }
    }
}