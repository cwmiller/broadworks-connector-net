using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the enterprise voice VPN level data associated with voice VPN.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:1221""}]")]
    public class EnterpriseVoiceVPNModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1221")]
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
        protected bool ServiceProviderIdSpecified { get; set; }

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1221")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDefaultSelection _defaultSelection;

        [XmlElement(ElementName = "defaultSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1221")]
        public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDefaultSelection DefaultSelection
        {
            get => _defaultSelection;
            set
            {
                DefaultSelectionSpecified = true;
                _defaultSelection = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNNonMatchingE164NumberSelection _e164Selection;

        [XmlElement(ElementName = "e164Selection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1221")]
        public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNNonMatchingE164NumberSelection E164Selection
        {
            get => _e164Selection;
            set
            {
                E164SelectionSpecified = true;
                _e164Selection = value;
            }
        }

        [XmlIgnore]
        protected bool E164SelectionSpecified { get; set; }

        protected bool _usePhoneContext;

        [XmlElement(ElementName = "usePhoneContext", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1221")]
        public bool UsePhoneContext
        {
            get => _usePhoneContext;
            set
            {
                UsePhoneContextSpecified = true;
                _usePhoneContext = value;
            }
        }

        [XmlIgnore]
        protected bool UsePhoneContextSpecified { get; set; }

    }
}
