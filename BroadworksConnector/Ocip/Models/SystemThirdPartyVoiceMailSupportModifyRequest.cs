using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Third-party Voice Mail Support.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode:
    /// stripDiversionOnVMDestinationRetrieval
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3c311aa5c89c0cf5b46e1cdefd5bc387:224""}]")]
    public class SystemThirdPartyVoiceMailSupportModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _overrideAltCallerIdForVMRetrieval;

        [XmlElement(ElementName = "overrideAltCallerIdForVMRetrieval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:224")]
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

        protected bool _stripDiversionOnVMDestinationRetrieval;

        [XmlElement(ElementName = "stripDiversionOnVMDestinationRetrieval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:224")]
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
