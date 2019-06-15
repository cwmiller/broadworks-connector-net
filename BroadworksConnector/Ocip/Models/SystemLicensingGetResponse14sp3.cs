using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLicensingGetRequest14sp3. The subscriber license table columns are: "Name", "Licensed", "Used" and "Available".
    /// The group service license table columns are: "Name", "Licensed", "Used" and "Available".
    /// The virtual service license table columns are: "Name", "Licensed", "Used" and "Available".
    /// The user service license table columns are: "Name", "Licensed", "Used", "Available", "Used By Hosted Users", "Used By Trunk Users", and "Expiration Date".
    /// The system param license table columns are: "Name", "Licensed", "Used", Available".
        /// <see cref="SystemLicensingGetRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetResponse14sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.LicenseStrictness _licenseStrictness;

        [XmlElement(ElementName = "licenseStrictness", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LicenseStrictness LicenseStrictness {
            get => _licenseStrictness;
            set {
                LicenseStrictnessSpecified = true;
                _licenseStrictness = value;
            }
        }

        [XmlIgnore]
        public bool LicenseStrictnessSpecified { get; set; }
        
        private int _groupUserlimit;

        [XmlElement(ElementName = "groupUserlimit", IsNullable = false, Namespace = "")]
        public int GroupUserlimit {
            get => _groupUserlimit;
            set {
                GroupUserlimitSpecified = true;
                _groupUserlimit = value;
            }
        }

        [XmlIgnore]
        public bool GroupUserlimitSpecified { get; set; }
        
        private string _expirationDate;

        [XmlElement(ElementName = "expirationDate", IsNullable = false, Namespace = "")]
        public string ExpirationDate {
            get => _expirationDate;
            set {
                ExpirationDateSpecified = true;
                _expirationDate = value;
            }
        }

        [XmlIgnore]
        public bool ExpirationDateSpecified { get; set; }
        
        private List<string> _hostId;

        [XmlElement(ElementName = "hostId", IsNullable = false, Namespace = "")]
        public List<string> HostId {
            get => _hostId;
            set {
                HostIdSpecified = true;
                _hostId = value;
            }
        }

        [XmlIgnore]
        public bool HostIdSpecified { get; set; }
        
        private List<string> _licenseName;

        [XmlElement(ElementName = "licenseName", IsNullable = false, Namespace = "")]
        public List<string> LicenseName {
            get => _licenseName;
            set {
                LicenseNameSpecified = true;
                _licenseName = value;
            }
        }

        [XmlIgnore]
        public bool LicenseNameSpecified { get; set; }
        
        private int _numberOfTrunkUsers;

        [XmlElement(ElementName = "numberOfTrunkUsers", IsNullable = false, Namespace = "")]
        public int NumberOfTrunkUsers {
            get => _numberOfTrunkUsers;
            set {
                NumberOfTrunkUsersSpecified = true;
                _numberOfTrunkUsers = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfTrunkUsersSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _subscriberLicenseTable;

        [XmlElement(ElementName = "subscriberLicenseTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SubscriberLicenseTable {
            get => _subscriberLicenseTable;
            set {
                SubscriberLicenseTableSpecified = true;
                _subscriberLicenseTable = value;
            }
        }

        [XmlIgnore]
        public bool SubscriberLicenseTableSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _groupServiceLicenseTable;

        [XmlElement(ElementName = "groupServiceLicenseTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupServiceLicenseTable {
            get => _groupServiceLicenseTable;
            set {
                GroupServiceLicenseTableSpecified = true;
                _groupServiceLicenseTable = value;
            }
        }

        [XmlIgnore]
        public bool GroupServiceLicenseTableSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _virtualServiceLicenseTable;

        [XmlElement(ElementName = "virtualServiceLicenseTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable VirtualServiceLicenseTable {
            get => _virtualServiceLicenseTable;
            set {
                VirtualServiceLicenseTableSpecified = true;
                _virtualServiceLicenseTable = value;
            }
        }

        [XmlIgnore]
        public bool VirtualServiceLicenseTableSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _userServiceLicenseTable;

        [XmlElement(ElementName = "userServiceLicenseTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserServiceLicenseTable {
            get => _userServiceLicenseTable;
            set {
                UserServiceLicenseTableSpecified = true;
                _userServiceLicenseTable = value;
            }
        }

        [XmlIgnore]
        public bool UserServiceLicenseTableSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _systemParamLicenseTable;

        [XmlElement(ElementName = "systemParamLicenseTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SystemParamLicenseTable {
            get => _systemParamLicenseTable;
            set {
                SystemParamLicenseTableSpecified = true;
                _systemParamLicenseTable = value;
            }
        }

        [XmlIgnore]
        public bool SystemParamLicenseTableSpecified { get; set; }
        
    }
}
