using UnityEngine;

namespace IvoKitchen.TransformComp
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.ROOT + CMRoute.TRANSFORM + "DestroyGameObject")]
    public class DestroyGameObject : MonoBehaviour
    {
        public void DestroyItSelf()
        {
            DestroyObject(this.gameObject);
        }
        
        public void DestroyObject(GameObject gameObject)
        {
            Destroy(gameObject);
        }
    }
}