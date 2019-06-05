using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterEnhancedGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private bool _overrideAgentWrapUpTime;

        [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false, Namespace = "")]
        public bool OverrideAgentWrapUpTime
        {
            get => _overrideAgentWrapUpTime;
            set
            {
                OverrideAgentWrapUpTimeSpecified = true;
                _overrideAgentWrapUpTime = value;
            }
        }

        [XmlIgnore]
        public bool OverrideAgentWrapUpTimeSpecified { get; set; }
        private int _wrapUpSeconds;

        [XmlElement(ElementName = "wrapUpSeconds", IsNullable = false, Namespace = "")]
        public int WrapUpSeconds
        {
            get => _wrapUpSeconds;
            set
            {
                WrapUpSecondsSpecified = true;
                _wrapUpSeconds = value;
            }
        }

        [XmlIgnore]
        public bool WrapUpSecondsSpecified { get; set; }
    }
}
