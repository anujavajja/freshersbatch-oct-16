using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net
{
    internal class Demo2
    {
        static void Main(string[] args)
        {
            
            string ConnectionString = "Data Source=anujavm;Initial Catalog=\"Sql Server\";Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {
                
                
                Console.WriteLine("Connection established succefully");
                string answer;
                do
                {
                    Console.WriteLine("Select from the Options below\n1.Creation\n2.Retrieve\n3.Update\n4.Delete");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:

                            //create => CRUD
                            Console.WriteLine("Enter your id");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Name of the Employee");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Enter salary");
                            int salary = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter your age");
                            int age = int.Parse(Console.ReadLine());
                            string insertQuery = "INSERT INTO Table_1(ID,[NAME OF THE EMPLOYEE],SALARY,AGE) VALUES(" + id + ",'" + Name + "'," + salary + ", " + age + ")";
                            SqlCommand insercommand = new SqlCommand(insertQuery, con);
                            insercommand.ExecuteNonQuery();
                            Console.WriteLine("Data is succefully inserted into table");
                            break;
                        case 2:
                            //Retrive the data;
                            string displayaQuery = "SELECT * FROM Table_1";
                            SqlCommand displaycmd = new SqlCommand(displayaQuery, con);
                            SqlDataReader dr = displaycmd.ExecuteReader();
                            while (dr.Read())
                            {
                                Console.Write("ID : " + dr.GetValue(0).ToString() + "\n");
                                Console.Write("Name : " + dr.GetValue(1).ToString());
                                Console.Write("\nSalary : " + dr.GetValue(2).ToString());
                                Console.Write("\nAge : " + dr.GetValue(3).ToString() + "\n");
                            }
                            dr.Close();
                            break;
                        case 3:
                            //Updation
                            Console.WriteLine("Enter the employee id that you would be update");
                            id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the salary of employee to update ");
                            salary = int.Parse(Console.ReadLine());
                            string UpdateQuery = "UPDATE Table_1 SET SALARY =" + salary + "WHERE ID =" + id + "";
                            SqlCommand updatecommand = new SqlCommand(UpdateQuery, con);
                            updatecommand.ExecuteNonQuery();
                            Console.WriteLine("The data is successfully Updated as you required");
                            break;
                        case 4:

                            //Deletion
                            int d_id;
                            Console.WriteLine("please enter ID of record that is to be deleted");
                            d_id = int.Parse(Console.ReadLine());
                            string deleteQuery = "DELETE FROM Table_1 WHERE ID = " + d_id;
                            SqlCommand delete = new SqlCommand(deleteQuery, con);
                            delete.ExecuteNonQuery();
                            Console.WriteLine("the Data is Deleted Succefully");
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                    Console.WriteLine("Do You Want to Continue ?");
                    answer = Console.ReadLine();
                   
                } while (answer != "NO");
                answer.ToLower();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                con.Close();   

            }
        }
    }
}
