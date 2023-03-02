using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetParadise
{
    public class PetRepo
    {
        private List<Pet> pets = new List<Pet>();
        private string connectionString = "Server = 10.56.8.36; Database = DB_2023_68; User Id = STUDENT_68; Password = OPENDB_68; TrustServerCertificate=true";

        public PetRepo()
        {
            // Load all pet data from database via SQL statements and populate pet repository
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT PetID, PetName, PetType, PetBreed, PetDOB, PetWeight FROM PET", connection);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Pet pet;
                        if (dataReader["PetDOB"] == DBNull.Value)
                        {
                            pet = new Pet
                            {
                                PetId = int.Parse(dataReader["PetID"].ToString()),
                                Name = dataReader["PetName"].ToString(),
                                PetType = (PetTypes)Enum.Parse(typeof(PetTypes), dataReader["PetType"].ToString()),
                                Breed = dataReader["PetBreed"].ToString(),
                                DOB = DateTime.MinValue,
                                Weight = double.Parse(dataReader["PetWeight"].ToString()),
                            };
                        }
                        else
                        {
                            pet = new Pet
                            {
                                PetId = int.Parse(dataReader["PetID"].ToString()),
                                Name = dataReader["PetName"].ToString(),
                                PetType = (PetTypes)Enum.Parse(typeof(PetTypes), dataReader["PetType"].ToString()),
                                Breed = dataReader["PetBreed"].ToString(),
                                DOB = DateTime.Parse(dataReader["PetDOB"].ToString()),
                                Weight = double.Parse(dataReader["PetWeight"].ToString()),
                            };
                        }
                        pets.Add(pet);
                    }
                }
            }
        }

        public int Add(Pet pet)
        {
            // Add new pet to database and to repository
            // Return the database id of the pet

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Pet> GetAll()
        {
            // Retrieve all pets from database
            return pets;
        }
        public Pet GetById(int id)
        {
            // Get pet by id from database
            Pet pet = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT PetID, PetName, PetType, PetBreed, PetDOB, PetWeight FROM PET WHERE PetID =" + id, connection);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        if (dataReader["PetDOB"] == DBNull.Value)
                        {
                            pet = new Pet
                            {
                                PetId = int.Parse(dataReader["PetID"].ToString()),
                                Name = dataReader["PetName"].ToString(),
                                PetType = (PetTypes)Enum.Parse(typeof(PetTypes), dataReader["PetType"].ToString()),
                                Breed = dataReader["PetBreed"].ToString(),
                                DOB = DateTime.MinValue,
                                Weight = double.Parse(dataReader["PetWeight"].ToString()),
                            };
                            return pet;
                        }
                        else
                        {
                            pet = new Pet
                            {
                                PetId = int.Parse(dataReader["PetID"].ToString()),
                                Name = dataReader["PetName"].ToString(),
                                PetType = (PetTypes)Enum.Parse(typeof(PetTypes), dataReader["PetType"].ToString()),
                                Breed = dataReader["PetBreed"].ToString(),
                                DOB = DateTime.Parse(dataReader["PetDOB"].ToString()),
                                Weight = double.Parse(dataReader["PetWeight"].ToString()),
                            };
                            return pet;
                        }
                    }
                }
            }
            return pet;
        }
        public void Update(Pet pet)
        {
            // Update existing pet on database

            // IMPLEMENT THIS!
        }
        public void Remove(Pet pet)
        {
            // Delete existing pet in database

            // IMPLEMENT THIS!
        }
    }
}
