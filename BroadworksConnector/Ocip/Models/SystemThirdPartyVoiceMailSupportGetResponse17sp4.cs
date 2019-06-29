using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemThirdPartyVoiceMailSupportGetRequest17sp4.
    /// <see cref="SystemThirdPartyVoiceMailSupportGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3c311aa5c89c0cf5b46e1cdefd5bc387:187""}]")]
    public class SystemThirdPartyVoiceMailSupportGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _overrideAltCallerIdForVMRetrieval;

        [XmlElement(ElementName = "overrideAltCallerIdForVMRetrieval", IsNullable = false, Namespace = "")]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:187")]
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

        private bool _stripDiversionOnVMDestinationRetrieval;

        [XmlElement(ElementName = "stripDiversionOnVMDestinationRetrieval", IsNullable = false, Namespace = "")]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:187")]
        public bool StripDiversionOnVMDestinationRetrieval
        {
            get => _stripDiversionOnVMDestinationRetrieval;
            set
            {
                StripDiversionOnVMDestinationRetrievalSpecified = true;
                _stripDiversionOnVMDestinationRetrieval = value;
            }
        }

        [XmlIgnore]
        protected bool StripDiversionOnVMDestinationRetrievalSpecified { get; set; }

    }
}
