
public class NYPets
    {
        
        public float age;
        public string name;
        public string hobbies;
        

        public NYPets()
        {
            
        }
        
        public NYPets( float age, string name, string hobbies)
        {
            this.age = age;
            this.name = name;
            this.hobbies = hobbies;
        }

        public virtual string GetRecord()
        {
            string record = "NYPets: " + this.age.ToString() + ", " + this.name + ", " + this.hobbies;
            return record;
        }
    }
