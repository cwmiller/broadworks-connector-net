using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupRoutePointQueueCallDispositionCodeSettingsGetRequest.
    /// <see cref="GroupRoutePointQueueCallDispositionCodeSettingsGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:1221""}]")]
    public class GroupRoutePointQueueCallDispositionCodeSettingsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableCallDispositionCodes;

        [XmlElement(ElementName = "enableCallDispositionCodes", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1221")]
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
        [Group(@"a27224a048c30ff69eab9209dec841cc:1221")]
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
        [Group(@"a27224a048c30ff69eab9209dec841cc:1221")]
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

        [XmlElement(ElementName = "defaultCallDispositionCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1221")]
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

    }
}
