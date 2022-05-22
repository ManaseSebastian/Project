using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Services;
using System.Data.SqlClient;

namespace Server
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private SqlConnection myCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Facultate\\An III (Semestrul II)\\Informatica Industriala (II)\\Laboratoare\\Tema2\\Client\\Client\\MyDatabase.mdf; Integrated Security=True");

        [WebMethod]
        public void addPrice(string name, string type, double price)
        {
            try
            {
                myCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tarife", myCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet set = new DataSet();
                adapter.Fill(set, "Tarife");

                DataRow row = set.Tables["Tarife"].NewRow();
                row["Denumire"] = name;
                row["Tip"] = type;
                row["Pret"] = price;
                set.Tables["Tarife"].Rows.Add(row);
                adapter.Update(set, "Tarife");
                myCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        [WebMethod]
        public void deletePrice(string name)
        {
            try
            {
                myCon.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Tarife", myCon);
                SqlCommandBuilder builder1 = new SqlCommandBuilder(adapter1);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "Tarife");
                int code = -1;
                DataRow row = null;
                foreach (DataRow row1 in set1.Tables["Tarife"].Rows)
                {
                    if (name == row1.ItemArray.GetValue(1).ToString())
                    {
                        code = Convert.ToInt32(row1.ItemArray.GetValue(0));
                        row = row1;
                        break;
                    }
                }

                SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Programari", myCon);
                SqlCommandBuilder builder2 = new SqlCommandBuilder(adapter2);
                DataSet set2 = new DataSet();
                adapter2.Fill(set2, "Programari");
                foreach (DataRow row2 in set2.Tables["Programari"].Rows)
                {
                    if (code == Convert.ToInt32(row2.ItemArray.GetValue(1)))
                    {
                        row2.Delete();
                    }
                }
                adapter2.Update(set2, "Programari");

                row.Delete();
                adapter1.Update(set1, "Tarife");
                myCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        [WebMethod]
        public void updatePrice(string currentName, string name, string type, double price)
        {
            try
            {
                myCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tarife", myCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet set = new DataSet();
                adapter.Fill(set, "Tarife");
                int index = 0;
                foreach (DataRow row in set.Tables["Tarife"].Rows)
                {
                    if (row.ItemArray.GetValue(1).ToString() == currentName)
                    {
                        break;
                    }
                    index++;
                }
                set.Tables["Tarife"].Rows[index]["Denumire"] = name;
                set.Tables["Tarife"].Rows[index]["Tip"] = type;
                set.Tables["Tarife"].Rows[index]["Pret"] = price;
                adapter.Update(set, "Tarife");
                myCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        [WebMethod]
        public List<string> getDataPrice()
        {
            myCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tarife", myCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet set = new DataSet();
            adapter.Fill(set, "Tarife");
            List<string> list = new List<string>();
            foreach (DataRow row in set.Tables["Tarife"].Rows)
            {
                list.Add(row["Denumire"].ToString());
                list.Add(row["Tip"].ToString());
                list.Add(row["Pret"].ToString());
            }
            myCon.Close();
            return list;
        }

        [WebMethod]
        public void addPatient(string name, string firstName, string phoneNumber)
        {
            try
            {
                myCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pacienti", myCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet set = new DataSet();
                adapter.Fill(set, "Pacienti");

                DataRow row = set.Tables["Pacienti"].NewRow();
                row["Nume"] = name;
                row["Prenume"] = firstName;
                row["Telefon"] = phoneNumber;
                set.Tables["Pacienti"].Rows.Add(row);
                adapter.Update(set,"Pacienti");
                myCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        [WebMethod] 
        public void updatePatient(int index, string name, string firstName, string phoneNumber) {
            try
            {
                myCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pacienti", myCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet set = new DataSet();
                adapter.Fill(set, "Pacienti");
                
                set.Tables["Pacienti"].Rows[index]["Nume"] = name;
                set.Tables["Pacienti"].Rows[index]["Prenume"] = firstName;
                set.Tables["Pacienti"].Rows[index]["Telefon"] = phoneNumber;
                adapter.Update(set, "Pacienti");
                myCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        [WebMethod]
        public List<string> getDataPatient() {
            myCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pacienti", myCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet set = new DataSet();
            adapter.Fill(set, "Pacienti");
            List<string> list = new List<string>();
            foreach (DataRow row in set.Tables["Pacienti"].Rows) {
                list.Add(row["Nume"].ToString());
                list.Add(row["Prenume"].ToString());
                list.Add(row["Telefon"].ToString());
            }
            myCon.Close();
            return list;
        }

        [WebMethod]
        public void addProgramme(string treatment, string name,string firstName, DateTime time)
        {
            try
            {
                myCon.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Tarife", myCon);
                SqlCommandBuilder builder1 = new SqlCommandBuilder(adapter1);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "Tarife");
                int code = -1;
                foreach (DataRow dr in set1.Tables["Tarife"].Rows) {
                    if (dr.ItemArray.GetValue(1).ToString() == treatment) {
                        code = Convert.ToInt32(dr.ItemArray.GetValue(0));
                    }
                }

                SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Pacienti", myCon);
                SqlCommandBuilder builder2 = new SqlCommandBuilder(adapter2);
                DataSet set2 = new DataSet();
                adapter2.Fill(set2, "Pacienti");
                int id = -1;
                foreach (DataRow dr in set2.Tables["Pacienti"].Rows)
                {
                    if (dr.ItemArray.GetValue(1).ToString() == name && dr.ItemArray.GetValue(2).ToString() == firstName)
                    {
                        id = Convert.ToInt32(dr.ItemArray.GetValue(0));
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Programari", myCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet set = new DataSet();
                adapter.Fill(set, "Programari");

                DataRow row = set.Tables["Programari"].NewRow();
                row["Cod_Tarif"] = code;
                row["Id_Pacient"] = id;
                row["Data ORA"] = time;
                set.Tables["Programari"].Rows.Add(row);
                adapter.Update(set, "Programari");
                myCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        [WebMethod]
        public void deleteProgramme(string name, string firstName) {
            try {
                string names = name + " " + firstName;
                List<string> list = getNameProgramme();
                int index = list.IndexOf(names);
                
                myCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Programari", myCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet set = new DataSet();
                adapter.Fill(set, "Programari");
                DataRow row = set.Tables["Programari"].Rows[index];
                row.Delete();
                adapter.Update(set, "Programari");
                myCon.Close();            
            }
            catch (Exception ex) {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        [WebMethod]
        public List<string> getDataProgramme()
        {
            myCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Programari", myCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet set = new DataSet();
            adapter.Fill(set, "Programari");
            List<string> list = new List<string>();
            foreach (DataRow row in set.Tables["Programari"].Rows)
            {
                list.Add(row["Data ORA"].ToString());
            }            
            myCon.Close();
            return list;
        }

        [WebMethod]
        public List<string> getNameProgramme() {
            myCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Programari", myCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet set = new DataSet();
            adapter.Fill(set, "Programari");

            SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Pacienti", myCon);
            SqlCommandBuilder builder2 = new SqlCommandBuilder(adapter2);
            DataSet set2 = new DataSet();
            adapter2.Fill(set2, "Pacienti");
            List<string> list = new List<string>();
            foreach (DataRow row in set.Tables["Programari"].Rows)
            {
                int id = Convert.ToInt32(row["Id_Pacient"]);
                foreach (DataRow row1 in set2.Tables["Pacienti"].Rows)
                {
                    if (id == Convert.ToInt32(row1["Id_Pacient"]))
                    {
                        list.Add(row1["Nume"].ToString() + " " + row1["Prenume"].ToString());
                    }
                }
            }
            myCon.Close();
            return list;
        }

        [WebMethod]
        public List<string> getPriceProgramme() {
            myCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Programari", myCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet set = new DataSet();
            adapter.Fill(set, "Programari");

            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Tarife", myCon);
            SqlCommandBuilder builder1 = new SqlCommandBuilder(adapter1);
            DataSet set1 = new DataSet();
            adapter1.Fill(set1, "Tarife");
            List<string> list = new List<string>();
            foreach (DataRow row in set.Tables["Programari"].Rows)
            {
                int code = Convert.ToInt32(row["Cod_Tarif"]);
                foreach (DataRow row1 in set1.Tables["Tarife"].Rows)
                {
                    if (code == Convert.ToInt32(row1["Cod_Tarif"]))
                    {
                        list.Add(row1["Denumire"].ToString());
                    }
                }
            }
            myCon.Close();
            return list;
        }
    }
}
