using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemThirdPartyVoiceMailSupportGetRequest17sp4.
        /// <see cref="SystemThirdPartyVoiceMailSupportGetRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemThirdPartyVoiceMailSupportGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _overrideAltCallerIdForVMRetrieval;

        [XmlElement(ElementName = "overrideAltCallerIdForVMRetrieval", IsNullable = false, Namespace = "")]
        public bool OverrideAltCallerIdForVMRetrieval {
            get => _overrideAltCallerIdForVMRetrieval;
            set {
                OverrideAltCallerIdForVMRetrievalSpecified = true;
                _overrideAltCallerIdForVMRetrieval = value;
            }
        }

        [XmlIgnore]
        public bool OverrideAltCallerIdForVMRetrievalSpecified { get; set; }
        
        private bool _stripDiversionOnVMDestinationRetrieval;

        [XmlElement(ElementName = "stripDiversionOnVMDestinationRetrieval", IsNullable = false, Namespace = "")]
        public bool StripDiversionOnVMDestinationRetrieval {
            get => _stripDiversionOnVMDestinationRetrieval;
            set {
                StripDiversionOnVMDestinationRetrievalSpecified = true;
                _stripDiversionOnVMDestinationRetrieval = value;
            }
        }

        [XmlIgnore]
        public bool StripDiversionOnVMDestinationRetrievalSpecified { get; set; }
        
    }
}
