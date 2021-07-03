using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemServerAddressesGetRequest.
    /// Contains a list of system Server Addresses.
    /// See also:
    /// PrimaryInfoGetResponse
    /// PublicClusterGetFullyQualifiedDomainNameResponse
    /// ServingInfoGetResponse
    /// <see cref="SystemServerAddressesGetRequest"/>
    /// <see cref="PrimaryInfoGetResponse"/>
    /// <see cref="PublicClusterGetFullyQualifiedDomainNameResponse"/>
    /// <see cref="ServingInfoGetResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15931""}]")]
    public class SystemServerAddressesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _webServerClusterPublicFQDN;

        [XmlElement(ElementName = "webServerClusterPublicFQDN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15931")]
        [MinLength(1)]
        [MaxLength(80)]
        public string WebServerClusterPublicFQDN
        {
            get => _webServerClusterPublicFQDN;
            set
            {
                WebServerClusterPublicFQDNSpecified = true;
                _webServerClusterPublicFQDN = value;
            }
        }

        [XmlIgnore]
        protected bool WebServerClusterPublicFQDNSpecified { get; set; }

        private string _applicationServerClusterPrimaryPublicFQDN;

        [XmlElement(ElementName = "applicationServerClusterPrimaryPublicFQDN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15931")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ApplicationServerClusterPrimaryPublicFQDN
        {
            get => _applicationServerClusterPrimaryPublicFQDN;
            set
            {
                ApplicationServerClusterPrimaryPublicFQDNSpecified = true;
                _applicationServerClusterPrimaryPublicFQDN = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationServerClusterPrimaryPublicFQDNSpecified { get; set; }

        private string _applicationServerClusterSecondaryPublicFQDN;

        [XmlElement(ElementName = "applicationServerClusterSecondaryPublicFQDN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15931")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ApplicationServerClusterSecondaryPublicFQDN
        {
            get => _applicationServerClusterSecondaryPublicFQDN;
            set
            {
                ApplicationServerClusterSecondaryPublicFQDNSpecified = true;
                _applicationServerClusterSecondaryPublicFQDN = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationServerClusterSecondaryPublicFQDNSpecified { get; set; }

        private string _applicationServerClusterPrimaryPrivateFQDN;

        [XmlElement(ElementName = "applicationServerClusterPrimaryPrivateFQDN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15931")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ApplicationServerClusterPrimaryPrivateFQDN
        {
            get => _applicationServerClusterPrimaryPrivateFQDN;
            set
            {
                ApplicationServerClusterPrimaryPrivateFQDNSpecified = true;
                _applicationServerClusterPrimaryPrivateFQDN = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationServerClusterPrimaryPrivateFQDNSpecified { get; set; }

        private string _applicationServerClusterSecondaryPrivateFQDN;

        [XmlElement(ElementName = "applicationServerClusterSecondaryPrivateFQDN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15931")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ApplicationServerClusterSecondaryPrivateFQDN
        {
            get => _applicationServerClusterSecondaryPrivateFQDN;
            set
            {
                ApplicationServerClusterSecondaryPrivateFQDNSpecified = true;
                _applicationServerClusterSecondaryPrivateFQDN = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationServerClusterSecondaryPrivateFQDNSpecified { get; set; }

    }
}
