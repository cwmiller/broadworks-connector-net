using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallRecordingGetPlatformUsageRequest.
    /// The response contains a table with columns headings "Service Provider Id", "Group Id".
    /// 
    /// Replaced by SystemCallRecordingGetPlatformUsageResponse22 in AS data mode.
    /// <see cref="SystemCallRecordingGetPlatformUsageRequest"/>
    /// <see cref="SystemCallRecordingGetPlatformUsageResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:41738""}]")]
    public class SystemCallRecordingGetPlatformUsageResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _groupTable;

        [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41738")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupTable
        {
            get => _groupTable;
            set
            {
                GroupTableSpecified = true;
                _groupTable = value;
            }
        }

        [XmlIgnore]
        public bool GroupTableSpecified { get; set; }

    }
}
