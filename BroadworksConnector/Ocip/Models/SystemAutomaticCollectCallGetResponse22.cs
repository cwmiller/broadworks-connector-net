using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemAutomaticCollectCallGetRequest22.
    /// Returns system Automatic Collect Call service settings.
    /// <see cref="SystemAutomaticCollectCallGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d5db1a19a0aeda6f13d1f1c609efa0a:60""}]")]
    public class SystemAutomaticCollectCallGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableAutomaticCollectCall;

        [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
        [Group(@"0d5db1a19a0aeda6f13d1f1c609efa0a:60")]
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
        [Group(@"0d5db1a19a0aeda6f13d1f1c609efa0a:60")]
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
        [Group(@"0d5db1a19a0aeda6f13d1f1c609efa0a:60")]
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
