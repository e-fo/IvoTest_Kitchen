using System;
using UnityEngine;
using System.Collections.Generic;

namespace UnityAtoms.BaseAtoms
{
    [Serializable]
    public class ListValuePair<T, TElem> where T: BaseAtomValueList
    {
        public TElem Value;
        public T List;
    }

    public abstract class ListInitializerBase<T,TElem> : MonoBehaviour where T : BaseAtomValueList
    {
        [SerializeField] protected bool _removeComponentAfterInit;

        [Header("Initialize State")]
        [SerializeField] protected bool _initOnAwake;
        [SerializeField] protected bool _initOnStart;
        [SerializeField] protected bool _initOnEnable;

        [Header("Deinitialize State")]
        [SerializeField] protected bool _removeOnDestroy;
        [SerializeField] protected bool _removeOnDisable;


        [SerializeField] protected IntValueList _keyList;

        [SerializeField] protected List<ListValuePair<T,TElem>> _valueList;

        void Awake()        { if(_initOnAwake)      AddToList(); if(_removeComponentAfterInit) Destroy(this);}
        void Start()        { if(_initOnStart)      AddToList(); if(_removeComponentAfterInit) Destroy(this);}
        void OnEnable()     { if(_initOnEnable)     AddToList(); if(_removeComponentAfterInit) Destroy(this);}
        void OnDisable()    { if(_removeOnDisable)  RemoveFromList(_keyList.IndexOf(this.gameObject.GetInstanceID())); }
        void OnDestroy()    { if(_removeOnDestroy)  RemoveFromList(_keyList.IndexOf(this.gameObject.GetInstanceID())); }

        protected virtual void AddToList()
        {
            _keyList.Add(this.gameObject.GetInstanceID());
            int c = _valueList.Count;

            for(int i=c-1; i>=0; i--) 
            {
                _valueList[i].List.IList.Add(_valueList[i].Value);
            }
        }

        protected virtual void RemoveFromList(int index)
        {
            int c = _valueList.Count;
            for(int i=c-1; i>=0; i--) 
            {
                _valueList[i].List.IList.RemoveAt(index);
            }
        }
    }
}