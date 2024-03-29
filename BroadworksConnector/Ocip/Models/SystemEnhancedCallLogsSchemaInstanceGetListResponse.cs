using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemEnhancedCallLogsSchemaInstanceGetListRequest.
    /// Contains a table with column headings: "Instance Name", "Actual Users", "Potential Users".
    /// <see cref="SystemEnhancedCallLogsSchemaInstanceGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1b5ee40628a3f2b1bcab94a53dec91e7:304""}]")]
    public class SystemEnhancedCallLogsSchemaInstanceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _schemaInstanceUsageTable;

        [XmlElement(ElementName = "schemaInstanceUsageTable", IsNullable = false, Namespace = "")]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:304")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SchemaInstanceUsageTable
        {
            get => _schemaInstanceUsageTable;
            set
            {
                SchemaInstanceUsageTableSpecified = true;
                _schemaInstanceUsageTable = value;
            }
        }

        [XmlIgnore]
        protected bool SchemaInstanceUsageTableSpecified { get; set; }

    }
}
