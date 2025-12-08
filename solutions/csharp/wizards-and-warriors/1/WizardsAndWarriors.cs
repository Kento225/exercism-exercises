abstract class Character
{
    private string CharacterType;
    protected bool Vulnerable_;

    protected Character(string characterType)
    {
        this.CharacterType = characterType;
        this.Vulnerable_ = false;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => Vulnerable_;

    public override string ToString() => $"Character is a {CharacterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
        base.Vulnerable_ = true;
    }

    public override int DamagePoints(Character target) => Vulnerable_ ? 3 : 12;

    public void PrepareSpell()
    {
        base.Vulnerable_ = false;
    }
}
