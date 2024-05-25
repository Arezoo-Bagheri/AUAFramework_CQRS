using System.ComponentModel;

namespace AUA.ProjectName.Commands.Commands.School.StudentCommands.Insert
{
    public enum InsertStudentResultStatus
    {
        [Description("Success")]
        Success = 0,

        [Description("FirstName Is Empty")]
        FirstNameIsEmpty = 1,

        [Description("LastName Is Empty")]
        LastNameIsEmpty = 2,
    }
}
