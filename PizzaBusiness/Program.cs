using System;
using System.Data;
using System.Data.SqlClient;

namespace PizzaBusiness
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ine:
            Console.WriteLine("<-----------------------------|| Hello, Welcome to Pizza - Mania  ||----------------------------->");



            Console.WriteLine(" \n\n\n<---------------|| Press 1 for Admin Login and Press 2 for franchise owner Login  ||---------------> ");




            //\n\n<--------------|  |-------------->\n\n
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1://for admin login
                    string admin_username = "admin@123";
                    string admin_password = "admin@123";

                    Console.WriteLine("Enter Username : " );
                    string au = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter Password : ");
                    string ap = Convert.ToString(Console.ReadLine());
                    Menu1 me = new Menu1();//Menu1 access
                    SqlConnection con2 = new SqlConnection("server=localhost;database=PizzaBusinesws;integrated security=true");//Connection bridge to SQL
                                                                                                                                //Command Creation for inserting data//
                    if (admin_username == au && admin_password == ap)
                    {
                        Console.WriteLine("\n\n-----------------------------|| You have sucessfully log in to the ADMIN Account\n\n ||-----------------------------");

                        Console.WriteLine("\n\n <--------------| Press 1 for Menu related Query |-------------->");
                        Console.WriteLine("\n\n <--------------| Press 2 for  Franchise Owner details Query |-------------->");
                        int b = int.Parse(Console.ReadLine());
                        switch (b)
                        {
                            case 1:
                                //Console.WriteLine("\n\n<--------------| There items are avaliable in your Menu |-------------->\n\n");
                                //adding item in menu
                                Console.WriteLine("\n\n<--------------| Press 1 to add item in the Menu   |-------------->\n\n");
                                Console.WriteLine("\n\n<--------------| Press 2 to Delete item in the Menu   |-------------->\n\n");
                                Console.WriteLine("\n\n<--------------| Press 3 to Update item in the Menu   |-------------->\n\n");


                                int d = int.Parse(Console.ReadLine());
                                switch (d)
                                {

                                    case 1:
                                        

                                        Console.WriteLine("Enter Pizza Name");
                                        me.pname = Console.ReadLine();
                                        Console.WriteLine("Enter Pizza Size");
                                        me.size = Console.ReadLine();
                                        Console.WriteLine("Enter Pizza Price");
                                        me.price = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter available toppings");
                                        me.toppings = Console.ReadLine();
                                        Console.WriteLine("Enter preparing");
                                        me.time = Console.ReadLine();

                                        

                                        SqlCommand cmd1 = new("insert into Menu1 values('" + me.pname + "','" + me.size + "'," + me.price + ",'" + me.toppings + "','" + me.time + "')", con2);

                                        con2.Open();
                                        cmd1.ExecuteNonQuery();
                                        con2.Close();

                                        Console.WriteLine("\n\n-----------------------------|| Record inserted sucessfully   ||-----------------------------\n\n");

                                        break;
                                    case 2:
                                        
                                        Console.WriteLine("Enter order ID ");
                                        me.oid = int.Parse(Console.ReadLine());

                                        SqlCommand cmd3 = new SqlCommand("delete from Menu1 where m_id"+me.oid+"",con2);
                                        con2.Open();
                                        cmd3.ExecuteNonQuery();
                                        con2.Close();
                                        Console.WriteLine("\n\n-----------------------------|| Record Deleted sucessfully   ||-----------------------------\n\n");
                                        break;

                                    case 3:
                                        Console.WriteLine("Enter order ID ");
                                        me.oid = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter Pizza Name");
                                        me.pname = Console.ReadLine();
                                        Console.WriteLine("Enter Pizza Size");
                                        me.size = Console.ReadLine();
                                        Console.WriteLine("Enter Pizza Price");
                                        me.price = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter available toppings");
                                        me.toppings = Console.ReadLine();
                                        Console.WriteLine("Enter preparing");
                                        me.time = Console.ReadLine();

                                        SqlCommand cmd4 = new SqlCommand("UPDTE Menu1 set pizza_name='"+me.pname+"',available_sizes='"+me.size+"',price='"+me.price+"',tippings='"+me.toppings+"',p_time='"+me.time+"' where m_id="+me.oid+"", con2);
                                        con2.Open();
                                        cmd4.ExecuteNonQuery();
                                        con2.Close();
                                        Console.WriteLine("\n\n-----------------------------|| Record Deleted sucessfully   ||-----------------------------\n\n");

                                        break;
                                   // case 4:
                                     //   Console.WriteLine("Enter Order ID");
                                      //  me.oid=int.Parse(Console.ReadLine());
//
                                     //   SqlDataAdapter da = new SqlDataAdapter("Select * from Menu1",con2);
                                     //   DataSet ds = new DataSet();
                                     //   da.Fill(ds, "Menu1");
                                     //   int x = ds.Tables[0].Rows.Count;
                                      //  for (int i = 0; i < x; i++)
                                      //  {
                                   //         if (Menu1.m_id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                                     //       {
                                    //            Console.WriteLine("name :" + ds.Tables[0].Rows[i][1].ToString());
                                    //            Console.WriteLine("department :" + ds.Tables[0].Rows[i][2].ToString());
                                     //           Console.WriteLine("salary :" + ds.Tables[0].Rows[i][3].ToString());
                                     //           Console.WriteLine("gender :" + ds.Tables[0].Rows[i][4].ToString());
                                     //       }
                                     //   }


                                       // break;//
                                    default:
                                        break;
                                }
                               
                                  //add item menu end//
                                break;

                            case 2:
                                

                                //-----------------------------Display table of  Whole Franchise Owners--------------------------//
                               // SqlConnection con1 = new SqlConnection("server=localhost;database=PizzaBusinesws;integrated security=true");//Connection bridge to SQL
                                                                                                                                            //Command Creation for inserting data// 
                        






                                Console.WriteLine("\n\n<--------------| Press 1 to register any Franchise Owner in the Database    |-------------->\n\n");


                                //----------------------------------------------------------------
                                int c = int.Parse(Console.ReadLine());
                                switch (c)
                                {

                                    case 1:
                                         
                                        FranchiseOwnerDetails fr = new FranchiseOwnerDetails();
                                        start1:
                                        Console.WriteLine("<------------------ || Enter Details ||------------------>");

                                        Console.WriteLine("Enter name");
                                        fr.name = Console.ReadLine();
                                        Console.WriteLine("Enter Location");
                                        fr.location = Console.ReadLine();
                                        Console.WriteLine("Enter Salary");
                                        fr.salary = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter gender");
                                        fr.gender = Console.ReadLine();
                                        Console.WriteLine("Enter contact");
                                        fr.contact = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter email ID");
                                        fr.email = Console.ReadLine();

                                        SqlConnection con = new SqlConnection("server=localhost;database=PizzaBusinesws;integrated security=true");//Connection bridge to SQL
                                                                                                                                                    //Command Creation for inserting data//

                                        SqlCommand cmd = new("insert into f_owner_details values('" + fr.name + "','" + fr.location + "'," + fr.salary + ",'" + fr.gender + "'," + fr.contact + ",'" + fr.email + "')", con);

                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();

                                        Console.WriteLine("\n\n-----------------------------|| Record inserted sucessfully   ||-----------------------------\n\n");

                                        Console.WriteLine("press 1 for Register another details and press any key to exit");
                                        int m = int.Parse(Console.ReadLine());
                                        if (m == 1)
                                        {
                                            goto start1;
                                        }
                                        else
                                        {
                                            Console.WriteLine("< = == == == =  Data Saved =  == = = = = == = >");
                                            goto ine;
                                        }



                                        break;
                                }
                                break;
                        }
                    }
                     break;

                //---------------------------------------------------------------------------------------------------------------//
                case 2:// for Resturant Login

                    string franchise_username = "fran@123";
                    string franchise_password = "fran@123";

                    Console.WriteLine("Enter Username : ");
                    string fu = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter Password : ");
                    string fp = Convert.ToString(Console.ReadLine());

                    if (franchise_username == fu && franchise_password == fp)
                    {

                        Console.WriteLine("\n\n-----------------------------|| You have sucessfully log in to the Franchise Owner Account\n\n  ||-----------------------------");
                        start:
                        Console.WriteLine("Enter Record Details ");
                        Sales1 sa = new Sales1();

                        Console.WriteLine("Enter Resturant Name");
                        sa.rname = Console.ReadLine();
                        Console.WriteLine("Enter Resturant Location");
                        sa.rlocation = Console.ReadLine();
                        Console.WriteLine("Enter Pizza price");
                        sa.oprice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Order Type");
                        sa.otype = Console.ReadLine();


                        SqlConnection con3 = new SqlConnection("server=localhost;database=PizzaBusinesws;integrated security=true");//Connection bridge to SQL
                                                                                                                                    //Command Creation for inserting data//

                        SqlCommand cmd3 = new("insert into Sales1 values('" + sa.rname + "','" + sa.rlocation + "'," + sa.oprice + ",'" + sa.otype + "')", con3);

                        con3.Open();
                        cmd3.ExecuteNonQuery();
                        con3.Close();

                        Console.WriteLine("\n\n-----------------------------|| Record inserted sucessfully   ||-----------------------------\n\n");

                        Console.WriteLine("press 1 to insert another record or Press any key to exit ");
                        int s = int.Parse(Console.ReadLine());

                        if (s == 1)
                        {
                            goto start;
                        }
                        else
                        {
                            Console.WriteLine("< = == == == =  Data Saved =  == = = = = == = >");
                        }

                    }


                    break;

                //---------------------------------------------------------------------------------------------------------------//
                default:
                    Console.WriteLine("|||||||||||||||||||||||   Please Enter Something Valid  |||||||||||||||||||||||");
                    break ;
                    


            }
            goto ine;







        }
    }
}