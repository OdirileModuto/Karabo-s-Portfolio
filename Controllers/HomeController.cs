using Microsoft.AspNetCore.Mvc;
using KaraboPortfolio.Models;
using System.Diagnostics;

namespace KaraboPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // In a real deployment this data would likely move to a JSON file,
        // database, or CMS. Keeping it here for now makes it a single
        // place to edit project/experience content.
        public IActionResult Index()
        {
            var model = new PortfolioViewModel
            {
                SkillCategories = new List<SkillCategory>
                {
                    new() { Name = "Backend", Items = new() { "Python", "FastAPI", "Django", "Node.js", "Java", "C#", ".NET" } },
                    new() { Name = "Frontend", Items = new() { "React.js", "Angular", "JavaScript", "HTML", "CSS" } },
                    new() { Name = "Databases", Items = new() { "PostgreSQL", "MySQL", "SQL" } },
                    new() { Name = "Cloud", Items = new() { "AWS", "Azure", "Firebase" } },
                    new() { Name = "DevOps", Items = new() { "Docker", "CI/CD", "Deployment Workflows", "Git" } },
                    new() { Name = "Integration", Items = new() { "REST APIs", "Webhooks", "OAuth 2.0", "JWT", "Microsoft Graph API", "WhatsApp Cloud API" } },
                    new() { Name = "Other", Items = new() { "Power BI", "Power Apps", "Microsoft 365", "AI / RAG Concepts" } },
                },

                Projects = new List<Project>
                {
                    new() {
                        Title = "Inventory Management System",
                        Description = "A C#/.NET Core inventory management application implementing CRUD operations and LINQ for efficient data management.",
                        Tech = new() { "C#", ".NET Core", "MS SQL", "LINQ", "CRUD" },
                        Highlights = new() { "Inventory management", "CRUD operations", "Database integration", "Search and data management", "Business logic", ".NET backend architecture" },
                        DemoUrl = "#", CodeUrl = "#"
                    },
                    new() {
                        Title = "FastAPI Lead Capture System",
                        Description = "A lead capture platform that collects customer information through a web interface and processes it through a backend API.",
                        Tech = new() { "Python", "FastAPI", "PostgreSQL", "REST API", "HTML/CSS/JavaScript" },
                        Highlights = new() { "REST API", "Database integration", "Lead capture", "Automated processing", "Backend validation", "API integration" },
                        Architecture = "User -> Web Form -> FastAPI -> PostgreSQL -> Notification / Processing",
                        DemoUrl = "#", CodeUrl = "#"
                    },
                    new() {
                        Title = "Enterprise API & Integration Platform",
                        Description = "Enterprise integrations connecting business applications with external communication and productivity platforms.",
                        Tech = new() { "Python", "REST APIs", "PostgreSQL", "WhatsApp Cloud API", "Microsoft Graph API" },
                        Highlights = new() { "WhatsApp Cloud API integration", "Microsoft Graph API integration", "PostgreSQL", "API authentication", "Data processing", "Automation" },
                        Architecture = "Business System -> API Layer -> Integration Services -> External Platforms",
                        DemoUrl = "#", CodeUrl = "#"
                    },
                    new() {
                        Title = "HR Automation Tools",
                        Description = "Automation tools for HR notifications and repetitive business processes, reducing manual intervention and improving operational efficiency.",
                        Tech = new() { "Python", "Automation", "APIs", "Email/Notifications" },
                        Highlights = new() { "Process automation", "Notifications", "Scheduled workflows", "Data processing", "Operational efficiency" },
                        DemoUrl = "#", CodeUrl = "#"
                    },

                    new() {
                        Title = "Power BI Dashboards & Reports",
                        Description = "Interactive dashboards and reports for business intelligence, providing insights into key metrics and performance indicators.",
                        Tech = new() { "Power BI", "Data Visualization", "Business Intelligence" },
                        Highlights = new() { "Data visualization", "Interactive dashboards", "Performance metrics", "Business insights", "Report generation" },
                        DemoUrl = "#", CodeUrl = "#"
                    },

                    new() {
                        Title = "Microsoft 365 Productivity Solutions",
                        Description = "Custom solutions leveraging Microsoft 365 tools to enhance productivity and streamline business processes.",
                        Tech = new() { "Microsoft 365", "Power Apps", "Power Automate", "SharePoint" },
                        Highlights = new() { "Productivity enhancement", "Process automation", "Custom applications", "Collaboration tools", "Workflow optimization" },
                        DemoUrl = "#", CodeUrl = "#"
                    },


                },

                Experience = new List<ExperienceItem>
                {
                    new() {
                        Role = "Integration Developer", Company = "Kato Connect Solutions", Period = "Feb 2026 - Present",
                        Responsibilities = new() {
                            "Design, develop, test and maintain enterprise web applications",
                            "Build backend services, APIs and microservices",
                            "Develop responsive frontend applications",
                            "Integrate third-party systems using REST APIs, webhooks, OAuth 2.0 and JWT",
                            "Optimise relational databases and SQL queries",
                            "Develop containerised applications",
                            "Support CI/CD pipelines",
                            "Collaborate with cross-functional teams",
                            "Participate in code reviews",
                        }
                    },
                    new() {
                        Role = "Full Stack Developer", Company = "CDA Solutions", Period = "Mar 2023 - Nov 2025",
                        Responsibilities = new() {
                            "Designed and implemented RESTful APIs and backend services",
                            "Automated data flows and reporting using SQL and Python",
                            "Improved efficiency by 40% through automation",
                            "Collaborated with frontend teams",
                            "Developed ETL processes",
                            "Optimised database performance",
                            "Built WhatsApp Cloud API integrations",
                            "Built Microsoft Graph API integrations",
                        }
                    },
                    new() {
                        Role = "Software Support Engineer", Company = "Busani Solutions", Period = "Dec 2021 - Mar 2023",
                        Responsibilities = new() {
                            "Provided 3rd and 4th level software support",
                            "Managed database installations and migrations",
                            "Supported cloud environments",
                            "Administered SFTP servers",
                            "Automated data transfers",
                            "Collaborated with developers to resolve software defects",
                        }
                    },
                    new() { Role = "IT Support Specialist", Company = "Digicall Solutions", Period = "Jun 2017 - Aug 2021",
                            Responsibilities = new() {
                         "Provided end-user and infrastructure support across enterprise environments.",
                         "Maintained IT infrastructure and ensured system availability.",
                         "Assisted in the deployment and configuration of software and hardware.",
                         "Provided end-user training and support documentation.",
                         "Ensured compliance with IT policies and best practices.",
                         "Monitored and maintained system performance and security.",
                         "Troubleshot and resolved technical issues in a timely manner.",
                         "Collaborated with cross-functional teams to implement IT solutions.",
                         "Provided timely updates and reports to management on IT operations.",
                         "Maintained inventory of IT assets and managed procurement processes.",
                         "Provided support for network and server infrastructure.",
                         
                         
                          }, },

                    new() { Role = "Senior Desktop Engineer", Company = "QIM Solutions", Period = "Jul 2014 - Jun 2017",
                            Responsibilities = new() {
                                 "Led desktop engineering and technical support operations.",
                                 "Managed and maintained desktop infrastructure and systems.",
                                 "Provided advanced troubleshooting and technical guidance to team members.",
                                 "Coordinated with other IT teams to ensure seamless desktop support operations.",
                                 "Implemented and maintained desktop support policies and procedures.",
                                 "Provided training and support to end-users on desktop systems and applications.",
                                 "Ensured compliance with IT policies and best practices."
                                 
                        }, },

                    new() { Role = "Support & Operations Assistant", Company = "Sanitech", Period = "Nov 2012 - Nov 2014",
                            Responsibilities = new() {
                                 "Supported day-to-day operations and technical administration.",
                                 "Assisted in the implementation of operational improvements.",
                                 "Provided support for various operational and technical tasks.",
                                 "Collaborated with team members to streamline operational processes.",
                                 "Ensured compliance with company policies and procedures.",
                                 "Assisted in the preparation of operational reports and documentation.",
                                 "Provided general administrative support to the operations team."


                                  }, },

                    new() { Role = "Web Administrator", Company = "KPT Marketing Solutions", Period = "Nov 2010 - Apr 2012",
                            Responsibilities = new() {
                                 "Maintained and administered company web properties.",
                                 "Optimized website performance and ensured security compliance.",
                                 "Managed content updates and ensured website functionality.",
                                 "Monitored website analytics and performance metrics.",
                                 "Troubleshot and resolved website issues to ensure optimal performance.",
                                 "Collaborated with cross-functional teams to implement website improvements.",
                                 "Provided training and support to team members on website management best practices.",
                                 "Ensured website accessibility and compliance with industry standards.",
                                 "Implemented SEO best practices to improve website visibility and search rankings.",
                                 "Conducted regular website audits to identify and resolve technical issues.",
                                 "Stayed updated with the latest web technologies and industry trends."
                                 
                                 }, },
                },

                Achievements = new List<Achievement>
                {
                    new() { Title = "40% Efficiency Improvement", Description = "Through SQL and Python automation initiatives.", Icon = "trend" },
                    new() { Title = "Enterprise API Integrations", Description = "WhatsApp Cloud API and Microsoft Graph API.", Icon = "link" },
                    new() { Title = "Backend Engineering", Description = "Designed and maintained enterprise-grade APIs and backend services.", Icon = "server" },
                    new() { Title = "DevOps & Deployment", Description = "Supported CI/CD workflows and deployment automation.", Icon = "cloud" },
                    new() { Title = "Enterprise Support", Description = "Provided international software support and complex troubleshooting.", Icon = "support" },
                },

                CareerJourney = new List<CareerStage>
                {
                    new() { Label = "IT & Technical Support" },
                    new() { Label = "Systems & Enterprise Support" },
                    new() { Label = "Software Support" },
                    new() { Label = "Full Stack Development" },
                    new() { Label = "Integration Development" },
                },

                Certifications = new List<Certification>
                {
                    new() { Name = "Full Stack Web Development: HTML, CSS, React & Node" },
                    new() { Name = "Node.js API Masterclass with Express & MongoDB" },
                    new() { Name = "Modern JavaScript From the Beginning 2.0" },
                    new() { Name = "Python PCEP - Introduction to Programming Using Python" },
                    new() { Name = "The Complete SQL Bootcamp" },
                    new() { Name = "Microsoft Power BI Desktop for Business Intelligence" },
                    new() { Name = "AWS Technical Essentials" },
                    new() { Name = "AWS Cloud Practitioner Essentials" },
                    new() { Name = "Introduction to Containers" },
                    new() { Name = "C++ Essentials 1" },
                    new() { Name = "Python Essentials" },
                    new() { Name = "JavaScript Essentials" },
                    new() { Name = "C# .NET with MS SQL" },
                    new() { Name = "AI for Data Analysis" },
                    new() { Name = "Data Privacy and Protection Officer" },
                    new() { Name = "AI Engineering" },
                    new() { Name = "Networking Fundamentals" },
                },

                Education = new List<EducationItem>
                {
                    new() { Qualification = "Higher National Certificate, Introduction in Technology", Institution = "Glencore Tech Institution", Year = "2013" },
                    new() { Qualification = "Higher National Certificate, Financial Management N4", Institution = "Tshwane North College", Year = "2011" },
                    new() { Qualification = "High School Certificate", Institution = "Eletsa Secondary School", Year = "2007" },
                },
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            // TODO: wire this up to an email provider (e.g. SendGrid/Resend) or
            // a database table. Kept as a stub so the form works end-to-end
            // once you plug in real sending logic.
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(message))
            {
                return Json(new { success = false, error = "Please fill in all fields." });
            }

            return Json(new { success = true });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
