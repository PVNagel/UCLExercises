using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetParadise
{
    public class TreatmentRepo
    {
        private List<Treatment> treatments = new List<Treatment>();
        private string connectionString = "Server = 10.56.8.36; Database = DB_2023_68; User Id = STUDENT_68; Password = OPENDB_68; TrustServerCertificate=true";

        public TreatmentRepo()
        {
            // Load all treatment data from database via SQL statements and populate treatment repository
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TreatID, TreatService, TreatDate, TreatCharge FROM TREATMENT", connection);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Treatment treatment;
                        treatment = new Treatment
                        {
                            TreatId = int.Parse(dataReader["TreatID"].ToString()),
                            Service = dataReader["TreatService"].ToString(),
                            Date = DateTime.Parse(dataReader["TreatDate"].ToString()),
                            Charge = double.Parse(dataReader["TreatCharge"].ToString()),
                        };
                        treatments.Add(treatment);
                    }
                }
            }
        }

        public int Add(Treatment treatment)
        {
            // Add new treatment to database and to repository
            // Return the database id of the treatment

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Treatment> GetAll()
        {
            // Retrieve all treatments from database
            return treatments;
        }
        public Treatment GetById(int id)
        {
            // Get treatment by id from database
            Treatment treatment = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TreatID, TreatService, TreatDate, TreatCharge FROM TREATMENT WHERE TreatID =" + id, connection);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        treatment = new Treatment
                        {
                            TreatId = int.Parse(dataReader["TreatID"].ToString()),
                            Service = dataReader["TreatService"].ToString(),
                            Date = DateTime.Parse(dataReader["TreatDate"].ToString()),
                            Charge = double.Parse(dataReader["TreatCharge"].ToString()),
                        };
                        return treatment;
                    }
                }
            }
            return treatment;
        }
        public void Update(Treatment treatment)
        {
            // Update existing treatment on database

            // IMPLEMENT THIS!
        }
        public void Remove(Treatment treatment)
        {
            // Delete existing treatment in database

            // IMPLEMENT THIS!
        }
    }
}
