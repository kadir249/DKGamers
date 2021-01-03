using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Identity
{
    public class IdentitySeed
    {
        public static async Task Seed(UserManager<Kullanici> kullaniciYoneticisi, RoleManager<IdentityRole> rolYoneticisi, IConfiguration konfigurasyon)
        {

            var kullaniciAdi1 = konfigurasyon["Admin1:AdminUser:username"];
            var email1 = konfigurasyon["Admin1:AdminUser:email"];
            var sifre1 = konfigurasyon["Admin1:AdminUser:password"];

            var kullaniciAdi2 = konfigurasyon["Admin2:AdminUser:username"];
            var email2 = konfigurasyon["Admin2:AdminUser:email"];
            var sifre2 = konfigurasyon["Admin2:AdminUser:password"];


            if ((await kullaniciYoneticisi.FindByNameAsync(kullaniciAdi1) == null) && (await kullaniciYoneticisi.FindByNameAsync(kullaniciAdi2)) == null)
            {
                await rolYoneticisi.CreateAsync(new IdentityRole("admin"));
                await rolYoneticisi.CreateAsync(new IdentityRole("user"));

                var admin1 = new Kullanici()
                {
                    UserName = kullaniciAdi1,
                    Email = email1,
                    EmailConfirmed = true,
                };
                var admin2 = new Kullanici()
                {
                    UserName = kullaniciAdi2,
                    Email = email2,
                    EmailConfirmed = true,
                };

                var adminResult1 = await kullaniciYoneticisi.CreateAsync(admin1, sifre1);
                if (adminResult1.Succeeded)
                {
                    await kullaniciYoneticisi.AddToRoleAsync(admin1, "admin");

                }
                var adminResult2 = await kullaniciYoneticisi.CreateAsync(admin2, sifre2);
                if (adminResult2.Succeeded)
                {
                    await kullaniciYoneticisi.AddToRoleAsync(admin2, "admin");

                }
            }
        }
    }
}