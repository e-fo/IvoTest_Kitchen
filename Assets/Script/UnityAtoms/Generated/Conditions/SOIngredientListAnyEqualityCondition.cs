using UnityEngine;
using IvoKitchen;
using System.Linq;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/Void/IngridientListEqualTo", fileName = "ListEqualTo")]
    public class SOIngredientListAnyEqualityCondition : VoidCondition
    {
        [SerializeField] SOIngredientValueList _list;
        [SerializeField] SOIngredient _value;

        public override bool Call()
        {
            return _list.Any(x=> x == _value);
        }
    }
}
