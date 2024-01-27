using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkServerSyncParametersGetRequest24V2.
    /// Contains a list of system Network Server Sync parameters.
    /// The following elements are only used in AS data mode:
    /// syncTrunkGroups
    /// <see cref="SystemNetworkServerSyncParametersGetRequest24V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12969""}]")]
    public class SystemNetworkServerSyncParametersGetResponse24V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableSync;

        [XmlElement(ElementName = "enableSync", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12969")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:12969")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:12969")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:12969")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:12969")]
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

        protected bool _syncEnterpriseNumbers;

        [XmlElement(ElementName = "syncEnterpriseNumbers", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12969")]
        public bool SyncEnterpriseNumbers
        {
            get => _syncEnterpriseNumbers;
            set
            {
                SyncEnterpriseNumbersSpecified = true;
                _syncEnterpriseNumbers = value;
            }
        }

        [XmlIgnore]
        protected bool SyncEnterpriseNumbersSpecified { get; set; }

    }
}
