using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelExpertsASP
{
    // Customer class - used to store registration and log in information of customer
    public class Customer
    {
        public Customer() { }

        // create properties 
        public int? CustomerId { get; set; }

        public string CustFirstName {get; set;}

        public string CustLastName { get; set; }

        public string CustAddress { get; set; }

        public string CustCity { get; set; }

        public string CustProv { get; set; }

        public string CustPostal { get; set; }

        public string CustCountry { get; set; }

        public string CustHomePhone { get; set; }

        public string CustBusPhone { get; set; }

        public string CustEmail { get; set; }

        //public int? AgentId { get; set; }

        public string CustUserName { get; set; }

        public string CustPassword { get; set; }


        public Customer(string custFirstName, string custLastName, string custAddress, string custCity,
                    string custProv, string custPostal, string custCountry, string custHomePhone,
                    string custBusPhone, string custEmail, //int? agentId
                    string custUserName, string custPassword)
        {
            CustFirstName = custFirstName;
            CustLastName = custLastName;
            CustAddress = custAddress;
            CustCity = custCity;
            CustProv = custProv;
            CustPostal = custPostal;
            CustCountry = custCountry;
            CustHomePhone = custHomePhone;
            CustBusPhone = custBusPhone;
            CustEmail = custEmail;
            //AgentId = agentId;
            CustUserName = custUserName;
            CustPassword = custPassword;
        }

    }

}