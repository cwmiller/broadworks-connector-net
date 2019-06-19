using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemAutomaticCollectCallGetRequest.
    /// Returns system Automatic Collect Call service settings.
    /// <see cref="SystemAutomaticCollectCallGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""af1b47d7cab3335a81456e64e42371b0:60""}]")]
    public class SystemAutomaticCollectCallGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableAutomaticCollectCall;

        [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
        [Group(@"af1b47d7cab3335a81456e64e42371b0:60")]
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
        public bool EnableAutomaticCollectCallSpecified { get; set; }

        private bool _enableConnectTone;

        [XmlElement(ElementName = "enableConnectTone", IsNullable = false, Namespace = "")]
        [Group(@"af1b47d7cab3335a81456e64e42371b0:60")]
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
        public bool EnableConnectToneSpecified { get; set; }

    }
}
