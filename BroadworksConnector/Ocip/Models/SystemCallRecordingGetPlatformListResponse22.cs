using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallRecordingGetPlatformListRequest22.
    /// Contains the default system Call Recording platform, default reseller Call Recording Platform (when applicable) and a table with columns headings
    /// "Name", "Net Address", "Port", "Transport Type", "Media Stream", "Description", "Schema Version", "Support Video Rec", "Reseller Id".
    /// The system default recording platform also appears in the table with the other platforms.
    /// 
    /// The port can be empty if it is not defined in the recording platform.
    /// The possible values for "Support Video Rec" can be either true or false.
    /// Schema version values include: 1.0, 2.0, 3.0
    /// 
    /// Replaced by: SystemCallRecordingGetPlatformListResponse22V2
    /// <see cref="SystemCallRecordingGetPlatformListRequest22"/>
    /// <see cref="SystemCallRecordingGetPlatformListResponse22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9189""}]")]
    public class SystemCallRecordingGetPlatformListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _systemDefault;

        [XmlElement(ElementName = "systemDefault", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9189")]
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

        protected string _resellerDefault;

        [XmlElement(ElementName = "resellerDefault", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9189")]
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
        protected bool ResellerDefaultSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _callRecordingPlatformTable;

        [XmlElement(ElementName = "callRecordingPlatformTable", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9189")]
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
