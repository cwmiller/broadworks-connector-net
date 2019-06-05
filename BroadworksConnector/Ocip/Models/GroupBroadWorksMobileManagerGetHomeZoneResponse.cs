using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupBroadWorksMobileManagerGetHomeZoneResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private string _homeZoneDomainName;

        [XmlElement(ElementName = "homeZoneDomainName", IsNullable = false, Namespace = "")]
        public string HomeZoneDomainName
        {
            get => _homeZoneDomainName;
            set
            {
                HomeZoneDomainNameSpecified = true;
                _homeZoneDomainName = value;
            }
        }

        [XmlIgnore]
        public bool HomeZoneDomainNameSpecified { get; set; }
        private string _mobileCountryCode;

        [XmlElement(ElementName = "mobileCountryCode", IsNullable = false, Namespace = "")]
        public string MobileCountryCode
        {
            get => _mobileCountryCode;
            set
            {
                MobileCountryCodeSpecified = true;
                _mobileCountryCode = value;
            }
        }

        [XmlIgnore]
        public bool MobileCountryCodeSpecified { get; set; }
        private string _mobileNetworkCode;

        [XmlElement(ElementName = "mobileNetworkCode", IsNullable = false, Namespace = "")]
        public string MobileNetworkCode
        {
            get => _mobileNetworkCode;
            set
            {
                MobileNetworkCodeSpecified = true;
                _mobileNetworkCode = value;
            }
        }

        [XmlIgnore]
        public bool MobileNetworkCodeSpecified { get; set; }
        private string _locationAreaCode;

        [XmlElement(ElementName = "locationAreaCode", IsNullable = false, Namespace = "")]
        public string LocationAreaCode
        {
            get => _locationAreaCode;
            set
            {
                LocationAreaCodeSpecified = true;
                _locationAreaCode = value;
            }
        }

        [XmlIgnore]
        public bool LocationAreaCodeSpecified { get; set; }
        private string _cellIdentity;

        [XmlElement(ElementName = "cellIdentity", IsNullable = false, Namespace = "")]
        public string CellIdentity
        {
            get => _cellIdentity;
            set
            {
                CellIdentitySpecified = true;
                _cellIdentity = value;
            }
        }

        [XmlIgnore]
        public bool CellIdentitySpecified { get; set; }
    }
}
