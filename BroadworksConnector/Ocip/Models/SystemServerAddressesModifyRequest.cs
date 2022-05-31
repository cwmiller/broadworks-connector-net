using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Server Addresses.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15951""}]")]
    public class SystemServerAddressesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _webServerClusterPublicFQDN;

        [XmlElement(ElementName = "webServerClusterPublicFQDN", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15951")]
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

        protected string _applicationServerClusterPrimaryPublicFQDN;

        [XmlElement(ElementName = "applicationServerClusterPrimaryPublicFQDN", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15951")]
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

        protected string _applicationServerClusterSecondaryPublicFQDN;

        [XmlElement(ElementName = "applicationServerClusterSecondaryPublicFQDN", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15951")]
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

        protected string _applicationServerClusterPrimaryPrivateFQDN;

        [XmlElement(ElementName = "applicationServerClusterPrimaryPrivateFQDN", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15951")]
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

        protected string _applicationServerClusterSecondaryPrivateFQDN;

        [XmlElement(ElementName = "applicationServerClusterSecondaryPrivateFQDN", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15951")]
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
