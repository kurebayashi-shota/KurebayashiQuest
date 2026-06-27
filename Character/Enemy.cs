namespace KurebayashiQuest;
class Enemy : Character
{
    public Enemy(string name)
    {
        Level = ParameterSetting.EnemyLevel;
        Exp = ParameterSetting.EnemyExp;
        Health = ParameterSetting.EnemyHealth;
        Attack = ParameterSetting.EnemyAttack;
    }
}