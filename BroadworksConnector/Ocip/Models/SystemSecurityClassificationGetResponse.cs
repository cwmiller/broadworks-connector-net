using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSecurityClassificationGetRequest.
    /// Contains a table with column headings:
    /// "Name", "Priority".
    /// <see cref="SystemSecurityClassificationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34732""}]")]
    public class SystemSecurityClassificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _meetMeAnncThreshold;

        [XmlElement(ElementName = "meetMeAnncThreshold", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34732")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int MeetMeAnncThreshold
        {
            get => _meetMeAnncThreshold;
            set
            {
                MeetMeAnncThresholdSpecified = true;
                _meetMeAnncThreshold = value;
            }
        }

        [XmlIgnore]
        public bool MeetMeAnncThresholdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _securityClassificationTable;

        [XmlElement(ElementName = "SecurityClassificationTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34732")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SecurityClassificationTable
        {
            get => _securityClassificationTable;
            set
            {
                SecurityClassificationTableSpecified = true;
                _securityClassificationTable = value;
            }
        }

        [XmlIgnore]
        public bool SecurityClassificationTableSpecified { get; set; }

    }
}
