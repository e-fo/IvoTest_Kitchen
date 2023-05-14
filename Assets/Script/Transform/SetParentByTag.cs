using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;

namespace IvoKitchen.TransformComp
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.ROOT + CMRoute.TRANSFORM + "SetParentByTag")]
    public class SetParentByTag : MonoBehaviour
    {
        [SerializeField] Vector3 _localPos;
        public void SetParent(StringConstant tag)
        {
            var go = AtomTags.FindByTag(tag.Value);
            if(go != null) 
            {
                transform.SetParent(go.transform);
                transform.localPosition = _localPos;
            }
            else
            {
                Debug.LogWarning($"Can't find object with tag {tag.Value}");
            }
        }
    }
}