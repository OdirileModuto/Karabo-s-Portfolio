namespace KaraboPortfolio.Models
{
    public class SkillCategory
    {
        public string Name { get; set; } = "";
        public List<string> Items { get; set; } = new();
    }

    public class Project
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> Tech { get; set; } = new();
        public List<string> Highlights { get; set; } = new();
        public string? Architecture { get; set; }
        public string DemoUrl { get; set; } = "#";
        public string CodeUrl { get; set; } = "#";
    }

    public class ExperienceItem
    {
        public string Role { get; set; } = "";
        public string Company { get; set; } = "";
        public string Period { get; set; } = "";
        public List<string> Responsibilities { get; set; } = new();
        public bool Expanded { get; set; } = true;
    }

    public class Achievement
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Icon { get; set; } = "";
    }

    public class CareerStage
    {
        public string Label { get; set; } = "";
    }

    public class Certification
    {
        public string Name { get; set; } = "";
    }

    public class EducationItem
    {
        public string Qualification { get; set; } = "";
        public string Institution { get; set; } = "";
        public string Year { get; set; } = "";
    }

    public class PortfolioViewModel
    {
        public string FullName { get; set; } = "Karabo Moduto";
        public string Title { get; set; } = "Full Stack & Integration Developer";
        public string Location { get; set; } = "Midrand, Gauteng, South Africa";
        public string Email { get; set; } = "ko.moduto@gmail.com";
        public string Phone { get; set; } = "076 433 1211";

        public List<SkillCategory> SkillCategories { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
        public List<ExperienceItem> Experience { get; set; } = new();
        public List<Achievement> Achievements { get; set; } = new();
        public List<CareerStage> CareerJourney { get; set; } = new();
        public List<Certification> Certifications { get; set; } = new();
        public List<EducationItem> Education { get; set; } = new();
    }
}
