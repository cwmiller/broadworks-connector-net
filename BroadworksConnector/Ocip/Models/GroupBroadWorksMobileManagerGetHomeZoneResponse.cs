using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupBroadWorksMobileManagerGetHomeZoneRequest
    /// <see cref="GroupBroadWorksMobileManagerGetHomeZoneRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1894""}]")]
    public class GroupBroadWorksMobileManagerGetHomeZoneResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _homeZoneDomainName;

        [XmlElement(ElementName = "homeZoneDomainName", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1894")]
        [MinLength(1)]
        [MaxLength(100)]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1894")]
        [MinLength(1)]
        [MaxLength(3)]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1894")]
        [MinLength(1)]
        [MaxLength(3)]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1894")]
        [MinLength(1)]
        [MaxLength(5)]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1894")]
        [MinLength(1)]
        [MaxLength(5)]
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
