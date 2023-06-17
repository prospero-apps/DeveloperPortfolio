using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeveloperPortfolio.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTechRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    TechId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTechRelations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Techs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Techs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "fa-solid fa-globe", "Web Projects" },
                    { 2, "fa-solid fa-gamepad", "Games" },
                    { 3, "fa-solid fa-cube", "Blender Projects" },
                    { 4, "fa-solid fa-book", "Books" },
                    { 5, "fa-solid fa-chalkboard-user", "Online Courses" },
                    { 6, "fa-solid fa-newspaper", "Magazines" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Destination", "DisplayText", "Icon", "ProjectId" },
                values: new object[,]
                {
                    { 1, "https://github.com/prospero-apps/ExtremeVacation", "Github", "devicon-github-original", 1 },
                    { 2, "https://happy-water-095a43b10.3.azurestaticapps.net", "Live", "fa-solid fa-rocket", 1 },
                    { 3, "https://github.com/prospero-apps/forest-monsters", "Github", "devicon-github-original", 2 },
                    { 4, "https://youtu.be/i7xyMbhdg_8", "YouTube", "fa-brands fa-youtube", 2 },
                    { 5, "https://prosperocoder.com/posts/unity/forest-monsters-a-2d-platformer-game-made-with-unity", "Prospero Coder blog", "fa-solid fa-blog", 2 },
                    { 6, "https://prosperocoder.itch.io/forest-monsters", "Download", "fa-solid fa-download", 2 },
                    { 7, "https://github.com/prospero-apps/slugrace", "Github", "devicon-github-original", 3 },
                    { 8, "https://youtu.be/z24eIFsbEl8", "YouTube", "fa-brands fa-youtube", 3 },
                    { 9, "https://prosperocoder.com/blog/posts/kivy", "Prospero Coder blog", "fa-solid fa-blog", 3 },
                    { 10, "https://github.com/prospero-apps/cv-project", "Github", "devicon-github-original", 4 },
                    { 11, "https://prospero-apps.github.io/cv-project", "Live", "fa-solid fa-rocket", 4 },
                    { 12, "https://github.com/prospero-apps/waldo", "Github", "devicon-github-original", 5 },
                    { 13, "https://prospero-apps.github.io/waldo/", "Live", "fa-solid fa-rocket", 5 },
                    { 14, "https://github.com/prospero-apps/blender/tree/master/blend%20files", "Github", "devicon-github-original", 6 },
                    { 15, "https://github.com/prospero-apps/blender/tree/master/blend%20files", "Github", "devicon-github-original", 7 },
                    { 16, "https://github.com/prospero-apps/blender/tree/master/blend%20files", "Github", "devicon-github-original", 8 },
                    { 17, "https://prosperocoder.com/posts/blender/bacteria-model-under-electron-microscope", "Prospero Coder blog", "fa-solid fa-blog", 8 },
                    { 18, "https://github.com/prospero-apps/blender/tree/master/blend%20files", "Github", "devicon-github-original", 9 },
                    { 19, "https://github.com/prospero-apps/blender/tree/master/blend%20files", "Github", "devicon-github-original", 10 },
                    { 20, "https://github.com/prospero-apps/blender/tree/master/blend%20files", "Github", "devicon-github-original", 11 },
                    { 21, "https://youtu.be/crGOEzZ2V6Y", "YouTube", "fa-brands fa-youtube", 11 },
                    { 22, "https://prosperocoder.com/posts/blender/tangled-wire-ball-with-uv-sphere", "Prospero Coder blog", "fa-solid fa-blog", 11 },
                    { 23, "https://github.com/prospero-apps/blender/tree/master/blend%20files/Town%20Houses", "Github", "devicon-github-original", 12 },
                    { 24, "https://github.com/prospero-apps/blender/tree/master/blend%20files/Treasure%20Chest", "Github", "devicon-github-original", 13 },
                    { 25, "https://prosperocoder.com/posts/blender/treasure-chest-model", "Prospero Coder blog", "fa-solid fa-blog", 13 },
                    { 26, "https://github.com/prospero-apps/blender/tree/master/blend%20files", "Github", "devicon-github-original", 14 },
                    { 27, "https://github.com/prospero-apps/blender/tree/master/blend%20files", "Github", "devicon-github-original", 15 },
                    { 28, "https://youtu.be/SPVJAwIuqJs", "YouTube", "fa-brands fa-youtube", 15 },
                    { 29, "https://prosperocoder.com/posts/blender/tunnel-animation-follow-path-constraint", "Prospero Coder blog", "fa-solid fa-blog", 15 },
                    { 30, "https://github.com/prospero-apps/blender/tree/master/blend%20files", "Github", "devicon-github-original", 16 },
                    { 31, "https://prosperocoder.com/posts/blender/alien-creature-animation", "Prospero Coder blog", "fa-solid fa-blog", 16 },
                    { 32, "https://github.com/prospero-apps/python/tree/master/GUI%20Programming%20with%20Python%20and%20Kivy%20BOOK", "Github", "devicon-github-original", 17 },
                    { 33, "https://www.amazon.com/Programming-Python-Kivy-Kamil-Pakula/dp/B09M9CYRCX/ref=asc_df_B09M9CYRCX/?tag=hyprod-20&linkCode=df0&hvadid=564675582183&hvpos=&hvnetw=g&hvrand=10679525743492153029&hvpone=&hvptwo=&hvqmt=&hvdev=c&hvdvcmdl=&hvlocint=&hvlocphy=1014434&hvtargid=pla-1595705564143&psc=1", "Amazon", "fa-brands fa-amazon", 17 },
                    { 34, "https://prosperocoder.com/product/gui-programming-with-python-and-kivy-e-book", "Prospero Coder Store", "fa-solid fa-cart-shopping", 17 },
                    { 35, "https://youtu.be/3W8zDYMBoDk", "YouTube", "fa-brands fa-youtube", 17 },
                    { 36, "https://prosperocoder.com/posts/kivy/my-gui-programming-with-python-and-kivy-book", "Prospero Coder blog", "fa-solid fa-blog", 17 },
                    { 37, "https://www.amazon.com/-/es/Kamil-Pakula/dp/B09RM5XFLS", "Amazon", "fa-brands fa-amazon", 18 },
                    { 38, "https://prosperoenglish.com/product/learn-over-400-phrasal-verbs-the-fun-way", "Prospero English Store", "fa-solid fa-cart-shopping", 18 },
                    { 39, "https://youtu.be/yCFe0nKw8JM", "YouTube", "fa-brands fa-youtube", 18 },
                    { 40, "https://prosperoenglish.com/posts/my-learn-over-400-phrasal-verbs-book", "Prospero English blog", "fa-solid fa-blog", 18 },
                    { 41, "https://www.udemy.com/course/python-jumpstart-course", "Udemy", "fa-solid fa-globe", 19 },
                    { 42, "https://www.skillshare.com/en/classes/Python-in-Science-%E2%80%93-Introduction-to-numpy/1418900066/projects", "Skillshare", "fa-solid fa-globe", 20 },
                    { 43, "https://www.udemy.com/course/advanced-english-learn-over-400-phrasal-verbs", "Udemy", "fa-solid fa-globe", 21 },
                    { 44, "https://www.skillshare.com/en/classes/Advanced-English-%E2%80%93-Learn-Over-400-Phrasal-Verbs/1050280779/projects", "Skillshare", "fa-solid fa-globe", 21 },
                    { 45, "https://youtu.be/KF_OqSmU554", "YouTube", "fa-brands fa-youtube", 21 },
                    { 46, "https://prosperoenglish.com/posts/my-learn-over-400-phrasal-verbs-the-fun-way-course", "Prospero English blog", "fa-solid fa-blog", 21 },
                    { 47, "https://www.amazon.com/Your-Panda3D-Magazine-Kamil-Pakula-ebook/dp/B09SR785WV", "Amazon", "fa-brands fa-amazon", 22 },
                    { 48, "https://prosperocoder.com/product/your-panda3d-magazine-1-1-2022", "Prospero Coder Store", "fa-solid fa-cart-shopping", 22 },
                    { 49, "https://youtu.be/N9_rrQXIuuo", "YouTube", "fa-brands fa-youtube", 22 },
                    { 50, "https://prosperocoder.com/posts/your-panda3d-magazine-issue-1-2022-1", "Prospero Coder blog", "fa-solid fa-blog", 22 },
                    { 51, "https://www.amazon.com/Your-American-English-Magazine-2022-ebook/dp/B09SQCZVF1", "Amazon", "fa-brands fa-amazon", 23 },
                    { 52, "https://prosperoenglish.com/product/your-american-english-magazine-1-1-2022", "Prospero English Store", "fa-solid fa-cart-shopping", 23 },
                    { 53, "https://youtu.be/XGlzwmBcsyY", "YouTube", "fa-brands fa-youtube", 23 },
                    { 54, "https://prosperoenglish.com/posts/your-american-english-magazine-issue-1-2022-1", "Prospero English blog", "fa-solid fa-blog", 23 }
                });

            migrationBuilder.InsertData(
                table: "ProjectTechRelations",
                columns: new[] { "Id", "ProjectId", "TechId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 4 },
                    { 4, 1, 5 },
                    { 5, 1, 12 },
                    { 6, 1, 11 },
                    { 7, 1, 10 },
                    { 8, 2, 1 },
                    { 9, 2, 3 },
                    { 10, 3, 8 },
                    { 11, 4, 4 },
                    { 12, 4, 5 },
                    { 13, 4, 6 },
                    { 14, 4, 7 },
                    { 15, 5, 4 },
                    { 16, 5, 5 },
                    { 17, 5, 6 },
                    { 18, 5, 7 },
                    { 19, 6, 9 },
                    { 20, 7, 9 },
                    { 21, 8, 9 },
                    { 22, 9, 9 },
                    { 23, 10, 9 },
                    { 24, 11, 9 },
                    { 25, 12, 9 },
                    { 26, 13, 9 },
                    { 27, 14, 9 },
                    { 28, 15, 9 },
                    { 29, 16, 9 },
                    { 30, 17, 8 },
                    { 31, 18, 14 },
                    { 32, 19, 8 },
                    { 33, 20, 14 },
                    { 34, 21, 8 },
                    { 35, 22, 8 },
                    { 36, 23, 14 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 1, "A portal that I made just for fun. You can use it to book your extreme vacation like in a burning city or sharing a den with a bear. The project is hosted in Azure, the backend was created using the ASP.NET Core Web API template and the frontend was made with Blazor WebAssembly. The data is stored in a SQL Server database. I used Entity Framework Core as the ORM.", "images/extreme-vacation.png", "Extreme Vacation" },
                    { 2, 2, "A 2D game made with Unity with C# scripting. Your task is to save the enchanted forest from a bad sorcerer. You have to kill lots of monsters on your way. This is a typical platformer game. You jump from platform to platform, collect items, shoot monsters, avoid bombs and poison, move toward the door to the next level. Some of the platforms can move, which makes the game more difficult.", "images/Forest Monsters.png", "Forest Monsters" },
                    { 3, 2, "A 2D game made with Python and Kivy. It can be played by up to four players. Each player places a bet on one of four racing slugs and they either win or lose money. The game is over when there's only one player left with any money, but you can set a different ending condition in the settings screen too, like after a given number of races or after a set period of time.", "images/Slugrace.png", "Slugrace" },
                    { 4, 1, "This is my first React project. In this app you can fill in a form with your personal information (like name, address, experience and education) to create a CV. You can also upload a photo. There's also a live preview of the CV, so whatever you type in the form is instantly visualized in the preview on the right.", "images/cv-project.png", "CV Project" },
                    { 5, 1, "This is a simple version of the popular Where Is Waldo game where you have to find Waldo and some other characters in the image. This isn't easy because there are a great number of characters in the image. If you find all three characters in an image, just try another image. There are three images to choose from. This project uses Firebase as the backend.", "images/waldo.png", "Waldo" },
                    { 6, 3, "Abstract artwork, pretty useless, just nice for the eye. You can open the blend file available on Github and tweak it to your heart's content. The options are countless.", "images/Abstract Artwork.jpg", "Abstract Artwork" },
                    { 7, 3, "A low-poly cellar model with simple texturing. You can import it in Unity or any other game engine and use as an environment for your project.", "images/Arched Cellar.jpg", "Arched Cellar" },
                    { 8, 3, "Bacteria as seen under an electron microscope. When you use an electron microscope, the object you watch is no longer alive, so the bacteria is not going to be animated. I also have a blog post where you can see how this model was built.", "images/Bacteria.png", "Bacteria" },
                    { 9, 3, "A couple high-poly rigged characters I created in Blender. They are animated, but as they are high-poly, they don't actually lend themselves very well to being used in a game.", "images/Characters.png", "Funny Characters" },
                    { 10, 3, "A gravestone with some inscriptions on it. It's a high-poly model, so it's not well suited for being used in a game, although it might be used in one as a static game object.", "images/Gravestone.png", "Gravestone" },
                    { 11, 3, "A simple animation, in which a ball of tangled wire rotates around its Z axis and then moves toward the camera along the Y axis until the camera is inside the ball.", "images/Tangled Wire Ball.jpg", "Tangled Wire Ball Animation" },
                    { 12, 3, "Five low-poly models of town houses, ready to export to Unity or any other game engine. The models are fully textured.", "images/Town Houses.png", "Town Houses" },
                    { 13, 3, "A model of a chest with an open lid and light coming out of it. If you want to model the chest along with me, just follow the step-by-step instructions in my blog post.", "images/Treasure Chest.jpg", "Treasure Chest" },
                    { 14, 3, "A tropical island with dense vegetation and the sea. The model is high-poly, so not very well suited for being used in a game. It consists of numerous smaller models of plants and stones that I created before.", "images/Tropical Island.jpg", "Tropical Island" },
                    { 15, 3, "A simple first-person-perspective animated journey through a tunnel - a tunnel animation using the follow path constraint, in which the camera will move along a path inside a tunnel.", "images/Tunnel.jpg", "Tunnel Animation" },
                    { 16, 3, "A simple animation of a worm winding its body. You can read my blog post with step-by-step instructions to first model and then animate along the worm.", "images/Worm.jpg", "Alien Creature Animation" },
                    { 17, 4, "This is a book for Python developers who want to create GUI apps using this language. One option is to use the Kivy library. In the book a game project is created from scratch.", "images/Kivy Book.png", "GUI Programming with Python and Kivy" },
                    { 18, 4, "In this book you will learn over 400 hundred phrasal verbs. Phrasal verbs are verbs that consist of two parts, the actual verb and a particle, like 'stand up', 'get off' or 'turn down', to mention just a few.", "images/Phrasal Verbs Book.png", "Learn Over 400 Phrasal Verbs the Fun Way" },
                    { 19, 5, "A Python course for absolute beginners. Lots of examples, exercises and projects for you to do. Includes the object-oriented programming paradigm.", "images/Python Jumpstart Course.png", "Python Jumpstart Course" },
                    { 20, 5, "This is a beginner course for Python developers who want to start using Python in science. numpy is the most basic library you should definitely start with.", "images/numpy.png", "Python in Science - Introduction to numpy" },
                    { 21, 5, "In this course you will learn over 400 phrasal verbs. Phrasal verbs are very popular especially in everyday colloquial language and using them makes you sound more like a native.", "images/Phrasal Verbs Course.png", "Advanced English - Learn Over 400 Phrasal Verbs" },
                    { 22, 6, "This is the first (and so far only) issue of a magazine focused on game development with Python and the Panda3D game engine. There's also quite a lot stuff related to 3D modeling with Blender.", "images/Your Panda3D Magazine.png", "Your Panda3D Magazine" },
                    { 23, 6, "This is the first issue of Your American English Magazine. There's quite a lot of stuff in it for you that you can use to improve your English, both grammar and vocabulary. Plus some American culture.", "images/Your American English Magazine.png", "Your American English Magazine" }
                });

            migrationBuilder.InsertData(
                table: "Techs",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "devicon-csharp-plain", "C#" },
                    { 2, "devicon-dotnetcore-plain", ".NET" },
                    { 3, "devicon-unity-original", "Unity" },
                    { 4, "devicon-html5-plain", "HTML" },
                    { 5, "devicon-css3-plain", "CSS" },
                    { 6, "devicon-javascript-plain", "JavaScript" },
                    { 7, "devicon-react-original", "React" },
                    { 8, "devicon-python-plain", "Python" },
                    { 9, "devicon-blender-original", "Blender" },
                    { 10, "devicon-azure-plain", "Azure" },
                    { 11, "devicon-microsoftsqlserver-plain", "Microsoft SQL Server" },
                    { 12, "devicon-bootstrap-plain", "Bootstrap" },
                    { 13, "devicon-sass-original", "Sass" },
                    { 14, "fa-solid fa-flag-usa", "english" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "ProjectTechRelations");

            migrationBuilder.DropTable(
                name: "Techs");
        }
    }
}
