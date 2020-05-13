using NUnit.Framework;
using Skeleton.Inter;
[TestFixture]
public class AxeTests
{
    [Test]

    public void AxeLoosesDurabillityAfterAttack()
    {
        IWeapon axe = new Axe(10, 10);
        ITargets dummy = new Dummy(10, 10);

        axe.Attack(dummy);

        Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability dosen't change after attack.");
    }
    
    [Test]
    public void AttackWithABrockenWeapon()
    {
        IWeapon axe = new Axe(10, 0);
        ITargets dummy = new Dummy(10, 10);

        Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Weapon is broken."));

    }
}
