public class NYDog : NYPets
    {
        
        public string location;

        public NYDog()
        {
            
        }

        public NYDog(float age, string name, string hobbies,string location) : base(age, name, hobbies)
        {
            this.location = location;
        }

        public override string GetRecord()
        {
            string record = base.GetRecord();
            return record + ", " + this.location;
        }
      
    }
