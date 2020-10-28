namespace entity.Models
{
    public class User
    {
        public int Id {get; set;}
        public string Name {get; set;} = "Kevin";
        public int Age {get; set;}=23;
        public SkillClass Skill { get; set; } = SkillClass.fullstack;
    }
} 
