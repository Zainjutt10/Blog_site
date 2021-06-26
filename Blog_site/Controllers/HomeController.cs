using Assignment03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment03.Controllers
{
    public class HomeController : Controller
    {
        //Login obj = null;
        static public string name = "";
        
        [HttpGet]
        /////Default login page whenever someone open our application
        public ViewResult Index()
        {
            name = "";
            return View("Index");
        }
        [HttpPost] 
        
        public ViewResult Index(Login log)
        {
            if(ModelState.IsValid)
            {
                ///checking for every login field to be filled.
                
                name= log.Name;
                return View("Display",PostRepo.post);
                
            }
            else
            {
                return View();
            }
           
        }
        [HttpPost]
        ////successfully when user have loged in we recieve its info and thanchecking for validity of user
        public ViewResult Home(Login log)
        {
            foreach(Login lg in LoginRepo.lg)
            {
                if(log.Name==lg.Name && log.Password==lg.Password)
                {
                    
                    return View("Display", PostRepo.post);
                   // break;
                }
            }
            
                ModelState.AddModelError(string.Empty, "Please Enter correct values.");
                return View("Unautharize");
            
        }
       
        
        /// simply a display of all the posts.
        
        public ViewResult Display()
        {
            return View(PostRepo.post);
        }
        [HttpGet]
        /////when we click on create post .
        public ViewResult Post()
        {
            return View("Post");
        }
        [HttpPost]
        //////update display of posts whenever a post has been add by the user.
        public ViewResult Post(Post p)
        {
            p.imgsrc = "https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png";
            PostRepo.Addpost(p);
            return View("Display",PostRepo.post);
        }
        //[HttpPost]
        //checking for updating individual post an also if user is admin giving his authority to update and delete the other post all done in this view.
        public ViewResult Update(int id)
        {
            Post p = PostRepo.post.Find(p => p.id == id);
           
            foreach(Login log in LoginRepo.lg)
            {
                if(log.admin && log.Name==name)
                {
                    
                        return View("Update", p);
                    
                }
            }
            if(p.Name==name)
            {
                return View("Update", p);
            }
            return View("Wobtn",p);
        }
        //if user wants to update its profile.
        public ViewResult ProfileUpdate()
        {
            foreach(Login log in LoginRepo.lg)
            {
                if(name==log.Name)
                {
                    return View("ProfileUpdate", log);
                }
            }
            //checking if user have logged in or some other visitor if a visitor than rediricting him to login page through unauthorize msg.
            return View("Unautharize");
        }
        [HttpPost]
        //if profile has been updated tha save the changes.
        public ViewResult ProfileUpdate(Login logto)
        {
            foreach(Login log in LoginRepo.lg)
            {
                if(log.Name==name)
                {
                    log.Name = logto.Name;
                    log.email = logto.email;
                    log.Password = logto.Password;
                    foreach (Post p in PostRepo.post)
                    {
                        if (name == p.Name)
                        {
                            p.Name = log.Name;
                            name = log.Name;
                            break;
                        }
                    }
                    break;
                }
                
            }
            
            return View("Display", PostRepo.post);
        }

        //editing a post should result in making this call by the user.
        public ViewResult Edit(int id)
        {
            Post p = PostRepo.post.Find(p => p.id == id);
            return View("Edit",p);
        }

        [HttpPost]
        //when updation is done by the user on the post it should make a post req and than redirect to the home page of posts.
        public ViewResult Edit(Post post)
        {
            if(ModelState.IsValid)
            {
                foreach(Post p in PostRepo.post)
                {
                    if(p.id==post.id)
                    {
                        p.Name = post.Name;
                        p.Title = post.Title;
                        p.Content = post.Content;
                        p.imgsrc = "https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png";
                        break;
                    }
                }
                return View ("Display", PostRepo.post);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Please Enter correct values.");
                return View();
            }
        }
        //removing post of the user.
        public ViewResult Remove(int id)
        {
            Post p = PostRepo.post.Find(p => p.id == id);
            PostRepo.post.Remove(p);
            return View("Display", PostRepo.post);
        }
        
    }
}
