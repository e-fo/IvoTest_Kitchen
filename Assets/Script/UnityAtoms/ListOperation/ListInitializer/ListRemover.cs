using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    public class ListRemover : MonoBehaviour
    {
        [SerializeField] IntValueList _keyList;
        [SerializeField] BaseAtomValueList[] _valueLists;

        [Header("Remove Time")]
        [SerializeField] protected bool _removeOnDestroy;
        [SerializeField] protected bool _removeOnDisable;


        void OnDisable()    { if(_removeOnDisable)  RemoveFromList(); }
        void OnDestroy()    { if(_removeOnDestroy)  RemoveFromList(); }

        protected virtual void RemoveFromList()
        {
            int l = _valueLists.Length;
            int idx = _keyList.IndexOf(this.gameObject.GetInstanceID());

            for(int i=l-1; i>=0; i--) 
            {
                _valueLists[i].IList.RemoveAt(idx);
            }
            _keyList.IList.RemoveAt(idx);
        }
    }
}
