using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Network Server Sync system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// syncTrunkGroups
    /// syncConnectionTimeoutSeconds
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12993""}]")]
    public class SystemNetworkServerSyncParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enableSync;

        [XmlElement(ElementName = "enableSync", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12993")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12993")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12993")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12993")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:12993")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12993")]
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
