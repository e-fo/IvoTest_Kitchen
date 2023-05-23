using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/Void/BoolEqualTo", fileName = "EqualTo")]
    public class BoolVariableEqualityCondition : VoidCondition
    {
        [SerializeField] bool _value;
        [SerializeField] BoolVariable _variable;
        public override bool Call()
        {
            return _variable.Value == _value;
        }
    }
}