using Data.Entities;

namespace Laboratorium3_App.Models
{
    public class ContactMapper
    {
        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity()
            {
                Name = model.Name,
                Email = model.Email,
                Birth = model.Birth,
                Phone = model.Phone,
                Id = model.Id,
                OrganizationId = model.OrganizationId
                // Priority =(int) model.Priority
            };
        } 

        public static Contact FromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Name = entity.Name,
                Email = entity.Email,
                Birth = entity.Birth,
                Phone = entity.Phone,
                Id = entity.Id,
                OrganizationId = entity.OrganizationId
                //Priority=(Priority)entity.Priority
            };
        }
    }
}
