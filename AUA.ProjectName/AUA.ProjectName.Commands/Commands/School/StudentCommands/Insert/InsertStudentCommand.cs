using AUA.Infrastructure.CommandInfra.Command;

namespace AUA.ProjectName.Commands.Commands.School.StudentCommands.Insert
{
    public class InsertStudentCommand : BaseCommand<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long UserCreatorId { get; set; }
    }
}
