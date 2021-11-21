using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySpot.Infrastructure.EF.Entity
{
    public class AppUsers : IdentityUser
    {
        public string Name { get; set; }
        public string GuardianName { get; set; }
        //public string AadhaarNumber { get; set; }
        //public string PanNumber { get; set; }
        public byte[] ProfileImage { get; set; }

        public WorkInfo WorkInfo { get; set; }
        public ResidenceAddressInfo ResidenceAddressInfo { get; set; }
        public List<KycInfo> KycInfos { get; set; }
    }

    public class WorkInfo
    {
        public int Id { get; set; }
        public string AppUsersId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public string StoreCity { get; set; }
        public string StoreState { get; set; }
        public string StorePincode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class KycInfo
    {
        public int Id { get; set; }
       
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public byte[] DocumentImage { get; set; }
    }

    public class ResidenceAddressInfo
    {
        public int Id { get; set; }
        public string AppUsersId { get; set; }
        public string ResidenceType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
    }
}
