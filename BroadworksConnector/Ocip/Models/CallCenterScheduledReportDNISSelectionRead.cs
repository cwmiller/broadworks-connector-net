using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Either all DNIS under the specified Call Center or 2 lists of DNIS, one for current one for past (deleted).
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7632"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7635"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7637""}]}]}]")]
    public class CallCenterScheduledReportDNISSelectionRead
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7632")]
        [MinLength(1)]
        [MaxLength(161)]
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

        private bool _deleted;

        [XmlElement(ElementName = "deleted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7632")]
        public bool Deleted
        {
            get => _deleted;
            set
            {
                DeletedSpecified = true;
                _deleted = value;
            }
        }

        [XmlIgnore]
        public bool DeletedSpecified { get; set; }

        private bool _allDNIS;

        [XmlElement(ElementName = "allDNIS", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7635")]
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

        private List<string> _currentName = new List<string>();

        [XmlElement(ElementName = "currentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7637")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> CurrentName
        {
            get => _currentName;
            set
            {
                CurrentNameSpecified = true;
                _currentName = value;
            }
        }

        [XmlIgnore]
        public bool CurrentNameSpecified { get; set; }

        private List<string> _pastName = new List<string>();

        [XmlElement(ElementName = "pastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7637")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> PastName
        {
            get => _pastName;
            set
            {
                PastNameSpecified = true;
                _pastName = value;
            }
        }

        [XmlIgnore]
        public bool PastNameSpecified { get; set; }

    }
}
