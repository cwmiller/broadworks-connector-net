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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7624"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7627"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7629""}]}]}]")]
    public class CallCenterScheduledReportDNISSelectionRead
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7624")]
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
        protected bool ServiceUserIdSpecified { get; set; }

        protected bool? _deleted;

        [XmlElement(ElementName = "deleted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7624")]
        public bool? Deleted
        {
            get => _deleted;
            set
            {
                DeletedSpecified = (value != null);
                _deleted = value;
            }
        }

        [XmlIgnore]
        protected bool DeletedSpecified { get; set; }

        protected bool _allDNIS;

        [XmlElement(ElementName = "allDNIS", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7627")]
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
        protected bool AllDNISSpecified { get; set; }

        protected List<string> _currentName = new List<string>();

        [XmlElement(ElementName = "currentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7629")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> CurrentName
        {
            get => _currentName;
            set
            {
                CurrentNameSpecified = (value != null);
                _currentName = value;
            }
        }

        [XmlIgnore]
        protected bool CurrentNameSpecified { get; set; }

        protected List<string> _pastName = new List<string>();

        [XmlElement(ElementName = "pastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7629")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> PastName
        {
            get => _pastName;
            set
            {
                PastNameSpecified = (value != null);
                _pastName = value;
            }
        }

        [XmlIgnore]
        protected bool PastNameSpecified { get; set; }

    }
}
