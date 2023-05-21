using System;
using UnityEngine;
using IvoKitchen;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;IvoKitchen.SOIngredientPlace&gt;`. Inherits from `IPair&lt;IvoKitchen.SOIngredientPlace&gt;`.
    /// </summary>
    [Serializable]
    public struct SOIngredientPlacePair : IPair<IvoKitchen.SOIngredientPlace>
    {
        public IvoKitchen.SOIngredientPlace Item1 { get => _item1; set => _item1 = value; }
        public IvoKitchen.SOIngredientPlace Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private IvoKitchen.SOIngredientPlace _item1;
        [SerializeField]
        private IvoKitchen.SOIngredientPlace _item2;

        public void Deconstruct(out IvoKitchen.SOIngredientPlace item1, out IvoKitchen.SOIngredientPlace item2) { item1 = Item1; item2 = Item2; }
    }
}