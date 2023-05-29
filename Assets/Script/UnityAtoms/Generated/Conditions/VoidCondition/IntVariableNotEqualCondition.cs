using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/Void/IntNotEqualTo", fileName = "IntNotEqualTo")]
    public class IntVariableNotEqualCondition : VoidCondition
    {
        [SerializeField] int _value;
        [SerializeField] IntVariable _variable;
        public override bool Call()
        {
            return _variable.Value != _value;
        }
    }
}