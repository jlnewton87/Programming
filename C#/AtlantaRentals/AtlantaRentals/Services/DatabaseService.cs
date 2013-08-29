using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using AtlantaRentals.Models;

namespace AtlantaRentals.Services
{
    public static class DatabaseService
    {
        public static DataTable GetDataTable(string p_selectQueryKey)
        {
            var connection = GetAccessConnection();
            connection.Open();
            OleDbCommand cmd = new OleDbCommand(DatabaseService.Queries[p_selectQueryKey], connection);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        //public static void DBUpdateQuery(string p_UpdateQueryKey, List<string> p_QueryParameters)
        //{
        //    var connection = GetAccessConnection();
        //    string commandString = String.Format(DatabaseService.Queries[p_UpdateQueryKey], );
        //    OleDbCommand cmd = new OleDbCommand(commandString, connection);
        //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //    da.UpdateCommand = cmd;
        //}

        //public static void DBInsertQuery(string p_InsertQueryKey, List<string> p_QueryParameters)
        //{
        //    var connection = GetAccessConnection();
        //    OleDbCommand cmd = new OleDbCommand(DatabaseService.Queries[p_InsertQueryKey], connection);
        //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //    da.InsertCommand = cmd;
        //}

        public static OleDbConnection GetAccessConnection()
        {
            string myConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Data\\AtlantaRentals.accdb;Persist Security Info=False;";
            OleDbConnection myConn = new OleDbConnection(myConnString);
            return myConn;
        }

        public static List<Branch> GetBranches()
        {
            List<Branch> output = new List<Branch>();
            List<BranchPhone> PhoneNumbers = new List<BranchPhone>();
            DataTable branchTable = GetDataTable("GetBranchInfo");
            foreach (DataRow row in branchTable.Rows)
            {
                Branch newBranch = new Branch();
                newBranch.BranchNumber = int.Parse(row["BranchNumber"].ToString());
                newBranch.Street = row["Street"].ToString();
                newBranch.City = row["City"].ToString();
                newBranch.State = row["State"].ToString();
                newBranch.Zip = row["Zip"].ToString();
                newBranch.ManagerId = row["ManagerId"].ToString();
                newBranch.Phone1 = row["Phone1"].ToString();
                newBranch.Phone2 = row["Phone2"].ToString();
                newBranch.Phone3 = row["Phone3"].ToString();
                output.Add(newBranch);
            }
            return output;
        }

        public static Dictionary<string, string> Queries
        {
            get { 
                return new Dictionary<string, string>() 
                {
                    {"GetNewspapers", "SELECT * FROM NEWSPAPER;"},
                    {"InsertNewspaper", "INSERT INTO NEWSPAPER (Street, City, State, Zip, Phone, ContactName, Name) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6});"},
                    {"UpdateNewspaper", "UPDATE NEWSPAPER SET Street = {0}, City = {1}, State = {2}, Zip = {3}, Phone = {4}, ContactName = {5}, Name = {6} WHERE [ID] = {7};"},
                    {"GetManagerIds", "SELECT managerId FROM MANAGER;"},
                    {"GetBranchNumbers", "SELECT BranchNumber FROM BRANCH;"},
                    {"InsertNewBranch", "INSERT INTO BRANCH (Street, City, State, Zip, ManagerId, Phone1, Phone2, Phone3) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7});"},
                    {"GetBranchInfo", "SELECT * FROM BRANCH;"},
                    {"UpdateBranch", "UPDATE BRANCH SET ManagerId = {0}, Street = {1}, City = {2}, State = {3}, Zip = {4}, Phone1 = {5}, Phone2 = {6}, Phone3 = {7} WHERE BranchNumber = {8};"},
                    {"InsertNewStaff", "INSERT INTO STAFF (Name, Street, City, State, Zip, Position, Salary, Gender, DOB, SupervisorId, BranchId) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10});"},
                    {"UpdateStaff", "UPDATE STAFF SET Name = {0}, Street = {1}, City = {2}, State = {3}, Zip = {4}, Position = {5}, Salary = {6}, Gender = {7}, DOB = {8}, SupervisorId = {9}, BranchId = {10} WHERE StaffId = {11};"},
                    {"GetStaffIds", "SELECT StaffId FROM STAFF;"},
                    {"InsertProperty", "INSERT INTO PROPERTY (Street, City, State, Zip, TypeId, NumRooms, MonthlyRent, AvailForPurchase, Price, OwnerId) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9});"},
                    {"UpdateProperty", "UPDATE PROPERTY SET Street = {0}, City = {1}, State = {2}, Zip = {3}, TypeId = {4}, NumRooms = {5}, MonthlyRent = {6}, AvailForPurchase = {7}, Price = {8}, OwnerId = {9} WHERE PropertyId = {10};"},
                    {"InsertPropertyOwner", "INSERT INTO PROPERTYOWNER (Name, Street, City, State, Zip, Phone, Email, Password, TypeOfBusiness, ContactName, PropertyOwnerTypeId) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10});"},
                    {"UpdatePropertyOwner", "UPDATE PROPERTYOWNER SET Name = {0}, Street = {1}, City = {2}, State = {3}, Zip = {4}, Phone = {5}, Email = {6}, Password = {7}, TypeOfBusiness = {8}, ContactName = {9}, PropertyOwnerTypeId = {10} WHERE [ID] = {11};"},
                    {"InsertLease", "INSERT INTO LEASE (ClientId, PropertyId, MethodOfPayment, DepositMade, Start, End, Approved) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6);"},
                    {"UpdateLease", "UPDATE LEASE SET ClientId = {0}, PropertyId = {1}, MethodOfPayment = {2}, DepositMade = {3}, Start = {4}, End = {5}, Approved = {6} WHERE [ID] = {7};"},
                    {"InsertViewing", "INSERT INTO PROPERTYVIEWING (ClientId, PropertyId, DTViewed, ClientComments) VALUES ({0}, {1}, {2}, {3});"},
                    {"UpdateViewing", "UPDATE PROPERTYVIEWING SET ClientId = {0}, PropertyId = {1}, DTViewed = {2}, ClientComments = {3} WHERE [ID] = {4};"},
                    {"InsertAd", "INSERT INTO AD (PropertyId, DTAdvertised, Cost, NewspaperId) VALUES ({0}, {1}, {2}, {3});"},
                    {"InsertRental", "INSERT INTO CURRENTLYRENTED (ManagingStaffId, PropertyId) VALUES ({0}, {1});"},
                    {"UpdateRental", "UPDATE CURRENTLYRENTED SET ManagingStaffId = {0}, PropertyId = {1} WHERE [ID] = {2};"},
                    {"UpdateAd", "UPDATE AD SET PropertyId = {0}, DTAdvertised = {1}, Cost = {2}, NewspaperId = {3} WHERE [ID] = {4};"},
                    {"InsertManager", "INSERT INTO MANAGER (ManagerStaffId, DTAssumedPosition, MonthlyBonus) VALUES ({0}, {1}, {2});"},
                    {"UpdateManager", "UPDATE MANAGER SET ManagerStaffId = {0}, DTAssumedPosition = {1}, MonthlyBonus = {2} WHERE ManagerId = {3};"},
                    {"CityList", "SELECT City FROM BRANCH;"},
                                                                //REPORTS//
                    {"BranchDetails", "SELECT * FROM BRANCH WHERE City = '{0}';"},
                    {"NumBranchesPerCity", "SELECT City, COUNT(*) AS [Number] FROM BRANCH GROUP BY CITY;"},
                    {"StaffInfo", "SELECT Name, StaffId, Position, Salary FROM STAFF ORDER BY Name DESC;"},
                    {"StaffNumAndSalary", "SELECT COUNT(*) as TotalStaff, SUM(Salary) as TotalSalary FROM STAFF;"},
                    {"RentedPropertiesByManager", "SELECT * FROM CURRENTLYRENTED WHERE ManagingStaffId = {0};"},
                    {"NumPropertiesAtBranch", "SELECT ManagingStaffId, COUNT(*) AS Total FROM CurrentlyRented WHERE ManagingStaffId IN (SELECT StaffId FROM STAFF WHERE BranchId = {0}) GROUP BY ManagingStaffId;"},
                    {"BusinessProperties", "SELECT * FROM PROPERTY WHERE OwnerId IN (SELECT [ID] FROM PROPERTYOWNER WHERE PropertyOwnerTypeId = 2);"},
                    {"NumPropertiesByType", "SELECT TypeId, COUNT(*) FROM PROPERTY GROUP BY TypeId;"},
                    {"MultiplePropertiesByPrivateOwner", "SELECT * FROM PROPERTYOWNER WHERE [ID] IN (SELECT OwnerId FROM PROPERTY WHERE TypeId = 1);"},
                    {"ClientInfo", "SELECT [ID], Name, Phone, PreferredAccomadation FROM CLIENT WHERE BranchId = {0};"},
                    {"AdvertisedProperties", "SELECT COUNT(*), AVERAGE(PropertyId) FROM AD ;"},
                    {"SupervisedTeams", "SELECT * FROM STAFF WHERE SupervisorId IN (SELECT StaffId FROM STAFF WHERE Name = {0});"},
                    {"AlphabeticalAssistants", "SELECT * FROM STAFF WHERE SupervisorId > 0 ORDER BY Name DESC;"},
                    {"ClientNames", "SELECT * FROM CLIENT WHERE StaffProcessedId = {0};"},
                    {"ClientByPropertyViewing", "SELECT Name, Phone FROM CLIENT WHERE [ID] IN (SELECT ClientId FROM PROPERTYVIEWING WHERE PropertyId = {0});"}
                }; 
            }
            set { }
        }
    }
}
