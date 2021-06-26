using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment03.Models
{
    static public class PostRepo
    {
        public static List<Post> post = new List<Post>();
        static PostRepo()
        {
            post.Add(new Post { id=1, imgsrc= "https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png",
                Name="Zain",Title = "React", Content = "React is an open-source, front end, JavaScript library for building user interfaces or UI components. It is maintained by Facebook and a community of individual developers and companies. React can be used as a base in the development of single-page or mobile applications. "
            });
            post.Add(new Post { id = 2, imgsrc = "https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png",Name = "Ali",Title = "C#",
                Content = "C# is a general-purpose, multi-paradigm programming language encompassing static typing, strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented, and component-oriented programming disciplines."
            });
            post.Add(new Post { id = 3, imgsrc = "https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png",Name = "Jutt", Title = "Python",
                Content = "Python is an interpreted, high-level and general-purpose programming language used worldwide. Python's design philosophy emphasizes code readability with its notable use of significant whitespace"
            });
            
        }
        public static void Addpost(Post p)
        {
            post.Add(p);
        }

    }
}
