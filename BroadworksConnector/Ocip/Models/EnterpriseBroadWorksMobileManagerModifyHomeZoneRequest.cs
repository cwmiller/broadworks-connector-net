using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing home zone in the BroadWorks Mobile Manager.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:350""}]")]
    public class EnterpriseBroadWorksMobileManagerModifyHomeZoneRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:350")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _homeZoneId;

        [XmlElement(ElementName = "homeZoneId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:350")]
        public string HomeZoneId
        {
            get => _homeZoneId;
            set
            {
                HomeZoneIdSpecified = true;
                _homeZoneId = value;
            }
        }

        [XmlIgnore]
        public bool HomeZoneIdSpecified { get; set; }

        private string _homeZoneDomainName;

        [XmlElement(ElementName = "homeZoneDomainName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:350")]
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
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:350")]
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
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:350")]
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
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:350")]
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
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:350")]
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
