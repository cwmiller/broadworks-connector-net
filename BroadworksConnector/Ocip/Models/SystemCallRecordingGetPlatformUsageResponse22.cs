using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallRecordingGetPlatformUsageRequest.
    /// The response contains a table with columns headings "Organization Id",
    /// "Organization Type", "Group Id".
    /// <see cref="SystemCallRecordingGetPlatformUsageRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9741e074fbfeb4c7312bfa4dfbaee3d3:229""}]")]
    public class SystemCallRecordingGetPlatformUsageResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _groupTable;

        [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:229")]
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
