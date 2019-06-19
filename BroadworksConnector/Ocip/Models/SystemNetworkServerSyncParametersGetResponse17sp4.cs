using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkServerSyncParametersGetRequest17sp4.
    /// Contains a list of system Network Server Sync parameters.
    /// The following elements are only used in AS data mode:
    /// syncTrunkGroups
    /// <see cref="SystemNetworkServerSyncParametersGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11723""}]")]
    public class SystemNetworkServerSyncParametersGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableSync;

        [XmlElement(ElementName = "enableSync", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11723")]
        public bool EnableSync
        {
            get => _enableSync;
            set
            {
                EnableSyncSpecified = true;
                _enableSync = value;
            }
        }

        [XmlIgnore]
        public bool EnableSyncSpecified { get; set; }

        private bool _syncLinePorts;

        [XmlElement(ElementName = "syncLinePorts", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11723")]
        public bool SyncLinePorts
        {
            get => _syncLinePorts;
            set
            {
                SyncLinePortsSpecified = true;
                _syncLinePorts = value;
            }
        }

        [XmlIgnore]
        public bool SyncLinePortsSpecified { get; set; }

        private bool _syncDeviceManagementInfo;

        [XmlElement(ElementName = "syncDeviceManagementInfo", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11723")]
        public bool SyncDeviceManagementInfo
        {
            get => _syncDeviceManagementInfo;
            set
            {
                SyncDeviceManagementInfoSpecified = true;
                _syncDeviceManagementInfo = value;
            }
        }

        [XmlIgnore]
        public bool SyncDeviceManagementInfoSpecified { get; set; }

        private bool _syncTrunkGroups;

        [XmlElement(ElementName = "syncTrunkGroups", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11723")]
        public bool SyncTrunkGroups
        {
            get => _syncTrunkGroups;
            set
            {
                SyncTrunkGroupsSpecified = true;
                _syncTrunkGroups = value;
            }
        }

        [XmlIgnore]
        public bool SyncTrunkGroupsSpecified { get; set; }

    }
}
