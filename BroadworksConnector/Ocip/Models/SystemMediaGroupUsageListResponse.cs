using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaGroupUsageListRequest.
    /// Contains a table of SAC groups associated with the media group.
    /// The column headings are: "SAC Group Name", "Organization Id", "Organization Type", and "Group Id".
    /// The "Group Id" will be empty for enterprise SAC groups.
    /// <see cref="SystemMediaGroupUsageListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10849""}]")]
    public class SystemMediaGroupUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _usageTable;

        [XmlElement(ElementName = "usageTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10849")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UsageTable
        {
            get => _usageTable;
            set
            {
                UsageTableSpecified = true;
                _usageTable = value;
            }
        }

        [XmlIgnore]
        protected bool UsageTableSpecified { get; set; }

    }
}
