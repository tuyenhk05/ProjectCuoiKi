﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace RazorPagesMovie.Application.Pages.Accout
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {
            this.Credential = new Credential()
            {
                UserName = "",
                Password = ""

            };
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                Console.WriteLine($"UserName: {Credential.UserName}, Password: {Credential.Password}");
                if (!ModelState.IsValid) return Page();

                if (Credential.UserName == "admin" && Credential.Password == "password")
                {
                    // Đăng nhập thành công
                    var claims = new List<Claim> {
            new Claim(ClaimTypes.Name, "admin"),
            new Claim(ClaimTypes.Email, "admin@mywebsite.com")
        };
                    var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
                    return RedirectToPage("/Index");
                }

                ModelState.AddModelError(string.Empty, "Tên đăng nhập hoặc mật khẩu không đúng.");
                return Page();
            }catch (Exception ex)
            {
                // Ghi lại lỗi ra console hoặc log
                Console.WriteLine(ex.Message);
                throw;
            }

        }


        }

    public class Credential
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public  string Password { get; set; }
    }


}
