using UnityEngine;
using UnityAtoms;
using IvoKitchen;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-sand")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/SOIngredient/EqualTo", fileName = "EqualTo")]
    public class SOIngredientCondEqualTo : SOIngredientCondition
    {
        public SOIngredient _equalTo;

        public override bool Call(SOIngredient ingredient)
        {
            return _equalTo == ingredient;
        }
    }
}