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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12823""}]")]
    public class SystemNetworkServerSyncParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _enableSync;

        [XmlElement(ElementName = "enableSync", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12823")]
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

        private bool _syncLinePorts;

        [XmlElement(ElementName = "syncLinePorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12823")]
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

        private bool _syncDeviceManagementInfo;

        [XmlElement(ElementName = "syncDeviceManagementInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12823")]
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

        private bool _syncTrunkGroups;

        [XmlElement(ElementName = "syncTrunkGroups", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12823")]
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

        private int _syncConnectionTimeoutSeconds;

        [XmlElement(ElementName = "syncConnectionTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12823")]
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

        private bool _syncEnterpriseNumbers;

        [XmlElement(ElementName = "syncEnterpriseNumbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12823")]
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
