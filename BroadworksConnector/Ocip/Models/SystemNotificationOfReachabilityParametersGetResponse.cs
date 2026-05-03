using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNotificationOfReachabilityParametersGetRequest.
    /// Contains the system Notification of Reachability parameters.
    /// <see cref="SystemNotificationOfReachabilityParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13246""}]")]
    public class SystemNotificationOfReachabilityParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableNoR;

        [XmlElement(ElementName = "enableNoR", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13246")]
        public bool EnableNoR
        {
            get => _enableNoR;
            set
            {
                EnableNoRSpecified = true;
                _enableNoR = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNoRSpecified { get; set; }

        protected bool _alwaysSendThirdPartyVMforUnreachable;

        [XmlElement(ElementName = "alwaysSendThirdPartyVMforUnreachable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13246")]
        public bool AlwaysSendThirdPartyVMforUnreachable
        {
            get => _alwaysSendThirdPartyVMforUnreachable;
            set
            {
                AlwaysSendThirdPartyVMforUnreachableSpecified = true;
                _alwaysSendThirdPartyVMforUnreachable = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysSendThirdPartyVMforUnreachableSpecified { get; set; }

        protected bool _disableFACforThirdPartyVoiceMail;

        [XmlElement(ElementName = "disableFACforThirdPartyVoiceMail", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13246")]
        public bool DisableFACforThirdPartyVoiceMail
        {
            get => _disableFACforThirdPartyVoiceMail;
            set
            {
                DisableFACforThirdPartyVoiceMailSpecified = true;
                _disableFACforThirdPartyVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool DisableFACforThirdPartyVoiceMailSpecified { get; set; }

    }
}
