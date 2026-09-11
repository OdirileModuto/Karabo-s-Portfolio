# Karabo Moduto — Developer Portfolio (ASP.NET Core MVC)

Built with **C# / ASP.NET Core 8 MVC**, Razor views, and vanilla CSS/JS (no frontend
build step required).

## Run it locally

Prerequisites: [.NET 8 SDK](https://dotnet.microsoft.com/download) installed.

```bash
cd KaraboPortfolio
dotnet restore
dotnet run
```

Then open the URL shown in the terminal (usually `https://localhost:5001` or
`http://localhost:5000`).

For live-reloading while you edit views/CSS/JS:

```bash
dotnet watch run
```

## Project structure

```
KaraboPortfolio/
├── Controllers/
│   └── HomeController.cs      # All content (projects, experience, skills...) lives here
├── Models/
│   └── PortfolioModels.cs     # Strongly-typed models for every section
├── Views/
│   ├── Shared/_Layout.cshtml  # Nav, footer, SEO/Open Graph meta
│   └── Home/Index.cshtml      # Hero -> About -> Skills -> Projects -> ... -> Contact
├── wwwroot/
│   ├── css/site.css           # Dark theme, glassmorphism, timeline, modal, responsive
│   ├── js/site.js             # Nav toggle, node-canvas hero animation, filtering, modal, contact form
│   └── cv/                    # Drop your real CV PDF here as Karabo-Moduto-CV.pdf
└── Program.cs                 # Minimal hosting model (.NET 8)
```

## How to update content later

Everything is data-driven from `HomeController.cs` — to add/edit a project,
job, skill, certification, etc. you only ever touch the `PortfolioViewModel`
being built in `Index()`. The Razor view loops over the model, so nothing in
`Index.cshtml` needs to change for routine content updates.

Next steps if you want to take this further:
- Move the content out of the controller into a `portfolio.json` file (or a
  database) so non-developers can edit it without touching C#.
- Wire `HomeController.Contact` up to a real email provider (SendGrid, Resend,
  or SMTP) — it currently just validates and returns success/failure as JSON.
- Deploy: this runs cleanly on Azure App Service, Render, Railway, or any
  host that supports ASP.NET Core 8.
