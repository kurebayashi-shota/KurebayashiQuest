namespace KurebayashiQuest;
class Player : Character
{
    public Player(string name)
    {
        Name = name;
        Level = ParameterSetting.PlayerLevel;
        Exp = ParameterSetting.PlayerExp;
        Health = ParameterSetting.PlayerHealth;
        Attack = ParameterSetting.PlayerAttack;
    }
}