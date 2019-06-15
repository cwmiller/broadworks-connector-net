using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLicensingGetRequest. The license table columns are: "Name", "Licensed", "Used",
    /// "Available" and "Expiration Date".
    /// Replaced By: SystemLicensingGetResponse14sp3
        /// <see cref="SystemLicensingGetRequest"/>
        /// <see cref="SystemLicensingGetResponse14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _licenseTable;

        [XmlElement(ElementName = "licenseTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LicenseTable {
            get => _licenseTable;
            set {
                LicenseTableSpecified = true;
                _licenseTable = value;
            }
        }

        [XmlIgnore]
        public bool LicenseTableSpecified { get; set; }
        
    }
}
