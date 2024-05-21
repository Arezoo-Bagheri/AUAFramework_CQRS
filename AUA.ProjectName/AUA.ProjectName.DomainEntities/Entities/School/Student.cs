using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Tools.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUA.ProjectName.DomainEntities.Entities.School
{
    [Table("Student", Schema = SchemaConsts.School)]
    public class Student : DomainEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
