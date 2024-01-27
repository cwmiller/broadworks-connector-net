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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:36260""}]")]
    public class SystemThirdPartyVoiceMailSupportGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _overrideAltCallerIdForVMRetrieval;

        [XmlElement(ElementName = "overrideAltCallerIdForVMRetrieval", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:36260")]
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
        protected bool OverrideAltCallerIdForVMRetrievalSpecified { get; set; }

    }
}
