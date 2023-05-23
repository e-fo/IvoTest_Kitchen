using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    public class ListSetterBase<T, TList> : MonoBehaviour where TList : BaseAtomValueList
    {
        private T _value;
        private TList _list;
        [SerializeField] IntValueList _instanceIdList;

        public void SetElementValue(T value) => _value = value;
        public void SetList(TList list) => _list = list;

        public void ApplyOnList(int index)
        {
            _list.IList[index] = _value;
            _value = default;
            _list = null;
        }

        public void ApplyOnListByListSearcher(ListSearcherBase searcher)
        {
            _list.IList[searcher.FindIndex()] = _value;
            _value = default;
            _list = null;
        }

        public void ApplyOnListByInstanceId()
        {
            int index = _instanceIdList.IndexOf(this.gameObject.GetInstanceID());
            _list.IList[index] = _value;
            _value = default;
            _list = null;
        }
    }
}