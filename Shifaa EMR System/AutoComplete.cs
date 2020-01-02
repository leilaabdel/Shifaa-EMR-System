using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShifaaEMRSystem
{
    class AutoComplete
    {

        readonly static SqlConnection conDataBase = new SqlConnection(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        static SqlDataReader reader;


        public static AutoCompleteStringCollection PatientLastNameAutoComplete()
        {
            AutoCompleteStringCollection patientLastNameCollection = new AutoCompleteStringCollection();


            string Query = "select LastName from dbo.Patient ;";
            SqlCommand command = new SqlCommand(Query, conDataBase);



            try
            {
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string lastName = reader.GetString(0);

                    patientLastNameCollection.Add(lastName.ToString());


                }

                reader.Close();
                conDataBase.Close();

                return patientLastNameCollection;
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static AutoCompleteStringCollection PatientFirstNameAutoComplete()
        {
            AutoCompleteStringCollection patientFirstNameCollection = new AutoCompleteStringCollection();


            string Query = "select FirstName from dbo.Patient ;";
            SqlCommand command = new SqlCommand(Query, conDataBase);



            try
            {
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string firstName = reader.GetString(0);

                    patientFirstNameCollection.Add(firstName.ToString());


                }

                reader.Close();
                conDataBase.Close();

                return patientFirstNameCollection;
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }


        public static AutoCompleteStringCollection PatientIDAutoComplete()
        {
            AutoCompleteStringCollection patientIDCollection = new AutoCompleteStringCollection();


            string Query = "select PatientID from dbo.Patient ;";
            SqlCommand command = new SqlCommand(Query, conDataBase);
      


            try
            {
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int patientID = reader.GetInt32(0);

                    patientIDCollection.Add(patientID.ToString());

                    
                }

                reader.Close();
                conDataBase.Close();

                return patientIDCollection;
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static AutoCompleteStringCollection AllergyNameAutoComplete()
        {


            string Query = "SELECT AllergieName FROM dbo.AllergiesDatabase ;";
            SqlCommand command = new SqlCommand(Query, conDataBase);
            AutoCompleteStringCollection allergyNameCollection = new AutoCompleteStringCollection();
       
            try
            {
                conDataBase.Close();
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    string AllergyName = reader.GetString(0);

  
                     allergyNameCollection.Add(AllergyName);

                       
                }

                reader.Close();
                conDataBase.Close();

                return allergyNameCollection;

              
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static AutoCompleteStringCollection LabNameCollection()
        {
            string Query = "SELECT LabTestName FROM dbo.LabTestNamesDatabase ;";
            SqlCommand command = new SqlCommand(Query, conDataBase);
            AutoCompleteStringCollection labnamecollection = new AutoCompleteStringCollection();

            try
            {
                conDataBase.Close();
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string LabTestName = reader.GetString(0);


                    labnamecollection.Add(LabTestName);


                }

                conDataBase.Close();
                reader.Close();
              

                return labnamecollection;
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static AutoCompleteStringCollection PrescriptionNameAutoComplete()
        {
            string Query = "SELECT DrugName FROM dbo.DrugDatabase;";
            SqlCommand command = new SqlCommand(Query, conDataBase);
            AutoCompleteStringCollection drugnamecollection = new AutoCompleteStringCollection();

            try
            {
                conDataBase.Close();
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string DrugName = reader.GetString(0);


                    drugnamecollection.Add(DrugName);


                }

                reader.Close();
                conDataBase.Close();

                return drugnamecollection;
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static AutoCompleteStringCollection ScanNameAutoComplete()
        {
            string Query = "SELECT ProcedureOrScanName FROM dbo.ProcedureAndScanDatabase;";
            SqlCommand command = new SqlCommand(Query, conDataBase);
            AutoCompleteStringCollection scannamecollection = new AutoCompleteStringCollection();

            try
            {
                conDataBase.Close();
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string ScanName = reader.GetString(0);


                    scannamecollection.Add(ScanName);


                }

                reader.Close();
                conDataBase.Close();
                return scannamecollection;
        
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static AutoCompleteStringCollection ProblemAutoComplete()
        {
            string Query = "SELECT ProblemName FROM dbo.ProblemListDatabase;";
            SqlCommand command = new SqlCommand(Query, conDataBase);
            AutoCompleteStringCollection problemnamecollection = new AutoCompleteStringCollection();

            try
            {
                conDataBase.Close();
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string ProblemName = reader.GetString(0);


                    problemnamecollection.Add(ProblemName);


                }


                Console.WriteLine(problemnamecollection[1]);
                Console.WriteLine(problemnamecollection[50]);
                reader.Close();
                conDataBase.Close();
                return problemnamecollection;

            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }



    }


}
