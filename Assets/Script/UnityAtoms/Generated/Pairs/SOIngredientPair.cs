using System;
using UnityEngine;
using IvoKitchen;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;IvoKitchen.SOIngredient&gt;`. Inherits from `IPair&lt;IvoKitchen.SOIngredient&gt;`.
    /// </summary>
    [Serializable]
    public struct SOIngredientPair : IPair<IvoKitchen.SOIngredient>
    {
        public IvoKitchen.SOIngredient Item1 { get => _item1; set => _item1 = value; }
        public IvoKitchen.SOIngredient Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private IvoKitchen.SOIngredient _item1;
        [SerializeField]
        private IvoKitchen.SOIngredient _item2;

        public void Deconstruct(out IvoKitchen.SOIngredient item1, out IvoKitchen.SOIngredient item2) { item1 = Item1; item2 = Item2; }
    }
}