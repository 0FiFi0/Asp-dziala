using Data;
using Data.Entities;

namespace Laboratorium3_App.Models
{
    public class EFContactService : IContactService
    {

        private readonly AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }
        public int Add(Contact contact)
        {
           var entity= _context.Contacts.Add(ContactMapper.ToEntity(contact));
            int id = entity.Entity.Id;
            _context.SaveChanges();
            return id;
        }

        public void Delete(int id)
        {
            ContactEntity? find=_context.Contacts.Find(id); 
            if (find != null)
            {
                _context.Contacts.Remove(find);
                _context.SaveChanges();
            }
            
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e=>ContactMapper.FromEntity(e)).ToList();
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
           return _context.Organizations.ToList();
        }

        public Contact? FindById(int id)
        {
            ContactEntity find=_context.Contacts.Find(id);
            return find == null?null : ContactMapper.FromEntity(find);
        }

        public PagingList<Contact> FindPage(int page,int size)
        {
           var data= _context.Contacts
                .OrderBy(c=>c.Name)
                .Skip((page-1)*size)
                .Take(size)
                .Select(ContactMapper.FromEntity)
                .ToList();
            return PagingList<Contact>.Create(data, _context.Contacts.Count(), page, size);
        }


        public void Update(Contact contact)
        {
            ContactEntity e=ContactMapper.ToEntity(contact);
            _context.Update(e);
            _context.SaveChanges();
        }
    }
}
