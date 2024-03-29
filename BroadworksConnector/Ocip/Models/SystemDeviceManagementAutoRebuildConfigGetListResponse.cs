using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceManagementAutoRebuildConfigGetListRequest.
    /// Contains a table with column headings: "OCI Request Prefix", "Auto Rebuild Enabled".
    /// "OCI Request Prefix" is the prefix of the OCI request name.  It does
    /// not include the request's version '17.sp4, 18...' since the disabled
    /// flag applies to the whole series of requests, independent of the
    /// version.
    /// "Auto Rebuild Enabled": 'True' if the request prefix triggers DM events
    /// automatically.  Otherwise, automatic DM events are not generated.
    /// <see cref="SystemDeviceManagementAutoRebuildConfigGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7784""}]")]
    public class SystemDeviceManagementAutoRebuildConfigGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _autoRebuildConfigTable;

        [XmlElement(ElementName = "autoRebuildConfigTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7784")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AutoRebuildConfigTable
        {
            get => _autoRebuildConfigTable;
            set
            {
                AutoRebuildConfigTableSpecified = true;
                _autoRebuildConfigTable = value;
            }
        }

        [XmlIgnore]
        protected bool AutoRebuildConfigTableSpecified { get; set; }

    }
}
