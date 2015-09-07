using MyFollow1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyFollow1.DAL
{
        public class ApplicationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationContext>
        {
            protected override void Seed(ApplicationContext context)
            {
                var endusers = new List<EndUser>
            {
            new EndUser{emailID="carson@gamil.com",DateOfJoin=DateTime.Parse("1/2/2013"),Gender="M",DateOfBirth=DateTime.Parse("1968-09-01"),Address=("Str1,Str2,City,State,Country,Pin"), ContactNumber=("9426387764")},
            new EndUser{emailID="alex@yahoo.com",DateOfJoin=DateTime.Parse("5/2/2013"),Gender="M",DateOfBirth=DateTime.Parse("1992-06-02"),Address=("Str1,Str2,City,State,Country,Pin"), ContactNumber=("9426387765")},
            new EndUser{emailID="gandalf@yahoo.com",DateOfJoin=DateTime.Parse("7/5/2014"),Gender="M",DateOfBirth=DateTime.Parse("1987-10-09"),Address=("Str1,Str2,City,State,Country,Pin"), ContactNumber=("9426387766")},
            new EndUser{emailID="Natalie@gamil.com",DateOfJoin=DateTime.Parse("4/8/2014"),Gender="F",DateOfBirth=DateTime.Parse("1975-12-15"),Address=("Str1,Str2,City,State,Country,Pin"), ContactNumber=("9426387767")},
           
            };
                
                var appowners = new List<AppOwner>
             {
             new AppOwner{emailID="harry.com",CompanyName=("abc"),Description= ("System Analyst"), DateOfJoin=DateTime.Parse("5/2/2014"),FoundedIn = ("2012"),Address=("Str1,Str2,City,State,Country,Pin"), ContactNumber=("9426387765"), WebsiteUrl=("MyFollow.app"), TwitterHandler=("cool_Harry@1369"), FacebookUrl=("https:\\har_facebook.com")},
             new AppOwner{emailID="louis.com",CompanyName=("mno"),Description= ("Data Analyst"), DateOfJoin=DateTime.Parse("8/9/2012"),FoundedIn = ("2012"),Address=("Str1,Str2,City,State,Country,Pin"), ContactNumber=("9426387764"), WebsiteUrl=("MyFollow.app"), TwitterHandler=("crazy_louis@1369"), FacebookUrl=("https:\\louis_facebook.com")},
             new AppOwner{emailID="tom.com",CompanyName=("pqr"),Description= ("System Analyst"), DateOfJoin=DateTime.Parse("29/4/2014"),FoundedIn = ("2012"),Address=("Str1,Str2,City,State,Country,Pin"), ContactNumber=("9426387763"), WebsiteUrl=("MyFollow.app"), TwitterHandler=("peeping_tom@1369"), FacebookUrl=("https:\\tom_facebook.com")},
             new AppOwner{emailID="liam.com",CompanyName=("xyz"),Description= ("Developer"), DateOfJoin=DateTime.Parse("17/3/2013"),FoundedIn = ("2012"),Address=("Str1,Str2,City,State,Country,Pin"), ContactNumber=("9426387762"), WebsiteUrl=("MyFollow.app"), TwitterHandler=("simply_Liam@1369"), FacebookUrl=("https:\\liam_facebook.com")},
             };
            }
        }
    }
