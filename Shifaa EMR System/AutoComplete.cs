using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Shifaa_EMR_System
{
    class AutoComplete
    {

        static SqlConnection conDataBase = new SqlConnection(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        static SqlDataReader reader;

        public static AutoCompleteStringCollection AllergyNameAutoComplete()
        {


            string Query = "SELECT AllergieName FROM dbo.AllergiesDatabase ;";
            SqlCommand command = new SqlCommand(Query, conDataBase);
            AutoCompleteStringCollection allergyNameCollection = new AutoCompleteStringCollection();
       
            try
            {
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
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string LabTestName = reader.GetString(0);


                    labnamecollection.Add(LabTestName);


                }

                reader.Close();
                conDataBase.Close();

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
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string LabTestName = reader.GetString(0);


                    drugnamecollection.Add(LabTestName);


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
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string LabTestName = reader.GetString(0);


                    scannamecollection.Add(LabTestName);


                }

                reader.Close();

                return scannamecollection;
                conDataBase.Close();
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }



    }


}
