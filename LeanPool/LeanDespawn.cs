using Lean.Pool;
using ParadoxNotion.Design;
using UnityEngine;

namespace scg
{
    public class LeanDespawn<T> : ActionTask where T : Component
    {

        public BBParameter<T> clone;

        protected override void OnExecute()
        {
            LeanPool.Despawn(clone.value);
            EndAction(true);
        }
    }
}
