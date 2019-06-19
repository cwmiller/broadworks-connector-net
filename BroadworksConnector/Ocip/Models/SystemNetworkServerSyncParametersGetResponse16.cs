using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkServerSyncParametersGetRequest16.
    /// Contains a list of system Network Server Sync parameters.
    /// Replaced By: SystemNetworkServerSyncParametersGetResponse17sp4
    /// <see cref="SystemNetworkServerSyncParametersGetRequest16"/>
    /// <see cref="SystemNetworkServerSyncParametersGetResponse17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21849""}]")]
    public class SystemNetworkServerSyncParametersGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableSync;

        [XmlElement(ElementName = "enableSync", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21849")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21849")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21849")]
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

    }
}
