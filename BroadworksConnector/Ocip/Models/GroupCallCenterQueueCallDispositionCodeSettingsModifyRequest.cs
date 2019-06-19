using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the enterprise level data associated with Call Center Agents Unavailable Code Settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:5682""}]")]
    public class GroupCallCenterQueueCallDispositionCodeSettingsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5682")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private bool _enableCallDispositionCodes;

        [XmlElement(ElementName = "enableCallDispositionCodes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5682")]
        public bool EnableCallDispositionCodes
        {
            get => _enableCallDispositionCodes;
            set
            {
                EnableCallDispositionCodesSpecified = true;
                _enableCallDispositionCodes = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallDispositionCodesSpecified { get; set; }

        private bool _includeOrganizationCodes;

        [XmlElement(ElementName = "includeOrganizationCodes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5682")]
        public bool IncludeOrganizationCodes
        {
            get => _includeOrganizationCodes;
            set
            {
                IncludeOrganizationCodesSpecified = true;
                _includeOrganizationCodes = value;
            }
        }

        [XmlIgnore]
        public bool IncludeOrganizationCodesSpecified { get; set; }

        private bool _forceUseOfCallDispositionCodes;

        [XmlElement(ElementName = "forceUseOfCallDispositionCodes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5682")]
        public bool ForceUseOfCallDispositionCodes
        {
            get => _forceUseOfCallDispositionCodes;
            set
            {
                ForceUseOfCallDispositionCodesSpecified = true;
                _forceUseOfCallDispositionCodes = value;
            }
        }

        [XmlIgnore]
        public bool ForceUseOfCallDispositionCodesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallDispositionCodeWithLevel _defaultCallDispositionCode;

        [XmlElement(ElementName = "defaultCallDispositionCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5682")]
        public BroadWorksConnector.Ocip.Models.CallDispositionCodeWithLevel DefaultCallDispositionCode
        {
            get => _defaultCallDispositionCode;
            set
            {
                DefaultCallDispositionCodeSpecified = true;
                _defaultCallDispositionCode = value;
            }
        }

        [XmlIgnore]
        public bool DefaultCallDispositionCodeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CallDispositionCodeActivation> _callDispositionCodeActivation = new List<BroadWorksConnector.Ocip.Models.CallDispositionCodeActivation>();

        [XmlElement(ElementName = "callDispositionCodeActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5682")]
        public List<BroadWorksConnector.Ocip.Models.CallDispositionCodeActivation> CallDispositionCodeActivation
        {
            get => _callDispositionCodeActivation;
            set
            {
                CallDispositionCodeActivationSpecified = true;
                _callDispositionCodeActivation = value;
            }
        }

        [XmlIgnore]
        public bool CallDispositionCodeActivationSpecified { get; set; }

    }
}
