using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace AmazingBargain.Areas.Identity.Pages.Account
{
    public class UpgradeToSellerModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UpgradeToSellerModel(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToPage("/Account/Login");
            }

            // Ensure the "Seller" role exists
            if (!await _roleManager.RoleExistsAsync("Seller"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Seller"));
            }

            // Remove the "Buyer" role and add the "Seller" role
            if (await _userManager.IsInRoleAsync(user, "Buyer"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Buyer");
            }

            await _userManager.AddToRoleAsync(user, "Seller");

            return RedirectToPage("/Index"); // Redirect after success
        }
    }
}
