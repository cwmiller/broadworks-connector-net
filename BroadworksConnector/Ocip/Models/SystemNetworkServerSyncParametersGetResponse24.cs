using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkServerSyncParametersGetRequest24.
    /// Contains a list of system Network Server Sync parameters.
    /// The following elements are only used in AS data mode:
    /// syncTrunkGroups
    /// 
    /// Replaced by: SystemNetworkServerSyncParametersGetResponse24V2 in AS data mode.
    /// <see cref="SystemNetworkServerSyncParametersGetRequest24"/>
    /// <see cref="SystemNetworkServerSyncParametersGetResponse24V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10840""}]")]
    public class SystemNetworkServerSyncParametersGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableSync;

        [XmlElement(ElementName = "enableSync", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10840")]
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
        protected bool EnableSyncSpecified { get; set; }

        protected bool _syncLinePorts;

        [XmlElement(ElementName = "syncLinePorts", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10840")]
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
        protected bool SyncLinePortsSpecified { get; set; }

        protected bool _syncDeviceManagementInfo;

        [XmlElement(ElementName = "syncDeviceManagementInfo", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10840")]
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
        protected bool SyncDeviceManagementInfoSpecified { get; set; }

        protected bool _syncTrunkGroups;

        [XmlElement(ElementName = "syncTrunkGroups", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10840")]
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
        protected bool SyncTrunkGroupsSpecified { get; set; }

        protected int _syncConnectionTimeoutSeconds;

        [XmlElement(ElementName = "syncConnectionTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10840")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int SyncConnectionTimeoutSeconds
        {
            get => _syncConnectionTimeoutSeconds;
            set
            {
                SyncConnectionTimeoutSecondsSpecified = true;
                _syncConnectionTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool SyncConnectionTimeoutSecondsSpecified { get; set; }

    }
}
