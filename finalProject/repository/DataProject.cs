
using Microsoft.VisualBasic;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Collections.Generic;
using entities;
using TaskStatus = entities.TaskStatus;
using Microsoft.EntityFrameworkCore;



namespace repository
{
    public class DataProject : DbContext
    {
        public DbSet<PossibleTask> PossibleTasks { get; set; }

        public DbSet<Volunteer> Volunteers { get; set; }

        public DbSet<Assignment> Assignments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FinalProjectDB"); 
        } 




        //static DataProject()
        //{
        //    PossibleTasks = new List<PossibleTask>
        //    {
        //        new PossibleTask(){ Id=1111, TaskDescription="cook for family with a sick boy",
        //           Date=new DateTime(2021,06,10), Location="Tel Aviv", Status=TaskStatus.open ,
        //            TaskType=AreasOfExpertise.cooking , Urgency=UrgencyTask.calm},

        //        new PossibleTask(){ Id=1112, TaskDescription="deliver groceries to elderly neighbor",
        //            Date=new DateTime(2021,05,24), Location="Jerusalem", Status=TaskStatus.completed ,
        //            TaskType=AreasOfExpertise.delivery , Urgency=UrgencyTask.middle},

        //        new PossibleTask(){ Id=1113, TaskDescription="walk the child for a busy parent",
        //            Date=new DateTime(2021,07,29), Location="Haifa", Status=TaskStatus.assigned ,
        //            TaskType=AreasOfExpertise.babysitting , Urgency=UrgencyTask.urgent},

        //        new PossibleTask(){ Id=1114, TaskDescription="tutor a student in mathematics",
        //            Date=new DateTime(2021,01,14), Location="Tel Aviv", Status=TaskStatus.completed ,
        //            TaskType=AreasOfExpertise.tutoring , Urgency=UrgencyTask.urgent},

        //        new PossibleTask(){ Id=1115, TaskDescription="help with garden maintenance",
        //            Date=new DateTime(2021,11,02), Location="Ashdod", Status=TaskStatus.assigned ,
        //            TaskType=AreasOfExpertise.gardening , Urgency=UrgencyTask.middle}
        //    };

        //    Volunteers = new List<Volunteer>
        //    {
        //        new Volunteer(){Id=5684, FullName="Rut Coehn", PhoneNumber="0548724591", 
        //            EmailAddress="r054@gmail.com" ,},

        //        new Volunteer(){Id=5685, FullName="David Levi", PhoneNumber="0528614592", 
        //            EmailAddress="david724@example.com",},

        //        new Volunteer(){Id=5686, FullName="Maya Roni", PhoneNumber="0538721193", 
        //            EmailAddress="m593@gmail.com", },

        //        new Volunteer(){Id=5687, FullName="Lior Cohen", PhoneNumber="0583424594", 
        //            EmailAddress="lior487@example.com",},

        //        new Volunteer(){Id=5688, FullName="Tamar Shapiro", PhoneNumber="0548724501", 
        //            EmailAddress="t782@gmail.com", }
        //    };
        //    Volunteers[0].PersonalAreasOfExpertise.Add(AreasOfExpertise.cooking);
        //    Volunteers[1].PersonalAreasOfExpertise.Add(AreasOfExpertise.delivery);
        //    Volunteers[2].PersonalAreasOfExpertise.Add(AreasOfExpertise.babysitting);
        //    Volunteers[3].PersonalAreasOfExpertise.Add(AreasOfExpertise.tutoring);
        //    Volunteers[4].PersonalAreasOfExpertise.Add(AreasOfExpertise.gardening);
        //    //
        //    Assignments = new List<Assignment>
        //    {
        //        new Assignment(){ codeId =0101 , VolunteerId=5684, TaskId=1111, 
        //            CompletionReportingTime=new DateTime(2022,06,10)},

        //        new Assignment(){ codeId =0202 , VolunteerId=5685, TaskId=1112,
        //            CompletionReportingTime=new DateTime(2022,09,14)},

        //        new Assignment(){codeId =0303 , VolunteerId=5686, TaskId=1113, 
        //            CompletionReportingTime = new DateTime(2022, 12, 03)},

        //        new Assignment(){ codeId =0404 ,VolunteerId=5688, TaskId=1114, 
        //            CompletionReportingTime=new DateTime(2022,04,05)},

        //        new Assignment(){ codeId =0505 ,VolunteerId=5688, TaskId=1115, 
        //            CompletionReportingTime=new DateTime(2022,10,27)}
        //    };
        //}
    }
}
