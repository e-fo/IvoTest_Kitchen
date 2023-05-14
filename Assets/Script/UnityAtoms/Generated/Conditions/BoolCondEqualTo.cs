using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-sand")]
    [CreateAssetMenu(menuName = "Unity Atoms/Conditions/Bool/EqualTo", fileName = "EqualTo")]
    public class BoolCondEqualTo : BoolCondition
    {
        [SerializeField] bool _equalTo;

        public override bool Call(bool value)
        {
            return _equalTo == value;
        }
    }
}
