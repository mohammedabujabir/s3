using Ecop.DAL.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecop.DAL.Models
{
    public class ApplicationDbContextSeed
    {
        // دالة لإضافة الأدوار إذا لم تكن موجودة
        public static async Task SeedRolesAsync(RoleManager<ApplicationRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Policeman"))
            {
                var role = new ApplicationRole { Name = "Policeman", NormalizedName = "POLICEMAN" };
                await roleManager.CreateAsync(role);
            }

            if (!await roleManager.RoleExistsAsync("Judge"))
            {
                var role = new ApplicationRole { Name = "Judge", NormalizedName = "JUDGE" };
                await roleManager.CreateAsync(role);
            }

            if (!await roleManager.RoleExistsAsync("Citizen"))
            {
                var role = new ApplicationRole { Name = "Citizen", NormalizedName = "CITIZEN" };
                await roleManager.CreateAsync(role);
            }



        }

        public static async Task SeedCitizensAndOthersAsync(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, ApplicationDbContext context)
        {
            // تأكد من أن الأدوار موجودة
            await SeedRolesAsync(roleManager);

            // Seed Citizens (إضافة بيانات للمواطنين)
            var citizen1 = await userManager.FindByEmailAsync("braa@gmail.com");
            if (citizen1 == null)
            {
                citizen1 = new ApplicationUser
                {
                    UserName = "user5",
                    Email = "braa@gmail.com",
                };
                await userManager.CreateAsync(citizen1, "Pass@123");

                // إضافة المواطن إلى الدور Citizen
                await userManager.AddToRoleAsync(citizen1, "Citizen");
            }

            var citizen2 = await userManager.FindByEmailAsync("osama@gmail.com");
            if (citizen2 == null)
            {
                citizen2 = new ApplicationUser
                {
                    UserName = "user6",
                    Email = "osama@gmail.com",
                };
                await userManager.CreateAsync(citizen2, "Pass@123");

                // إضافة المواطن إلى الدور Citizen
                await userManager.AddToRoleAsync(citizen2, "Citizen");
            }

            var citizen3 = await userManager.FindByEmailAsync("samira@gmail.com");
            if (citizen3 == null)
            {
                citizen3 = new ApplicationUser
                {
                    UserName = "user7",
                    Email = "samira@gmail.com",
                };
                await userManager.CreateAsync(citizen3, "Pass@123");

                // إضافة المواطن إلى الدور Citizen
                await userManager.AddToRoleAsync(citizen3, "Citizen");
            }

            var citizenList = new List<Citizen>
    {
        new Citizen
        {
            Name = "Braa",
            Email = "braa@gmail.com",
            Phone = "1231231234",
            Address = "Tubas",
            Password = "Pass@123",
            Camera_id = "cam123",
            UserId = citizen1.Id,
        },
        new Citizen
        {
            Name = "Osama",
            Email = "osama@gmail.com",
            Phone = "3213214321",
            Address = "Tulkarm",
            Password = "Pass@123",
            Camera_id = "cam456",
            UserId = citizen2.Id,
        },
        new Citizen
        {
            Name = "Samira",
            Email = "samira@gmail.com",
            Phone = "9876543210",
            Address = "Ramallah",
            Password = "Pass@123",
            Camera_id = "cam789",
            UserId = citizen3.Id,
        }
    };

            await context.Citizens.AddRangeAsync(citizenList);
            await context.SaveChangesAsync();
            // Seed Policemen (إضافة بيانات للشرطة)
            var policeman1 = await userManager.FindByEmailAsync("mohammed@gmail.com");
            if (policeman1 == null)
            {
                policeman1 = new ApplicationUser
                {
                    UserName = "user1",
                    Email = "mohammed@gmail.com",
                };
                await userManager.CreateAsync(policeman1, "Pass@123");

                // إضافة رجل الشرطة إلى الدور Policeman
                await userManager.AddToRoleAsync(policeman1, "Policeman");
            }

            var policeman2 = await userManager.FindByEmailAsync("noor@gmail.com");
            if (policeman2 == null)
            {
                policeman2 = new ApplicationUser
                {
                    UserName = "user2",
                    Email = "noor@gmail.com",
                };
                await userManager.CreateAsync(policeman2, "Pass@123");

                // إضافة رجل الشرطة إلى الدور Policeman
                await userManager.AddToRoleAsync(policeman2, "Policeman");
            }

            var policeman3 = await userManager.FindByEmailAsync("ahmed@gmail.com");
            if (policeman3 == null)
            {
                policeman3 = new ApplicationUser
                {
                    UserName = "user3",
                    Email = "ahmed@gmail.com",
                };
                await userManager.CreateAsync(policeman3, "Pass@123");

                // إضافة رجل الشرطة إلى الدور Policeman
                await userManager.AddToRoleAsync(policeman3, "Policeman");
            }

            var policemanList = new List<Policeman>
    {
        new Policeman
        {
            Name = "Mohammed",
            Badge_Number = "12345",
            Email = "mohammed@gmail.com",
            Phone = "0123456789",
            Password = "Pass@123",
            UserId = policeman1.Id,
        },
        new Policeman
        {
            Name = "Noor",
            Badge_Number = "54321",
            Email = "noor@gmail.com",
            Phone = "0987654321",
            Password = "Pass@123",
            UserId = policeman2.Id,
        },
        new Policeman
        {
            Name = "Ahmed",
            Badge_Number = "67890",
            Email = "ahmed@gmail.com",
            Phone = "0112233445",
            Password = "Pass@123",
            UserId = policeman3.Id,
        }
    };

            await context.Policemans.AddRangeAsync(policemanList);
            await context.SaveChangesAsync();
            // Seed Judges (إضافة بيانات للقضاة)
            var judge1 = await userManager.FindByEmailAsync("ali@gmail.com");
            if (judge1 == null)
            {
                judge1 = new ApplicationUser
                {
                    UserName = "user4",
                    Email = "ali@gmail.com",
                };
                await userManager.CreateAsync(judge1, "Pass@123");

                // إضافة القاضي إلى الدور Judge
                await userManager.AddToRoleAsync(judge1, "Judge");
            }

            var judge2 = await userManager.FindByEmailAsync("hadi@gmail.com");
            if (judge2 == null)
            {
                judge2 = new ApplicationUser
                {
                    UserName = "user5",
                    Email = "hadi@gmail.com",
                };
                await userManager.CreateAsync(judge2, "Pass@123");

                // إضافة القاضي إلى الدور Judge
                await userManager.AddToRoleAsync(judge2, "Judge");
            }

            var judge3 = await userManager.FindByEmailAsync("layla@gmail.com");
            if (judge3 == null)
            {
                judge3 = new ApplicationUser
                {
                    UserName = "user6",
                    Email = "layla@gmail.com",
                };
                await userManager.CreateAsync(judge3, "Pass@123");

                // إضافة القاضي إلى الدور Judge
                await userManager.AddToRoleAsync(judge3, "Judge");
            }

            var judgeList = new List<Judge>
    {
        new Judge
        {
            Name = "Ali",
            Email = "ali@gmail.com",
            Phone = "1234567890",
            Address = "Jenin",
            Password = "Pass@123",
            UserId = judge1.Id,
        },
        new Judge
        {
            Name = "Hadi",
            Email = "hadi@gmail.com",
            Phone = "0987654321",
            Address = "Nablus",
            Password = "Pass@123",
            UserId = judge2.Id,
        },
        new Judge
        {
            Name = "Layla",
            Email = "layla@gmail.com",
            Phone = "1122334455",
            Address = "Ramallah",
            Password = "Pass@123",
            UserId = judge3.Id,
        }
    };

            await context.Judges.AddRangeAsync(judgeList);

            // حفظ التغييرات في قاعدة البيانات
            await context.SaveChangesAsync();
        }


    }

}
