using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomerService.Model;
using System.Data.Entity.Validation;
using System.ComponentModel;

namespace CustomerService.Classes
{


    public class CustomersContext : ContextBase

    {
        customerDbEntities _db = new customerDbEntities();

        public List<Customer> GetALLCustomers(int databaseId)
        {
            List<Customer> q = new List<Customer>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.Customers.Where(w=>w.databaseID ==databaseId).OrderBy(o=>o.CustomerName).ToList();
            }

            return q;




        }

        public string GetDatabaseNames(int databaseId)
        {
            UserDatabas q;

            using (var myContext = new customerDbEntities())
            {

                q = myContext.UserDatabases.Where(w => w.databaseID == databaseId).SingleOrDefault();
            }

            return q.DatabaseName;




        }
        public List<ContractDetail> GetAllContractsById(int id,int databaseId)
        {
            List<ContractDetail> q = new List<ContractDetail>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.ContractDetails.Where(w => w.CustomerId == id && w.databaseID == databaseId).ToList();
            }

            return q;




        }
        public List<ProgamType> GetALLProgramTypesById(int id,int databaseId)
        {
            List<ProgamType> q = new List<ProgamType>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.ProgamTypes.Where(w => w.CustomerId == id && w.databaseID == databaseId).ToList();
            }

            return q;




        }

        public List<User> GetAllUsers()
        {
            List<User> q = new List<User>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.Users.ToList();
            }

            return q;




        }


        public List<AddOn> GetAllAddonsByCustomerId(int id,int databaseId)
        {
            List<AddOn> q = new List<AddOn>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.AddOns.Where(w => w.CustomerId == id && w.databaseID == databaseId).ToList();
            }

            return q;




        }

        public List<ProgamType> GetAllProgramTypesByCustomerId(int id,int databaseId)
        {
            List<ProgamType> q = new List<ProgamType>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.ProgamTypes.Where(w => w.CustomerId == id && w.databaseID == databaseId).ToList();
            }

            return q;




        }

        public List<Implentat> GetAllImpentationsByCustomerId(int CustomerId,int databaseId)
        {
            List<Implentat> q = new List<Implentat>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.Implentats.Where(w => w.customerId == CustomerId && w.databaseID == databaseId).ToList();
            }

            return q;




        }

        public List<revenue> GetAlLRevenuByCustomerId(int CustomerId,int databaseId)
        {
            List<revenue> q = new List<revenue>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.revenues.Where(w => w.customerid == CustomerId && w.databaseID == databaseId).ToList();
            }

            return q;




        }
      

        public BindingList<StandardLookups> GetStandardLookupByGroup(int groups)
        {
            BindingList<StandardLookups> lookups = new BindingList<StandardLookups>();

            using (var myContext = new customerDbEntities())
            {
                var q = from lookup in myContext.StandardLookups
                        where lookup.lookupgroup == groups
                        orderby lookup.id ascending
                        select new
                        {
                            Code = lookup.id,
                            Description = lookup.description,
                            Value = lookup.description,
                        };

                if (q != null)
                {
                    Array.ForEach(q.ToArray(), l =>
                    {
                        lookups.Add(new StandardLookups(l.Code, l.Description, l.Value));
                    });
                }
            }
            return lookups;
        }

 

        public BindingList<StandardLookups> GetAllDatabasesForSearchByUser(int UserId)
        {
            BindingList<StandardLookups> lookups = new BindingList<StandardLookups>();

            using (var myContext = new customerDbEntities())
            {
                var q = from lookup in myContext.UserDatabases
                        where lookup.userId == UserId
                        orderby lookup.ID ascending
                        select new
                        {
                            Code = lookup.ID,
                            Description = lookup.DatabaseName,
                        };

                if (q != null)
                {
                    Array.ForEach(q.ToArray(), l =>
                    {
                        lookups.Add(new StandardLookups(l.Code, l.Description, ""));
                    });
                }
            }
            return lookups;
        }
        public BindingList<StandardLookups> GetAlCustomersForSearch()
        {
            BindingList<StandardLookups> lookups = new BindingList<StandardLookups>();

            using (var myContext = new customerDbEntities())
            {
                var q = from lookup in myContext.Customers
                        orderby lookup.id ascending
                        select new
                        {
                            Code = lookup.id,
                            Description = lookup.CustomerName,
                        };

                if (q != null)
                {
                    Array.ForEach(q.ToArray(), l =>
                    {
                        lookups.Add(new StandardLookups(l.Code, l.Description,""));
                    });
                }
            }
            return lookups;
        }
        public override int SaveChanges()
        {
            try
            {
                using (var myContext = new customerDbEntities())
                {
                    return myContext.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public void SaveUser(User _user)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.Users.Add(_user);
                    ctx.Entry(_user).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public void SaveCustomerContact(CustomerContact _customerContact)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.CustomerContacts.Add(_customerContact);
                    ctx.Entry(_customerContact).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public void SaveImplmentation(Implentat _newImp)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.Implentats.Add(_newImp);
                    ctx.Entry(_newImp).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public void SaveAddon(AddOn _addon)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.AddOns.Add(_addon);
                    ctx.Entry(_addon).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public void SaveCustomFields(CustomField _CustomFields)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.CustomFields.Add(_CustomFields);
                    ctx.Entry(_CustomFields).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public void SaveCustomerCounty(CustomerCounty _customerCounty)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.CustomerCountys.Add(_customerCounty);
                    ctx.Entry(_customerCounty).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public void SaveProgramTypes(ProgamType _programType)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.ProgamTypes.Add(_programType);
                    ctx.Entry(_programType).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public void SaveNote(Note _note)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.Notes.Add(_note);
                    ctx.Entry(_note).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public void SaveContractType(ContractDetail _contract)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.ContractDetails.Add(_contract);
                    ctx.Entry(_contract).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public void SaveCustomer(Customer _cust)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.Customers.Add(_cust);
                    ctx.Entry(_cust).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public void SaveLookup(StandardLookup _lookup)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.StandardLookups.Add(_lookup);
                    ctx.Entry(_lookup).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public void SaveRevenue(revenue _reve)
        {
            try
            {
                using (var ctx = new customerDbEntities())
                {
                    ctx.revenues.Add(_reve);
                    ctx.Entry(_reve).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public string GetCustomerNameById(int Id)
        {
            using (var myContext = new customerDbEntities())
            {
                Customer q = myContext.Customers.Where(w => w.id == Id).FirstOrDefault();
                return q.CustomerName;


            }

        }
        public ProgamType GetProgramTypeById(int Id ,int databaseId)
        {
            using (var myContext = new customerDbEntities())
            {
                ProgamType q = myContext.ProgamTypes.Where(w => w.id == Id && w.databaseID == databaseId).FirstOrDefault();
                return q;
            }
        }
        public User GetUserById(int Id)
        {
            using (var myContext = new customerDbEntities())
            {
                User q = myContext.Users.Where(w => w.id == Id).FirstOrDefault();
                return q;
            }
        }


        public AddOn GetAddOnById(int Id,int databaseId)
        {
            using (var myContext = new customerDbEntities())
            {
                AddOn q = myContext.AddOns.Where(w => w.id == Id && w.databaseID == databaseId).FirstOrDefault();
                return q;
            }
        }

        public Implentat GetImplentationById(int Id,int databaseId)
        {
            using (var myContext = new customerDbEntities())
            {
                Implentat q = myContext.Implentats.Where(w => w.id == Id && w.databaseID == databaseId).FirstOrDefault();
                return q;
            }
        }

        public Customer GetCustomerById(int Id ,int databaseId)
        {
            using (var myContext = new customerDbEntities())
            {
                Customer q = myContext.Customers.Where(w => w.id == Id && w.databaseID== databaseId).FirstOrDefault();
                return q;
            }
        }

                 public string GetStandardLookupDescription(int Id)
        {
            using (var myContext = new customerDbEntities())
            {
                StandardLookup q = myContext.StandardLookups.Where(w => w.id == Id).Single();
                return q.description;
            }
        }

        public revenue GetRevenueById(int id,int databaseId)
        {
            revenue q = new revenue();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.revenues.Where(w => w.id == id && w.databaseID ==databaseId).FirstOrDefault();

            }

            return q;
        }


     
        public StandardLookup GetLookupById(int id)
        {
            StandardLookup q = new StandardLookup();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.StandardLookups.Where(w => w.id == id).FirstOrDefault();

            }

            return q;
        }

        public User ValidateUser(string txtUser, string password)
        {
            User q = new User();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.Users.Where(w => w.UserName.Trim() == txtUser.Trim() && w.Pasword == password).FirstOrDefault();

            }

            return q;
        }
        public CustomerContact GetCustomerContactById(int id)
        {
            CustomerContact q = new CustomerContact();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.CustomerContacts.Where(w => w.id == id).FirstOrDefault();

            }

            return q;
        }

        public ContractDetail GetContractById(int id)
        {
            ContractDetail q = new ContractDetail();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.ContractDetails.Where(w => w.id == id).FirstOrDefault();

            }

            return q;
        }
        public CustomField GetCustomFieldById(int id)
        {
            CustomField q = new CustomField();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.CustomFields.Where(w => w.id == id).FirstOrDefault();

            }

            return q;
        }


        public Note GetNotesById(int id)
        {
            Note q = new Note();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.Notes.Where(w => w.id == id).FirstOrDefault();

            }

            return q;
        }
        public void AddToContact(CustomerContact newContact)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.CustomerContacts.Add(newContact);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }

        public void AddToUsers(User newUser)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.Users.Add(newUser);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void AddToCustomFields(CustomField custField)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.CustomFields.Add(custField);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void AddToAddon(AddOn newAddon)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.AddOns.Add(newAddon);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }


        public void AddToProgramType(ProgamType newProgramType)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.ProgamTypes.Add(newProgramType);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void AddToCustomer(Customer newCust)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.Customers.Add(newCust);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }

        public void AddToContract(ContractDetail contractDetail)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.ContractDetails.Add(contractDetail);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void AddToImplemtnation(Implentat newImp)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.Implentats.Add(newImp);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }

        public void AddToLookups(StandardLookup lookup)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.StandardLookups.Add(lookup);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }

        public void DeleteContract(ContractDetail contractDetail)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.ContractDetails.Attach(contractDetail);
                myContext.ContractDetails.Remove(contractDetail);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void DeleteContact(CustomerContact deleteContact)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.CustomerContacts.Attach(deleteContact);
                myContext.CustomerContacts.Remove(deleteContact);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void DeleteNote(Note deleteNote)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.Notes.Attach(deleteNote);
                myContext.Notes.Remove(deleteNote);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void DeleteCustomField(CustomField customFiled)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.CustomFields.Attach(customFiled);
                myContext.CustomFields.Remove(customFiled);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void DeleteImplmentation(Implentat deleteImplentation)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.Implentats.Attach(deleteImplentation);
                myContext.Implentats.Remove(deleteImplentation);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void DeleteRevenue(revenue deleteRevenue)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.revenues.Attach(deleteRevenue);
                myContext.revenues.Remove(deleteRevenue);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void DeleteAddon(AddOn deleteAddon)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.AddOns.Attach(deleteAddon);
                myContext.AddOns.Remove(deleteAddon);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }

        public void DeleteProgramType(ProgamType progtypes)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.ProgamTypes.Attach(progtypes);
                myContext.ProgamTypes.Remove(progtypes);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }


        public void DeleteUser(User deleteUser)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.Users.Attach(deleteUser);
                myContext.Users.Remove(deleteUser);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void AddToCounties(CustomerCounty newCounty)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.CustomerCountys.Add(newCounty);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void AddToNotes(Note newNote)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.Notes.Add(newNote);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void AddToRevenue(revenue newReve)
        {
            using (var myContext = new customerDbEntities())
            {
                myContext.revenues.Add(newReve);
                try
                {
                    myContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
        }
        public List<CustomerContact> GetAlLContactsByCustomerId(int Id,int databaseId)
        {
            List<CustomerContact> q = new List<CustomerContact>();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.CustomerContacts.Where(w => w.CustomerId == Id && w.databaseID==databaseId).ToList();
            }
            return q;

        }
        public List<CustomField> GetAllCustomFieldsByCustomer(int Id, int databaseId)
        {
            List<CustomField> q = new List<CustomField>();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.CustomFields.Where(w => w.CustomerId == Id && w.databaseID == databaseId).ToList();
            }
            return q;

        }


        public List<CustomField> GetAllCustomFields(int databaseId)
        {
            List<CustomField> q = new List<CustomField>();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.CustomFields.Where(w=>w.databaseID ==databaseId).ToList();
            }
            return q;

        }
        public List<StandardLookup> GetAllLookupsById(int Id)
        {
            List<StandardLookup> q = new List<StandardLookup>();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.StandardLookups.Where(w=>w.id==Id).ToList();
            }
            return q;

        }

        public List<User> GetAllUsers(int Id)
        {
            List<User> q = new List<User>();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.Users.ToList();
            }
            return q;

        }
        public List<Note> GetAlLNotesByCustomerId(int Id,int databaseId)
        {
            List<Note> q = new List<Note>();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.Notes.Where(w => w.CustomerId == Id && w.databaseID == databaseId).ToList();
            }
            return q;

        }
    }
}
