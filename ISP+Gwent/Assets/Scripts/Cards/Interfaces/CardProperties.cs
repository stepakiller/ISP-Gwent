public interface IRareCard { }
public interface ILeaderCard { void ApplyUltimate(); }
public interface IWeatherCard { void ApplyWeatherEffect(); }
public interface IHasPower 
{ 
    int PowerPoints { get; }
    void ApplyPower(); 
}
