using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Inter
{
    public interface IHeros
    {
        string Name { get; }

        int Experience { get; }

        Axe Weapon { get; }

        void Attack(ITargets target);
        
    }
}
