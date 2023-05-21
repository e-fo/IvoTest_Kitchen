using UnityEngine;

namespace IvoKitchen.TransformComp
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.ROOT + CMRoute.TRANSFORM + "SetParentByGameObject")]
    public class SetParentByGameobject : MonoBehaviour
    {
        [SerializeField] Vector3 _localPos;
        public void SetParent(GameObject go)
        {
            if(go != null) 
            {
                transform.SetParent(go.transform);
                transform.localPosition = _localPos;
            }
            else
            {
                Debug.LogWarning($"The gameobject parent is null");
            }
        }
    }
}