using Lean.Pool;
using NodeCanvas.Framework;
using UnityEngine;

namespace scg
{
    public class LeanSpawn<T> : ActionTask where T : Component
    {
        public BBParameter<T> prefab;
        public BBParameter<T> spawnedItem;

        protected override void OnExecute()
        {
            spawnedItem.value = LeanPool.Spawn(prefab.value);
            EndAction(true);
        }

    }

    public class LeanSpawnParent<T> : ActionTask where T : Component
    {
        public BBParameter<T> prefab;
        public BBParameter<T> spawnedItem;
        public BBParameter<Transform> parent;

        protected override void OnExecute()
        {
            spawnedItem.value = LeanPool.Spawn(prefab.value, parent.value);
            EndAction(true);
        }

    }

}
