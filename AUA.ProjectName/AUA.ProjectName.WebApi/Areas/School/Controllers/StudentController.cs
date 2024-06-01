using AUA.ProjectName.Commands.Commands.School.StudentCommands.Insert;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.School.Controllers
{
    [ApiVersion(ApiVersionConsts.V1)]
    public class StudentController : BaseApiController
    {

        [HttpPost]
        public async Task<ResultModel<long>> InsertStudentAsync(InsertStudentCommand command, CancellationToken cancellationToken)
        {
            command.UserCreatorId = UserId;
            return await RequestDispatcher.Send(command, cancellationToken);
        }

    }
}
