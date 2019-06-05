using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterScheduledReportCallCenterSelection
    {
        private bool _allCallCenter;

        [XmlElement(ElementName = "allCallCenter", IsNullable = false, Namespace = "")]
        public bool AllCallCenter
        {
            get => _allCallCenter;
            set
            {
                AllCallCenterSpecified = true;
                _allCallCenter = value;
            }
        }

        [XmlIgnore]
        public bool AllCallCenterSpecified { get; set; }
        private List<string> _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public List<string> ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
    }
}
