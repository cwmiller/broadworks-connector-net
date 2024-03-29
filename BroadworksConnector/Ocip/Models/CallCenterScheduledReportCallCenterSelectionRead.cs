using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User for admin read. Either all call centers or 2 lists of call centers: one for current and one for deleted call centers.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7621"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7623""}]}]")]
    public class CallCenterScheduledReportCallCenterSelectionRead
    {

        protected bool _allCallCenter;

        [XmlElement(ElementName = "allCallCenter", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7621")]
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
        protected bool AllCallCenterSpecified { get; set; }

        protected List<string> _currentUserId = new List<string>();

        [XmlElement(ElementName = "currentUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7623")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> CurrentUserId
        {
            get => _currentUserId;
            set
            {
                CurrentUserIdSpecified = true;
                _currentUserId = value;
            }
        }

        [XmlIgnore]
        protected bool CurrentUserIdSpecified { get; set; }

        protected List<string> _pastUserId = new List<string>();

        [XmlElement(ElementName = "pastUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7623")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> PastUserId
        {
            get => _pastUserId;
            set
            {
                PastUserIdSpecified = true;
                _pastUserId = value;
            }
        }

        [XmlIgnore]
        protected bool PastUserIdSpecified { get; set; }

    }
}
