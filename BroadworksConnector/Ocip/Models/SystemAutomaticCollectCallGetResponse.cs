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
    /// 
    /// Replaced by SystemAutomaticCollectCallGetResponse22 in AS mode.
    /// <see cref="SystemAutomaticCollectCallGetRequest"/>
    /// <see cref="SystemAutomaticCollectCallGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20019""}]")]
    public class SystemAutomaticCollectCallGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableAutomaticCollectCall;

        [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20019")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20019")]
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

    }
}
