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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:29579""}]")]
    public class SystemSecurityClassificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _meetMeAnncThreshold;

        [XmlElement(ElementName = "meetMeAnncThreshold", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29579")]
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
        protected bool MeetMeAnncThresholdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _securityClassificationTable;

        [XmlElement(ElementName = "SecurityClassificationTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29579")]
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
        protected bool SecurityClassificationTableSpecified { get; set; }

    }
}
