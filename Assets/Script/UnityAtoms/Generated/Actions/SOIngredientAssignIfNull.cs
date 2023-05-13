namespace UnityAtoms.BaseAtoms
{
    using UnityEngine;
    using IvoKitchen;

    [CreateAssetMenu(menuName = "Unity Atoms/Actions/SOIngredient/AssignIfNull")]
    public class SOIngredientAssignIfNull : SOIngredientAction
    {
        [SerializeField] SOIngredientVariable _variable;

        public override void Do(SOIngredient ingredient)
        {
            if(_variable.Value == null) _variable.Value = ingredient;
        }
    }
}