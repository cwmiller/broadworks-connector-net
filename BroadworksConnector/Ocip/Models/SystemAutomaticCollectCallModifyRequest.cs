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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d5db1a19a0aeda6f13d1f1c609efa0a:78""}]")]
    public class SystemAutomaticCollectCallModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enableAutomaticCollectCall;

        [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0d5db1a19a0aeda6f13d1f1c609efa0a:78")]
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

        protected bool _enableConnectTone;

        [XmlElement(ElementName = "enableConnectTone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0d5db1a19a0aeda6f13d1f1c609efa0a:78")]
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

        protected bool _includeCountryCodeInCic;

        [XmlElement(ElementName = "includeCountryCodeInCic", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0d5db1a19a0aeda6f13d1f1c609efa0a:78")]
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
