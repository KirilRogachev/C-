using NUnit.Framework;
using Skeleton.Inter;
[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyLossesHealthAfterAttack()
    {
        ITargets dummy = new Dummy(10, 10);

        dummy.TakeAttack(7);

        Assert.That(dummy.Health, Is.EqualTo(3));
    }

    [Test]
    public void DeadDummyThrowsExceptionAfterAttack()
    {
        ITargets Dummy = new Dummy(0, 10);


        Assert.That(() => Dummy.TakeAttack(2), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }
    [Test]
    public void DeadDummyCanGiveExperience()
    {
        ITargets dummy = new Dummy(0, 10);

        var experience = dummy.GiveExperience();

        Assert.That(experience,Is.EqualTo(10));
    }
    [Test]
    public void AliveDummyCanNotGiveExperience()
    {
       
        ITargets dummy = new Dummy(10, 10);

        

        Assert.That(() => dummy.GiveExperience(), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is not dead."));
    }


}
