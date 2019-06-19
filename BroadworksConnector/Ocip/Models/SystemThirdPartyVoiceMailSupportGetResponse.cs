using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemThirdPartyVoiceMailSupportGetRequest.
    /// 
    /// Replaced by: SystemThirdPartyVoiceMailSupportGetResponse17sp4
    /// <see cref="SystemThirdPartyVoiceMailSupportGetRequest"/>
    /// <see cref="SystemThirdPartyVoiceMailSupportGetResponse17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27052""}]")]
    public class SystemThirdPartyVoiceMailSupportGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _overrideAltCallerIdForVMRetrieval;

        [XmlElement(ElementName = "overrideAltCallerIdForVMRetrieval", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27052")]
        public bool OverrideAltCallerIdForVMRetrieval
        {
            get => _overrideAltCallerIdForVMRetrieval;
            set
            {
                OverrideAltCallerIdForVMRetrievalSpecified = true;
                _overrideAltCallerIdForVMRetrieval = value;
            }
        }

        [XmlIgnore]
        public bool OverrideAltCallerIdForVMRetrievalSpecified { get; set; }

    }
}
