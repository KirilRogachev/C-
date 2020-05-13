using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Inter
{
 public interface IWeapon
    {
         int AttackPoints { get; }

         int DurabilityPoints { get; }

        void Attack(ITargets target);
    }
}
