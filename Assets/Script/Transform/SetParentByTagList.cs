using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;

namespace IvoKitchen.TransformComp
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.ROOT + CMRoute.TRANSFORM + "SetParentByTagList")]
    public class SetParentByTagList : MonoBehaviour
    {
        [SerializeField] Vector3 _localPos;
        [SerializeField] AtomList _atomList;

        public void SetParent(ListSearcherBase searcher)
        {
            var tag = _atomList.Value.Get<StringConstant>(searcher.FindIndex());
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