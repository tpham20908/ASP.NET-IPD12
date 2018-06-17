using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRentalStore.Models
{
    public class VideoRentalStoreRepository
    {
        VideoRentalStoreDBContext _context = new VideoRentalStoreDBContext();

        // get all customers
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        // get customer by Id
        public Customer GetCustomerById(int id)
        {
            return GetCustomers().FirstOrDefault(c => c.ID == id);
        }

        // update customer
        public void UpdateCustomer(int id, string firstName, string lastName, string address, string phoneNumber)
        {
            Customer c = GetCustomerById(id);

            if (!String.IsNullOrEmpty(firstName))
                c.FirstName = firstName;
            if (!String.IsNullOrEmpty(lastName))
                c.LastName = lastName;
            if (!String.IsNullOrEmpty(address))
                c.Address = address;
            if (!String.IsNullOrEmpty(phoneNumber))
                c.PhoneNumber = phoneNumber;

            _context.SaveChanges();
        }

        public List<Media> GetMediaListByCustomerId (int customerId)
        {
            //int custId = int.Parse(customerId);

            List<Media> medias = new List<Media>();

            List<RentalRecord> rentalRecords = (from r in _context.RentalRecords
                                                where r.customer.ID == customerId
                                                select r).ToList();

            if (rentalRecords != null)
            {
                foreach (RentalRecord record in rentalRecords)
                {
                    medias.AddRange(record.RentedMedias);
                }
            }

            return medias;
        }

        public IEnumerable<Media> GetMediaByTitle(string text)
        {
            return _context.Medias.Where(m => m.Title.Contains(text));
        }

        public void AddRentalRecord(int customerId, List<int> mediaIds)
        {
            List<Media> medias = new List<Media>();

            foreach (int mId in mediaIds)
            {
                medias.Add(_context.Medias.FirstOrDefault(m => m.ID == mId));
            }
            
            RentalRecord rentalRecord = new RentalRecord()
            {
                RentalDate = DateTime.Now,
                RentedMedias = medias
            };

            Customer c = GetCustomerById(customerId);

            if (c.RentalRecords == null)
            {
                c.RentalRecords = new List<RentalRecord>();
            }

            c.RentalRecords.Add(rentalRecord);
            _context.SaveChanges();
        }

        public void AddNewCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void AddNewMedia(Media media)
        {
            _context.Medias.Add(media);
            _context.SaveChanges();
        }
    }
}