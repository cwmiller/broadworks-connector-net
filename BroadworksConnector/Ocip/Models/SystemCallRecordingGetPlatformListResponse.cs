using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallRecordingGetPlatformListRequest.
    /// Contains the default system Call Recording platform and a table with columns headings "Name", "Net Address", "Port",
    /// "Transport Type", "Media Stream", "Description", "Schema Version", "Support Video Rec".
    /// The system default recording platform also appears in the table with the other platforms.
    /// 
    /// The possible values for "Support Video Rec" can be either true or false.
    /// Schema version values include: 1.0, 2.0, 3.0
    /// 
    /// Replaced by: SystemCallRecordingGetPlatformListResponse20sp1 in AS data mode
    /// <see cref="SystemCallRecordingGetPlatformListRequest"/>
    /// <see cref="SystemCallRecordingGetPlatformListResponse20sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:24572""}]")]
    public class SystemCallRecordingGetPlatformListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _systemDefault;

        [XmlElement(ElementName = "systemDefault", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24572")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SystemDefault
        {
            get => _systemDefault;
            set
            {
                SystemDefaultSpecified = true;
                _systemDefault = value;
            }
        }

        [XmlIgnore]
        protected bool SystemDefaultSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _callRecordingPlatformTable;

        [XmlElement(ElementName = "callRecordingPlatformTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24572")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallRecordingPlatformTable
        {
            get => _callRecordingPlatformTable;
            set
            {
                CallRecordingPlatformTableSpecified = true;
                _callRecordingPlatformTable = value;
            }
        }

        [XmlIgnore]
        protected bool CallRecordingPlatformTableSpecified { get; set; }

    }
}
