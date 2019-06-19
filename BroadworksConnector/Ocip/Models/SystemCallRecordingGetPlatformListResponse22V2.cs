using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallRecordingGetPlatformListRequest22V2.
    /// Contains the default system Call Recording platform, default reseller Call Recording Platform (when applicable) and a table with columns headings
    /// "Name", "Net Address", "Port", "Transport Type", "Media Stream", "Description", "Schema Version", "Support Video Rec", "Reseller Id", "Route".
    /// The system default recording platform also appears in the table with the other platforms.
    /// 
    /// The port can be empty if it is not defined in the recording platform.
    /// The possible values for "Support Video Rec" can be either true or false.
    /// Schema version values include: 1.0, 2.0, 3.0
    /// <see cref="SystemCallRecordingGetPlatformListRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9741e074fbfeb4c7312bfa4dfbaee3d3:194""}]")]
    public class SystemCallRecordingGetPlatformListResponse22V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _systemDefault;

        [XmlElement(ElementName = "systemDefault", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:194")]
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
        public bool SystemDefaultSpecified { get; set; }

        private string _resellerDefault;

        [XmlElement(ElementName = "resellerDefault", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:194")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ResellerDefault
        {
            get => _resellerDefault;
            set
            {
                ResellerDefaultSpecified = true;
                _resellerDefault = value;
            }
        }

        [XmlIgnore]
        public bool ResellerDefaultSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _callRecordingPlatformTable;

        [XmlElement(ElementName = "callRecordingPlatformTable", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:194")]
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
        public bool CallRecordingPlatformTableSpecified { get; set; }

    }
}
