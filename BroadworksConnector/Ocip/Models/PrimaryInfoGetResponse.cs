using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Information about the primary server in the high-availablity cluster.
    /// For optimization, we only get the hostname and addresses for primary if they are
    /// explicitly requested or if the current server is not the primary.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:473""}]")]
    public class PrimaryInfoGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isPrimary;

        [XmlElement(ElementName = "isPrimary", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:473")]
        public bool IsPrimary
        {
            get => _isPrimary;
            set
            {
                IsPrimarySpecified = true;
                _isPrimary = value;
            }
        }

        [XmlIgnore]
        protected bool IsPrimarySpecified { get; set; }

        protected string _hostnameForPrimary;

        [XmlElement(ElementName = "hostnameForPrimary", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:473")]
        [MinLength(1)]
        [MaxLength(80)]
        public string HostnameForPrimary
        {
            get => _hostnameForPrimary;
            set
            {
                HostnameForPrimarySpecified = true;
                _hostnameForPrimary = value;
            }
        }

        [XmlIgnore]
        protected bool HostnameForPrimarySpecified { get; set; }

        protected List<string> _addressForPrimary = new List<string>();

        [XmlElement(ElementName = "addressForPrimary", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:473")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> AddressForPrimary
        {
            get => _addressForPrimary;
            set
            {
                AddressForPrimarySpecified = true;
                _addressForPrimary = value;
            }
        }

        [XmlIgnore]
        protected bool AddressForPrimarySpecified { get; set; }

        protected List<string> _privateAddressForPrimary = new List<string>();

        [XmlElement(ElementName = "privateAddressForPrimary", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:473")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> PrivateAddressForPrimary
        {
            get => _privateAddressForPrimary;
            set
            {
                PrivateAddressForPrimarySpecified = true;
                _privateAddressForPrimary = value;
            }
        }

        [XmlIgnore]
        protected bool PrivateAddressForPrimarySpecified { get; set; }

    }
}
