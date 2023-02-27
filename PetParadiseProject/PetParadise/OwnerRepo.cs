using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace PetParadise
{
    public class OwnerRepo
    {
        private List<Owner> owners = new List<Owner>();
        private string connectionString = "Server = 10.56.8.36; Database = DB_2023_68; User Id = STUDENT_68; Password = OPENDB_68; TrustServerCertificate=true";
        public OwnerRepo()
        {
            // Load all owner data from database via SQL statements and populate owner repository
            GetAll();
        }

        public int Add(Owner owner)
        {
            // Add new owner to database and to repository
            // Return the database id of the owner

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Owner> GetAll()
        {
            // Retrieve all owners from database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT OwnerId, OwnerFirstName, OwnerLastName, OwnerPhone, OwnerEmail FROM OWNER", connection);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Owner owner = new Owner
                        {
                            OwnerId = int.Parse(dataReader["OwnerId"].ToString()),
                            FirstName = dataReader["OwnerFirstName"].ToString(),
                            LastName = dataReader["OwnerLastName"].ToString(),
                            Phone = dataReader["OwnerPhone"].ToString(),
                            Email = dataReader["OwnerEmail"].ToString(),
                        };
                        owners.Add(owner);
                    }
                }
            }
            return owners;
        }
        public Owner GetById(int id)
        {
            // Get owner by id from database

            Owner result = null;

            // IMPLEMENT THIS!

            return result;
        }
        public void Update(Owner owner)
        {
            // Update existing owner on database

            // IMPLEMENT THIS!
        }
        public void Remove(Owner owner)
        {
            // Delete existing owner in database

            // IMPLEMENT THIS!
        }

    }
}
