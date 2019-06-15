using System;
using System.Xml.Serialization;
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
     
    public class GroupDeviceTypeFileGetListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _groupDeviceTypeFilesTable;

        [XmlElement(ElementName = "groupDeviceTypeFilesTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupDeviceTypeFilesTable {
            get => _groupDeviceTypeFilesTable;
            set {
                GroupDeviceTypeFilesTableSpecified = true;
                _groupDeviceTypeFilesTable = value;
            }
        }

        [XmlIgnore]
        public bool GroupDeviceTypeFilesTableSpecified { get; set; }
        
        private bool _groupHasCustomizableDynamicFiles;

        [XmlElement(ElementName = "groupHasCustomizableDynamicFiles", IsNullable = false, Namespace = "")]
        public bool GroupHasCustomizableDynamicFiles {
            get => _groupHasCustomizableDynamicFiles;
            set {
                GroupHasCustomizableDynamicFilesSpecified = true;
                _groupHasCustomizableDynamicFiles = value;
            }
        }

        [XmlIgnore]
        public bool GroupHasCustomizableDynamicFilesSpecified { get; set; }
        
    }
}
