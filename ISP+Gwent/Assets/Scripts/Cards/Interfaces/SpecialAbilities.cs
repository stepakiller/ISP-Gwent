public enum SpecialAbilityType { Horn, Scorch, Fog, Spy, MoraleBoost, None }
public interface IHasSpecialAbility 
{ 
    SpecialAbilityType AbilityType { get; }
    void ApplySpecialAbility(); 
}
public interface ISpy { void ApplySpyEffect(); }
public interface IMedic { void Revive(); }
public interface IConnection { void Connect(); }
public interface IPretence { }
public interface ITwin { }
public interface IStrengthSurge { void Surge(); }
public interface IExecution { void Execute(); }
public interface IBerserk { }
public interface IMardrem { }
public interface IAvengerCall { }