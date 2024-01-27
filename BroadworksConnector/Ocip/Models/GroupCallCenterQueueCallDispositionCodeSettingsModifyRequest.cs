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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:5640""}]")]
    public class GroupCallCenterQueueCallDispositionCodeSettingsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5640")]
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
        protected bool ServiceUserIdSpecified { get; set; }

        protected bool _enableCallDispositionCodes;

        [XmlElement(ElementName = "enableCallDispositionCodes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5640")]
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
        protected bool EnableCallDispositionCodesSpecified { get; set; }

        protected bool _includeOrganizationCodes;

        [XmlElement(ElementName = "includeOrganizationCodes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5640")]
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
        protected bool IncludeOrganizationCodesSpecified { get; set; }

        protected bool _forceUseOfCallDispositionCodes;

        [XmlElement(ElementName = "forceUseOfCallDispositionCodes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5640")]
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
        protected bool ForceUseOfCallDispositionCodesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallDispositionCodeWithLevel _defaultCallDispositionCode;

        [XmlElement(ElementName = "defaultCallDispositionCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5640")]
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
        protected bool DefaultCallDispositionCodeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.CallDispositionCodeActivation> _callDispositionCodeActivation = new List<BroadWorksConnector.Ocip.Models.CallDispositionCodeActivation>();

        [XmlElement(ElementName = "callDispositionCodeActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5640")]
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
        protected bool CallDispositionCodeActivationSpecified { get; set; }

    }
}
