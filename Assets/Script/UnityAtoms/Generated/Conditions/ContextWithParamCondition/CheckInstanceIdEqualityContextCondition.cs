using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/With Context And Param/CheckInstanceIdEqualityContextCondition", 
        fileName = "CheckInstanceIdEqualityContextCondition")]
    public class CheckInstanceIdEqualityContextCondition : AtomConditionWithContext<int>
    {
        public override bool Call(GameObject context, int t)
        {
            return t == context.GetInstanceID();
        }
    }
}