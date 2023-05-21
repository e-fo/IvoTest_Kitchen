using IvoKitchen;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [AddComponentMenu("Unity Atoms/List Operation/ListSetter")]
    public class ListSetter : MonoBehaviour
    {
        private SOIngredient _value;
        private SOIngredientValueList _list;

        public void SetElementValue(SOIngredient value) => _value = value;
        public void SetList(SOIngredientValueList list) => _list = list;

        public void ApplyOnList(int index)
        {
            _list[index] = _value;
            _value = null;
            _list = null;
        }

        public void ApplyOnListByListSearcher(ListSearcherBase searcher)
        {
            _list[searcher.FindIndex()] = _value;
            _value = null;
            _list = null;
        }

        public void ApplyOnListByInstanceId(IntValueList instanceIdList)
        {
            int index = instanceIdList.IndexOf(this.gameObject.GetInstanceID());
            _list[index] = _value;
            _value = null;
            _list = null;
        }
    }
}