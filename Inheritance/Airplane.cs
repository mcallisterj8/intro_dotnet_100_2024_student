public class Airplane : Vehicle {
    public string Airline { get; private set;}
    public int MaxAltitude { get; private set;}    
    public int NumEngines { get; set;}
    
    // public Airplane(){}
    public Airplane(string airline, int maxAltitude, int numEngines) {
        this.Airline = airline;
        this.MaxAltitude = maxAltitude;
        this.NumEngines = numEngines;
        Console.WriteLine("Airplane constuctor!");
    }

    public Airplane(string airline, int maxAltitude, int numEngines, string name) 
    : base(name) {
        this.Airline = airline;
        this.MaxAltitude = maxAltitude;
        this.NumEngines = numEngines;
        Console.WriteLine("Airplane constuctor!");
    }
        
    public override void Drive() {
        Console.WriteLine("Airplane is flying");
    }
        
    public override void Stop() {
        Console.WriteLine("Airplane is landing");
    }
    
    public void DeployLandingGear() {
        Console.WriteLine("Deploying landing gear");
    }
    
    protected void EngineCheck() {
        Console.WriteLine("Checking " + this.NumEngines + " engines");
    }

}