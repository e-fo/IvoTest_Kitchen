using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/Void/IntEqualTo", fileName = "IntEqualTo")]
    public class IntVariableEqualCondition : VoidCondition
    {
        [SerializeField] int _value;
        [SerializeField] IntVariable _variable;
        public override bool Call()
        {
            return _variable.Value == _value;
        }
    }
}