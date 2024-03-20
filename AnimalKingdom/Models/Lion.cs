public class Lion : Animal {
    public override List<string> SuitableHabitats { get; set; }
    public Lion(string name, List<string> habitatList): base(name) {
        this.SuitableHabitats = new List<string>();
        // this.SuitableHabitats = habitatList; // do not do this.
        foreach(string habitat in habitatList) {
            this.SuitableHabitats.Add(habitat);
        }
    }
    public override bool Eat(string food) {
        
        return false;
    }

    public override bool IsHabitatSuitable(string habitat) {
        
        return false;
    }
}