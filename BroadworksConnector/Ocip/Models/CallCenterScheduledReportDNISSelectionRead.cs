using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Either all DNIS under the specified Call Center or 2 lists of DNIS, one for current one for past (deleted).
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterScheduledReportDNISSelectionRead 
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
        private bool _deleted;

        [XmlElement(ElementName = "deleted", IsNullable = false, Namespace = "")]
        public bool Deleted {
            get => _deleted;
            set {
                DeletedSpecified = true;
                _deleted = value;
            }
        }

        [XmlIgnore]
        public bool DeletedSpecified { get; set; }
        
        private bool _allDNIS;

        [XmlElement(ElementName = "allDNIS", IsNullable = false, Namespace = "")]
        public bool AllDNIS {
            get => _allDNIS;
            set {
                AllDNISSpecified = true;
                _allDNIS = value;
            }
        }

        [XmlIgnore]
        public bool AllDNISSpecified { get; set; }
        
        private List<string> _currentName;

        [XmlElement(ElementName = "currentName", IsNullable = false, Namespace = "")]
        public List<string> CurrentName {
            get => _currentName;
            set {
                CurrentNameSpecified = true;
                _currentName = value;
            }
        }

        [XmlIgnore]
        public bool CurrentNameSpecified { get; set; }
        
        private List<string> _pastName;

        [XmlElement(ElementName = "pastName", IsNullable = false, Namespace = "")]
        public List<string> PastName {
            get => _pastName;
            set {
                PastNameSpecified = true;
                _pastName = value;
            }
        }

        [XmlIgnore]
        public bool PastNameSpecified { get; set; }
        
    }
}
