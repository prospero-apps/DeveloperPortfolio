using DeveloperPortfolio.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeveloperPortfolio.Api.Data
{
    public class DeveloperPortfolioDbContext : DbContext
    {
        public DeveloperPortfolioDbContext(DbContextOptions<DeveloperPortfolioDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed the Projects table

            // Extreme Vacation
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 1,
                Name = "Extreme Vacation",                
                Description = "A portal that I made just for fun. You can use it to book your extreme vacation like in a burning city or sharing a den with a bear. The project is hosted in Azure, the backend was created using the ASP.NET Core Web API template and the frontend was made with Blazor WebAssembly. The data is stored in a SQL Server database. I used Entity Framework Core as the ORM.",
                ImageUrl = "images/extreme-vacation.png",
                CategoryId = 1
            });

            // Forest Monsters
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 2,
                Name = "Forest Monsters",                
                Description = "A 2D game made with Unity with C# scripting. Your task is to save the enchanted forest from a bad sorcerer. You have to kill lots of monsters on your way. This is a typical platformer game. You jump from platform to platform, collect items, shoot monsters, avoid bombs and poison, move toward the door to the next level. Some of the platforms can move, which makes the game more difficult.",
                ImageUrl = "images/Forest Monsters.png",
                CategoryId = 2
            });

            // Slugrace
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 3,
                Name = "Slugrace",                
                Description = "A 2D game made with Python and Kivy. It can be played by up to four players. Each player places a bet on one of four racing slugs and they either win or lose money. The game is over when there's only one player left with any money, but you can set a different ending condition in the settings screen too, like after a given number of races or after a set period of time.",
                ImageUrl = "images/Slugrace.png",
                CategoryId = 2
            });
                        
            // CV Project
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 4,
                Name = "CV Project",                
                Description = "This is my first React project. In this app you can fill in a form with your personal information (like name, address, experience and education) to create a CV. You can also upload a photo. There's also a live preview of the CV, so whatever you type in the form is instantly visualized in the preview on the right.",
                ImageUrl = "images/cv-project.png",
                CategoryId = 1
            });
                        
            // Waldo
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 5,
                Name = "Waldo",                
                Description = "This is a simple version of the popular Where Is Waldo game where you have to find Waldo and some other characters in the image. This isn't easy because there are a great number of characters in the image. If you find all three characters in an image, just try another image. There are three images to choose from. This project uses Firebase as the backend.",
                ImageUrl = "images/waldo.png",
                CategoryId = 1
            });
                     
            // Abstract Artwork
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 6,
                Name = "Abstract Artwork",                
                Description = "Abstract artwork, pretty useless, just nice for the eye. You can open the blend file available on Github and tweak it to your heart's content. The options are countless.",
                ImageUrl = "images/Abstract Artwork.jpg",
                CategoryId = 3
            });

            // Arched Cellar
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 7,
                Name = "Arched Cellar",                
                Description = "A low-poly cellar model with simple texturing. You can import it in Unity or any other game engine and use as an environment for your project.",
                ImageUrl = "images/Arched Cellar.jpg",
                CategoryId = 3
            });

            // Bacteria
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 8,
                Name = "Bacteria",                
                Description = "Bacteria as seen under an electron microscope. When you use an electron microscope, the object you watch is no longer alive, so the bacteria is not going to be animated. I also have a blog post where you can see how this model was built.",
                ImageUrl = "images/Bacteria.png",
                CategoryId = 3
            });

            // Funny Characters
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 9,
                Name = "Funny Characters",                
                Description = "A couple high-poly rigged characters I created in Blender. They are animated, but as they are high-poly, they don't actually lend themselves very well to being used in a game.",
                ImageUrl = "images/Characters.png",
                CategoryId = 3
            });

            // Gravestone
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 10,
                Name = "Gravestone",                
                Description = "A gravestone with some inscriptions on it. It's a high-poly model, so it's not well suited for being used in a game, although it might be used in one as a static game object.",
                ImageUrl = "images/Gravestone.png",
                CategoryId = 3
            });
                        
            // Tangled Wire Ball Animation
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 11,
                Name = "Tangled Wire Ball Animation",                
                Description = "A simple animation, in which a ball of tangled wire rotates around its Z axis and then moves toward the camera along the Y axis until the camera is inside the ball.",
                ImageUrl = "images/Tangled Wire Ball.jpg",
                CategoryId = 3
            });

            // Town Houses
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 12,
                Name = "Town Houses",                
                Description = "Five low-poly models of town houses, ready to export to Unity or any other game engine. The models are fully textured.",
                ImageUrl = "images/Town Houses.png",
                CategoryId = 3
            });

            // Treasure Chest
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 13,
                Name = "Treasure Chest",                
                Description = "A model of a chest with an open lid and light coming out of it. If you want to model the chest along with me, just follow the step-by-step instructions in my blog post.",
                ImageUrl = "images/Treasure Chest.jpg",
                CategoryId = 3
            });

            // Tropical Island
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 14,
                Name = "Tropical Island",                
                Description = "A tropical island with dense vegetation and the sea. The model is high-poly, so not very well suited for being used in a game. It consists of numerous smaller models of plants and stones that I created before.",
                ImageUrl = "images/Tropical Island.jpg",
                CategoryId = 3
            });

            // Tunnel Animation
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 15,
                Name = "Tunnel Animation",                
                Description = "A simple first-person-perspective animated journey through a tunnel - a tunnel animation using the follow path constraint, in which the camera will move along a path inside a tunnel.",
                ImageUrl = "images/Tunnel.jpg",
                CategoryId = 3
            });

            // Alien Creature Animation
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 16,
                Name = "Alien Creature Animation",                
                Description = "A simple animation of a worm winding its body. You can read my blog post with step-by-step instructions to first model and then animate along the worm.",
                ImageUrl = "images/Worm.jpg",
                CategoryId = 3
            });

            // GUI Programming with Python and Kivy
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 17,
                Name = "GUI Programming with Python and Kivy",                
                Description = "This is a book for Python developers who want to create GUI apps using this language. One option is to use the Kivy library. In the book a game project is created from scratch.",
                ImageUrl = "images/Kivy Book.png",
                CategoryId = 4
            });

            // Learn Over 400 Phrasal Verbs the Fun Way
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 18,
                Name = "Learn Over 400 Phrasal Verbs the Fun Way",                
                Description = "In this book you will learn over 400 hundred phrasal verbs. Phrasal verbs are verbs that consist of two parts, the actual verb and a particle, like 'stand up', 'get off' or 'turn down', to mention just a few.",
                ImageUrl = "images/Phrasal Verbs Book.png",
                CategoryId = 4
            });

            // Python Jumpstart Course
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 19,
                Name = "Python Jumpstart Course",                
                Description = "A Python course for absolute beginners. Lots of examples, exercises and projects for you to do. Includes the object-oriented programming paradigm.",
                ImageUrl = "images/Python Jumpstart Course.png",
                CategoryId = 5
            });

            // Python in Science - Introduction to numpy
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 20,
                Name = "Python in Science - Introduction to numpy",                
                Description = "This is a beginner course for Python developers who want to start using Python in science. numpy is the most basic library you should definitely start with.",
                ImageUrl = "images/numpy.png",
                CategoryId = 5
            });

            // Advanced English - Learn Over 400 Phrasal Verbs
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 21,
                Name = "Advanced English - Learn Over 400 Phrasal Verbs",                
                Description = "In this course you will learn over 400 phrasal verbs. Phrasal verbs are very popular especially in everyday colloquial language and using them makes you sound more like a native.",
                ImageUrl = "images/Phrasal Verbs Course.png",
                CategoryId = 5
            });

            // Your Panda3D Magazine
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 22,
                Name = "Your Panda3D Magazine",                
                Description = "This is the first (and so far only) issue of a magazine focused on game development with Python and the Panda3D game engine. There's also quite a lot stuff related to 3D modeling with Blender.",
                ImageUrl = "images/Your Panda3D Magazine.png",
                CategoryId = 6
            });

            // Your American English Magazine
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 23,
                Name = "Your American English Magazine",                
                Description = "This is the first issue of Your American English Magazine. There's quite a lot of stuff in it for you that you can use to improve your English, both grammar and vocabulary. Plus some American culture.",
                ImageUrl = "images/Your American English Magazine.png",
                CategoryId = 6
            });

            // Seed the Categories table
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Web Projects", Icon = "fa-solid fa-globe" });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 2, Name = "Games", Icon = "fa-solid fa-gamepad" });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 3, Name = "Blender Projects", Icon = "fa-solid fa-cube" });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 4, Name = "Books", Icon = "fa-solid fa-book" });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 5, Name = "Online Courses", Icon = "fa-solid fa-chalkboard-user" });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 6, Name = "Magazines", Icon = "fa-solid fa-newspaper" });

            // Seed the Techs table
            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 1, Name = "C#", Icon = "devicon-csharp-plain" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 2, Name = ".NET", Icon = "devicon-dotnetcore-plain" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 3, Name = "Unity", Icon = "devicon-unity-original" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 4, Name = "HTML", Icon = "devicon-html5-plain" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 5, Name = "CSS", Icon = "devicon-css3-plain" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 6, Name = "JavaScript", Icon = "devicon-javascript-plain" });  
            
            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 7, Name = "React", Icon = "devicon-react-original" });  
            
            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 8, Name = "Python", Icon = "devicon-python-plain" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 9, Name = "Blender", Icon = "devicon-blender-original" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 10, Name = "Azure", Icon = "devicon-azure-plain" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 11, Name = "Microsoft SQL Server", Icon = "devicon-microsoftsqlserver-plain" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 12, Name = "Bootstrap", Icon = "devicon-bootstrap-plain" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 13, Name = "Sass", Icon = "devicon-sass-original" });

            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 14, Name = "english", Icon = "fa-solid fa-flag-usa" });

            // Seed the Links table
            // Extreme Vacation - Github, live
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 1,
                Destination = "https://github.com/prospero-apps/ExtremeVacation",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 1,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 2,
                Destination = "https://happy-water-095a43b10.3.azurestaticapps.net",
                DisplayText = "Live",
                Icon = "fa-solid fa-rocket",
                ProjectId = 1,
            });

            // Forest Monsters - Github, YouTube, blog, download
            modelBuilder.Entity<Link>().HasData(new Link 
            { 
                Id = 3, 
                Destination = "https://github.com/prospero-apps/forest-monsters",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 2,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 4,
                Destination = "https://youtu.be/i7xyMbhdg_8",
                DisplayText = "YouTube",
                Icon = "fa-brands fa-youtube",
                ProjectId = 2,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 5,
                Destination = "https://prosperocoder.com/posts/unity/forest-monsters-a-2d-platformer-game-made-with-unity",
                DisplayText = "Prospero Coder blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 2,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 6,
                Destination = "https://prosperocoder.itch.io/forest-monsters",
                DisplayText = "Download",
                Icon = "fa-solid fa-download",
                ProjectId = 2,
            });

            // Slugrace - Github, YouTube, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 7,
                Destination = "https://github.com/prospero-apps/slugrace",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 3,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 8,
                Destination = "https://youtu.be/z24eIFsbEl8",
                DisplayText = "YouTube",
                Icon = "fa-brands fa-youtube",
                ProjectId = 3,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 9,
                Destination = "https://prosperocoder.com/blog/posts/kivy",
                DisplayText = "Prospero Coder blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 3,
            });

            // CV Project - Github, live
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 10,
                Destination = "https://github.com/prospero-apps/cv-project",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 4,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 11,
                Destination = "https://prospero-apps.github.io/cv-project",
                DisplayText = "Live",
                Icon = "fa-solid fa-rocket",
                ProjectId = 4,
            });

            // Waldo - Github, live
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 12,
                Destination = "https://github.com/prospero-apps/waldo",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 5,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 13,
                Destination = "https://prospero-apps.github.io/waldo/",
                DisplayText = "Live",
                Icon = "fa-solid fa-rocket",
                ProjectId = 5,
            });

            // Abstract Artwork - Github
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 14,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 6,
            });

            // Arched Cellar - Github
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 15,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 7,
            });

            // Bacteria - Github, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 16,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 8,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 17,
                Destination = "https://prosperocoder.com/posts/blender/bacteria-model-under-electron-microscope",
                DisplayText = "Prospero Coder blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 8,
            });

            // Funny Characters - Github
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 18,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 9,
            });

            // Gravestone - Github
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 19,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 10,
            });

            // Tangled Wire Ball Animation - Github, YouTube, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 20,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 11,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 21,
                Destination = "https://youtu.be/crGOEzZ2V6Y",
                DisplayText = "YouTube",
                Icon = "fa-brands fa-youtube",
                ProjectId = 11,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 22,
                Destination = "https://prosperocoder.com/posts/blender/tangled-wire-ball-with-uv-sphere",
                DisplayText = "Prospero Coder blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 11,
            });

            // Town Houses - Github
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 23,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files/Town%20Houses",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 12,
            });

            // Treasure Chest - Github, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 24,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files/Treasure%20Chest",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 13,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 25,
                Destination = "https://prosperocoder.com/posts/blender/treasure-chest-model",
                DisplayText = "Prospero Coder blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 13,
            });

            // Tropical Island - Github
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 26,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 14,
            });

            // Tunnel Animation - Github, YouTube, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 27,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 15,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 28,
                Destination = "https://youtu.be/SPVJAwIuqJs",
                DisplayText = "YouTube",
                Icon = "fa-brands fa-youtube",
                ProjectId = 15,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 29,
                Destination = "https://prosperocoder.com/posts/blender/tunnel-animation-follow-path-constraint",
                DisplayText = "Prospero Coder blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 15,
            });

            // Alien Creature Animation - Github, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 30,
                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 16,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 31,
                Destination = "https://prosperocoder.com/posts/blender/alien-creature-animation",
                DisplayText = "Prospero Coder blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 16,
            });

            // GUI Programming with Python and Kivy - Github, Amazon, webstore, YouTube, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 32,
                Destination = "https://github.com/prospero-apps/python/tree/master/GUI%20Programming%20with%20Python%20and%20Kivy%20BOOK",
                DisplayText = "Github",
                Icon = "devicon-github-original",
                ProjectId = 17,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 33,
                Destination = "https://www.amazon.com/Programming-Python-Kivy-Kamil-Pakula/dp/B09M9CYRCX/ref=asc_df_B09M9CYRCX/?tag=hyprod-20&linkCode=df0&hvadid=564675582183&hvpos=&hvnetw=g&hvrand=10679525743492153029&hvpone=&hvptwo=&hvqmt=&hvdev=c&hvdvcmdl=&hvlocint=&hvlocphy=1014434&hvtargid=pla-1595705564143&psc=1",
                DisplayText = "Amazon",
                Icon = "fa-brands fa-amazon",
                ProjectId = 17,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 34,
                Destination = "https://prosperocoder.com/product/gui-programming-with-python-and-kivy-e-book",
                DisplayText = "Prospero Coder Store",
                Icon = "fa-solid fa-cart-shopping",
                ProjectId = 17,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 35,
                Destination = "https://youtu.be/3W8zDYMBoDk",
                DisplayText = "YouTube",
                Icon = "fa-brands fa-youtube",
                ProjectId = 17,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 36,
                Destination = "https://prosperocoder.com/posts/kivy/my-gui-programming-with-python-and-kivy-book",
                DisplayText = "Prospero Coder blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 17,
            });

            // Learn Over 400 Phrasal Verbs the Fun Way - Amazon, webstore, YouTube, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 37,
                Destination = "https://www.amazon.com/-/es/Kamil-Pakula/dp/B09RM5XFLS",
                DisplayText = "Amazon",
                Icon = "fa-brands fa-amazon",
                ProjectId = 18,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 38,
                Destination = "https://prosperoenglish.com/product/learn-over-400-phrasal-verbs-the-fun-way",
                DisplayText = "Prospero English Store",
                Icon = "fa-solid fa-cart-shopping",
                ProjectId = 18,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 39,
                Destination = "https://youtu.be/yCFe0nKw8JM",
                DisplayText = "YouTube",
                Icon = "fa-brands fa-youtube",
                ProjectId = 18,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 40,
                Destination = "https://prosperoenglish.com/posts/my-learn-over-400-phrasal-verbs-book",
                DisplayText = "Prospero English blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 18,
            });

            // Python Jumpstart Course - Udemy
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 41,
                Destination = "https://www.udemy.com/course/python-jumpstart-course",
                DisplayText = "Udemy",
                Icon = "fa-solid fa-globe",
                ProjectId = 19,
            });


            // Python in Science - Introduction to numpy - Skillshare
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 42,
                Destination = "https://www.skillshare.com/en/classes/Python-in-Science-%E2%80%93-Introduction-to-numpy/1418900066/projects",
                DisplayText = "Skillshare",
                Icon = "fa-solid fa-globe",
                ProjectId = 20,
            });

            // Advanced English - Learn Over 400 Phrasal Verbs - Udemy, Skillshare, YouTube, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 43,
                Destination = "https://www.udemy.com/course/advanced-english-learn-over-400-phrasal-verbs",
                DisplayText = "Udemy",
                Icon = "fa-solid fa-globe",
                ProjectId = 21,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 44,
                Destination = "https://www.skillshare.com/en/classes/Advanced-English-%E2%80%93-Learn-Over-400-Phrasal-Verbs/1050280779/projects",
                DisplayText = "Skillshare",
                Icon = "fa-solid fa-globe",
                ProjectId = 21,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 45,
                Destination = "https://youtu.be/KF_OqSmU554",
                DisplayText = "YouTube",
                Icon = "fa-brands fa-youtube",
                ProjectId = 21,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 46,
                Destination = "https://prosperoenglish.com/posts/my-learn-over-400-phrasal-verbs-the-fun-way-course",
                DisplayText = "Prospero English blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 21,
            });

            // Your Panda3D Magazine - Issue 1 - Amazon, webstore, YouTube, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 47,
                Destination = "https://www.amazon.com/Your-Panda3D-Magazine-Kamil-Pakula-ebook/dp/B09SR785WV",
                DisplayText = "Amazon",
                Icon = "fa-brands fa-amazon",
                ProjectId = 22,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 48,
                Destination = "https://prosperocoder.com/product/your-panda3d-magazine-1-1-2022",
                DisplayText = "Prospero Coder Store",
                Icon = "fa-solid fa-cart-shopping",
                ProjectId = 22,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 49,
                Destination = "https://youtu.be/N9_rrQXIuuo",
                DisplayText = "YouTube",
                Icon = "fa-brands fa-youtube",
                ProjectId = 22,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 50,
                Destination = "https://prosperocoder.com/posts/your-panda3d-magazine-issue-1-2022-1",
                DisplayText = "Prospero Coder blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 22,
            });

            // Your American English Magazine - Amazon, webstore, YouTube, blog
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 51,
                Destination = "https://www.amazon.com/Your-American-English-Magazine-2022-ebook/dp/B09SQCZVF1",
                DisplayText = "Amazon",
                Icon = "fa-brands fa-amazon",
                ProjectId = 23,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 52,
                Destination = "https://prosperoenglish.com/product/your-american-english-magazine-1-1-2022",
                DisplayText = "Prospero English Store",
                Icon = "fa-solid fa-cart-shopping",
                ProjectId = 23,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 53,
                Destination = "https://youtu.be/XGlzwmBcsyY",
                DisplayText = "YouTube",
                Icon = "fa-brands fa-youtube",
                ProjectId = 23,
            });

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Id = 54,
                Destination = "https://prosperoenglish.com/posts/your-american-english-magazine-issue-1-2022-1",
                DisplayText = "Prospero English blog",
                Icon = "fa-solid fa-blog",
                ProjectId = 23,
            });

            // Seed the ProjectTechRelations table

            // Extreme Vacation - C#, .Net, HTML, CSS, Bootstrap, Microsoft SQL Server, Azure
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 1, ProjectId = 1, TechId = 1 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 2, ProjectId = 1, TechId = 2 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 3, ProjectId = 1, TechId = 4 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 4, ProjectId = 1, TechId = 5 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 5, ProjectId = 1, TechId = 12 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 6, ProjectId = 1, TechId = 11 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 7, ProjectId = 1, TechId = 10 });

            // Forest Monsters - C#, Unity
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 8, ProjectId = 2, TechId = 1 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 9, ProjectId = 2, TechId = 3 });

            // Slugrace - Python
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 10, ProjectId = 3, TechId = 8 });

            // CV Project - HTML, CSS, JavaScript, React
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 11, ProjectId = 4, TechId = 4 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 12, ProjectId = 4, TechId = 5 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 13, ProjectId = 4, TechId = 6 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 14, ProjectId = 4, TechId = 7 });

            // Waldo - HTML, CSS, JavaScript, React
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 15, ProjectId = 5, TechId = 4 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 16, ProjectId = 5, TechId = 5 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 17, ProjectId = 5, TechId = 6 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 18, ProjectId = 5, TechId = 7 });

            // Abstract Artwork - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 19, ProjectId = 6, TechId = 9 });

            // Arched Cellar - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 20, ProjectId = 7, TechId = 9 });

            // Bacteria - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 21, ProjectId = 8, TechId = 9 });

            // Funny Characters - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 22, ProjectId = 9, TechId = 9 });

            // Gravestone - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 23, ProjectId = 10, TechId = 9 });

            // Tangled Wire Ball Animation - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 24, ProjectId = 11, TechId = 9 });

            // Town Houses - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 25, ProjectId = 12, TechId = 9 });

            // Treasure Chest - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 26, ProjectId = 13, TechId = 9 });

            // Tropical Island - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 27, ProjectId = 14, TechId = 9 });

            // Tunnel Animation - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 28, ProjectId = 15, TechId = 9 });

            // Alien Creature Animation - Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 29, ProjectId = 16, TechId = 9 });

            // GUI Programming with Python and Kivy - Python
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 30, ProjectId = 17, TechId = 8 });

            // Learn Over 400 Phrasal Verbs the Fun Way - English
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 31, ProjectId = 18, TechId = 14 });

            // Python Jumpstart Course - Python
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 32, ProjectId = 19, TechId = 8 });

            // Advanced English - Learn Over 400 Phrasal Verbs - English
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 33, ProjectId = 20, TechId = 14 });

            // Your Panda3D Magazine - Python, Blender
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 34, ProjectId = 21, TechId = 8 });

            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 35, ProjectId = 22, TechId = 8 });

            // Your American English Magazine - English
            modelBuilder.Entity<ProjectTechRelation>().HasData(
                new ProjectTechRelation { Id = 36, ProjectId = 23, TechId = 14 });
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tech> Techs { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<ProjectTechRelation> ProjectTechRelations { get; set; }
    }
}
