using AUA.Infrastructure.BaseServices;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;

namespace AUA.ProjectName.Services.EntitiesService.School.Services
{
    public class StudentService : DomainEntityService<Student>, IStudentService
    {
    }
}
