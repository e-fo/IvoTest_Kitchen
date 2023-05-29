using System;
using UnityEngine;
using IvoKitchen;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;IvoKitchen.SOIngredientState&gt;`. Inherits from `IPair&lt;IvoKitchen.SOIngredientState&gt;`.
    /// </summary>
    [Serializable]
    public struct SOIngredientStatePair : IPair<IvoKitchen.SOIngredientState>
    {
        public IvoKitchen.SOIngredientState Item1 { get => _item1; set => _item1 = value; }
        public IvoKitchen.SOIngredientState Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private IvoKitchen.SOIngredientState _item1;
        [SerializeField]
        private IvoKitchen.SOIngredientState _item2;

        public void Deconstruct(out IvoKitchen.SOIngredientState item1, out IvoKitchen.SOIngredientState item2) { item1 = Item1; item2 = Item2; }
    }
}