using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecop.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf49c6a0-8a20-4084-b85e-1df87634d484", "57a6309c-ba02-4423-a6b9-55c099b8bcfb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f090f5e-5ee7-44f1-a299-fc8631579fa6", "598613fc-d760-48a7-b21e-60ec2c44b0cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af7f9a34-ba2c-45df-b07b-3cc72c773ef1", "802bc3bd-db8e-40fb-8412-5606162f46a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa79828d-6239-4ce7-83e6-1e5ea5300d3d", "80af320b-6c13-4262-8d1a-dbe8977f5ae2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f090f5e-5ee7-44f1-a299-fc8631579fa6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af7f9a34-ba2c-45df-b07b-3cc72c773ef1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf49c6a0-8a20-4084-b85e-1df87634d484");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa79828d-6239-4ce7-83e6-1e5ea5300d3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57a6309c-ba02-4423-a6b9-55c099b8bcfb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "598613fc-d760-48a7-b21e-60ec2c44b0cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "802bc3bd-db8e-40fb-8412-5606162f46a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80af320b-6c13-4262-8d1a-dbe8977f5ae2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23d71d4b-42f5-4cbd-a2bb-ac172cab9060", null, "Judge", "JUDGE" },
                    { "551024e5-b7d5-4d32-b02f-6ecb857f7140", null, "Citizen", "CITIZEN" },
                    { "bd7b4f79-3b4f-4e1a-aee0-605d7aa59ed7", null, "Policeman", "POLICEMAN" },
                    { "cde66c04-f06b-4343-9e15-39695f02fa95", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2aa29558-5abd-4bfa-88bf-9658714c188b", 0, "f8b8ecf7-836f-4b19-8c0c-b1717e462ab3", "policman2@gmail.com", true, false, null, "POLICEMAN2@GMAIL.COM", "POLICEMAN2", "AQAAAAIAAYagAAAAEOWTXq56VPI8dAGZ8tyWJRXaddf/1c/Xy3f+Jvm6WVM+fqr08WWBP6cKNi4b/X37GQ==", null, false, "0c679799-5263-4eea-8de1-98f8779b76ea", false, "policman2" },
                    { "67891b16-13f2-4095-aa13-605e93212d70", 0, "73c22c1e-10e0-4a65-8adb-a0148af987ee", "judge2@gmail.com", true, false, null, "JUDGE2@GMAIL.COM", "JUDGE2", "AQAAAAIAAYagAAAAEJZWR9WA01BKnocczrOpMOYRq4A+/XQScblMl0KLBQE41V+fc1pU7vxJhaRRbUW1eA==", null, false, "3092040c-657b-4b60-bfce-869b17780308", false, "judge2" },
                    { "6ebf1b40-4d75-4351-a7d7-4dfa97b749c6", 0, "69fe26b9-65c2-494f-a11d-bf41edd367c2", "citizen2@gmail.com", true, false, null, "CITIZEN2@GMAIL.COM", "CITIZEN2", "AQAAAAIAAYagAAAAEIJy0kUBwEoPrjONrXQ+Tnzn2KKDgS4dLMtRAwiyiWh+81Ezszs78vb8GxZ8RJmSYA==", null, false, "9c2bbb91-3c45-49b1-983e-01b7aff3aba0", false, "citizen2" },
                    { "7dd0c4e4-0624-413a-9846-8dbd645b85f8", 0, "89eb1d2a-5e13-45e3-85c6-42e645aa4e4b", "citizen1@gmail.com", true, false, null, "CITIZEN1@GMAIL.COM", "CITIZEN1", "AQAAAAIAAYagAAAAEFSD9nRxB4sQDaWWsHNwazS110C9aCwYuJJi9Xg6EXjwamM9hvV45fzmmkjbB/uL3Q==", null, false, "2a53919f-5f79-4432-a8b4-7f95e502976c", false, "citizen1" },
                    { "bb025201-b208-4d99-bb48-b80b38b2e213", 0, "9218b142-3238-4c74-828d-0b48e5af5da6", "policman1@gmail.com", true, false, null, "POLICEMAN1@GMAIL.COM", "POLICEMAN1", "AQAAAAIAAYagAAAAEPek6sC/V1j8oBq8IquU8VXnFzMLeh1Bt7w+RdHmwwHI8P0TtYgn1DfpZ6xjm5XtJg==", null, false, "a41c6fbf-9b54-49b3-bd2f-55a7bd8ef99a", false, "policman1" },
                    { "be26c05c-c4b4-4e64-987d-83ebea155bf7", 0, "e215ef35-9dbe-4229-ac03-896958f7df0f", "judge1@gmail.com", true, false, null, "JUDGE1@GMAIL.COM", "JUDGE1", "AQAAAAIAAYagAAAAEIL2NBNnJqZYPpl2cRNc5SQynj+FqMrRNCzP8ftXpmSlDgSeORvQGOP/XuotrarWsg==", null, false, "5b9a2864-5aa2-4ca0-862e-3d8ef16fc5a1", false, "judge1" },
                    { "c8ef6f1b-42f4-401f-9c2b-d92ea5c48f98", 0, "5b8701ff-22b7-4037-ba95-359e54ceb405", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAENvj5QcMwTpKRQNBGDWn1vGIPMiVvnrA0TnuRrg7ltwa+YEp/3bWlx5b23orsk7M5w==", null, false, "dec872ff-1644-430c-90ae-536a6ed6fc25", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bd7b4f79-3b4f-4e1a-aee0-605d7aa59ed7", "2aa29558-5abd-4bfa-88bf-9658714c188b" },
                    { "23d71d4b-42f5-4cbd-a2bb-ac172cab9060", "67891b16-13f2-4095-aa13-605e93212d70" },
                    { "551024e5-b7d5-4d32-b02f-6ecb857f7140", "6ebf1b40-4d75-4351-a7d7-4dfa97b749c6" },
                    { "551024e5-b7d5-4d32-b02f-6ecb857f7140", "7dd0c4e4-0624-413a-9846-8dbd645b85f8" },
                    { "bd7b4f79-3b4f-4e1a-aee0-605d7aa59ed7", "bb025201-b208-4d99-bb48-b80b38b2e213" },
                    { "23d71d4b-42f5-4cbd-a2bb-ac172cab9060", "be26c05c-c4b4-4e64-987d-83ebea155bf7" },
                    { "cde66c04-f06b-4343-9e15-39695f02fa95", "c8ef6f1b-42f4-401f-9c2b-d92ea5c48f98" }
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "CitizenId", "Address", "Camera_id", "Email", "Name", "Password", "Phone", "UserId" },
                values: new object[,]
                {
                    { 1, "Tubas", "cam123", "braa@gmail.com", "Braa", "Pass@123", "1231231234", "7dd0c4e4-0624-413a-9846-8dbd645b85f8" },
                    { 2, "Tulkarm", "cam456", "osama@gmail.com", "Osama", "Pass@123", "3213214321", "6ebf1b40-4d75-4351-a7d7-4dfa97b749c6" }
                });

            migrationBuilder.InsertData(
                table: "Judges",
                columns: new[] { "JudgeId", "Address", "Email", "Name", "Password", "Phone", "UserId" },
                values: new object[,]
                {
                    { 1, "Jenin", "ali@gmail.com", "Ali", "Pass@123", "1234567890", "be26c05c-c4b4-4e64-987d-83ebea155bf7" },
                    { 2, "Nablus", "hadi@gmail.com", "Hadi", "Pass@123", "0987654321", "67891b16-13f2-4095-aa13-605e93212d70" }
                });

            migrationBuilder.InsertData(
                table: "Policemans",
                columns: new[] { "PolicemanId", "Badge_Number", "Email", "Name", "Password", "Phone", "UserId" },
                values: new object[,]
                {
                    { 1, "12345", "mohammed@gmail.com", "Mohammed", "Pass@123", "0123456789", "bb025201-b208-4d99-bb48-b80b38b2e213" },
                    { 2, "54321", "noor@gmail.com", "Noor", "Pass@123", "0987654321", "2aa29558-5abd-4bfa-88bf-9658714c188b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd7b4f79-3b4f-4e1a-aee0-605d7aa59ed7", "2aa29558-5abd-4bfa-88bf-9658714c188b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "23d71d4b-42f5-4cbd-a2bb-ac172cab9060", "67891b16-13f2-4095-aa13-605e93212d70" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "551024e5-b7d5-4d32-b02f-6ecb857f7140", "6ebf1b40-4d75-4351-a7d7-4dfa97b749c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "551024e5-b7d5-4d32-b02f-6ecb857f7140", "7dd0c4e4-0624-413a-9846-8dbd645b85f8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd7b4f79-3b4f-4e1a-aee0-605d7aa59ed7", "bb025201-b208-4d99-bb48-b80b38b2e213" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "23d71d4b-42f5-4cbd-a2bb-ac172cab9060", "be26c05c-c4b4-4e64-987d-83ebea155bf7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cde66c04-f06b-4343-9e15-39695f02fa95", "c8ef6f1b-42f4-401f-9c2b-d92ea5c48f98" });

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "CitizenId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "CitizenId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Judges",
                keyColumn: "JudgeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Judges",
                keyColumn: "JudgeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Policemans",
                keyColumn: "PolicemanId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Policemans",
                keyColumn: "PolicemanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23d71d4b-42f5-4cbd-a2bb-ac172cab9060");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "551024e5-b7d5-4d32-b02f-6ecb857f7140");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd7b4f79-3b4f-4e1a-aee0-605d7aa59ed7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cde66c04-f06b-4343-9e15-39695f02fa95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa29558-5abd-4bfa-88bf-9658714c188b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67891b16-13f2-4095-aa13-605e93212d70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ebf1b40-4d75-4351-a7d7-4dfa97b749c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dd0c4e4-0624-413a-9846-8dbd645b85f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb025201-b208-4d99-bb48-b80b38b2e213");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be26c05c-c4b4-4e64-987d-83ebea155bf7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8ef6f1b-42f4-401f-9c2b-d92ea5c48f98");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8f090f5e-5ee7-44f1-a299-fc8631579fa6", null, "Policman", "POLICEMAN" },
                    { "af7f9a34-ba2c-45df-b07b-3cc72c773ef1", null, "Judge", "JUDGE" },
                    { "cf49c6a0-8a20-4084-b85e-1df87634d484", null, "Admin", "ADMIN" },
                    { "fa79828d-6239-4ce7-83e6-1e5ea5300d3d", null, "Citizen", "CITIZEN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "57a6309c-ba02-4423-a6b9-55c099b8bcfb", 0, "01ff1632-5f6c-4957-a57e-44a4e5eb7903", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEKlej/e+D/P8rIb2f1XRa0Ptnf3Phkxx/lVW1gyDy8/t8SvLs1iytatqbftOsQGNOg==", null, false, "baae20fe-818f-4c21-9418-3eee57b5b8fe", false, "admin" },
                    { "598613fc-d760-48a7-b21e-60ec2c44b0cd", 0, "6a583056-982e-42ea-83fc-fddfa7dfd4dc", "policman@gmail.com", true, false, null, "POLICEMAN@GMAIL.COM", "POLICEMAN", "AQAAAAIAAYagAAAAED0mj/5QDzevrLs023lKEDllURsKW3HQK78MVzW67DOmjxUOnjjA/JAq1qPSOa/mHw==", null, false, "3ff37e06-734d-4cc7-bd5f-efa159d5a17d", false, "policman" },
                    { "802bc3bd-db8e-40fb-8412-5606162f46a1", 0, "0a125c5e-20e2-472e-a26b-099a2af99a73", "judge@gmail.com", true, false, null, "JUDGE@GMAIL.COM", "JUDGE", "AQAAAAIAAYagAAAAEJICrY8FiZFqoQ3dFFubVuZDMUuHPofFxQqw3aXWAV3sF3FdpgfZ36LOP0aAnoLo0w==", null, false, "078a3ac8-15a5-4309-9539-0a4d4cbee11a", false, "judge" },
                    { "80af320b-6c13-4262-8d1a-dbe8977f5ae2", 0, "5f3eaa2a-6c21-4b1e-aa4c-2ca8f16991fa", "citizen@gmail.com", true, false, null, "CITIZEN@GMAIL.COM", "CITIZEN", "AQAAAAIAAYagAAAAEP6T2rWTX50UFm+uW/dUQrGoAZPNPGSlzL+sWn62wM7979eEfgfNmbecQO7sDAnIFw==", null, false, "339076fa-9ee4-4fe2-b3d4-05dea0ca21ae", false, "citizen" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cf49c6a0-8a20-4084-b85e-1df87634d484", "57a6309c-ba02-4423-a6b9-55c099b8bcfb" },
                    { "8f090f5e-5ee7-44f1-a299-fc8631579fa6", "598613fc-d760-48a7-b21e-60ec2c44b0cd" },
                    { "af7f9a34-ba2c-45df-b07b-3cc72c773ef1", "802bc3bd-db8e-40fb-8412-5606162f46a1" },
                    { "fa79828d-6239-4ce7-83e6-1e5ea5300d3d", "80af320b-6c13-4262-8d1a-dbe8977f5ae2" }
                });
        }
    }
}
