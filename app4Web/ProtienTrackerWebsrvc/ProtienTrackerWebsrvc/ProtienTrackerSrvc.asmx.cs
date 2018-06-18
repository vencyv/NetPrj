using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProtienTrackerWebsrvc
{
    //[WebService(Namespace = "http://tempuri.org/")]
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class ProtienTrackerSrvc : WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /*   [WebMethod]
          public int AddUser(string name, int goal)
          {

              var repository = new UserRepository();

              var user = new user { goal = goal, Name = name, Total = 0 };

              repository.add(user);

              return user.UserID;


          }
  */
        [WebMethod(Description = "test web service", MessageName = "ProtienAdd", EnableSession = true)]
        public int AddProtien(int amount,int userId)
        {
            if (Session["user"+userId] != null)
            {
                return  -1;
            }

            var user = (User)Session["userID" + userId];
            user.Total += amount;
            // return amount;
            Session["user" + userId] = user;
            return user.Total;
        }


        [WebMethod( Description ="test web service",MessageName ="ProtienAdd1", EnableSession =true)]
        public int AddProtien1(int amount)
        {
            var total = 0;
            if (Session["total"] != null)
            {
                total = (int)Session["total"];
            }
                total += amount;
                Session["total"] = total;
                    return total;

           

           // return amount;
        }

        [WebMethod(Description = "test web service", MessageName = "AddUsers", EnableSession = true)]
        public int AddUser(string name,int goal)
        {
            var userID = 0;
            if (Session["userID"] != null)
            {
                userID = (int)Session["userID"];
            }
           
            Session["userID" + userID] = new User { Goal= goal, Name = name, Total =0, UserID =userID};

            Session["userID"] = userID + 1;

            return userID;



            // return amount;
        }

        [WebMethod(Description = "test web service", MessageName = "listuser", EnableSession = true)]
        public List<User> ListUsers()
        {

            var users = new List<User>();
            var userID = 0;
            if (Session["userID"] != null)
            {
                userID = (int)Session["userID"];
            }
            for (var i = 0; i < userID; i++)
            {

                users.Add((User) Session["userID" + i]);

            }
            return users;

        }


    }
}
