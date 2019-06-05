using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterScheduledReportDNISSelection
    {
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId
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
        private bool _allDNIS;

        [XmlElement(ElementName = "allDNIS", IsNullable = false, Namespace = "")]
        public bool AllDNIS
        {
            get => _allDNIS;
            set
            {
                AllDNISSpecified = true;
                _allDNIS = value;
            }
        }

        [XmlIgnore]
        public bool AllDNISSpecified { get; set; }
        private List<string> _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public List<string> Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
    }
}
