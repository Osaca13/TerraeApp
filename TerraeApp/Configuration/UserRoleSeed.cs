
using Microsoft.AspNetCore.Identity;

namespace TerraeApp.Configuration
{
    public class UserRoleSeed
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        
        public UserRoleSeed(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;

        }

        public async void SeedAsync()
        {
            if ((await _roleManager.FindByNameAsync("Candidato")) == null)
            {
                await _roleManager.CreateAsync( new IdentityRole { Name = "Candidato"});
            }

            if ((await _roleManager.FindByNameAsync("Admin")) == null)
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            }

            if ((await _roleManager.FindByNameAsync("Empresario")) == null)
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Empresario" });
            }
        }
    }
}
