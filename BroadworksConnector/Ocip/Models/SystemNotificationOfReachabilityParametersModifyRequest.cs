using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system Notification of Reachability parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13264""}]")]
    public class SystemNotificationOfReachabilityParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _enableNoR;

        [XmlElement(ElementName = "enableNoR", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13264")]
        public bool? EnableNoR
        {
            get => _enableNoR;
            set
            {
                EnableNoRSpecified = (value != null);
                _enableNoR = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNoRSpecified { get; set; }

        protected bool? _alwaysSendThirdPartyVMforUnreachable;

        [XmlElement(ElementName = "alwaysSendThirdPartyVMforUnreachable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13264")]
        public bool? AlwaysSendThirdPartyVMforUnreachable
        {
            get => _alwaysSendThirdPartyVMforUnreachable;
            set
            {
                AlwaysSendThirdPartyVMforUnreachableSpecified = (value != null);
                _alwaysSendThirdPartyVMforUnreachable = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysSendThirdPartyVMforUnreachableSpecified { get; set; }

        protected bool? _disableFACforThirdPartyVoiceMail;

        [XmlElement(ElementName = "disableFACforThirdPartyVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13264")]
        public bool? DisableFACforThirdPartyVoiceMail
        {
            get => _disableFACforThirdPartyVoiceMail;
            set
            {
                DisableFACforThirdPartyVoiceMailSpecified = (value != null);
                _disableFACforThirdPartyVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool DisableFACforThirdPartyVoiceMailSpecified { get; set; }

    }
}
