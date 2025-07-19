using TaskManagementAPI.Models;

namespace TaskManagementAPI.Data
{
    public static class DummyTMSData
    {
        public static List<TMSDto> GetDummyTasks()
        {
            return new List<TMSDto>
            {
                new TMSDto { Id = Guid.NewGuid(), Title = "Design Login Page", Description = "Create UI for login", Status = "To Do", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Implement Auth", Description = "Add JWT auth", Status = "In Progress", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Fix navbar bug", Description = "Navbar not responsive", Status = "Done", Type = "Bug" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Setup CI/CD", Description = "Configure GitHub Actions", Status = "In Progress", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Add forgot password", Description = "Implement password reset flow", Status = "To Do", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Dashboard Metrics", Description = "Show usage stats", Status = "To Do", Type = "Story" },
                new TMSDto { Id = Guid.NewGuid(), Title = "API Caching", Description = "Add Redis cache", Status = "In Progress", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "User Analytics", Description = "Track user actions", Status = "Done", Type = "Analytics" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Dark Mode", Description = "Add theme toggle", Status = "To Do", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Fix 404 page", Description = "404 not styled", Status = "Done", Type = "Bug" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Deploy to Azure", Description = "First production deploy", Status = "In Progress", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Integrate Payment API", Description = "Add Stripe support", Status = "To Do", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Improve SEO", Description = "Meta tags + sitemap", Status = "Done", Type = "Story" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Code cleanup", Description = "Refactor legacy modules", Status = "To Do", Type = "Task" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Multi-language Support", Description = "i18n implementation", Status = "In Progress", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Admin Role", Description = "Add RBAC system", Status = "Done", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Fix mobile layout", Description = "UI breaking on iPhone", Status = "To Do", Type = "Bug" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Write Unit Tests", Description = "Increase coverage to 80%", Status = "In Progress", Type = "Task" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Real-time Chat", Description = "Socket.io integration", Status = "To Do", Type = "Feature" },
                new TMSDto { Id = Guid.NewGuid(), Title = "Update Docs", Description = "Write API usage docs", Status = "Done", Type = "Story" }
            };
        }
    }
}
