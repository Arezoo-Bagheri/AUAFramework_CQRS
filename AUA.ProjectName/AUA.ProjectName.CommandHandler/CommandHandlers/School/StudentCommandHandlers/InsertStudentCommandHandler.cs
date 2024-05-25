using AUA.ProjectName.Commands.Commands.School.StudentCommands.Insert;
using AUA.ProjectName.Common.Extensions.ValidationExtensions;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Infrastructure.CommandInfra.Handler.Base;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;

namespace AUA.ProjectName.CommandHandler.CommandHandlers.School.StudentCommandHandlers
{
    public class InsertStudentCommandHandler : BaseCommandHandler<InsertStudentCommand, long>
    {

        private readonly IStudentService _studentService;

        public InsertStudentCommandHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public override void Validation()
        {
            if (_request.FirstName.IsEmpty())
                AddError(InsertStudentResultStatus.FirstNameIsEmpty);

            if (_request.LastName.IsEmpty())
                AddError(InsertStudentResultStatus.LastNameIsEmpty);
        }

        public override async Task<ResultModel<long>> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var student = CreateStudent();
            var studentId = await _studentService.InsertAsync(student, cancellationToken);

            return CreateSuccessResult(studentId);
        }

        private Student CreateStudent()
        {
            return new Student
            {
                FirstName = _request.FirstName,
                LastName = _request.LastName,
                CreatorUserId = _request.UserCreatorId
            };

        }
    }
}
