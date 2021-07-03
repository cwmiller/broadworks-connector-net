using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system Automatic Collect Call service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""af1b47d7cab3335a81456e64e42371b0:79""}]")]
    public class SystemAutomaticCollectCallModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _enableAutomaticCollectCall;

        [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"af1b47d7cab3335a81456e64e42371b0:79")]
        public bool EnableAutomaticCollectCall
        {
            get => _enableAutomaticCollectCall;
            set
            {
                EnableAutomaticCollectCallSpecified = true;
                _enableAutomaticCollectCall = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutomaticCollectCallSpecified { get; set; }

        private bool _enableConnectTone;

        [XmlElement(ElementName = "enableConnectTone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"af1b47d7cab3335a81456e64e42371b0:79")]
        public bool EnableConnectTone
        {
            get => _enableConnectTone;
            set
            {
                EnableConnectToneSpecified = true;
                _enableConnectTone = value;
            }
        }

        [XmlIgnore]
        protected bool EnableConnectToneSpecified { get; set; }

        private bool _includeCountryCodeInCic;

        [XmlElement(ElementName = "includeCountryCodeInCic", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"af1b47d7cab3335a81456e64e42371b0:79")]
        public bool IncludeCountryCodeInCic
        {
            get => _includeCountryCodeInCic;
            set
            {
                IncludeCountryCodeInCicSpecified = true;
                _includeCountryCodeInCic = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeCountryCodeInCicSpecified { get; set; }

    }
}
