﻿using System;
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

        public List<Customer> GetALLCustomers()
        {
            List<Customer> q = new List<Customer>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.Customers.ToList();
            }

            return q;




        }

        public List<ProgamType> GetALLProgramTypesById(int id)
        {
            List<ProgamType> q = new List<ProgamType>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.ProgamTypes.Where(w=>w.CustomerId==id).ToList();
            }

            return q;




        }



        public List<AddOn> GetAllAddonsByCustomerId(int id)
        {
            List<AddOn> q = new List<AddOn>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.AddOns.Where(w=>w.CustomerId==id).ToList();
            }

            return q;




        }

        public List<ProgamType> GetAllProgramTypesByCustomerId(int id)
        {
            List<ProgamType> q = new List<ProgamType>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.ProgamTypes.Where(w => w.CustomerId == id).ToList();
            }

            return q;




        }

        public List<Implentat> GetAllImpentationsByCustomerId(int CustomerId)
        {
            List<Implentat> q = new List<Implentat>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.Implentats.Where(w => w.customerId == CustomerId).ToList(); 
            }

            return q;




        }

        public List<revenue> GetAlLRevenuByCustomerId(int CustomerId)
        {
            List<revenue> q = new List<revenue>();

            using (var myContext = new customerDbEntities())
            {

                q = myContext.revenues.Where(w => w.customerid == CustomerId).ToList();
            }

            return q;




        }
        public  List<CustomerCounty> GetALLCustomerCountiesForList(int CustomerId)
        {
            List<CustomerCounty> lookups = new List<CustomerCounty>();
            var q = new List<CustomerCounty>();
            using (var myContext = new customerDbEntities())
            {

                q = myContext.CustomerCountys.Where(w=>w.CustomerId ==CustomerId).ToList();
            }

            return q;


        }

        public BindingList<StandardLookup> GetALLCustomerCounties(    )
        {
            BindingList<StandardLookup> lookups = new BindingList<StandardLookup>();

            using (var myContext = new customerDbEntities())
            {
                var q = from lookup in myContext.StandardLookups
                        where lookup.lookupgroup==1 
                        orderby lookup.id ascending
                        select new
                        {
                            Code = lookup.id,
                            Description = lookup.code,
                        };

                if (q != null)
                {
                    Array.ForEach(q.ToArray(), l =>
                    {
                        lookups.Add(new StandardLookup(l.Code, l.Description));
                    });
                }
            }
            return lookups;
        }

        public BindingList<StandardLookup> GetStandardLookupByGroup(int groups)
        {
            BindingList<StandardLookup> lookups = new BindingList<StandardLookup>();

            using (var myContext = new customerDbEntities())
            {
                var q = from lookup in myContext.StandardLookups
                        where lookup.lookupgroup == groups
                        orderby lookup.id ascending
                        select new
                        {
                            Code = lookup.id,
                            Description = lookup.description,
                        };

                if (q != null)
                {
                    Array.ForEach(q.ToArray(), l =>
                    {
                        lookups.Add(new StandardLookup(l.Code, l.Description));
                    });
                }
            }
            return lookups;
        }


        public BindingList<StandardLookup> GetALLCustomerCountiesForList()
        {
            BindingList<StandardLookup> lookups = new BindingList<StandardLookup>();

            using (var myContext = new customerDbEntities())
            {
                var q = from lookup in myContext.StandardLookups
                        where lookup.lookupgroup==1
                        orderby lookup.id ascending
                        select new
                        {
                            Code = lookup.id,
                            Description = lookup.code,
                        };

                if (q != null)
                {
                    Array.ForEach(q.ToArray(), l =>
                    {
                        lookups.Add(new StandardLookup(l.Code, l.Description));
                    });
                }
            }
            return lookups;
        }

        public BindingList<StandardLookup> GetAlCustomersForSearch()
        {
            BindingList<StandardLookup> lookups = new BindingList<StandardLookup>();

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
                        lookups.Add(new StandardLookup(l.Code, l.Description));
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
        public ProgamType GetProgramTypeById(int Id)
        {
            using (var myContext = new customerDbEntities())
            {
                ProgamType q = myContext.ProgamTypes.Where(w => w.CustomerId == Id).FirstOrDefault();
                return q;
            }
        }



        public AddOn GetAddOnById(int Id)
        {
            using (var myContext = new customerDbEntities())
            {
                AddOn q = myContext.AddOns.Where(w => w.id == Id).FirstOrDefault();
                return q;
            }
        }

        public Implentat GetImplentationById(int Id)
        {
            using (var myContext = new customerDbEntities())
            {
                Implentat q = myContext.Implentats.Where(w => w.id == Id).FirstOrDefault();
                return q;
            }
        }

        public Customer GetCustomerById(int Id)
        {
            using (var myContext = new customerDbEntities())
            {
                Customer q = myContext.Customers.Where(w => w.id == Id).FirstOrDefault();
                return q;
            }
        }


        public revenue GetRevenueById(int id)
        {
            revenue q = new revenue();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.revenues.Where(w => w.id == id).FirstOrDefault();

            }

            return q;
        }


        public User ValidateUser(string txtUser,string password)
        {
            User q = new User();
            using (var myContext = new customerDbEntities())
            {
                q = myContext.Users.Where(w => w.UserName.Trim() == txtUser.Trim() || w.Pasword ==password).FirstOrDefault();

            }

            return q;
        }
        public CustomerContact GetCustomerContactById(int id)
        { CustomerContact q = new CustomerContact();
            using (var myContext = new customerDbEntities())
            {
              q= myContext.CustomerContacts.Where(w => w.id == id).FirstOrDefault();
          
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
        public List<CustomerContact> GetAlLContactsByCustomerId(int Id)
        {
            List<CustomerContact> q = new List<CustomerContact>();
            using (var myContext = new customerDbEntities())
            {
              q = myContext.CustomerContacts.Where(w => w.CustomerId == Id).ToList();
            }
            return q;

        }
    }
}