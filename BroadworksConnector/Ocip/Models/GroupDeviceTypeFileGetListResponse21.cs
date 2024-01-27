using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDeviceTypeFileGetListRequest21.
    /// Contains a table of device type files managed by the Device Management System, on a per-group basis.
    /// The column headings are: "File Format", "Is Authenticated", "Access URL", "Repository URL", "Template URL".
    /// <see cref="GroupDeviceTypeFileGetListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:4103""}]")]
    public class GroupDeviceTypeFileGetListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _groupDeviceTypeFilesTable;

        [XmlElement(ElementName = "groupDeviceTypeFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:4103")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupDeviceTypeFilesTable
        {
            get => _groupDeviceTypeFilesTable;
            set
            {
                GroupDeviceTypeFilesTableSpecified = true;
                _groupDeviceTypeFilesTable = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDeviceTypeFilesTableSpecified { get; set; }

        protected bool _groupHasCustomizableDynamicFiles;

        [XmlElement(ElementName = "groupHasCustomizableDynamicFiles", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:4103")]
        public bool GroupHasCustomizableDynamicFiles
        {
            get => _groupHasCustomizableDynamicFiles;
            set
            {
                GroupHasCustomizableDynamicFilesSpecified = true;
                _groupHasCustomizableDynamicFiles = value;
            }
        }

        [XmlIgnore]
        protected bool GroupHasCustomizableDynamicFilesSpecified { get; set; }

    }
}
