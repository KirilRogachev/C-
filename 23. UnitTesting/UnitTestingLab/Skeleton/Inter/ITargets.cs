namespace Skeleton.Inter
{

  public  interface ITargets
    {
       int Health { get; }

       void TakeAttack(int attackPoints);

        int GiveExperience();

        bool IsDead();
    }
}
