using IvoKitchen;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    using ARoute = AssetMenuRoute;
    [CreateAssetMenu(menuName = "Unity Atoms/List Searcher/IngridientListFirstIndex")]
    public class IngridientListFirstIndex : ListSearcherBase
    {
        [SerializeField] SOIngredientValueList _list;
        [SerializeField] SOIngredient _value;

        public override int FindIndex()
        {
            return _list.IndexOf(_value);
        }
    }
}