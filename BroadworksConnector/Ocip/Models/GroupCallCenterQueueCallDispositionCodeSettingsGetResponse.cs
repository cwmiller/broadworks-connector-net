using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCallCenterQueueCallDispositionCodeSettingsGetRequest.
    /// <see cref="GroupCallCenterQueueCallDispositionCodeSettingsGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:5625""}]")]
    public class GroupCallCenterQueueCallDispositionCodeSettingsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableCallDispositionCodes;

        [XmlElement(ElementName = "enableCallDispositionCodes", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5625")]
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

        private bool _includeOrganizationCodes;

        [XmlElement(ElementName = "includeOrganizationCodes", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5625")]
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

        private bool _forceUseOfCallDispositionCodes;

        [XmlElement(ElementName = "forceUseOfCallDispositionCodes", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5625")]
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

        private BroadWorksConnector.Ocip.Models.CallDispositionCodeWithLevel _defaultCallDispositionCode;

        [XmlElement(ElementName = "defaultCallDispositionCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5625")]
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

    }
}
